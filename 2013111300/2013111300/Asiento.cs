using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Asiento
    {
        Cinturon pcinturon;

        public String NumSerie { get; set; }

        public Asiento(String pnumSerie)
        {
            pcinturon = new Cinturon();
            NumSerie = pnumSerie;
        }
        public Asiento()
        {

        }
    }
}
