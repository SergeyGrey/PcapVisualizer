using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Интерфейс вида визуализатора
    /// </summary>
    public interface IVisualizerView
    {
        /// <summary>
        /// Модель вида
        /// </summary>
        ResultPacketsViewModel ViewModel { get; set; }

        /// <summary>
        /// Вид контроллера
        /// </summary>
        IFilterParametersView ControlView { get; set; }
    }
}
