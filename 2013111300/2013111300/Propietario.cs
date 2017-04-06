using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    class Propietario
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir { get; set; }

        public Propietario(string pDni, string pNombre, string pApellidos, string pLicencia)
        {
            Dni = pDni;
            Nombres = pNombre;
            Apellidos = pApellidos;
            LicenciaConducir = pLicencia;
        }
        public Propietario()
        {
            Dni = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            LicenciaConducir = string.Empty;
        }

    }
}
