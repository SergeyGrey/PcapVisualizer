using System.ComponentModel;
using PcapVisualizer.Model;
using PcapVisualizer.Model.Packets;

namespace PcapVisualizer.Presentation
{
    public class PacketViewModel : Packet
    {
        public readonly Packet packet;

        public PacketViewModel(Packet incomingPacket)
        {
            packet = incomingPacket;
        }

        [DisplayName(@"Time")]
        public new string TimeStamp
        {
            get { return packet.TimeStamp.ToString(); }
        }

        [DisplayName(@"Source adress")]
        public new string SourceAdress
        {
            get { return packet.SourceAdress; }
        }

        [DisplayName(@"Source port")]
        public new string SourcePort
        {
            get { return packet.SourcePort; }
        }

        [DisplayName(@"Protocol")]
        public new string Protocol
        {
            get { return packet.Protocol; }
        }

        [DisplayName(@"Destination address")]
        public new string DestinationAddress
        {
            get { return packet.DestinationAddress; }
        }

        [DisplayName(@"Destination port")]
        public new string DestinationPort
        {
            get { return packet.DestinationPort; }
        }

        [DisplayName(@"Length")]
        public new string Length
        {
            get { return packet.Length.ToString(); }
        }
    }
}
