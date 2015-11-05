using System;
using System.Windows;
using System.Windows.Controls;

namespace Sinoptik
{
    /// <summary>
    /// Логика взаимодействия для XRadioButtonStackControlForPain.xaml
    /// </summary>
    public partial class XRadioButtonStackControlForPain : UserControl
    {
        public XRadioButtonStackControlForPain()
        {
            InitializeComponent();

            for (int i = 0; i < 6; ++i)
                XButtonStack.Children.Add(new RadioButton
                {
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(10,0,10,0)
                });
        }

        public Int16? CheckedValue()
        {
            for (Int16 i = 0; i < 6; ++i)
            {
                if (((RadioButton)XButtonStack.Children[i]).IsChecked == true)
                    return i;
            }
            return null;
        }
    }
}
