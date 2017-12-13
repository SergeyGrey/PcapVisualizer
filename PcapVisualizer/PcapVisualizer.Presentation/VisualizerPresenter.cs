using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PcapVisualizer.Presentation
{
    public class VisualizerPresenter
    {
        public VisualizerPresenter(IVisualizerView view, FilterParametersPresenter presenter)
        {
            View = view;
            FilterParametersPresenter = presenter;

            View.ViewModel = new ResultPacketsViewModel();
            FilterParametersPresenter.View.FileChosen += View.ViewModel.Parse;
        }

        /// <summary>
        /// Получает или задает вид
        /// </summary>
        public IVisualizerView View { get; set; }

        /// <summary>
        /// Получает или задает представление управления фильтром
        /// </summary>
        public FilterParametersPresenter FilterParametersPresenter { get; set; }

        /// <summary>
        /// Инициализирует модель представления
        /// </summary>
        /// <param name="viewModel">Модель</param>
        public void Initialize(ResultPacketsViewModel viewModel)
        {
            View.ViewModel = viewModel;
        }
    }
}
