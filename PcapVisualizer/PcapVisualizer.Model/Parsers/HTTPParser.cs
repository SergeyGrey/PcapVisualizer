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
                    PacketDeviceOpenAttributes.Promiscuous, //  флаги
                    1000)) // время чтения
            {
                // Установка фильтра на TCP Пакеты
                using (var filter = communicator.CreateFilter("tcp port 80"))
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

                                    if (http == null)
                                        continue;

                                    var httpHeader = packet.IpV4.Tcp.Http.Header; 
                       
                                    if (!http.IsValid)
                                        continue;

                                    // common fields
                                    myPacket.Protocol = "HTTP";
                                    myPacket.SourceAddress = ip.Source.ToString();
                                    myPacket.SourcePort = tcp.SourcePort.ToString();
                                    myPacket.DestinationAddress = ip.Destination.ToString();
                                    myPacket.DestinationPort = tcp.DestinationPort.ToString();
                                    myPacket.TimeStamp = packet.Timestamp;
                                    myPacket.Length = packet.Length;
                                    myPacket.Data = packet.Buffer;

                                    StringBuilder properties = new StringBuilder();

                                    // флаги HTTP Пакета
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

                                    myPacket.Header = http.Decode(Encoding.ASCII).Replace("\0", string.Empty);

                                    #region Don't look here

                                    if (myPacket.Header.Contains("GET"))
                                    {
                                        myPacket.Header = myPacket.Header.Substring(myPacket.Header.IndexOf("GET"));

                                        int hostStartsPos = myPacket.Header.IndexOf("Host: ") + 6;
                                        int hostLength = myPacket.Header.IndexOf("\r\n", hostStartsPos);

                                        if (hostLength == -1)
                                            continue;

                                        string host = myPacket.Header.Substring(hostStartsPos,
                                            hostLength - hostStartsPos);

                                        int addressStartPos = myPacket.Header.IndexOf("GET ") + 4;
                                        int addressLength = myPacket.Header.IndexOf(" HTTP");

                                        string addres = myPacket.Header.Substring(addressStartPos,
                                            addressLength - addressStartPos);

                                        myPacket.Header = myPacket.Header.Substring(0,
                                            myPacket.Header.IndexOf("\r\n\r\n"));

                                        myPacket.Header += "\r\n\r\nurl: http://";
                                        myPacket.Header += host;
                                        myPacket.Header += addres;
                                    }
                                    else if (myPacket.Header.Contains("POST"))
                                    {
                                        myPacket.Header = myPacket.Header.Substring(myPacket.Header.IndexOf("POST"));

                                        int hostStartsPos = myPacket.Header.IndexOf("Host: ") + 6;
                                        int hostLength = myPacket.Header.IndexOf("\r\n", hostStartsPos);

                                        if (hostLength == -1)
                                            continue;

                                        string host = myPacket.Header.Substring(hostStartsPos,
                                            hostLength - hostStartsPos);

                                        int addressStartPos = myPacket.Header.IndexOf("POST ") + 5;
                                        int addressLength = myPacket.Header.IndexOf(" HTTP");

                                        string addres = myPacket.Header.Substring(addressStartPos,
                                            addressLength - addressStartPos);

                                        myPacket.Header = myPacket.Header.Substring(0,
                                            myPacket.Header.IndexOf("\r\n\r\n"));

                                        myPacket.Header += "\r\n\r\nurl: http://";
                                        myPacket.Header += host;
                                        myPacket.Header += addres;
                                    }
                                    else if (myPacket.Header.Contains("HTTP"))
                                    {
                                        myPacket.Header = myPacket.Header.Substring(myPacket.Header.IndexOf("HTTP"));
                                        myPacket.Header = myPacket.Header.Substring(0,
                                            myPacket.Header.IndexOf("\r\n\r\n"));
                                    }
                                    else
                                        continue;

                                    properties.AppendLine();
                                    properties.AppendLine(myPacket.Header);

                                    myPacket.Header = properties.ToString();

                                    #endregion


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