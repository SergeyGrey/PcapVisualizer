using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapVisualizer.Presentation;

namespace PcapVisualizer.UI
{
    static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new  PcapVisualizerForm();
            var presenter = new VisualizerPresenter(form, new FilterParametersPresenter(form.ControlView));

            Application.Run(new PcapVisualizerForm());
        }
    }
}
