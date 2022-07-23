using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Actualizacion
    {
        public string num_inv { get; set; }
        public string num_serie { get; set; }
        public string descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public string Info()
        {
            return num_inv + num_serie + descripcion + Fecha;
        }
    }
}
