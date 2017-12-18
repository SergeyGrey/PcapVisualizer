using System;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    public class UDPParserTests
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void UDPParserTest()
        {
            UDPParser parser = new UDPParser();

            var result = parser.ParsePcapFile(@"../../../../TestFiles/test.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("UDP"));
            Assert.That(result[0].Length, Is.EqualTo(145));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("95.27.46.98"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("58595"));
            Assert.That(result[0].SourceAddress, Is.EqualTo("192.168.43.156"));
            Assert.That(result[0].SourcePort, Is.EqualTo("60734"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            // unusual
            Assert.That(result[0].Header,
                Is.EqualTo("Checksum : 18532\r\nPacketLength : 111\r\n"));

            Assert.That(result.Count, Is.EqualTo(51));
        }
    }

}
