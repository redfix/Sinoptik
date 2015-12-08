﻿using System;
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
            this.HeadPainStack.Header.Content = "Головная боль";
            this.HeartPainStack.Header.Content = "Боль в сердце";
            this.BonePainStack.Header.Content = "Боль в суставах";
        }
    }
}