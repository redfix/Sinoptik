using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.ViewModel
{
    class XBreathRateVM : XParameterBase<Int16>
    {
        static XBreathRateVM()
        {
            Name = "ЧД";
            Measure = "Вдох/мин";
            MaxValidValue = 60;
            MinValidValue = 5;
            MaxAllowableValue = 25;
            MinAllowableValue = 15;
            MaxDangerouseValue = 30;
            MinDangerouseValue = 10;
        }


        public XBreathRateVM(Int16 hrValue)
        {
            Value = hrValue;
        }

        public XBreathRateVM()
        {
            
        }
    }
}
