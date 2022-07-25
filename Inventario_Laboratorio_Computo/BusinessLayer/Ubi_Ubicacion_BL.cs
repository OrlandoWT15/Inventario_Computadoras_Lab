using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace BusinessLayer
{
    public class Ubi_Ubicacion_BL
    {
        /*Insertar*/
        public Boolean AgregandoUbicacion(Ubicacion newUbi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO ubicacion(num_inv,nombre_laboratorio)" +
                "VALUES (@num_inv,@nombre_laboratorio);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@nombre_laboratorio",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newUbi.num_inv;
                evaluacion[1].Value = newUbi.nombre_laboratorio;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoLaboratorio(Laboratorio newLab, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO laboratorio(nombre_laboratorio)" +
                "VALUES (@nombre_laboratorio);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@nombre_laboratorio",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newLab.Nombre_Laboratorio;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarUbicacion(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM ubicacion";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarLaboratorio(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM laboratorio";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarUbicacion(Ubicacion newUbi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE ubicacion SET num_inv=@num_inv,nombre_laboratorio=@nombre_laboratorio" +
                              " where num_inv = @num_inv;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@nombre_laboratorio",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newUbi.num_inv;
                evaluacion[1].Value = newUbi.nombre_laboratorio;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarLaboratorio(Laboratorio newLab, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE laboratorio SET nombre_laboratorio=@nombre_laboratorio" +
                              " where nombre_laboratorio = @nombre_laboratorio;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@nombre_laboratorio",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newLab.Nombre_Laboratorio;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        /*Actualizar*/

        /*Eliminacion*/
        public Boolean DropUbicacion(Ubicacion dropUbi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM ubicacion where where num_inv = @num_inv;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                };
                evaluacion[0].Value = dropUbi.num_inv;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropLaboratorio(Laboratorio dropLab, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM laboratorio where nombre_laboratorio = @nombre_laboratorio;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@nombre_laboratorio",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = dropLab.Nombre_Laboratorio;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        /*Eliminacion*/
    }
}
