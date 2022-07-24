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
    public class BL
    {
        private DAL keyDAL = null;
        //Business layer de componentes de una computadora
        private Com_DiscoDuro_BL key_DDBL = new Com_DiscoDuro_BL();
        private Com_RAM_BL key_RBL = new Com_RAM_BL();

        public BL(string cadenaCn)
        {
            keyDAL = new DAL(cadenaCn);
        }

        /*Prueba de conexion*/
        public string PruebaConexion()
        {
            string salida = "";
            keyDAL.EstadoCn(ref salida);
            return salida;
        }
        /************************************************************/
        /*                   D I S C O   D U R O                   */
        public Boolean AgregarDiscoDuro(DiscoDuro newDD, ref string estado,ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando="";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.AgregandoDiscoDuro(newDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando,keyDAL.EstadoCn(ref estado),ref salida,parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoDiscoduro(ref string estado,ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_DDBL.MostrarDiscoDuro(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarDiscoDuro(DiscoDuro newDD, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.ModificarDiscoDuro(newDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarDiscoduro(DiscoDuro dropDD, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.DropDiscoDuro(dropDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        /*          D I S C O   D U R O && C O M P F I N A L         */
        public Boolean AgregarCantDiscoDuro(CantDisc newCDD, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.AgregandoCantDiscoDuro(newCDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoCantDiscoduro(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_DDBL.MostrarCantDiscoDuro(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarCantDiscoDuro(CantDisc newCDD, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.ModificarCantDiscoDuro(newCDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarCantDiscoduro(CantDisc dropCDD, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_DDBL.DropCantDiscoDuro(dropCDD, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        /*                   A D I C I O N A L                  */
        public DataTable InfoDiscoduroCompleto(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_DDBL.MostrarDiscoDuroCompleto(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        /************************************************************/
        /*#########################################################*/

        /************************************************************/
        /*                   R A M                                 */
        public Boolean AgregarRAM(RAM newRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.AgregandoRam(newRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoRAM(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_RBL.MostrarRAM(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarRAM(RAM newRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.ModificarRAM(newRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarRAM(RAM dropRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.DropRAM(dropRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        /************************************************************/
        /*                     T I P O   R A M                     */
        public Boolean AgregarTipoRAM(TipoRAM newTRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.AgregandoTipoRam(newTRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoTipoRAM(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_RBL.MostrarTipoRAM(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarTipoRAM(TipoRAM newTRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.ModificarTipoRAM(newTRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarTipoRAM(TipoRAM dropTRAM, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_RBL.DropTipoRAM(dropTRAM, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        /*                   A D I C I O N A L                  */
        public DataTable InfoRAMCompleto(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_RBL.MostrarRAMCompleto(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        /************************************************************/
        /*#########################################################*/
    }
}
