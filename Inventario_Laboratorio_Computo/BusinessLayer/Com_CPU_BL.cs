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
    public class Com_CPU_BL
    {
        /*Insertar*/
        public Boolean AgregandoCPUModelo(ModeloCPU newMCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO ModeloCPU(modeloCPU,f_marca)" +
                "VALUES (@modeloCPU,@f_marca);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@modeloCPU",SqlDbType.VarChar,50),
                    new SqlParameter("@f_marca",SqlDbType.Int),
                };
                evaluacion[0].Value = newMCPU.modeloCPU;
                evaluacion[1].Value = newMCPU.F_Marca;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoCPUTipo(Tipo_CPU newTCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Tipo_CPU(Tipo,Familia,Velocidad,Extra,idModelocpu)" +
                "VALUES (@Tipo,@Familia,@Velocidad,@Extra,@idModelocpu);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Tipo",SqlDbType.VarChar,40),
                    new SqlParameter("@Familia",SqlDbType.VarChar,30),
                    new SqlParameter("@Velocidad",SqlDbType.VarChar,50),
                    new SqlParameter("@Extra",SqlDbType.VarChar,30),
                    new SqlParameter("@idModelocpu",SqlDbType.Int),
                };
                evaluacion[0].Value = newTCPU.Tipo;
                evaluacion[1].Value = newTCPU.Familia;
                evaluacion[2].Value = newTCPU.Velocidad;
                evaluacion[3].Value = newTCPU.Extra;
                evaluacion[4].Value = newTCPU.F_Modelocpu;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoCPUGenerico(CPU_Generico newGCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO CPU_Generico(f_Tcpu,f_MarcaCpu,Modelo,Descripcion,f_tipoRam,id_Gabinete,f_imagenes)" +
                "VALUES (@f_Tcpu,@f_MarcaCpu,@Modelo,@Descripcion,@f_tipoRam,@id_Gabinete,@f_imagenes);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@f_Tcpu",SqlDbType.Int),
                    new SqlParameter("@f_MarcaCpu",SqlDbType.Int),
                    new SqlParameter("@Modelo",SqlDbType.VarChar,20),
                    new SqlParameter("@Descripcion",SqlDbType.VarChar,40),
                    new SqlParameter("@f_tipoRam",SqlDbType.Int),
                    new SqlParameter("@id_Gabinete",SqlDbType.Int),
                    new SqlParameter("@f_imagenes",SqlDbType.Int),
                };
                evaluacion[0].Value = newGCPU.F_Tcpu;
                evaluacion[1].Value = newGCPU.F_Marca;
                evaluacion[2].Value = newGCPU.Modelo;
                evaluacion[3].Value = newGCPU.Descripcion;
                evaluacion[4].Value = newGCPU.F_TipoRam;
                evaluacion[5].Value = newGCPU.F_Gabinete;
                evaluacion[6].Value = newGCPU.F_Imagenes;

                respuesta = true;
            }

            return respuesta;
        }
        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarCPUCompleto(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT tcpu.Tipo,tcpu.Familia,tcpu.Velocidad,mcpu.modeloCPU,gcpu.Modelo,ma.Marca,gcpu.Descripcion,icpu.urlimage_one" +
                    " FROM CPU_Generico as gcpu" +
                    " INNER JOIN Tipo_CPU as tcpu ON gcpu.f_Tcpu = tcpu.id_Tcpu" +
                    " INNER JOIN ModeloCPU as mcpu ON tcpu.idModelocpu = mcpu.id_modcpu" +
                    " INNER JOIN Marca as ma ON mcpu.f_marca = ma.Id_Marca" +
                    " INNER JOIN Imagenes_CPU as icpu ON gcpu.f_imagenes = icpu.Id_Image";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarCPUModelo(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM ModeloCPU";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarCPUTipo(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Tipo_CPU";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarCPUGenerico(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * CPU_Generico";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarCPUModelo(ModeloCPU newMCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE ModeloCPU SET modeloCPU=@modeloCPU,f_marca=@f_marca" +
                              " where id_modcpu = @id_modcpu;";

                evaluacion = new SqlParameter[]
                {
                     new SqlParameter("@id_modcpu",SqlDbType.Int),
                    new SqlParameter("@modeloCPU",SqlDbType.VarChar,50),
                    new SqlParameter("@f_marca",SqlDbType.Int),
                };
                evaluacion[0].Value = newMCPU.Id;
                evaluacion[1].Value = newMCPU.modeloCPU;
                evaluacion[2].Value = newMCPU.F_Marca;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarCPUTipo(Tipo_CPU newTCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Tipo_CPU SET Tipo=@Tipo,Familia=@Familia,Velocidad=@Velocidad,Extra=@Extra,idModelocpu=@idModelocpu" +
                              " where id_Tcpu = @id_Tcpu;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_Tcpu",SqlDbType.Int),
                    new SqlParameter("@Tipo",SqlDbType.VarChar,40),
                    new SqlParameter("@Familia",SqlDbType.VarChar,30),
                    new SqlParameter("@Velocidad",SqlDbType.VarChar,50),
                    new SqlParameter("@Extra",SqlDbType.VarChar,30),
                    new SqlParameter("@idModelocpu",SqlDbType.Int),
                };
                evaluacion[0].Value = newTCPU.Id;
                evaluacion[1].Value = newTCPU.Tipo;
                evaluacion[2].Value = newTCPU.Familia;
                evaluacion[3].Value = newTCPU.Velocidad;
                evaluacion[4].Value = newTCPU.Extra;
                evaluacion[5].Value = newTCPU.F_Modelocpu;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarCPUGenerico(CPU_Generico newGCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE CPU_Generico SET f_Tcpu=@f_Tcpu,f_MarcaCpu=@f_MarcaCpu,Modelo=@Modelo,Descripcion=@Descripcion,f_tipoRam=@f_tipoRam,id_Gabinete=@id_Gabinete,f_imagenes=@f_imagenes" +
                              " where id_CPU = @id_CPU;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_Tcpu",SqlDbType.Int),
                    new SqlParameter("@Tipo",SqlDbType.VarChar,40),
                    new SqlParameter("@Familia",SqlDbType.VarChar,30),
                    new SqlParameter("@Velocidad",SqlDbType.VarChar,50),
                    new SqlParameter("@Extra",SqlDbType.VarChar,30),
                    new SqlParameter("@idModelocpu",SqlDbType.Int),
                };
                evaluacion[0].Value = newGCPU.id;
                evaluacion[1].Value = newGCPU.F_Tcpu;
                evaluacion[2].Value = newGCPU.F_Marca;
                evaluacion[3].Value = newGCPU.Modelo;
                evaluacion[4].Value = newGCPU.Descripcion;
                evaluacion[5].Value = newGCPU.F_TipoRam;
                evaluacion[6].Value = newGCPU.F_Gabinete;
                evaluacion[7].Value = newGCPU.F_Imagenes;


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
        public Boolean DropCPUModelo(ModeloCPU dropMCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM ModeloCPU where id_modcpu = @id_modcpu;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_modcpuo",SqlDbType.Int),
                };
                evaluacion[0].Value = dropMCPU.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropCPUTipo(Tipo_CPU dropTCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Tipo_CPUc where id_Tcpu = @id_Tcpu;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_Tcpu",SqlDbType.Int),
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
        public Boolean DropCPUGenerico(CPU_Generico dropTCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM CPU_Generico where id_CPU = @id_CPU;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@id_CPU",SqlDbType.Int),
                };
                evaluacion[0].Value = dropTCPU.id;

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
