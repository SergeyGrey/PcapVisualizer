using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class EthernetParserTests
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void EthernetParserTest()
        {
            EthernetParser parser = new EthernetParser();

            var result = parser.ParsePcapFile(@"../../../../TestFiles/test.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("Ethernet"));
            Assert.That(result[0].Length, Is.EqualTo(42));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("43.1.0.0"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("2048"));
            Assert.That(result[0].SourceAddress, Is.EqualTo("199.15.192.168"));
            Assert.That(result[0].SourcePort, Is.EqualTo("1"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            // unusual
            Assert.That(result[0].Header,
               Is.EqualTo("MAC adress of destination : FF:FF:FF:FF:FF:FF\r\nEtherType : Arp\r\nHeaderLength : 14\r\nPayloadLength : 28\r\nSource Mac adress : 64:CC:2E:E8:C7:0F\r\n"));

            Assert.That(result.Count, Is.EqualTo(3));
        }
    }
}