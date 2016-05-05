using System;
using System.Windows;
using Sinoptik.ViewModel;

namespace Sinoptik.View
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

            DataContext = _mwin;

        }

        
        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {


            XSANVM SAN = new XSANVM();
            if (this.RadioButtonGroupFeeling.CheckedValue() != null)
                SAN.Feeling = (Int16?)(8 - this.RadioButtonGroupFeeling.CheckedValue().Value);
            else
                SAN.Feeling = null;

            if (this.RadioButtonGroupFullForceExhausted.CheckedValue() != null)
                SAN.FullForceExhausted = (Int16?)(8 - this.RadioButtonGroupFullForceExhausted.CheckedValue().Value);
            else
                SAN.FullForceExhausted = null;

            if (this.RadioButtonGroupRestedTired.CheckedValue() != null)
                SAN.RestedTired = (Int16?)(8 - this.RadioButtonGroupRestedTired.CheckedValue().Value);
            else
                SAN.RestedTired = null;

            SAN.PassivActiv = this.RadioButtonGroupPassivActiv.CheckedValue();
            SAN.SlepyHorny = this.RadioButtonGroupSlepyHorny.CheckedValue();
            SAN.DesireToWork = this.RadioButtonGroupDesireToWork.CheckedValue();

            if (this.RadioButtonGroupMoody.CheckedValue() != null)
                SAN.Mood = (Int16?)(8 - this.RadioButtonGroupMoody.CheckedValue().Value);
            else
                SAN.Mood = null;

            if (this.RadioButtonGroupCalmHorny.CheckedValue() != null)
                SAN.CalmHorny = (Int16?)(8 - this.RadioButtonGroupCalmHorny.CheckedValue().Value);
            else
                SAN.CalmHorny = null;

            if (this.RadioButtonGroupOptimismPessimism.CheckedValue() != null)
                SAN.OptimismPessimism = (Int16?)(8 - RadioButtonGroupOptimismPessimism.CheckedValue().Value);
            else
                SAN.OptimismPessimism = null;

            _mwin.Exam.SAN = SAN;

            XSubjectivParametersVM subj = new XSubjectivParametersVM();

            subj.Headache = this.one.HeadPainStack.GetChoiceResult();
            subj.HeartPain = this.one.HeartPainStack.GetChoiceResult();
            subj.RheumaticPain = this.one.BonePainStack.GetChoiceResult();

            _mwin.Exam.SubjParams = subj;

            _mwin.SaveChanges();
        }

        private void CreateNewPlotSubWnd_Click(object sender, RoutedEventArgs e)
        {
            XStack.Children.Add(_mwin.AddWnd());
        }
    }
}
