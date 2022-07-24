using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CantDisc
    {
        public int id { get; set; }
        public string num_inv { get; set; }
        public int F_Dico { get; set; }

        public string Info()
        {
            return num_inv + F_Dico;
        }
    }
}
