using System;
using System.Collections.Generic;
using System.ComponentModel;
using PcapDotNet.Packets;
using Packet = PcapVisualizer.Model.Packet;

namespace PcapVisualizer.Model.Parsers
{
    public static class PcapParser
    {
        /// <summary>
        /// Реализуй меня, пожалуйста!
        /// </summary>
        /// <param name="filepath">Путь к используемому pcap - файлу</param>
        /// <returns></returns>
        public static List<Model.Packet> ParsePcapFile(string filepath)
        {
            var result = new List<Model.Packet>();

            var pac = new Model.Packet();
            pac.Protocol = "prot";
            pac.Data = new byte[10] {0,1,2,3,4,5,6,7,8,29};
            pac.DestinationAddress = "111.111";
            pac.DestinationPort = "0";
            pac.Header = "header";
            pac.Length = 11;
            pac.SourceAdress = "22.22";
            pac.SourcePort = "1";
            pac.TimeStamp = new DateTime(20,10,11);

            var pac2 = new Model.Packet();
            pac2.Protocol = "ICMP";
            pac2.Data = new byte[10] { 0, 31, 2, 23, 4, 5, 6, 17, 8, 29 };
            pac2.DestinationAddress = "111.111";
            pac2.DestinationPort = "0";
            pac2.Header = "header2";
            pac2.Length = 11;
            pac2.SourceAdress = "22.22";
            pac2.SourcePort = "1";
            pac2.TimeStamp = new DateTime(20, 10, 11);

            result.Add(pac);
            result.Add(pac2);
            return result;
        }
    }
}
