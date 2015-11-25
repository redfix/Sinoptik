using System;
using System.Windows;
using System.Windows.Controls;

// "painScale.png";

namespace Sinoptik
{
    /// <summary>
    /// Логика взаимодействия для XRadioButtonStackControl.xaml
    /// </summary>
    public partial class XRadioButtonStackControl : UserControl
    {
        public XRadioButtonStackControl()
        {

            InitializeComponent();

            for (int i = 0; i < 7; ++i)
                XButtonStack.Children.Add(new RadioButton
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(2)
                });
        }

        public Int16? CheckedValue()
        {
            for(Int16 i=0; i<7; ++i)
            {
                if (((RadioButton)XButtonStack.Children[i]).IsChecked == true)
                    return i;
            }
            return null;
        }

    }
}
