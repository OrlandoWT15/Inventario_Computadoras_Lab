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
    public class Com_Componente_BL
    {
        /*Insertar*/
        public Boolean AgregandoComponente(Componente newCom, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Componente(Nombre)" +
                "VALUES (@Nombre);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Nombre",SqlDbType.VarChar,16),
                };
                evaluacion[0].Value = newCom.Nombre;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoComponenteMarca(Componente_Marca newComMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO TipoRAM(f_componente,f_marca)" +
                "VALUES (@f_componente,@f_marca);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@f_componente",SqlDbType.Int),
                    new SqlParameter("@f_marca",SqlDbType.Int),
                };
                evaluacion[0].Value = newComMar.F_Componente;
                evaluacion[1].Value = newComMar.F_Marca;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarComponente(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Componente";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarca(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Componente_Marca";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaTeclado(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 3";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaMouse(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 2";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaMonitor(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 1";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaGabinete(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 5";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaDiscoduro(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 4";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenteMarcaModeloCPU(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cm.f_marca,ma.Marca" +
                    " FROM Componente_Marca as cm" +
                    " INNER JOIN Marca as ma ON cm.f_marca = ma.Id_Marca" +
                    " where cm.f_componente = 6";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarComponente(Componente newCom, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Componente SET Nombre=@Nombre" +
                              " where Id_Componente = @Id_Componente;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Id_Componente",SqlDbType.Int),
                    new SqlParameter("@Nombre",SqlDbType.VarChar,16),
                };
                evaluacion[0].Value = newCom.Id;
                evaluacion[1].Value = newCom.Nombre;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarComponenteMarca(Componente_Marca newComMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Componente_Marca SET f_componente=@f_componente,f_marca=@f_marca" +
                              " where IdComponenteMarca = @IdComponenteMarca;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@IdComponenteMarca",SqlDbType.Int),
                    new SqlParameter("@f_componente",SqlDbType.VarChar,20),
                    new SqlParameter("@f_marca",SqlDbType.VarChar,30),
                };
                evaluacion[0].Value = newComMar.Id;
                evaluacion[1].Value = newComMar.F_Componente;
                evaluacion[2].Value = newComMar.F_Marca;

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
        public Boolean DropComponente(Componente dropCom, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Componente where Id_Componente = @Id_Componente;";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Id_Componente",SqlDbType.Int),
                };
                evaluacion[0].Value = dropCom.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropComponenteMarca(Componente_Marca dropComMar, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Componente_Marca where IdComponenteMarca = @IdComponenteMarca;";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@IdComponenteMarca",SqlDbType.Int),
                };
                evaluacion[0].Value = dropComMar.Id;

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
