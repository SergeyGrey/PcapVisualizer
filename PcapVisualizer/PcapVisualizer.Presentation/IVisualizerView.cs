using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcapVisualizer.Presentation
{
    public interface IVisualizerView
    {
        ResultPacketsViewModel ViewModel { get; set; }

        IFilterParametersView ControlView { get; set; }
    }
}
