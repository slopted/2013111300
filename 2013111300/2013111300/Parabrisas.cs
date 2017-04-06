using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Parabrisas
    {
        public string NumSerie { get; set; }

        public Parabrisas(String pnumSerie)
        {
            NumSerie = pnumSerie;
        }
        public Parabrisas()
        {
            NumSerie = string.Empty;
        }
    }
}
