using System;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class HttpParserTests
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void HttpParserTest()
        {
            HTTPParser parser = new HTTPParser();

            var result = parser.ParsePcapFile(@"../../../../TestFiles/test.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("HTTP"));
            Assert.That(result[0].Length, Is.EqualTo(298));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("104.244.43.209"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("443"));
            Assert.That(result[0].SourceAddress, Is.EqualTo("192.168.43.156"));
            Assert.That(result[0].SourcePort, Is.EqualTo("1434"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            Assert.That(result.Count, Is.EqualTo(93));

            result = parser.ParsePcapFile("../../../../TestFiles/newTest2.pcap");

            Assert.That(result.Count, Is.EqualTo(378));
        }
    }
}
