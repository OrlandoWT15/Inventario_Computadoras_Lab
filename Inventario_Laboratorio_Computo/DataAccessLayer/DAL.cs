using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;


namespace DataAccessLayer
{
    public class DAL
    {
        private string Conexion { get; set; }

        public DAL(string cadenaCn)
        {
            Conexion = cadenaCn;
        }
        public SqlConnection AbrirPuerta(ref string Mensaje)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Conexion;
            try
            {
                conexion.Open();
                Mensaje = "Puerta Abierta";
            }
            catch (Exception h)
            {
                Mensaje = "ERROR:" + h.Message;
                conexion = null;
            }
            return conexion;
        }









    }
}
