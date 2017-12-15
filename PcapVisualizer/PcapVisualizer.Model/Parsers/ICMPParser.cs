using System;
using System.Collections.Generic;
using System.Text;
using PcapDotNet.Core;
using PcapDotNet.Packets.Icmp;
using PcapDotNet.Packets.IpV4;

namespace PcapVisualizer.Model.Parsers
{
    public class ICMPParser : IProtocolParser
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
                // Установка фильтра на udp Пакеты
                using (var filter = communicator.CreateFilter("ip and icmp"))
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
                                    IpV4Datagram ip = packet.Ethernet.IpV4;
                                    IcmpDatagram icmp = ip.Icmp;

                                    // common fields
                                    myPacket.Protocol = "ICMP";
                                    myPacket.SourceAdress = ip.Source.ToString();
                                    myPacket.SourcePort = ip.Udp.SourcePort.ToString();
                                    myPacket.DestinationAddress = ip.Destination.ToString();
                                    myPacket.DestinationPort = ip.Udp.DestinationPort.ToString();
                                    myPacket.TimeStamp = packet.Timestamp;
                                    myPacket.Length = packet.Length;
                                    myPacket.Data = packet.Buffer;

                                    // unusual fields

                                    StringBuilder properties = new StringBuilder();

                                    // Контрольная сумма icmp пакета
                                    properties.AppendLine("Checksum : " + icmp.Checksum.ToString());
                                    // Формат хранимых данных
                                    properties.AppendLine("MessageType : " + icmp.MessageType.ToString());
                                    // Сведения о сообщении передаваемом пакетом
                                    properties.AppendLine("MessageTypeAndCode : " + icmp.MessageTypeAndCode.ToString());
                                    // Специальное значение передаваемое пакетом 
                                    properties.AppendLine("Variable : " + icmp.Variable.ToString());

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