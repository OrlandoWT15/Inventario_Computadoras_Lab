using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gabinete
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string TipoForma { get; set; }
        public int F_Marca { get; set; }
        public string Info()
        {
            return Modelo + TipoForma + F_Marca;
        }
    }
}
