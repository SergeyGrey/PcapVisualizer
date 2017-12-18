using System;
using System.Collections.Generic;
using System.Text;
using PcapDotNet.Core;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace PcapVisualizer.Model.Parsers
{
    public class HTTPParser : IProtocolParser
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
                using (var filter = communicator.CreateFilter("ip and tcp"))
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

                                    var http = packet.IpV4.Tcp.Http;
                                    var httpHeader = packet.IpV4.Tcp.Http.Header;


                                    
                                    if (!http.IsValid)
                                        continue;

                                    // common fields
                                    myPacket.Protocol = "HTTP";
                                    myPacket.SourceAdress = ip.Source.ToString();
                                    myPacket.SourcePort = tcp.SourcePort.ToString();
                                    myPacket.DestinationAddress = ip.Destination.ToString();
                                    myPacket.DestinationPort = tcp.DestinationPort.ToString();
                                    myPacket.TimeStamp = packet.Timestamp;
                                    myPacket.Length = packet.Length;
                                    myPacket.Data = packet.Buffer;

                                    // unusual fields

                                    StringBuilder properties = new StringBuilder();

                                    // Длинна заголовков
                                    if (httpHeader != null)
                                    {
                                        properties.AppendLine("HeaderLength : " + httpHeader.BytesLength.ToString());
                                        // Длинна контента
                                        properties.AppendLine("ContentLength : " + httpHeader.ContentLength);
                                        // Тип контента
                                        properties.AppendLine("ContentType : " + httpHeader.ContentType);
                                        // Поле передачи
                                        properties.AppendLine("ContentType : " + httpHeader.Trailer.ValueString);
                                        // Шифрования
                                        properties.AppendLine("TransferEncoding : " +
                                                              httpHeader.TransferEncoding.ValueString);
                                    }

                                    if (http.IsRequest && http.IsValid)
                                    {
                                        string message = http.Decode(Encoding.ASCII);
                                        if (message.StartsWith("GET "))
                                        {
                                            properties.AppendLine("PacketType : " + "Get");
                                            properties.AppendLine("Message : " + message);
                                        }
                                        else if (message.StartsWith("POST "))
                                        {
                                            properties.AppendLine("PacketType : " + "Post");
                                            properties.AppendLine("Message : " + message);
                                        }
                                    }

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