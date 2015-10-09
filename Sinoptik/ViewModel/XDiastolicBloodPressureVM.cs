using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.ViewModel
{
    class XDiastolicBloodPressureVM : XParameterBase<Int16>
    {
        static XDiastolicBloodPressureVM()
        {
            Name = "ДиастолическоеАД";
            Measure = "мм.рт.ст";
            MaxValidValue = 150;
            MinValidValue = 30;
            MaxAllowableValue = 90;
            MinAllowableValue = 70;
            MaxDangerouseValue = 110;
            MinDangerouseValue = 55;
        }

        public XDiastolicBloodPressureVM()
        { }
        public XDiastolicBloodPressureVM(Int16 sadValue)
        {
            Value = sadValue;
        }
    }
}
