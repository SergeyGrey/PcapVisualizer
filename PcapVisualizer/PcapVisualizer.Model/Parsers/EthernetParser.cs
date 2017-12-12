using System;
using System.ComponentModel;
using PcapVisualizer.Model.Packets;

namespace PcapVisualizer.Model.Parsers
{
    public class EthernetParser : IProtocolParser
    {
        public BindingList<Packet> ParsePcapFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
