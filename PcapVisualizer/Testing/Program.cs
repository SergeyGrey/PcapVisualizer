using System;
using System.ComponentModel;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapVisualizer.Model;

namespace Testing
{
    class Program
    {
        static void Main()
        {
            BindingList<MyPacket> List = new BindingList<MyPacket>();

            OfflinePacketDevice selectedDevice = new OfflinePacketDevice("C:/Users/Сергей/Documents/test.pcap");

            // открытие файла для парсинга
            using (PacketCommunicator communicator =
                selectedDevice.Open(65536, // считает полностью весь пакет 65536 max size of packet
                    PacketDeviceOpenAttributes.Promiscuous, // какие - то непонятные флаги)
                    1000)) // время чтения
            {

                using (BerkeleyPacketFilter filter = communicator.CreateFilter("tcp"))
                {

                    // Retrieve the packets
                    bool endOfFile = false;

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
                                endOfFile = true;
                                break;
                        }
                    } while (!endOfFile);

                    
                }
            }
        }


        //static void Main()
        //{
        //    // Создание оффлайн считывателя
        //    OfflinePacketDevice selectedDevice = new OfflinePacketDevice("C:/Users/Сергей/Documents/test.pcap");

        //    // открытие файла для парсинга
        //    using (PacketCommunicator communicator =
        //        selectedDevice.Open(65536,                                       // считает полностью весь пакет
        //                            PacketDeviceOpenAttributes.Promiscuous,     // какие - то непонятные флаги)
        //                            1000))                                     // время чтения
        //    {

        //        using (BerkeleyPacketFilter filter = communicator.CreateFilter("udp"))
        //        {
        //            // Read and dispatch packets until EOF is reached
        //            communicator.ReceivePackets(0, DispatcherHandler);
        //        }
 
        //    }
        //}

        //private static void DispatcherHandler(Packet packet)
        //{
        //    // print packet timestamp and packet length
        //    Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss") + " length:" + packet.Length);

        //    IpV4Datagram ip = packet.Ethernet.IpV4;
        //    UdpDatagram udp = ip.Udp;

        //    // print ip addresses and udp ports
        //    Console.WriteLine(ip.Source + ":" + udp.SourcePort + " -> " + ip.Destination + ":" + udp.DestinationPort);
        //    const int LineLength = 64;
        //    for (int i = 0; i != packet.Length; ++i)
        //    {
        //        Console.Write((packet[i]).ToString("X2"));
        //        if ((i + 1) % LineLength == 0)
        //            Console.WriteLine();
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine();
        //}
    }
}