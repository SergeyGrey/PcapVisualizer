using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    /// <summary>
    /// Реализация интерфейса вида визуализатора
    /// </summary>
    class VisualizerViewMock : IVisualizerView
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public VisualizerViewMock()
        {
            ControlView = new FilterParametesViewMock();
            ViewModel = new VisualizerViewModel();
        }

        /// <summary>
        /// Получает или задает вид управления
        /// </summary>
        public IFilterParametersView ControlView { get; set; }

        /// <summary>
        /// Получает или задает модель результатов поиска
        /// </summary>
        public VisualizerViewModel ViewModel { get; set; }
    }
}
