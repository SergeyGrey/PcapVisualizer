using System;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    public class TcpParserTests
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void TcpParserTest()
        {
           TcpParser parser = new TcpParser();

           var result = parser.ParsePcapFile(@"../../../TestFiles/test.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("TCP"));
            Assert.That(result[0].Length, Is.EqualTo(298));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("104.244.43.209"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("443"));
            Assert.That(result[0].SenderAddress, Is.EqualTo("192.168.43.156"));
            Assert.That(result[0].SenderPort, Is.EqualTo("1434"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            // unusual
            Assert.That(result[0].Header,
                Is.Not.EqualTo( @"ControlBits : Push, Acknowledgment\nCheckSum : 41150\nNextPack\nNextPacketNumber : 3723115071\nHeaderLength : 20\nPayLoadLength : 244\nWindow : 59\n"));

            Assert.That(result.Count, Is.EqualTo(93));
        }
    }
}
