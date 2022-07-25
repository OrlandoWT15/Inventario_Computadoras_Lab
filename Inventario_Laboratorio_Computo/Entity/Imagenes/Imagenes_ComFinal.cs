using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Imagenes_ComFinal
    {
        public int Id { get; set; }
        public string urlimage_one { get; set; }
        public string urlimage_two { get; set; }
        public string urlimage_three { get; set; }
        public string F_ComputadoraFinal { get; set; }

        public string Info()
        {
            return urlimage_one + urlimage_two + urlimage_three + F_ComputadoraFinal;
        }
    }
}
