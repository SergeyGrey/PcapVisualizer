using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PcapDotNet.Core;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapVisualizer.Model.Packets;

namespace PcapVisualizer.Model.Parsers
{
    public class TcpParser : IProtocolParser
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
                // Установка фильтра на TCP Пакеты
                using (var filter = communicator.CreateFilter("tcp"))
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
                                TcpDatagram tcp = ip.Tcp;
                                

                                // common fields
                                myPacket.Protocol = "TCP";
                                myPacket.SenderAddress = ip.Source.ToString();
                                myPacket.SenderPort = tcp.SourcePort.ToString();
                                myPacket.DestinationAddress = ip.Destination.ToString();
                                myPacket.DestinationPort = tcp.DestinationPort.ToString();
                                myPacket.TimeStamp = packet.Timestamp;
                                myPacket.Length = packet.Length;
                                myPacket.Data = packet.Buffer;

                                // unusual fields

                                StringBuilder properties = new StringBuilder();

                                // флаги TCP Пакета
                                properties.AppendLine("ControlBits : " + tcp.ControlBits.ToString());
                                // Контрольная сумма
                                properties.AppendLine("CheckSum : " + tcp.Checksum.ToString());
                                // Число отвечающее за последовательность пакетов
                                properties.AppendLine("NextPacketNumber : " + tcp.NextSequenceNumber.ToString());
                                // Длинна заголовков
                                properties.AppendLine("HeaderLength : " + tcp.HeaderLength.ToString());
                                // Длина полезной загрузки
                                properties.AppendLine("PayLoadLength : " + tcp.PayloadLength.ToString());
                                // Количество октетов данных, которое отправитель этого сегмента готов принять.
                                properties.AppendLine("Window : " + tcp.Window.ToString());
                                
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