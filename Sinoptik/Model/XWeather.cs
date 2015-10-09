using System;
using System.Collections.Generic;
using Attr = System.ComponentModel.DataAnnotations;

namespace Sinoptik.Model
{
    [Attr.Schema.Table("Weather")]
    class XWeather
    {
        
        public Int32 Id { get; set; }

        [Attr.Schema.Column("DateAndTime", TypeName = "datetime2")]
        public DateTime DateAndTime { get; set; }
        public String Local { get; set; }

        public Int16 Temp { get; set; }
        public Int16 Pressure { get; set; }
        public Int16 Cloudly { get; set; }
        public Int16 RainFall { get; set; }
        public Int16 Geomagnetic { get; set; }  
    }
}
