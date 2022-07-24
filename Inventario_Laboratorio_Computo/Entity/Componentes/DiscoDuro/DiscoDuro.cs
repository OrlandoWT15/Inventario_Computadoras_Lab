using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DiscoDuro
    {
        public int id { get; set; }
        public string TipoDisco { get; set; }
        public string Conector { get; set; }
        public string Capacidad { get; set; }
        public int F_MarcaDisco { get; set; }
        public string Extra { get; set; }

        public string Info()
        {
            return TipoDisco + Conector + Capacidad + F_MarcaDisco + Extra;
        }
    }
}
