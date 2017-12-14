using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Модель отображаемого пакета
    /// </summary>
    public class ResultPacketsViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Все рахобранные пакеты, храним отдельно от отображаемых для осуществления фильтрации
        /// </summary>
        private List<Packet> _allPackets;

        /// <summary>
        /// Скрываемое поле отображаемых пакетов
        /// </summary>
        private BindingList<PacketViewModel> _packets;

        /// <summary>
        /// Скрываемые поля заголовка и данных текущего выбранного пакета
        /// </summary>
        private string _currentHeader;
        private string _currentData;

        /// <summary>
        /// Конструктор по умолчанию - инициализирует поля
        /// </summary>
        public ResultPacketsViewModel()
        {
            _allPackets = new List<Packet>();
            Packets = new BindingList<PacketViewModel>();
        }

        public string CurrentHeader
        {
            get { return _currentHeader; }
            set { _currentHeader = value; OnPropertyChanged(); }
        }

        public string CurrentData
        {
            get { return _currentData; }
            set { _currentData = value; OnPropertyChanged(); }
        }

        public BindingList<PacketViewModel> Packets
        {
            get { return _packets; }
            set { _packets = value; OnPropertyChanged(); }
        }

        public void Filter(object obj, FilterParameters args)
        {
            Packets = PacketToViewModelBindingList(Model.Filter.DoFilter(_allPackets, args));
            CurrentHeader = CurrentData = "";
        }

        public void Parse(object ogj, string filepath)
        {
            _allPackets = Model.Parsers.PcapParser.ParsePcapFile(filepath);
            Packets = PacketToViewModelBindingList(_allPackets);
            CurrentHeader = CurrentData = "";
        }

        public void UpdateHeaderAndData(SelectedItemInList args)
        {
            PacketViewModel selectedPacket = Packets[args.ItemPosition];

            CurrentHeader = selectedPacket.Header;
            CurrentData = selectedPacket.Data;
        }

        /// <summary>
        /// Событие изменения значений свойств
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private BindingList<PacketViewModel> PacketToViewModelBindingList(List<Packet> list)
        {
            BindingList<PacketViewModel> result = new BindingList<PacketViewModel>();

            foreach (var packet in list)
                result.Add(new PacketViewModel(packet));

            return result;
        }

        /// <summary>
        /// Вызов обработчика события изменения значения свойств
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
