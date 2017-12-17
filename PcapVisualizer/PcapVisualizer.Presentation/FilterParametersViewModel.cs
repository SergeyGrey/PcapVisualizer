using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    /// <summary>
    /// Модель параметров фильтра
    /// </summary>
    public class FilterParametersViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Поле выбранного отображаемого протокола
        /// </summary>
        private ProtocolState _selectedProtocolIndex;

        /// <summary>
        /// Поле пути к выбранному файлу
        /// </summary>
        private string _selectedFile;

        /// <summary>
        /// Событие изменение данных модели
        /// </summary>
        public event EventHandler<FilterParameters> FilterChanged;

        /// <summary>
        /// Событие изменения значения свойств
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Свойство выбранного отображаемого протокола
        /// </summary>
        public int SelectedProtocolState
        {
            get { return (int)_selectedProtocolIndex; }
            set
            {
                _selectedProtocolIndex = (ProtocolState)value;
                OnPropertyChanged();
                OnFilterChanged();
            }
        }

        /// <summary>
        /// Свойство отображаемого пути к выбранному файлу
        /// </summary>
        public string SelectedFile
        {
            get { return _selectedFile; }
            set { _selectedFile = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Ставит выбранный протокол на позицию по умолчанию
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filepath"></param>
        public void ResetProtocol(object obj, string filepath)
        {
            SelectedProtocolState = 0;
        }

        /// <summary>
        /// Задает название выбранного файла
        /// </summary>
        /// <param name="ogj">не используется</param>
        /// <param name="filepath">путь к выбранному файлу</param>
        public void SetSelectedFile(object ogj, string filepath)
        {
            SelectedFile = filepath;
        }

        /// <summary>
        /// Преобразует состояние модели в параметры для фильрации
        /// </summary>
        /// <returns></returns>
        public FilterParameters ToParameters()
        {
            return new FilterParameters{ SelectedProtocol = _selectedProtocolIndex };
        }
        
        /// <summary>
        /// Обработка наступления события изменения данных модели
        /// </summary>
        /// <param name="propertyName">Имя параметра</param>
        protected virtual void OnFilterChanged([CallerMemberName] string propertyName = null)
        {
            var handler = FilterChanged;

            if (handler != null)
                handler(this, ToParameters());
        }

        /// <summary>
        /// Вызов обработчика события изменения значения свойств
        /// </summary>
        /// <param name="propertyName">Название измененного свойства</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
