using System.ComponentModel;
using PcapVisualizer.Model.Packets;

namespace PcapVisualizer.Model.Parsers
{
    public interface IProtocolParser
    {
        BindingList<Packet> ParsePcapFile(string path);
    }
}
