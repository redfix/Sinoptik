using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinoptik.Model;

namespace Sinoptik.ViewModel
{
    class XWeatherVM
    {
        readonly XWeather _weather;

        public XWeatherVM()
        {
            _weather = new XWeather();
        }

        public XWeatherVM(XWeather weather)
        {
            _weather = weather;
        }


        public String Local 
        {
            get 
            {
                return Weather.Local; 
            }
            set
            {
                Weather.Local = value;
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


        public Int16 Temp
        {
            get
            {
                return Weather.Temp;
            }
            set
            {
                Weather.Temp = value;
            }
        }

        public Int16 Pressure
        {
            get
            {
                return Weather.Pressure; 
            }
            set
            {
                Weather.Pressure = value;
             }
        }

        public Int16 Cloudly
        {
            get
            {
                return Weather.Cloudly;
            }
            set
            {
                if (value < 1 || value > 4) //смотря какая шкала (Ясно-Малооблачно-Облачно-Пасмурно)
                    throw new ArgumentException("Значение вне допустимых пределов (1-4)");
                Weather.Cloudly = value;
            }
        }


        public Int16 RainFall
        {
            get
            {
                return Weather.RainFall; 
            }
            set
            {
                if (value < 1 || value > 4) //смотря какая шкала (Нет осадков-Слабые осадки-Осадки-Сильные осадки)
                    throw new ArgumentException("Значение вне допустимых пределов (1-4)");
                Weather.RainFall = value;
            }
        }

        public Int16 Geomagnetic 
        {
            get 
            {
                return Weather.Geomagnetic; 
            }
            set 
            {
                if (value < 1 || value > 8)
                    throw new ArgumentException("Значение вне допустимых пределов (1-8)");
                else
                    Weather.Geomagnetic = value;
            }
        }




        internal XWeather Weather
        {
            get
            {
                return _weather;
            }
        }
    }
}
