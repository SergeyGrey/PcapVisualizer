using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PcapVisualizer.Presentation
{
    public class FilterParametersViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие изменение данных модели
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Обработка наступления события изменения данных модели
        /// </summary>
        /// <param name="propertyName">Имя параметра</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
