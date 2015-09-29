using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.Model
{
    class XClient
    {
        internal Int32 Id { get; set; }
        internal String Name {get; set;}
        internal DateTime DateBirthday { get; set; }
        internal Boolean IsRheumaticSufferer { get; set; }
        internal Boolean IsHearhSufferer { get; set; }
        internal Boolean IsNeuroticSufferer { get; set; }
    }
}
