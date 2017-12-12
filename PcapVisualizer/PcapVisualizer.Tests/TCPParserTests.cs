using System;
using System.IO;
using System.Linq;
using Castle.Components.DictionaryAdapter.Xml;
using NUnit.Framework;
using PcapVisualizer.Model;
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
            Assert.That(result[0].SourceAdress, Is.EqualTo("192.168.43.156"));
            Assert.That(result[0].SourcePort, Is.EqualTo("1434"));
            Assert.That(result[0].TimeStamp.ToString("yyyy-MM-dd"), Is.EqualTo("2017-11-23"));

            // unusual
            Assert.That(result[0].Length, Is.EqualTo(298));
            Assert.That(result[0].Length, Is.EqualTo(298));
            Assert.That(result[0].Length, Is.EqualTo(298));
            Assert.That(result[0].Length, Is.EqualTo(298));



            Assert.That(result.Count, Is.EqualTo(93));
        }
    }
}
