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
            pac.Data = null;
            pac.DestinationAddress = "111.111";
            pac.DestinationPort = "0";
            pac.Header = "header";
            pac.Length = 11;
            pac.SourceAdress = "22.22";
            pac.SourcePort = "1";
            pac.TimeStamp = new DateTime(20,10,11);

            result.Add(pac);
            return result;
        }
    }
}
