using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Cinturon : Asiento
    {
        public Cinturon()
        {
            NumSerie = String.Empty;
            Metraje = 0;
        }
        public string NumSerie { get; set; }

        public int Metraje { get; set; }
    }
}
