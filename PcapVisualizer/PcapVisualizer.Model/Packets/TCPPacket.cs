using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Packets.Transport;

namespace PcapVisualizer.Model.Packets
{
    public class TCPPacket : Packet
    {
        // флаги TCP Пакета
        public TcpControlBits ControlBits { get; set; }
        // Контрольная сумма
        public ulong TcpCheckSum { get; set; }
        // Длинна заголовков
        public int HeaderLength { get; set; }
        // Число отвечающее за последовательность пакетов
        public uint NextPacketNumber { get; set; }
        // Длина полезной загрузки
        public int PayLoadLength { get; set; }
        // Количество октетов данных, которое отправитель этого сегмента готов принять.
        public ushort Window { get; set; }
    }
}
