using System;
using System.Collections.Generic;
using System.Text;
using PcapDotNet.Core;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace PcapVisualizer.Model.Parsers
{
    public class EthernetParser : IProtocolParser
    {
        public List<Packet> ParsePcapFile(string path)
        {
            List<Packet> list = new List<Packet>();

            OfflinePacketDevice selectedDevice = new OfflinePacketDevice(path);

            // открытие файла для парсинга
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536, // считает полностью весь пакет 65536 max size of packet
                    PacketDeviceOpenAttributes.Promiscuous, // какие - то непонятные флаги)
                    1000)) // время чтения
            {

                using (var filter = communicator.CreateFilter("ether broadcast"))
                {
                    communicator.SetFilter(filter);

                    bool endOfFile = false;

                    // разираем полученные пакеты по одному
                    do
                    {
                        PcapDotNet.Packets.Packet packet;
                        var myPacket = new Packet();


                        PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);
                        switch (result)
                        {
                            case PacketCommunicatorReceiveResult.Eof:
                            {
                                endOfFile = true;
                                break;
                            }

                            case PacketCommunicatorReceiveResult.Timeout:
                                break; // Timeout

                            case PacketCommunicatorReceiveResult.Ok:
                            {
                                //if (packet.IpV4.Protocol != IpV4Protocol.EtherIp)
                                //    continue;

                                IpV4Datagram ip = packet.Ethernet.IpV4;
                                TcpDatagram tcp = ip.Tcp;
                                EthernetDatagram ethernet = packet.Ethernet;

                                // common fields
                                myPacket.Protocol = "Ethernet";
                                myPacket.SourceAddress = ip.Source.ToString();
                                myPacket.SourcePort = tcp.SourcePort.ToString();
                                myPacket.DestinationAddress = ip.Destination.ToString();
                                myPacket.DestinationPort = tcp.DestinationPort.ToString();
                                myPacket.TimeStamp = packet.Timestamp;
                                myPacket.Length = packet.Length;
                                myPacket.Data = packet.Buffer;

                                // unusual fields

                                StringBuilder properties = new StringBuilder();

                                // MAC адресс получателя
                                properties.AppendLine("MAC address of destination : " + ethernet.Destination.ToString());
                                // 
                                properties.AppendLine("EtherType : " + ethernet.EtherType.ToString());
                                // Длинна заголовков
                                properties.AppendLine("HeaderLength : " + ethernet.HeaderLength.ToString());
                                // Длинна полезной загрузки
                                properties.AppendLine("PayloadLength : " + ethernet.PayloadLength.ToString());
                                // MAC адресс отправителя
                                properties.AppendLine("Source Mac address : " + ethernet.Source.ToString());

                                myPacket.Header = properties.ToString();

                                list.Add(myPacket);

                                continue;
                            }
                            default:
                                throw new InvalidOperationException("The result " + result +
                                                                    " shoudl never be reached here");
                        }
                    } while (!endOfFile);
                }
            }

            return list;
        }
    }
}