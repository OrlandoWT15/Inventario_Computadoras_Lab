using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Marca
    {
        public string marca { get; set; }
        public string Extra { get; set; }
        public string Info()
        {
            return marca + Extra;
        }
    }
}
