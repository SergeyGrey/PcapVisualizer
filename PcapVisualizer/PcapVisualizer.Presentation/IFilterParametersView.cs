using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapVisualizer.Model;

namespace PcapVisualizer.Presentation
{
    public interface IFilterParametersView
    {
        event EventHandler<FilterParameters> FilterChanged;

        FilterParametersViewModel ViewModel { get; set; }
    }
}
