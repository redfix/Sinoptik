using System;
using Attr = System.ComponentModel.DataAnnotations;


namespace Sinoptik.Model
{
    [Attr.Schema.Table("SubjParams")]    
    class XSubjectivParameters
    {
        public Int32 Id { get; set; }

        public Int16 Hedache { get; set; }
        public Int16 RheumaticPain { get; set; }
        public Int16 HeartPain { get; set; }
    }
}
