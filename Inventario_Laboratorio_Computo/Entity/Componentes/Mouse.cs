using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mouse
    {
        public int F_marcamouse { get; set; }
        public string conector { get; set; }

        public string Info()
        {
            return F_marcamouse + conector;
        }
    }
}
