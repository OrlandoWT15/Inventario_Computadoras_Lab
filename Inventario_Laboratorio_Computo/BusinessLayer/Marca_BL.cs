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
    public class Marca_BL
    {
        /*Insertar*/
        public Boolean AgregandoMarca(Marca newMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Marca(Marca,Extra)" +
                "VALUES (@Marca,@Extra);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Marca",SqlDbType.VarChar,50),
                    new SqlParameter("@Extra",SqlDbType.VarChar,50),
                };
                evaluacion[0].Value = newMar.marca;
                evaluacion[1].Value = newMar.Extra;

                respuesta = true;
            }

            return respuesta;
        }

        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarMarca(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Marca";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarMarcaGlobal(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT Marca,Id_Marca FROM marca";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }

        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarMarca(Marca newMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Marca SET Marca=@Marca,Extra=@Extra" +
                              " where Id_Marca = @Id_Marca;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Id_Marca",SqlDbType.Int),
                    new SqlParameter("@Marca",SqlDbType.VarChar,50),
                    new SqlParameter("@Extra",SqlDbType.VarChar,50),
                };
                evaluacion[0].Value = newMar.Id;
                evaluacion[1].Value = newMar.marca;
                evaluacion[2].Value = newMar.Extra;

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
        public Boolean DropMarca(Marca dropMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Marca where Id_Marca = @Id_Marca;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@Id_Marca",SqlDbType.Int),
                };
                evaluacion[0].Value = dropMar.Id;

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
