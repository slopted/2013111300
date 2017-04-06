using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Llanta : clsAbsCarro
    {
        public Llanta()
        {
            NumSerie = String.Empty;
        }
        public override string NumSerie { get; set; }
    }
}
