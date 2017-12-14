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
    /// <summary>
    /// Форма визуализатора
    /// </summary>
    public partial class PcapVisualizerForm : Form, IVisualizerView
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
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
            get { return (ResultPacketsViewModel)_filterResultsBindingSource.DataSource; }
            set { _filterResultsBindingSource.DataSource = value; }
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
            ControlView = _filterControl;
            _packetsDataGrid.SelectionChanged += SetHeaderAndData;
        }

        /// <summary>
        /// Сообщает модели, что был выбран элемент в списке пакетов
        /// </summary>
        /// <param name="obj">не используется</param>
        /// <param name="args">не испоьзуется</param>
        private void SetHeaderAndData(object obj, EventArgs args)
        {
            if (_packetsDataGrid.CurrentRow == null)
                return;

            ViewModel.UpdateHeaderAndData(new SelectedItemInList(){ ItemPosition = _packetsDataGrid.CurrentRow.Index });
        }
    }
}
