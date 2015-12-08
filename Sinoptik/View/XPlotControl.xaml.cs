using Sinoptik.Model;
using System.Windows.Controls;

namespace Sinoptik.View
{
    /// <summary>
    /// Логика взаимодействия для XPlotControl.xaml
    /// </summary>
    public partial class XPlotControl : UserControl
    {
        public XPlotControl()
        {
            InitializeComponent();
        }

        public XPlotControl(XPlot plot)
        {
            InitializeComponent();
            DataContext = plot;
        }
    }
}
