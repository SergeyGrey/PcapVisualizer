using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.Tests
{
    /// <summary>
    /// Реализация интрфейса вида параметров визуализатора
    /// </summary>
    class FilterParametesViewMock : IFilterParametersView
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FilterParametesViewMock()
        {
            ViewModel = new FilterParametersViewModel();
        }

        /// <summary>
        /// Событие выбора файла для обработки
        /// </summary>
        public event EventHandler<string> FileChosen;

        /// <summary>
        /// Получает или задает модель
        /// </summary>
        public FilterParametersViewModel ViewModel { get; set; }
    }
}
