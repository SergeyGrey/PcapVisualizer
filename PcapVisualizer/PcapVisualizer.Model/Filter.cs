using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Packets;

namespace PcapVisualizer.Model
{
    public static class Filter
    {
        public static List<Model.Packets.Packet> DoFilter(List<Model.Packets.Packet> packets, FilterParameters parameters)
        {
            if (parameters.SelectedProtocol == ProtocolState.All)
                return packets;

            return packets.Where(pack => pack.Protocol == TranslateStateToString(parameters.SelectedProtocol)).ToList();
        }

        private static string TranslateStateToString(ProtocolState state)
        {
            if (state == ProtocolState.Ethernet)
                return "Ethernet";

            if (state == ProtocolState.HTTP)
                return "HTTP";

            if (state == ProtocolState.ICMP)
                return "ICMP";

            if (state == ProtocolState.TCP)
                return "TCP";

            return "Ethernet";
        }
    }
}
