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
    public class Img_Imagenes_BL
    {
        /*Insertar*/
        public Boolean AgregandoImagenCPU(Imagenes_CPU newImaCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Imagenes_CPU(urlimage_one)" +
                "VALUES (@urlimage_one);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@urlimage_one",SqlDbType.VarChar,255),
                };
                evaluacion[0].Value = newImaCPU.urlimage_one;

                respuesta = true;
            }

            return respuesta;
        }
        public Boolean AgregandoImagenCompFinal(Imagenes_ComFinal newImaCompFinal, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta = false;


            if (evaluacion == null)
            {
                instruccion = "INSERT INTO Imagenes_ComFinal(urlimage_one,urlimage_two,urlimage_three,f_ComputadoraFinal)" +
                "VALUES (@urlimage_one,@urlimage_two,@urlimage_three,@f_ComputadoraFinal);";
                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@urlimage_one",SqlDbType.VarChar,255),
                    new SqlParameter("@urlimage_two",SqlDbType.VarChar,255),
                    new SqlParameter("@urlimage_three",SqlDbType.VarChar,255),
                    new SqlParameter("@f_ComputadoraFinal",SqlDbType.Int),
                };
                evaluacion[0].Value = newImaCompFinal.urlimage_one;
                evaluacion[1].Value = newImaCompFinal.urlimage_two;
                evaluacion[2].Value = newImaCompFinal.urlimage_three;
                evaluacion[3].Value = newImaCompFinal.F_ComputadoraFinal;

                respuesta = true;
            }

            return respuesta;
        }

        /*Insertar*/

        /*Mostrar*/
        public Boolean MostrarImagenCPU(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Imagenes_CPU";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        public Boolean MostrarImagenCompFinal(ref string instruccion)
        {
            Boolean respuesta;
            if (instruccion == "")
            {
                instruccion = "SELECT * FROM Imagenes_ComFinal";
                respuesta = true;
            }
            else
                respuesta = false;

            return respuesta;
        }
        /*Mostrar*/

        /*Actualizar*/
        public Boolean ModificarImagenCPU(Imagenes_CPU newImaCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Imagenes_CPU SET urlimage_one=@urlimage_one" +
                              " where Id_Image = @Id_Image;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@Id_Image",SqlDbType.Int),
                    new SqlParameter("@urlimage_one",SqlDbType.VarChar,255),
                };
                evaluacion[0].Value = newImaCPU.Id;
                evaluacion[1].Value = newImaCPU.urlimage_one;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean ModificarImagenCompFinal(Imagenes_ComFinal newImaCompFinal, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "UPDATE Imagenes_ComFinal SET urlimage_one=@urlimage_one,urlimage_two=@urlimage_two,urlimage_three=@urlimage_three,f_ComputadoraFinal=@f_ComputadoraFinal" +
                              " where Id_Image = @Id_Image;";

                evaluacion = new SqlParameter[]
                {
                    new SqlParameter("@id_Gabinete",SqlDbType.Int),
                    new SqlParameter("@urlimage_one",SqlDbType.VarChar,255),
                    new SqlParameter("@urlimage_two",SqlDbType.VarChar,255),
                    new SqlParameter("@urlimage_three",SqlDbType.VarChar,255),
                    new SqlParameter("@f_ComputadoraFinal",SqlDbType.Int),
                };
                evaluacion[0].Value = newImaCompFinal.Id;
                evaluacion[1].Value = newImaCompFinal.urlimage_one;
                evaluacion[2].Value = newImaCompFinal.urlimage_one;
                evaluacion[3].Value = newImaCompFinal.urlimage_one;
                evaluacion[4].Value = newImaCompFinal.urlimage_one;

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
        public Boolean DropImagenCPU(Imagenes_CPU dropImaCPU, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Imagenes_CPU where Id_Image = @Id_Image;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@Id_Image",SqlDbType.Int),
                };
                evaluacion[0].Value = dropImaCPU.Id;

                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }
        public Boolean DropImagenCompFinal(Imagenes_ComFinal dropImaCompFinal, ref SqlParameter[] evaluacion, ref string instruccion)
        {
            Boolean respuesta;

            if (evaluacion == null)
            {
                instruccion = "DELETE FROM Imagenes_ComFinal where Id_Image = @Id_Image;";
                evaluacion = new SqlParameter[]
                {
                new SqlParameter("@Id_Image",SqlDbType.Int),
                };
                evaluacion[0].Value = dropImaCompFinal.Id;

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
