using System;
using System.ComponentModel;
using System.Windows.Forms;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer
{
    public partial class FilterControl : UserControl, IFilterParametersView
    {
        public FilterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие изменение данных модели
        /// </summary>
        public event EventHandler<FilterParameters> FilterChanged;

        /// <summary>
        /// Получает или задает модель параметров
        /// </summary>
        [Browsable(false)]
        public FilterParametersViewModel ViewModel
        {
            get { return (FilterParametersViewModel)filterParametersViewModelBindingSource.DataSource; }
            set { filterParametersViewModelBindingSource.DataSource = value; }
        }
    }
}
