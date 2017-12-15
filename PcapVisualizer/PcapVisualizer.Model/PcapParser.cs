using System;
using System.Collections.Generic;
using System.Linq;
using LightInject;
using PcapDotNet.Base;
using PcapVisualizer.Model.Parsers;

namespace PcapVisualizer.Model
{
    public class PcapParser
    {
        /// <summary>
        /// 
        /// </summary>
        private static ServiceContainer DiContainer { get; set; }
        private static string[] _parsersNames = { "EthernetParser", "HTTPParser", "ICMPParser", "TCPParser", "UDPParser" };

        /// <summary>
        /// Парсер pcap файлов на основе модулей и ligthinject
        /// </summary>
        /// <param name="filepath">Путь к используемому pcap - файлу</param>
        /// <returns> список пакетов </returns>
        public static List<Packet> ParsePcapFile(string filepath)
        {
            if (DiContainer == null)
                InitializeContainer();

            var result = new List<Packet>();

            foreach (var parser in _parsersNames.Select(parserName => DiContainer.GetInstance<IProtocolParser>(parserName)))
                result.AddRange(parser.ParsePcapFile(filepath));

            return result;
        }

        private static void InitializeContainer()
        {
          DiContainer = new ServiceContainer();

          DiContainer.Register<IProtocolParser, HTTPParser>("HTTPParser");
          DiContainer.Register<IProtocolParser, TcpParser>("TCPParser");
          DiContainer.Register<IProtocolParser, EthernetParser>("EthernetParser");
          DiContainer.Register<IProtocolParser, ICMPParser>("ICMPParser");
          DiContainer.Register<IProtocolParser, UDPParser>("UDPParser");
        }
    }
}
