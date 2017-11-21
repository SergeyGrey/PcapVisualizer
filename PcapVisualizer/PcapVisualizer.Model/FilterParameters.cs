using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcapVisualizer.Model
{
    /// <summary>
    /// Класс параметров выбора отображаемых пакетов
    /// </summary>
    public class FilterParameters
    {
        /// <summary>
        /// Путь к pcap файлу, пакеты которого отображаются
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Выбранный протокол, определяет пакеты, которые будут отображаться
        /// </summary>
        public ProtocolState SelectedProtocol { get; set; }
    }
}
