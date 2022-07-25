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
    public class Actualizacion_BL
    {

        /*Insertar*/
        public Boolean AgregandoActualizar(Actualizacion newAct, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO actualizacion(num_inv,num_serie,descripcion,fecha)" +
                "VALUES (@num_inv,@num_serie,@descripcion,@fecha);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@num_serie",SqlDbType.VarChar,11),
                    new SqlParameter("@descripcion",SqlDbType.VarChar,64),
                    new SqlParameter("@fecha",SqlDbType.Date),
                };
                evaluacion[0].Value = newAct.num_inv;
                evaluacion[1].Value = newAct.num_serie;
                evaluacion[2].Value = newAct.descripcion;
                evaluacion[3].Value = newAct.Fecha;

                respuesta = true;
            }

            return respuesta;
        }

        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarActualizar(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM actualizacion";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }

        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarActualizar(Actualizacion newAct, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE actualizacion SET num_inv=@num_inv,num_serie=@num_serie,descripcion=@descripcion,fecha=@fecha" +
                              " where id_act = @id_act;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_act",SqlDbType.Int),
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@num_serie",SqlDbType.VarChar,11),
                    new SqlParameter("@descripcion",SqlDbType.VarChar,64),
                    new SqlParameter("@fecha",SqlDbType.Date),
                };
                evaluacion[0].Value = newAct.Id;
                evaluacion[1].Value = newAct.num_inv;
                evaluacion[2].Value = newAct.num_serie;
                evaluacion[3].Value = newAct.descripcion;
                evaluacion[4].Value = newAct.Fecha;

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
        public Boolean DropActualizar(Actualizacion dropAct, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM actualizacion where id_act = @id_act;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_act",SqlDbType.Int),
                };
                evaluacion[0].Value = dropAct.Id;

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
