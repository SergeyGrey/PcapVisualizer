using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.UI
{
    public partial class PcapVisualizerForm : Form, IVisualizerView
    {
        public PcapVisualizerForm()
        {
            InitializeComponent();
            CustomInitializeComponent();
        }

        /// <summary>
        /// Получает или задает модель вывода результатов поиска
        /// </summary>
        [Browsable(false)]
        public ResultPacketsViewModel ViewModel
        {
            get { return (ResultPacketsViewModel)filterResultsBindingSource.DataSource; }
            set { filterResultsBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Получает или задает вид элемента управления
        /// </summary>
        public IFilterParametersView ControlView { get; set; }

        /// <summary>
        /// Дополнение стандартного конструктора формы
        /// </summary>
        private void CustomInitializeComponent()
        {
            ControlView = filterControl;
        }
    }
}
