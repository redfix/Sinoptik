using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinoptik.Model;

namespace Sinoptik.ViewModel
{
    class XExamVM
    {
        readonly XExam _exam;

        readonly XHeartRateVM _heartRate;
        readonly XBodyTempVM _bodyTemp;
        readonly XSistolicBloodPressureVM _sBP;
        readonly XDiastolicBloodPressureVM _dBP;
        readonly XBreathRateVM _breathRate;
        readonly XSANVM _san;
        readonly XWeatherVM _weather;
        readonly XSubjectivParametersVM _subjParams;
        


        public XExamVM(XExam exam)
        {
            _exam = exam;
            _heartRate = new XHeartRateVM(exam.ObjParams.HeartRate);
           // _heartRate.Value = exam.ObjParams.HeartRate;
            _san = new XSANVM(exam.SANTest);
            _subjParams = new XSubjectivParametersVM(exam.SubjParams);
            _weather = new XWeatherVM(exam.Weather);
            _bodyTemp = new XBodyTempVM(exam.ObjParams.BodyTemp);
            //_bodyTemp.Value = exam.ObjParams.BodyTemp;
            _sBP = new XSistolicBloodPressureVM(exam.ObjParams.SistolicBloodPressure);
            //_sBP.Value = exam.ObjParams.SistolicBloodPressure;
            _dBP = new XDiastolicBloodPressureVM(exam.ObjParams.DiastolicBloodPressure);
            //_dBP.Value = exam.ObjParams.DiastolicBloodPressure;
            _breathRate = new XBreathRateVM(exam.ObjParams.BreathRate);
        }

        public XExamVM() 
        {
            _exam = new XExam();
            _exam.ObjParams = new XObjectivParameters();
            _exam.SANTest = new XSANTest();
            _exam.SubjParams = new XSubjectivParameters();
            _exam.Weather = new XWeather();
            _heartRate = new XHeartRateVM();
            _san = new XSANVM(new XSANTest());
            _subjParams = new XSubjectivParametersVM(new XSubjectivParameters());
            _bodyTemp = new XBodyTempVM();
            _sBP = new XSistolicBloodPressureVM();
            _dBP = new XDiastolicBloodPressureVM();
            _weather = new XWeatherVM(new XWeather());
            _breathRate = new XBreathRateVM();
        }

        internal XExam Exam
        {
            get
            {
                return _exam;
            }
        }

        public Int16 HeartRate
        {
            get
            {
                return _heartRate.Value;
            }
            set
            {
                _exam.ObjParams.HeartRate = _heartRate.Value = value;
            }
        }

        public XSANVM SAN 
        {
            get 
            {
                return _san;
            }
            set
            {
                _exam.SANTest = value.SANTest;
              
            }
        }

        internal XWeatherVM Weather
        {
            get
            {
                return _weather;
            }
        }

        public DateTime DateAndTime
        {
            get
            {
                return Weather.DateAndTime;
            }
            set
            {
                Weather.DateAndTime = value;
            }
        }

        internal Single BodyTemp
        {
            get
            {
                return _bodyTemp.Value;
            }
            set
            {
                _exam.ObjParams.BodyTemp = _bodyTemp.Value = value;
            }
        }

        public Int16 SBP
        {
            get
            {
                return _sBP.Value;
            }
            set
            {
                _exam.ObjParams.SistolicBloodPressure = _sBP.Value = value;
            }
        }

        public Int16 DBP
        {
            get
            {
                return _dBP.Value;
            }
            set
            {
                _exam.ObjParams.DiastolicBloodPressure = _dBP.Value = value;
            }
        }


        public Int16 BreathRate
        {
            get
            {
                return _breathRate.Value;
            }

            set 
            {
                _exam.ObjParams.BreathRate = _breathRate.Value = value;
            }
        }

        internal XSubjectivParametersVM SubjParams
        {
            get
            {
                return _subjParams;
            }
            set 
            {
                _exam.SubjParams = value.SubjParams;
            }
        }

    }
}
