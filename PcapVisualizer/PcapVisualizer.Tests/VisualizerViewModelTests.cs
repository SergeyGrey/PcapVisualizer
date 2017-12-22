using System;
using System.ComponentModel;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    /// <summary>
    /// Тестирование модели визуализатора
    /// </summary>
    [TestFixture]
    class VisualizerViewModelTests
    {
        private VisualizerViewModel _model;

        /// <summary>
        /// Инициализация до тестов
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _model = new VisualizerViewModel();
        }
        
        /// <summary>
        /// Проверка обновления отображаемого списка пакетов
        /// </summary>
        [Test]
        public void PacketListTest()
        {
            bool visualStateUpdated = false;

            _model.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                visualStateUpdated = true;
            };

            Assert.That(_model.Packets, Is.EqualTo(new BindingList<PacketViewModel>()));

            PacketViewModel packet = new PacketViewModel(GetPacketExample());
            BindingList<PacketViewModel> list = new BindingList<PacketViewModel>() { packet };

            _model.Packets = list;
            Assert.That(_model.Packets, Is.EqualTo(list));

            Assert.True(visualStateUpdated);
        }

        /// <summary>
        /// Проверка обновления полей заголовка и данных при смене выбранного индекса пакета
        /// </summary>
        [Test]
        public void HeaderAndDataTest()
        {
            PacketViewModel packet = new PacketViewModel(GetPacketExample());
            BindingList<PacketViewModel> list = new BindingList<PacketViewModel>() { packet };

            _model.Packets = list;
            Assert.That(_model.Packets, Is.EqualTo(list));

            _model.UpdateHeaderAndData(new SelectedItemInList{ItemPosition = 0});
            Assert.That(_model.CurrentData, Is.EqualTo(packet.Data));
            Assert.That(_model.CurrentHeader, Is.EqualTo(packet.Header));
        }

        /// <summary>
        /// Проверка работы функций парсинга нового файла и фильтрации
        /// </summary>
        [Test]
        public void FilterAndParseTest()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string filepath = "../../../../TestFiles/test.pcap";

            bool listChanged = false;

            _model.PropertyChanged += delegate(object sender, PropertyChangedEventArgs args)
            {
                listChanged = true;
            };

            PacketViewModel packet = new PacketViewModel(GetPacketExample());
            BindingList<PacketViewModel> list = new BindingList<PacketViewModel>() { packet };

            _model.Packets = list;
            Assert.That(_model.Packets, Is.EqualTo(list));

            _model.Filter(null, new FilterParameters());
            _model.Parse(null, filepath);

            Assert.True(listChanged);
        }

        public Packet GetPacketExample()
        {
            var result = new Model.Packet
            {
                Protocol = "protocol",
                Data = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 21, 44 },
                DestinationAddress = "111.111",
                DestinationPort = "0",
                Header = "header",
                Length = 11,
                SourceAddress = "22.22",
                SourcePort = "1",
                TimeStamp = new DateTime(20, 10, 11)
            };

            return result;
        }
    }
}
