using System;
using System.IO;
using NUnit.Framework;
using PcapVisualizer.Model;

namespace PcapVisualizer.Tests
{
    [TestFixture]
    class ParsePcapFileTest
    {
        [SetUp]
        public void TestInitialize()
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TestCase]
        public void ParseTest()
        {
            var result = PcapParser.ParsePcapFile("../../../TestFiles/test.pcap");

            Assert.That(result.Count, Is.EqualTo(151));
        }
    }
}
