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
        /// Выбранный протокол, определяет пакеты, которые будут отображаться
        /// </summary>
        public ProtocolState SelectedProtocol { get; set; }
    }
}
