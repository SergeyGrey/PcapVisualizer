using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    public class ResultPacketsViewModel : INotifyPropertyChanged
    {
        private List<Packet> _allPackets;
        private BindingList<PacketViewModel> _packets;

        public ResultPacketsViewModel()
        {
            Packets = new BindingList<PacketViewModel>();
        }

        public BindingList<PacketViewModel> Packets
        {
            get { return _packets; }
            set { _packets = value; OnPropertyChanged(); }
        }

        public void Filter(object obj, FilterParameters args)
        {
            Packets = PacketToViewModelBindingList(Model.Filter.DoFilter(_allPackets, args));
        }

        public void Parse(object ogj, string filepath)
        {
            _allPackets = Model.Parsers.PcapParser.ParsePcapFile(filepath);
            Packets = PacketToViewModelBindingList(_allPackets);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private BindingList<Packet> ViewModelToPacketBindingList(BindingList<PacketViewModel> list)
        {
            BindingList<Packet> result = new BindingList<Packet>();

            foreach (var packet in list)
                result.Add(packet.Packet);

            return result;
        }

        private BindingList<PacketViewModel> PacketToViewModelBindingList(List<Packet> list)
        {
            BindingList<PacketViewModel> result = new BindingList<PacketViewModel>();

            foreach (var packet in list)
                result.Add(new PacketViewModel(packet));

            return result;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
