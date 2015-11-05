using System;
using System.Windows;
using Sinoptik.ViewModel;

namespace Sinoptik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        XMainWindowVM _mwin;
        public MainWindow()
        {
            InitializeComponent();

            _mwin = new XMainWindowVM();

            DataContext = _mwin.Exam;

        }

        
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.RadioButtonGroupFeeling.CheckedValue() != null)
                _mwin.Exam.SAN.Feeling = (Int16?)(6 - this.RadioButtonGroupFeeling.CheckedValue().Value);
            else
                _mwin.Exam.SAN.Feeling = null;

            if (this.RadioButtonGroupFullForceExhausted.CheckedValue() != null)
                _mwin.Exam.SAN.FullForceExhausted = (Int16?)(6 - this.RadioButtonGroupFullForceExhausted.CheckedValue().Value);
            else
                _mwin.Exam.SAN.FullForceExhausted = null;

            if (this.RadioButtonGroupRestedTired.CheckedValue() != null)
                _mwin.Exam.SAN.RestedTired = (Int16?)(6 - this.RadioButtonGroupRestedTired.CheckedValue().Value);
            else
                _mwin.Exam.SAN.RestedTired = null;

            _mwin.Exam.SAN.PassivActiv = this.RadioButtonGroupPassivActiv.CheckedValue();
            _mwin.Exam.SAN.SlepyHorny = this.RadioButtonGroupSlepyHorny.CheckedValue();
            _mwin.Exam.SAN.DesireToWork = this.RadioButtonGroupDesireToWork.CheckedValue();

            if (this.RadioButtonGroupMoody.CheckedValue() != null)
                _mwin.Exam.SAN.Mood = (Int16?)(6 - this.RadioButtonGroupMoody.CheckedValue().Value);
            else
                _mwin.Exam.SAN.Mood = null;

            if (this.RadioButtonGroupCalmHorny.CheckedValue() != null)
                _mwin.Exam.SAN.CalmHorny = (Int16?)(6 - this.RadioButtonGroupCalmHorny.CheckedValue().Value);
            else
                _mwin.Exam.SAN.CalmHorny = null;

            

            _mwin.SaveChanges();
        }
    }
}
