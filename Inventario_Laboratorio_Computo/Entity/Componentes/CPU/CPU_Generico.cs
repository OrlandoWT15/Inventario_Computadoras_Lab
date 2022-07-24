using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CPU_Generico
    {
        public int id { get; set; }
        public int F_Tcpu { get; set; }
        public int F_Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int F_TipoRam { get; set; }
        public int F_Gabinete { get; set; }
        public int F_Imagenes { get; set; }

        public string Info()
        {
            return F_Tcpu + F_Marca + Modelo + Descripcion + F_TipoRam + F_Gabinete + F_Imagenes;
        }
    }
}
