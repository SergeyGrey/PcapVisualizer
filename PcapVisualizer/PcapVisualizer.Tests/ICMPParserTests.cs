using System;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class ICMPParserTests
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void UDPParserTest()
        {
            ICMPParser parser = new ICMPParser();

            var result = parser.ParsePcapFile(@"../../../../TestFiles/icmp.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("ICMP"));
            Assert.That(result[0].Length, Is.EqualTo(74));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("192.168.0.1"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("16988"));
            Assert.That(result[0].SourceAddress, Is.EqualTo("192.168.0.89"));
            Assert.That(result[0].SourcePort, Is.EqualTo("2048"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2011-06-27"));

            // unusual
            Assert.That(result[0].Header,
               Is.EqualTo("Checksum : 16988\r\nMessageType : Echo\r\nMessageTypeAndCode : Echo\r\nVariable : 33556736\r\n"));

            Assert.That(result.Count, Is.EqualTo(12));
        }
    }
}
