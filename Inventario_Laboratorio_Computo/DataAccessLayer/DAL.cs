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

        /* Para la cadena de Conexión */
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

        /*Procedimiento para la seguridad de la base de datos*/
        public Boolean BaseSegura(string Sqlinstruc, SqlConnection prAb, ref string mensaje, SqlParameter[] evaluacion)
        {
            Boolean resp = false;
            SqlCommand carrito = null;

            if (prAb != null)
            {
                mensaje = "";
                using (carrito = new SqlCommand())
                {
                    carrito.CommandText = Sqlinstruc;
                    carrito.Connection = prAb;
                    foreach (SqlParameter x in evaluacion)
                    {
                        carrito.Parameters.Add(x);
                    }
                    try
                    {
                        carrito.ExecuteNonQuery();
                        mensaje = "Instrucción Correcta";
                        resp = true;
                    }
                    catch (Exception h)
                    {
                        mensaje = "Error : " + h.Message + " !";
                        resp = false;
                    }
                }
                prAb.Close();
                prAb.Dispose();
            }
            else
            {
                mensaje = "Error de Conexión";
            }
            return resp;
        }

        /*Recuperación de la información al macenada en un data set y normalmente se usa para un grid view*/
        public DataSet DBLectura(string Sqlinstruc, SqlConnection prAb, ref string m)
        {
            SqlCommand carrito = null;
            DataSet cajaGrande = null;
            SqlDataAdapter trailer = null;


            if (prAb == null)
            {
                cajaGrande = null;
            }
            else
            {
                using (carrito = new SqlCommand(Sqlinstruc, prAb))
                {
                    using (trailer = new SqlDataAdapter())
                    {
                        cajaGrande = new DataSet();
                        trailer.SelectCommand = carrito;
                        try
                        {
                            trailer.Fill(cajaGrande);
                            m = "Instrucción Correcta";
                        }
                        catch (Exception h)
                        {
                            m = "Error:" + h.Message;
                            cajaGrande = null;
                        }
                    }
                }
                prAb.Close();
                prAb.Dispose();
            }
            return cajaGrande;
        }
        /*Recuperación de la información al macenada en un data Reader y normal mente se usa para una listbox*/
        public SqlDataReader DBLecturaR(string Sqlinstruc, SqlConnection prAb, ref string m)
        {
            SqlCommand carrito = null;
            SqlDataReader caja;
            if (prAb == null)
            {
                caja = null;
            }
            else
            {
                using (carrito = new SqlCommand(Sqlinstruc, prAb))
                {
                    try
                    {
                        caja = carrito.ExecuteReader();
                        m = "Instrucción Correcta";
                    }
                    catch (Exception h)
                    {
                        m = "Error:" + h.Message;
                        caja = null;
                    }
                }
            }
            return caja;
        }








    }
}
