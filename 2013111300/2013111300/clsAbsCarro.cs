using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013111300
{
    abstract public class clsAbsCarro
    {
        Llanta pllanta;
        Asiento pasiento;
        Cinturon pcinturon;
        Parabrisas pparabrisas;
        Volante pvolante;
        public string NumSerieMotor { get; set; }
        public string NumSerieChasis { get; set; }

        public clsAbsCarro(string pnumSerieMotor, string pnumSerieChasis)
        {
            NumSerieChasis = pnumSerieChasis;
            NumSerieMotor = pnumSerieMotor;
            pllanta = new Llanta();
            pasiento = new Asiento();
            pparabrisas = new Parabrisas();
            pvolante = new Volante();
                    }
        public clsAbsCarro()
        {

        }
    }
}
