using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using Entity;

namespace BusinessLayer
{
    public class BL
    {
        private DAL keyDAL = null;

        public BL(string cadenaCn)
        {
            keyDAL = new DAL(cadenaCn);
        }

        /*Prueba de conexion*/
        public string PruebaConexion()
        {
            string salida = "";
            keyDAL.AbrirPuerta(ref salida);
            return salida;
        }
    }
}
