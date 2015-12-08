using System;
using Sinoptik.Model;

namespace Sinoptik.ViewModel
{
    class XSubjectivParametersVM
    {
        readonly XSubjectivParameters _subjParams;


        public XSubjectivParametersVM(XSubjectivParameters subjParams)
        {
            _subjParams = subjParams;
        }

        public XSubjectivParametersVM()
        {
            _subjParams = new XSubjectivParameters();
        }

        internal XSubjectivParameters SubjParams
        {
            get
            {
                return _subjParams;
            }
        }

        public Int16? Headache 
        {
            get
            {
                return SubjParams.Hedache;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (0-5)");
                else
                SubjParams.Hedache = value;
            }

         }

         public Int16? RheumaticPain 
         {
            get
            {
                return SubjParams.Hedache;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (0-5)");
                else
                SubjParams.Hedache = value;
            }
         }

         public Int16? HeartPain
         {
            get
            {
                return SubjParams.HeartPain;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (0-5)");
                else
                SubjParams.HeartPain = value;
            }
         }


        private Boolean Validation(Int16? value)
        {
            if (value > 10 || value < 1)
                return false;
            else
                return true;
        }

    }
}
