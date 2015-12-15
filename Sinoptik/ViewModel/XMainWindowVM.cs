using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinoptik.Model;
using System.Windows.Data;
using System.ComponentModel;
using Sinoptik.View;
using Sinoptik.DAL;

namespace Sinoptik.ViewModel
{
    class XMainWindowVM : XViewModelBase
    {
       readonly XExamVM _exam;
        //   readonly XDBContext _context;
       public  readonly XDAL _DAL;
       readonly XClientVM _client;
        readonly IEnumerable<String> _paramTypeNamesCollection; 
        readonly CollectionViewSource _paramTypeNamesCVSView;

        //Даты для фильтрации параметров
        DateTime _dateFrom = new DateTime(2000, 1, 1);
        DateTime _dateTo = DateTime.Now;
        //Action _act;

        public XMainWindowVM()
        {
            //_exam = new XExamVM();
            _DAL = new XDAL("DBSinoptik");
            _paramTypeNamesCollection = new List<String> 
            {
                "ЧСС",
                "СисАД",
                "ДиастАД",
                "ЧД"              
            };

            _paramTypeNamesCVSView = new CollectionViewSource();
            _paramTypeNamesCVSView.Source = _paramTypeNamesCollection;
            _paramTypeNamesCVSView.View.CurrentChanged += ParamTypeNameView_CurrentChanged;


            IEnumerable<XClient> clients = _DAL.GetEntityCollection<XClient>("ExamsCollection");
           IEnumerable<XExam> exams = _DAL.GetEntityCollection<XExam>("Weather", "ObjParams");

            _client = new XClientVM(clients.First(cl => cl.Id == 1));
            //  _act = new Action(SaveChanges);
        }


        public String SelectedParamName
        {
            get
                {
                    return ParamTypeNamesCVSView.CurrentItem as String;
                }
        }

        private void ParamTypeNameView_CurrentChanged(object sender, EventArgs e)
        {
            RaisePropertyChanged("SelectedParamName");
        }

        public XExamVM Exam
        {
            get
            {
                return _exam;
            }
        }

        

        public ICollectionView ParamTypeNamesCVSView
        {
            get
            {
                return _paramTypeNamesCVSView.View;
            }
        }

        /// <summary>
        /// Возвращает или задает начальную дату для фильтрации параметров
        /// </summary>
        public DateTime DateFrom
        {
            get
            {
                return _dateFrom;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _dateFrom = value;
            }
        }

        /// <summary>
        /// Возвращает или задает конечную дату для фильтрации параметров
        /// </summary>
        public DateTime DateTo
        {
            get
            {
                return _dateTo;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                _dateTo = value;
            }
        }

        public void SaveChanges() 
        {
            //_client.AddExam(Exam);
            //_context.SaveChanges();
        }



        internal XPlotControl AddWnd()
        {
            return new XPlotControl(CreatePlot());
        }

        public XPlot CreatePlot()
        {
            XPlot plot = new XPlot();
            plot.CreatePlot(this._client.GetParameterValue(SelectedParamName, DateFrom, DateTo), SelectedParamName);
            return plot;
        }
    }
}
