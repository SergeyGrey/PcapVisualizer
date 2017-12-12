using System;

namespace PcapVisualizer.Model.Packets
{
    public class Packet
    {
        public Packet(){}
        // пакет, который отображается в списке пакетов. У него будут поля, которые будут видны в качестве столбцов (протокол, время, адрес отправителя, адрес получателя, размер, мб еще что-то)
        // + !! два поля - свойства и данные, короче все как в вайршарке
        public string SenderAddress { get; set; }
        public string SenderPort { get; set; }
        public string DestinationAddress { get; set; }
        public string DestinationPort { get; set; }
        public string Protocol { get; set; }
        public byte[] Data { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Length { get; set; }
    }
}
