using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Teclado
    {
        public int Id { get; set; }
        public int F_marcat { get; set; }
        public string Conector { get; set; }
        public string Info()
        {
            return F_marcat + Conector;
        }
    }
}
