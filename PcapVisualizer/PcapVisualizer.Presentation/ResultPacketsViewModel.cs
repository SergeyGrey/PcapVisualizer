using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PcapVisualizer.Model;
using PcapVisualizer.Model.Packets;

namespace PcapVisualizer.Presentation
{
    public class ResultPacketsViewModel
    {
        private List<Packet> _allPackets;

        public ResultPacketsViewModel()
        {
            Packets = new BindingList<PacketViewModel>();
        }

        public BindingList<PacketViewModel> Packets { get; set; }

        public void Filter(object obj, FilterParameters args)
        {
            Packets = PacketToViewModelBindingList(Model.Filter.DoFilter(_allPackets, args));
        }

        public void Parse(object ogj, string filepath)
        {
            _allPackets = Model.Parsers.PcapParser.ParsePcapFile(filepath);
            Packets = PacketToViewModelBindingList(_allPackets);
        }

        private BindingList<Packet> ViewModelToPacketBindingList(BindingList<PacketViewModel> list)
        {
            BindingList<Packet> result = new BindingList<Packet>();

            foreach (var packet in list)
                result.Add(packet.packet);

            return result;
        }

        private BindingList<PacketViewModel> PacketToViewModelBindingList(List<Packet> list)
        {
            BindingList<PacketViewModel> result = new BindingList<PacketViewModel>();

            foreach (var student in list)
                result.Add(new PacketViewModel(student));

            return result;
        }
    }
}
