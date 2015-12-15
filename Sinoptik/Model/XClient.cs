using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Attr = System.ComponentModel.DataAnnotations;



namespace Sinoptik.Model
{

    [Attr.Schema.Table("Clients")]
    class XClient
    {   
        [Attr.Key]
        [Attr.Required]
        [Attr.Schema.Column("Id", TypeName = "int")]
        public Int32 Id { get; set; }

        [Attr.Schema.Column("Name", TypeName = "nvarchar")]
        public String Name {get; set;}

        [Attr.Schema.Column("DateBirthday", TypeName = "datetime2")]
        public DateTime DateBirthday { get; set; }

        [Attr.Schema.Column("IsRheumaticSufferer", TypeName = "bit")]
        public Boolean IsRheumaticSufferer { get; set; }

        [Attr.Schema.Column("IsHearhSufferer", TypeName = "bit")]
        public Boolean IsHearhSufferer { get; set; }

        [Attr.Schema.Column("IsNeuroticSufferer", TypeName = "bit")]
        public Boolean IsNeuroticSufferer { get; set; }

        
        public ICollection<XExam> ExamsCollection { get; set; }

        public XClient()
        {
            ExamsCollection = new Collection<XExam>();
            
        }
    }
}
