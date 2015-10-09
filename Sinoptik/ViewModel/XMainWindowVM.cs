using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinoptik.Model;

namespace Sinoptik.ViewModel
{
    class XMainWindowVM : XViewModelBase
    {
        XExamVM _exam;
        XDBContext _context;
        XClientVM _client;
        //Action _act;

        public XMainWindowVM()
        {
            Exam = new XExamVM();
            _context = new XDBContext();

            var v = from cl in _context.Clients
                    where cl.Id == 1
                    select cl;

            foreach (XClient c in v)
                _client = new XClientVM(c);

            //  _act = new Action(SaveChanges);
        }



        internal XExamVM Exam
        {
            get
            {
                return _exam;
            }

            private set
            {
                _exam = value;
            }
        }

        public void SaveChanges() 
        {
            _client.AddExam(Exam);
            _context.SaveChanges();
         }


    }
}
