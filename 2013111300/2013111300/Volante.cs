using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Volante
    {

        public string NumSerie { get; set; }

        public Volante(string pnumserie)
        {
            NumSerie = pnumserie;
        }
        public Volante()
        {
            NumSerie = string.Empty;
        }
    }
}
