using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.ViewModel
{
    class XSistolicBloodPressureVM : XParameterBase<Int16>
    {
        static XSistolicBloodPressureVM()
        {
            Name = "СистолическоеАД";
            Measure = "мм.рт.ст";
            MaxValidValue = 220;
            MinValidValue = 30;
            MaxAllowableValue = 130;
            MinAllowableValue = 110;
            MaxDangerouseValue = 145;
            MinDangerouseValue = 95;
        }

        public XSistolicBloodPressureVM() { }
        public XSistolicBloodPressureVM(Int16 sadValue)
        {
            Value = sadValue;
        }
    }
}
