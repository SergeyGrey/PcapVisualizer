using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcapVisualizer.Model
{
    /// <summary>
    /// Выбранный протокол, пакеты которого требуется отобразить
    /// </summary>
    public enum ProtocolState
    {
        /// <summary>
        /// Все протоколы
        /// </summary>
        All,

        /// <summary>
        /// Протокол Ethernet
        /// </summary>
        Ethernet,

        /// <summary>
        /// Протокол TCP
        /// </summary>
        TCP,

        /// <summary>
        /// Протокол UDP
        /// </summary>
        UDP,

        /// <summary>
        /// Протокол ICMP
        /// </summary>
        ICMP,

        /// <summary>
        /// Протокол HTTP
        /// </summary>
        HTTP
    }
}