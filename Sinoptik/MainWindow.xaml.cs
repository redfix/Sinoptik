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
using Sinoptik.Model;
using Sinoptik.ViewModel;

namespace Sinoptik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            using (XDBContext dbContext = new XDBContext())
            {



                var c = dbContext.Clients.Include("ExamsCollection.Weather")
                                                .Include("ExamsCollection.ObjParams")
                                                .Include("ExamsCollection.SubjParams")
                                                .Include("ExamsCollection.SANTest");



                ////cl.Name = "Fktrcfylh";
                //XExamVM ex = new XExamVM()
                //{

                //};

                //ex.HeartRate = 88;
                //ex.BodyTemp = 36.6f;
                //ex.SBP = 121;
                //ex.DBP = 82;

                //ex.SAN.DesireToWork = 5;
                //ex.SAN.Feeling = 6;
                //ex.SAN.FullForceExhausted = 6;
                //ex.SAN.Mood = 6;
                //ex.SAN.PassivActiv = 5;
                //ex.SAN.RestedTired = 6;

                //ex.DateAndTime = DateTime.Now;

                //ex.Weather.Local = "mayakovka";
                //ex.Weather.Temp = 6;
                //ex.Weather.Pressure = 745;
                //ex.Weather.RainFall = 1;
                //ex.Weather.Geomagnetic = 2;
                //ex.Weather.Cloudly = 3;

                //ex.SubjParams.Headache = 7;
                //ex.SubjParams.HeartPain = 1;
                //ex.SubjParams.RheumaticPain = 1;
                

              //  cl.AddExam(ex);
                //dbContext.Clients

                //dbContext.SaveChanges();
            }
                       
        }
    }
}
