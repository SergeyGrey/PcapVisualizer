using System;

namespace PcapVisualizer.Model.Packets
{
    public class Packet
    {
        public Packet(){}
        // пакет, который отображается в списке пакетов. У него будут поля, которые будут видны в качестве столбцов (протокол, время, адрес отправителя, адрес получателя, размер, мб еще что-то)
        // + !! два поля - свойства и данные, короче все как в вайршарке
        public string SourceAdress { get; set; }
        public string SourcePort { get; set; }
        public string DestinationAddress { get; set; }
        public string DestinationPort { get; set; }
        public string Protocol { get; set; }

        /// <summary>
        /// Данные, находящиеся в пакете
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Прочие данные из заголовка пакета
        /// </summary>
        public string Header { get; set; }

        public DateTime TimeStamp { get; set; }
        public int Length { get; set; }
    }
}
