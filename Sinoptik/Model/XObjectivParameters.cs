using System;
using Attr = System.ComponentModel.DataAnnotations;


namespace Sinoptik.Model
{
    [Attr.Schema.Table("ObjParams")]
    class XObjectivParameters
    {
        public Int32 Id { get; set; }
        public Int16 HeartRate { get; set; }
        public Int16 SistolicBloodPressure  { get; set; }
        public Int16 DiastolicBloodPressure { get; set; }
        public Single BodyTemp { get; set; }
        public Int16 BreathRate { get; set; }
    }
}
