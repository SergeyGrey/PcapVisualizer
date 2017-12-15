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

            var result = parser.ParsePcapFile(@"../../../TestFiles/test.pcap");

            // Common properties
            Assert.That(result[0].Protocol, Is.EqualTo("HTTP"));
            Assert.That(result[0].Length, Is.EqualTo(54));
            Assert.That(result[0].DestinationAddress, Is.EqualTo("192.168.43.156"));
            Assert.That(result[0].DestinationPort, Is.EqualTo("1856"));
            Assert.That(result[0].SourceAdress, Is.EqualTo("216.239.38.21"));
            Assert.That(result[0].SourcePort, Is.EqualTo("80"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            // unusual
            Assert.That(result[0].Header,
                Is.EqualTo(""));

            Assert.That(result.Count, Is.EqualTo(4));
        }
    }
}
