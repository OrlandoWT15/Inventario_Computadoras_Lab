using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace BusinessLayer
{
    public class Com_DiscoDuro_BL
    {

        /*Insertar*/
        public Boolean AgregandoDiscoDuro(DiscoDuro newDDuro, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO DiscoDuro(TipoDisco,conector,Capacidad,F_MarcaDisco,Extra)" +
                "VALUES (@TipoDisco,@conector,@Capacidad,@F_MarcaDisco,@Extra);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@TipoDisco",SqlDbType.VarChar,20),
                    new SqlParameter("@conector",SqlDbType.VarChar,10),
                    new SqlParameter("@Capacidad",SqlDbType.VarChar,12),
                    new SqlParameter("@F_MarcaDisco",SqlDbType.Int),
                    new SqlParameter("@Extra",SqlDbType.VarChar,25),
                };
                evaluacion[0].Value = newDDuro.TipoDisco;
                evaluacion[1].Value = newDDuro.Conector;
                evaluacion[2].Value = newDDuro.Capacidad;
                evaluacion[3].Value = newDDuro.F_MarcaDisco;
                evaluacion[4].Value = newDDuro.Extra;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoCantDiscoDuro(CantDisc newCDDuro, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO cantDisc(num_inv,id_Disco)" +
                "VALUES (@num_inv,@id_Disco);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@id_Disco",SqlDbType.Int),
                };
                evaluacion[0].Value = newCDDuro.num_inv;
                evaluacion[1].Value = newCDDuro.F_Dico;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarDiscoDuroCompleto(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT ca.num_inv,dd.TipoDisco,dd.conector,dd.Capacidad,ma.Marca,dd.Extra FROM  cantDisc as ca"+
                    " INNER JOIN DiscoDuro AS dd ON ca.id_Disco = dd.id_Disco"+
                    " INNER JOIN Marca AS ma ON dd.F_MarcaDisco = ma.Id_Marca";
                respuesta = true;
            }
            else
                respuesta = false;
            
            return respuesta;
        }
        public Boolean MostrarDiscoDuro(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM DiscoDuro";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarCantDiscoDuro(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM cantDisc";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarDiscoDuro(DiscoDuro newDDuro,ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE DiscoDuro SET TipoDisco = @TipoDisco,conector=@conector,Capacidad=@Capacidad,F_MarcaDisco=@F_MarcaDisco,Extra=@Extra" +
                              " where id_Disco = @id_Disco;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_Disco",SqlDbType.Int),
                    new SqlParameter("@TipoDisco",SqlDbType.VarChar,20),
                    new SqlParameter("@conector",SqlDbType.VarChar,10),
                    new SqlParameter("@Capacidad",SqlDbType.VarChar,12),
                    new SqlParameter("@F_MarcaDisco",SqlDbType.Int),
                    new SqlParameter("@Extra",SqlDbType.VarChar,25),
                };
                evaluacion[0].Value = newDDuro.id;
                evaluacion[1].Value = newDDuro.TipoDisco;
                evaluacion[2].Value = newDDuro.Conector;
                evaluacion[3].Value = newDDuro.Capacidad;
                evaluacion[4].Value = newDDuro.F_MarcaDisco;
                evaluacion[5].Value = newDDuro.Extra;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
           
            return respuesta;
        }
        public Boolean ModificarCantDiscoDuro(CantDisc newCDDuro, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE cantDisc SET num_inv=@num_inv,id_Disco=@id_Disco" +
                              " where id_cant = @id_cant;";

                evaluacion = new SqlParameter[]
                {
                   new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                   new SqlParameter("@id_Disco",SqlDbType.Int),
                };
                evaluacion[0].Value = newCDDuro.num_inv;
                evaluacion[1].Value = newCDDuro.F_Dico;

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
        public Boolean DropDiscoDuro(DiscoDuro dropDD, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM DiscoDuro where id_Disco = @id_Disco;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_Disco",SqlDbType.Int),
                };
                evaluacion[0].Value = dropDD.id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropCantDiscoDuro(CantDisc dropCDD, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM cantDisc where id_cant = @id_cant;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_cant",SqlDbType.Int),
                };
                evaluacion[0].Value = dropCDD.id;

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
