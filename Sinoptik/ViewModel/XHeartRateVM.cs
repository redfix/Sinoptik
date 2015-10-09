using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.ViewModel
{
    sealed class XHeartRateVM : XParameterBase<Int16> 
    {
        static XHeartRateVM() 
         {
            Name = "ЧСС";
            Measure = "Уд/мин";
            MaxValidValue = 220;
            MinValidValue = 30;
            MaxAllowableValue = 85;
            MinAllowableValue = 50;
            MaxDangerouseValue = 100;
            MinDangerouseValue = 40;
         }


        public XHeartRateVM(Int16 hrValue)
        {
            Value = hrValue;   
        }

        public XHeartRateVM() 
        {
            
        }

    }
}
