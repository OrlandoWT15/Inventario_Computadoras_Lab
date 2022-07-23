using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ModeloCPU
    {
        public string modeloCPU { get; set; }
        public int F_Marca { get; set; }

        public string Info()
        {
            return modeloCPU + F_Marca;
        }
    }
}
