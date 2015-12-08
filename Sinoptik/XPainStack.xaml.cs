using System;
using System.Windows.Controls;

namespace Sinoptik
{
    /// <summary>
    /// Interaction logic for XPainStack.xaml
    /// </summary>
    public partial class XPainStack : UserControl
  {
    public XPainStack()
    {
      InitializeComponent();
    }

    public Int16? GetChoiceResult()
    {
      Int16 result;
      foreach (RadioButton el in this.Stack1.Children)
        if ((el.IsChecked.HasValue) ? el.IsChecked.Value : false)
          if (el.Name.Length == 10)
            if (Int16.TryParse(el.Name.Substring(9, 1), out result))
              return result;
            else
              return null;
          else
            if (Int16.TryParse(el.Name.Substring(9, 2), out result))
              return result;
            else
              return null;
        else
          continue;
      return null;
    }
  }
}
