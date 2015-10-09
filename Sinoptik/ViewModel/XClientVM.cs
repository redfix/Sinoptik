using System;
using Sinoptik.Model;
using System.Collections.Generic;

namespace Sinoptik.ViewModel
{
    class XClientVM : XViewModelBase
    {
        readonly XClient _client;
        ICollection<XExamVM> _examCollection;
 
        public XClientVM() 
        {
            _client = new XClient();
            ExamCollection = new List<XExamVM>();

        }
        public XClientVM(XClient client)
        {
            _client = client;

            ExamCollection = new List<XExamVM>();
            foreach(var v in client.ExamsCollection)
            {
                ExamCollection.Add(new XExamVM(v));
            }
            
        }

        internal DateTime DateBirthday
        {
            get 
            {
                return Client.DateBirthday;
             }
             set
             {
                Client.DateBirthday = value;
              // RaisePropertyChanged("DateBirthday");
                RaisePropertyChanged("Age");                
             }
        }

        internal Int32 Age 
        {
            get 
            {
                return DateBirthday.Subtract(DateTime.Now).Days / 365;
            }
         }

        internal string Name
        {
            get
            {
                return Client.Name;
            }

            set
            {
                Client.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        internal XClient Client
        {
            get
            {
                return _client;
            }
        }

        internal Boolean IsNeuroticSufferer 
        {
            get 
            {
                return Client.IsNeuroticSufferer;
            }
            set
            {
                Client.IsNeuroticSufferer = value;
              //  RaisePropertyChanged("IsNeuroticSufferer");
            }
         }

        internal Boolean IsHeartSufferer
        {
            get
            {
                return Client.IsHearhSufferer;
            }
            set
            {
                Client.IsHearhSufferer = value;
            }
        }

        internal Boolean IsRheumaticSufferer
        {
            get
            {
                return Client.IsRheumaticSufferer;
            }
            set
            {
                Client.IsRheumaticSufferer = value;
            }
        }

        internal ICollection<XExamVM> ExamCollection
        {
            get
            {
                return _examCollection;
            }

            private set
            {
                _examCollection = value;
            }
        }

        internal void AddExam(XExamVM ex)
        {
            this.ExamCollection.Add(ex);
            Client.ExamsCollection.Add(ex.Exam);
        }
    }
}
