using System;
using System.Collections.Generic;
using Attr = System.ComponentModel.DataAnnotations;

namespace Sinoptik.Model
{
    [Attr.Schema.Table("Exams")] 
   class XExam
    {
        [Attr.Key]
        public Int32 Id { get; set; }

        [Attr.Schema.ForeignKey("Client")]
        [Attr.Required]
        public Int32 ClientId { get; set; }
        public XClient Client { get; set; }

        [Attr.Schema.ForeignKey("Weather")]
        [Attr.Required]
        public Int32 WeatherId { get; set; }
        public XWeather Weather { get; set; }
       
        [Attr.Schema.ForeignKey("SubjParams")]
        public Int32? SubjParamsId { get; set; }
        public XSubjectivParameters SubjParams { get; set; }

        [Attr.Schema.ForeignKey("ObjParams")]
        public Int32? ObjParamsId { get; set; }
        public XObjectivParameters ObjParams { get; set; }        

        [Attr.Schema.ForeignKey("SANTest")]
        public Int32? SANTestId { get; set; }
        public XSANTest SANTest { get; set; }


        public XExam()
        {
            //Weather = new XWeather();
            //SubjParams = new XSubjectivParameters();
            //ObjParams = new XObjectivParameters();
            //SANTest = new XSANTest();
        }
    }
}
