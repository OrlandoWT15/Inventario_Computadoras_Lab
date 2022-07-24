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
    public class Com_Perifericos_BL
    {
        /*Insertar*/
        public Boolean AgregandoMonitor(Monitor newMoni, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO monitor(f_marcam,conectores,tamano)" +
                "VALUES (@f_marcam,@conectores,@tamano);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@f_marcam",SqlDbType.Int),
                    new SqlParameter("@conectores",SqlDbType.VarChar,64),
                    new SqlParameter("@tamano",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newMoni.F_marcam;
                evaluacion[1].Value = newMoni.Conectores;
                evaluacion[2].Value = newMoni.Tamanio;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoTeclado(Teclado newTecl, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO teclado(f_marcat,conector)" +
                "VALUES (@f_marcat,@conector);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@f_marcat",SqlDbType.Int),
                    new SqlParameter("@conector",SqlDbType.VarChar,5),
                };
                evaluacion[0].Value = newTecl.F_marcat;
                evaluacion[1].Value = newTecl.Conector;


                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoMouse(Mouse newMouse, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO mouse(f_marcamouse,conector)" +
                "VALUES (@f_marcamouse,@conector);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@f_marcamouse",SqlDbType.Int),
                    new SqlParameter("@conector",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newMouse.F_marcamouse;
                evaluacion[1].Value = newMouse.conector;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarMonitor(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM monitor";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarTeclado(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM teclado";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarMouse(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * mouse";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarMonitor(Monitor newMoni, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE monitor SET f_marcam=@f_marcam, conectores=@conectores, tamano=@tamano" +
                              " where id_monitor = @id_monitor;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_monitor",SqlDbType.Int),
                    new SqlParameter("@f_marcam",SqlDbType.Int),
                    new SqlParameter("@conectores",SqlDbType.VarChar,64),
                    new SqlParameter("@tamano",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newMoni.Id;
                evaluacion[1].Value = newMoni.F_marcam;
                evaluacion[2].Value = newMoni.Conectores;
                evaluacion[3].Value = newMoni.Tamanio;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarTeclado(Teclado newTecl, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE teclado SET f_marcat=@f_marcat,conector=@conector" +
                              " where id_teclado = @id_teclado;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_teclado",SqlDbType.Int),
                    new SqlParameter("@f_marcat",SqlDbType.Int),
                    new SqlParameter("@conector",SqlDbType.VarChar,5),
                };
                evaluacion[0].Value = newTecl.Id;
                evaluacion[1].Value = newTecl.F_marcat;
                evaluacion[2].Value = newTecl.Conector;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarMouse(Mouse newMouse, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE mouse SET f_marcamouse=@f_marcamouse,conector=@conector" +
                              " where id_mouse = @id_mouse;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_mouse",SqlDbType.Int),
                    new SqlParameter("@f_marcamouse",SqlDbType.Int),
                    new SqlParameter("@conector",SqlDbType.VarChar,64),
                };
                evaluacion[0].Value = newMouse.Id;
                evaluacion[1].Value = newMouse.F_marcamouse;
                evaluacion[2].Value = newMouse.conector;

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
        public Boolean DropMonitor(Monitor dropMoni, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM monitor where id_monitor = @id_monitor;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_monitor",SqlDbType.Int),
                };
                evaluacion[0].Value = dropMoni.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropTeclado(Teclado dropTCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM teclado where id_teclado = @id_teclado;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_teclado",SqlDbType.Int),
                };
                evaluacion[0].Value = dropTCPU.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropMouse(Mouse dropMouse, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM mouse where id_mouse = @id_mouse;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_mouse",SqlDbType.Int),
                };
                evaluacion[0].Value = dropMouse.Id;

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
