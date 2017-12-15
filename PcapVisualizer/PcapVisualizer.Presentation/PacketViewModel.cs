using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Модель отображаемого пакета
    /// </summary>
    public class PacketViewModel : Packet
    {
        /// <summary>
        /// Скрываемое поле, к которому ведется обращение с помощью свойств
        /// </summary>
        public readonly Packet Packet;

        public PacketViewModel(Packet incomingPacket)
        {
            Packet = incomingPacket;
        }

        [DisplayName(@"Time")]
        public new string TimeStamp
        {
            get { return Packet.TimeStamp.ToString(); }
        }

        [DisplayName(@"Source adress")]
        public new string SourceAdress
        {
            get { return Packet.SourceAdress; }
        }

        [DisplayName(@"Source port")]
        public new string SourcePort
        {
            get { return Packet.SourcePort; }
        }

        [DisplayName(@"Protocol")]
        public new string Protocol
        {
            get { return Packet.Protocol; }
        }

        [DisplayName(@"Destination address")]
        public new string DestinationAddress
        {
            get { return Packet.DestinationAddress; }
        }

        [DisplayName(@"Destination port")]
        public new string DestinationPort
        {
            get { return Packet.DestinationPort; }
        }

        [DisplayName(@"Length")]
        public new string Length
        {
            get { return Packet.Length.ToString(); }
        }

        public new string Header
        {
            get { return Packet.Header; }
        }

        public new string Data
        {
            get { return ByteArrayToHexString(Packet.Data); }
        }

        /// <summary>
        /// Преобразует массив байт в читаемую строку с переносом по группам байт
        /// </summary>
        /// <param name="bytesArray">Массив байт для преобразования</param>
        /// <returns></returns>
        private static string ByteArrayToHexString(byte[] bytesArray)
        {
            StringBuilder result = new StringBuilder();
            string alphabet = "0123456789ABCDEF";

            int bytePosition = 0;

            foreach (byte currentByte in bytesArray)
            {
                result.Append(alphabet[(int)(currentByte >> 4)]);
                result.Append(alphabet[(int)(currentByte & 0xF)]);
                if (bytePosition % 16 == 15)
                    result.Append("\r\n");
                else if(bytePosition % 8 == 7)
                    result.Append("\t");
                else
                    result.Append(" ");

                ++bytePosition;
            }

            return result.ToString();
        } 
    }
}
