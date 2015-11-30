using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sinoptik
{
    /// <summary>
    /// Interaction logic for PainControl.xaml
    /// </summary>
    public partial class PainControl : UserControl
    {
        public PainControl()
        {
            InitializeComponent();
        }

        public int GetChoiceResult()
        {
          int result;
          foreach (RadioButton el in this.Stack1.Children)
            if ((el.IsChecked.HasValue) ? el.IsChecked.Value : false)
              if (el.Name.Length == 10)
                if (Int32.TryParse(el.Name.Substring(9, 1), out result))
                  return result;
                else
                  return -1;
              else
                if (Int32.TryParse(el.Name.Substring(9, 2), out result))
                  return result;
                else
                  return -1;
            else
              continue;
          return -1;
        }
    }
}
