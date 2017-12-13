using System.Collections.Generic;
using PcapVisualizer.Model;

namespace PcapVisualizer.Model.Parsers
{
    public interface IProtocolParser
    {
        List<Packet> ParsePcapFile(string path);
    }
}
