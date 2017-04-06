using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Propietario :clsAbsCarro
    {
        public override string DNI { get; set; }

        public override string Nombre { get; set; }

        public override string Apellidos { get; set; }

        public override string LicenciaConducir { get; set; }
    }
}
