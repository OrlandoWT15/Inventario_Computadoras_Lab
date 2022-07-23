using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ComputadoraFinal
    {
        public string num_inv { get; set; }
        public string num_scpu { get; set; }
        public int F_cpug { get; set; }
        public string num_steclado { get; set; }
        public int F_tecladog { get; set; }
        public string num_smonitor { get; set; }
        public int F_mong { get; set; }
        public string num_smouse { get; set; }
        public int F_mouseg { get; set; }
        public string Estado { get; set; }

        public string Info()
        {
            return num_inv + num_scpu + F_cpug + num_steclado + F_tecladog + num_smonitor + F_mong + num_smouse + F_mouseg + Estado;
        }

    }
}
