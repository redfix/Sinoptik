using System;
using Attr = System.ComponentModel.DataAnnotations;


namespace Sinoptik.Model
{
    [Attr.Schema.Table("SANParams")]
    class XSANTest
    {
        public Int32 Id { get; set; }

        public Int16 SANFeeling { get; set; }
        public Int16 SANPassivActiv { get; set; }
        public Int16 SANMood { get; set; }
        public Int16 SANFullForceExhausted { get; set; }
        public Int16 SANRestedTired { get; set; }
        public Int16 SANSlepyHorny { get; set; }
        public Int16 SANDesireToWork { get; set; }
    }
}
