using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class PacketViewModelTests
    {
        [Test]
        public void InitTest()
        {
            Packet packet = GetPacketExample();
            PacketViewModel model = new PacketViewModel(packet);

            Assert.That(model.Packet, Is.EqualTo(packet));
            Assert.That(model.Data, Is.EqualTo("00 01 02 03 04 05 06 07    08 09 00 0B 15 2C 41 2C\r\n0B 15 2C 41 2C "));
            Assert.That(model.Header, Is.EqualTo(packet.Header));
            Assert.That(model.DestinationAddress, Is.EqualTo(packet.DestinationAddress));
            Assert.That(model.DestinationPort, Is.EqualTo(packet.DestinationPort));
            Assert.That(model.SourceAdress, Is.EqualTo(packet.SourceAdress));
            Assert.That(model.SourcePort, Is.EqualTo(packet.SourcePort));
            Assert.That(model.Length, Is.EqualTo(packet.Length.ToString()));
            Assert.That(model.TimeStamp, Is.EqualTo(packet.TimeStamp.ToString()));
            Assert.That(model.Protocol, Is.EqualTo(packet.Protocol));
        }

        public Packet GetPacketExample()
        {
            var result = new Model.Packet
            {
                Protocol = "protocol",
                Data = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 21, 44, 65, 44, 11, 21, 44, 65, 44 },
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
