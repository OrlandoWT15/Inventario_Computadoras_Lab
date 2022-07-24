using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RAM
    {
        public int Id { get; set; }
        public Int16 Capacidad { get; set; }
        public string Velocidad { get; set; }
        public int F_TipoR { get; set; }

        public string Info()
        {
            return Capacidad + Velocidad + F_TipoR;
        }
    }
}
