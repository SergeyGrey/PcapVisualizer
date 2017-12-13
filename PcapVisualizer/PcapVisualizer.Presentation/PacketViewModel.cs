using System.ComponentModel;
using System.Runtime.CompilerServices;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    public class PacketViewModel : Packet
    {
        public readonly Packet Packet;

        public PacketViewModel(Packet incomingPacket)
        {
            Packet = incomingPacket;
        }

        [DisplayName(@"Time")]
        public new string TimeStamp
        {
            get { return Packet.TimeStamp.ToString(); }
        }

        [DisplayName(@"Source adress")]
        public new string SourceAdress
        {
            get { return Packet.SourceAdress; }
        }

        [DisplayName(@"Source port")]
        public new string SourcePort
        {
            get { return Packet.SourcePort; }
        }

        [DisplayName(@"Protocol")]
        public new string Protocol
        {
            get { return Packet.Protocol; }
        }

        [DisplayName(@"Destination address")]
        public new string DestinationAddress
        {
            get { return Packet.DestinationAddress; }
        }

        [DisplayName(@"Destination port")]
        public new string DestinationPort
        {
            get { return Packet.DestinationPort; }
        }

        [DisplayName(@"Length")]
        public new string Length
        {
            get { return Packet.Length.ToString(); }
        }

        public new string Header
        {
            get { return Packet.Header; }
        }

        public new string Data
        {
            get { return Packet.Data.ToString(); }
        }
    }
}
