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
    public class Com_RAM_BL
    {
        /*Insertar*/
        public Boolean AgregandoRam(RAM newRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO RAM(Capacidad,Velocidad,F_TipoR)" +
                "VALUES (@Capacidad,@Velocidad,@F_TipoR);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Capacidad",SqlDbType.SmallInt),
                    new SqlParameter("@Velocidad",SqlDbType.VarChar,15),
                    new SqlParameter("@F_TipoR",SqlDbType.Int),
                };
                evaluacion[0].Value = newRam.Capacidad;
                evaluacion[1].Value = newRam.Velocidad;
                evaluacion[2].Value = newRam.F_TipoR;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoTipoRam(TipoRAM newTRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO TipoRAM(Tipo,Extra)" +
                "VALUES (@Tipo,@Extra);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Tipo",SqlDbType.VarChar,20),
                    new SqlParameter("@Extra",SqlDbType.VarChar,30),
                };
                evaluacion[0].Value = newTRam.Tipo;
                evaluacion[1].Value = newTRam.Extra;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarRAMCompleto(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT  ra.Capacidad, ra.Velocidad,tr.Tipo,tr.Extra" +
                    " FROM RAM AS ra" +
                    " INNER JOIN TipoRAM as tr ON ra.F_TipoR = tr.id_tipoRam";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarRAM(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM RAM";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarTipoRAM(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM TipoRAM";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarRAM(RAM newRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE RAM SET Capacidad=@Capacidad,Velocidad=@Velocidad,F_TipoR=@F_TipoR" +
                              " where id_RAM = @id_RAM;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_RAM",SqlDbType.Int),
                    new SqlParameter("@Capacidad",SqlDbType.SmallInt),
                    new SqlParameter("@Velocidad",SqlDbType.VarChar,15),
                    new SqlParameter("@F_TipoR",SqlDbType.Int),
                };
                evaluacion[0].Value = newRam.Id;
                evaluacion[1].Value = newRam.Capacidad;
                evaluacion[2].Value = newRam.Velocidad;
                evaluacion[3].Value = newRam.F_TipoR;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarTipoRAM(TipoRAM newTRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE TipoRAM SET Tipo=@Tipo,Extra=@Extra" +
                              " where id_tipoRam = @id_tipoRam;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_tipoRam",SqlDbType.Int),
                    new SqlParameter("@Tipo",SqlDbType.VarChar,20),
                    new SqlParameter("@Extra",SqlDbType.VarChar,30),
                };
                evaluacion[0].Value = newTRam.Id;
                evaluacion[1].Value = newTRam.Tipo;
                evaluacion[2].Value = newTRam.Extra;

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
        public Boolean DropRAM(RAM dropRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM RAM where id_RAM = @id_RAM;";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_RAM",SqlDbType.Int),
                };
                evaluacion[0].Value = dropRam.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropTipoRAM(TipoRAM dropTRam, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM TipoRAM where id_tipoRam = @id_tipoRam;";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_tipoRam",SqlDbType.Int),
                };
                evaluacion[0].Value = dropTRam.Id;

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
