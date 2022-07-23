using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Monitor
    {
        public int F_marcam { get; set; }
        public string  Conectores { get; set; }
        public string  Tamanio { get; set; }

        public string Info()
        {
            return F_marcam + Conectores + Tamanio;
        }
    }
}
