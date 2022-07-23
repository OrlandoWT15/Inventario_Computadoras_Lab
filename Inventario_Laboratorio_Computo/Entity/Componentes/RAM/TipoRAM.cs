using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TipoRAM
    {
        public string Tipo { get; set; }
        public string Extra { get; set; }

        public string Info()
        {
            return Tipo + Extra;
        }
    }
}
