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
    public class ComputadoraFinal_BL
    {
        /*Insertar*/
        public Boolean AgregandoCompFinal(ComputadoraFinal newComF, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO computadorafinal(num_inv,num_scpu,id_cpug,num_steclado,id_tecladog,num_smonitor,id_mong,num_smouse,id_mousg,estado)" +
                " VALUES(@num_inv,@num_scpu,@id_cpug,@num_steclado,@id_tecladog,@num_smonitor,@id_mong,@num_smouse,@id_mousg,@estado);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@num_scpu",SqlDbType.VarChar,11),
                    new SqlParameter("@id_cpug",SqlDbType.Int),
                    new SqlParameter("@num_steclado",SqlDbType.VarChar,11),
                    new SqlParameter("@id_tecladog",SqlDbType.Int),
                    new SqlParameter("@num_smonitor",SqlDbType.VarChar,11),
                    new SqlParameter("@id_mong",SqlDbType.Int),
                    new SqlParameter("@num_smouse",SqlDbType.VarChar,11),
                    new SqlParameter("@id_mousg",SqlDbType.Int),
                    new SqlParameter("@estado",SqlDbType.VarChar,64)
                };
                evaluacion[0].Value = newComF.num_inv;
                evaluacion[1].Value = newComF.num_scpu;
                evaluacion[2].Value = newComF.F_cpug;
                evaluacion[3].Value = newComF.num_steclado;
                evaluacion[4].Value = newComF.F_tecladog;
                evaluacion[5].Value = newComF.num_smonitor;
                evaluacion[6].Value = newComF.F_mong;
                evaluacion[7].Value = newComF.num_smouse;
                evaluacion[8].Value = newComF.F_mouseg;
                evaluacion[9].Value = newComF.Estado;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarCompFinal(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM computadorafinal";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarComponenCompFinal(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT cf.num_inv,cf.num_scpu,cpu.Modelo,cf.num_steclado,te.conector,cf.num_smonitor,mo.conectores,cf.num_smouse,mu.conector,cf.estado" +
                    " FROM computadorafinal as cf" +
                    " INNER JOIN CPU_Generico as cpu ON cf.id_cpug = cpu.id_CPU" +
                    " INNER JOIN teclado as te ON cf.id_tecladog = te.id_teclado" +
                    " INNER JOIN monitor as mo ON cf.id_mong = mo.id_monitor" +
                    " INNER JOIN mouse as mu ON cf.id_mousg = mu.id_mouse";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarCompFinal(ComputadoraFinal newComF, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE computadorafinal SET num_scpu=@num_scpu,id_cpug=@id_cpug,num_steclado=@num_steclado,id_tecladog=@id_tecladog,num_smonitor=@num_smonitor,id_mong=@id_mong,num_smouse=@num_smouse,id_mousg=@id_mousg,estado=@estado" +
                              " WHERE num_inv = @num_inv;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                    new SqlParameter("@num_scpu",SqlDbType.VarChar,11),
                    new SqlParameter("@id_cpug",SqlDbType.Int),
                    new SqlParameter("@num_steclado",SqlDbType.VarChar,11),
                    new SqlParameter("@id_tecladog",SqlDbType.Int),
                    new SqlParameter("@num_smonitor",SqlDbType.VarChar,11),
                    new SqlParameter("@id_mong",SqlDbType.Int),
                    new SqlParameter("@num_smouse",SqlDbType.VarChar,11),
                    new SqlParameter("@id_mousg",SqlDbType.Int),
                    new SqlParameter("@estado",SqlDbType.VarChar,64)
                };
                evaluacion[0].Value = newComF.num_inv;
                evaluacion[1].Value = newComF.num_scpu;
                evaluacion[2].Value = newComF.F_cpug;
                evaluacion[3].Value = newComF.num_steclado;
                evaluacion[4].Value = newComF.F_tecladog;
                evaluacion[5].Value = newComF.num_smonitor;
                evaluacion[6].Value = newComF.F_mong;
                evaluacion[7].Value = newComF.num_smouse;
                evaluacion[8].Value = newComF.F_mouseg;
                evaluacion[9].Value = newComF.Estado;

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
        public Boolean DropCompFinal(ComputadoraFinal dropComF, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM computadorafinal where num_inv = @num_inv;";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@num_inv",SqlDbType.VarChar,10),
                };
                evaluacion[0].Value = dropComF.num_inv;

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
