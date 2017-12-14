using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Интерфейс вида контроллера параметров фильтрации
    /// </summary>
    public interface IFilterParametersView
    {
        /// <summary>
        /// Событие совершения выбора обрабатываемого файла
        /// </summary>
        event EventHandler<string> PacketChosen;

        /// <summary>
        /// Модель вида
        /// </summary>
        FilterParametersViewModel ViewModel { get; set; }
    }
}