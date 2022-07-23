using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tipo_CPU
    {
        public string Tipo { get; set; }
        public string Familia { get; set; }
        public string Velocidad { get; set; }
        public string Extra { get; set; }
        public string F_Modelocpu { get; set; }
        public string Info()
        {
            return Tipo + Familia + Velocidad + Extra + F_Modelocpu;
        }
    }
}
