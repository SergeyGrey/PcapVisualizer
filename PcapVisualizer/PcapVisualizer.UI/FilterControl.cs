using System;
using System.ComponentModel;
using System.Windows.Forms;
using PcapVisualizer.Model;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.UI
{
    public partial class FilterControl : UserControl, IFilterParametersView
    {
        public FilterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Союытие выбора пакета
        /// </summary>
        public event EventHandler<string> PacketChosen;

        /// <summary>
        /// Получает или задает модель параметров
        /// </summary>
        [Browsable(false)]
        public FilterParametersViewModel ViewModel
        {
            get { return (FilterParametersViewModel)_filterParametersBindingSource.DataSource; }
            set { _filterParametersBindingSource.DataSource = value; }
        }

        /// <summary>
        /// Обработка нажатия на кнопку выбора файла
        /// </summary>
        /// <param name="sender">не используется</param>
        /// <param name="e">не используется</param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog {Filter = @"pcap file|*.pcap|all files|*"};

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;
             
            string filepath = fileDialog.FileName;

            var handle = PacketChosen;

            if (handle != null)
                handle(this, filepath);
        }
    }
}
