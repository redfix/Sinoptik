using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.ViewModel
{
    class XBodyTempVM : XParameterBase<Single>
    {
        static XBodyTempVM()
        {
            Name = "Температура тела";
            Measure = "град. С";
            MaxValidValue = 50.0f;
            MinValidValue = 30.0f;
            MaxAllowableValue = 36.9f;
            MinAllowableValue = 36.3f;
            MaxDangerouseValue = 38.0f;
            MinDangerouseValue = 36.0f;
        }

        public XBodyTempVM() { }
        public XBodyTempVM(Single tempValue)
        {
            Value = tempValue; 
        }



    }
}
