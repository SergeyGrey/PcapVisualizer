using System;

namespace PcapVisualizer.Model
{
    public class Packet
    {
        public Packet(){}
<<<<<<< HEAD
        // пакет, который отображается в списке пакетов.
        // протокол, время, адрес отправителя, адрес получателя, размер
        // два поля - свойства и данные, как в вайршарке
        public string SourceAdress { get; set; }
=======
        // пакет, который отображается в списке пакетов. У него будут поля, которые будут видны в качестве столбцов (протокол, время, адрес отправителя, адрес получателя, размер, мб еще что-то)
        // + !! два поля - свойства и данные, короче все как в вайршарке
        public string SourceAddress { get; set; }
>>>>>>> 442b03bdd1d0dcd80ff8abf848e7320fe927a353
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
