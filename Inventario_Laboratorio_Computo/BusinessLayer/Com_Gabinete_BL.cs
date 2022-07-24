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
    public class Com_Gabinete_BL
    {
        /*Insertar*/
        public Boolean AgregandoGabinete(Gabinete newGabi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Gabinete(Modelo,TipoForma,F_Marca)" +
                "VALUES (@Modelo,@TipoForma,@F_Marca);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Modelo",SqlDbType.VarChar,10),
                    new SqlParameter("@TipoForma",SqlDbType.VarChar,30),
                    new SqlParameter("@F_Marca",SqlDbType.Int),
                };
                evaluacion[0].Value = newGabi.Modelo;
                evaluacion[1].Value = newGabi.TipoForma;
                evaluacion[2].Value = newGabi.F_Marca;

                respuesta = true;
            }

            return respuesta;
        }

        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarGabinete(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Gabinete";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }

        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarGabinete(Gabinete newGabi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Gabinete SET Modelo=@Modelo,TipoForma=@TipoForma,F_Marca=@F_Marca" +
                              " where id_Gabinete = @id_Gabinete;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_Gabinete",SqlDbType.Int),
                    new SqlParameter("@Modelo",SqlDbType.Int),
                    new SqlParameter("@TipoForma",SqlDbType.VarChar,64),
                    new SqlParameter("@F_Marca",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newGabi.Id;
                evaluacion[1].Value = newGabi.Modelo;
                evaluacion[2].Value = newGabi.TipoForma;
                evaluacion[3].Value = newGabi.F_Marca;

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
        public Boolean DropGabinete(Gabinete dropGabi, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Gabinete where id_Gabinete = @id_Gabinete;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_Gabinete",SqlDbType.Int),
                };
                evaluacion[0].Value = dropGabi.Id;

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
