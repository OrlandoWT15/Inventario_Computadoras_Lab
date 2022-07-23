using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ubicacion
    {
        public string num_inv { get; set; }
        public string nombre_laboratorio { get; set; }
        public string Info()
        {
            return num_inv + nombre_laboratorio;
        }
    }
}
