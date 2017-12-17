using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class VisualizerViewModelTests
    {
        private VisualizerViewModel _model;

        [SetUp]
        public void SetUp()
        {
            _model = new VisualizerViewModel();
        }

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

        [Test]
        public void FilterAndParseTest()
        {
            string filepath = ""; //пусть к файлу для обработки
            Assert.That(() => _model.Parse(null, ""), Throws.Exception);

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
                SourceAdress = "22.22",
                SourcePort = "1",
                TimeStamp = new DateTime(20, 10, 11)
            };

            return result;
        }
    }
}
