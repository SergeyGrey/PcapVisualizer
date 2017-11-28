using System;
using System.ComponentModel;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace PcapVisualizer.Model
{
    public class TCPParser : IProtocolParser
    {
        public static BindingList<MyPacket> ParsePcapFile(string path)
        {
            BindingList<MyPacket> List = new BindingList<MyPacket>();

            OfflinePacketDevice selectedDevice = new OfflinePacketDevice(path);

            // открытие файла для парсинга
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536, // считает полностью весь пакет 65536 max size of packet
                    PacketDeviceOpenAttributes.Promiscuous, // какие - то непонятные флаги)
                    1000)) // время чтения
            {

                using (BerkeleyPacketFilter filter = communicator.CreateFilter("tcp"))
                {

                    // Retrieve the packets

                    do
                    {
                        Packet packet;
                        MyPacket myPacket = new MyPacket();

                        PacketCommunicatorReceiveResult result = communicator.ReceivePacket(out packet);
                        switch (result)
                        {
                            case PacketCommunicatorReceiveResult.Timeout:
                                // Timeout
                                break;
                            case PacketCommunicatorReceiveResult.Ok:
                            {
                                IpV4Datagram ip = packet.Ethernet.IpV4;
                                UdpDatagram udp = ip.Udp;

                                myPacket.Protocol = "TCP";
                                myPacket.SenderAdr = ip.Source + " : " + udp.SourcePort.ToString();
                                myPacket.DestinationAdr = ip.Destination + " : " + udp.DestinationPort;
                                myPacket.TimeStamp = packet.Timestamp;
                                myPacket.Length = packet.Length;
                                myPacket.Data = packet.Buffer;

                                List.Add(myPacket);

                                continue;
                            }
                            default:
                                throw new InvalidOperationException("The result " + result +
                                                                    " shoudl never be reached here");
                        }
                    } while (true);

                }
            }

            return List;
        }
    }
}


//        //    private static void DispatcherHandler(PcapDotNet.Packets.MyPacket packet)
//    //    {
//    //        // print packet timestamp and packet length
//    //        Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss") + " length:" + packet.Length);
//    //        Console.WriteLine(packet.IpV4.Protocol);
//    //        Console.WriteLine(Enum.GetName(typeof(IpV4Protocol), packet.IpV4.Protocol));
//    //        // Print the packet
//    //        const int LineLength = 64;
//    //        for (int i = 0; i != packet.Length; ++i)
//    //        {
//    //            Console.Write((packet[i]).ToString("X2"));
//    //            if ((i + 1) % LineLength == 0)
//    //                Console.WriteLine();
//    //        }


//                   // IpV4Datagram ip = packet.Ethernet.IpV4;
//            //UdpDatagram udp = ip.Udp;
            
//            // print ip addresses and udp ports
//        //    Console.WriteLine(ip.Source + ":" + udp.SourcePort+ " -> " + ip.Destination + ":" + udp.DestinationPort);
//    //        Console.WriteLine();
//    //        Console.WriteLine();
//    //    }
//    //}
//}
//        } 
//    }
//}