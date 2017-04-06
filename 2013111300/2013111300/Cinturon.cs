using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Cinturon
    {

        public int Metraje { get; set; }
        public string NumSerie { get; set; }

        public Cinturon(string pNumSerie, int pMetraje)
        {
            NumSerie = pNumSerie;
            Metraje = pMetraje;
        }
        public Cinturon()
        {
            NumSerie = string.Empty;
            Metraje = 0;
        }    
    }
}
