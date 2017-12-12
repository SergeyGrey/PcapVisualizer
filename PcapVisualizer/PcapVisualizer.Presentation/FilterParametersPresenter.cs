using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    public class FilterParametersPresenter
    {
        /// <summary>
        /// Конструктор представления
        /// </summary>
        /// <param name="view">Вид</param>
        public FilterParametersPresenter(IFilterParametersView view)
        {
            View = view;

            View.ViewModel = new FilterParametersViewModel();
        }


        /// <summary>
        /// Получает или задает вид параметров
        /// </summary>
        public IFilterParametersView View { get; set; }

        /// <summary>
        /// Инициализирует модель представления
        /// </summary>
        /// <param name="viewModel">Модель</param>
        public void Initialize(FilterParametersViewModel viewModel)
        {
            View.ViewModel = viewModel;
        }
    }
}
