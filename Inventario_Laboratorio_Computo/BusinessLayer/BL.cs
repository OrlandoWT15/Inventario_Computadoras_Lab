﻿using System;
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
        private Com_CPU_BL key_CPUBL = new Com_CPU_BL();
        private Com_Perifericos_BL key_PBL = new Com_Perifericos_BL();
        private Com_Gabinete_BL key_GBL = new Com_Gabinete_BL();

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

        /************************************************************/
        /*                C P U   G E N E R I C O                  */
        public Boolean AgregarCPUGenerico(CPU_Generico newCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.AgregandoCPUGenerico(newCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoCPUGenerico(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CPUBL.MostrarCPUGenerico(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarCPUGenerico(CPU_Generico newCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.ModificarCPUGenerico(newCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarCPUGenerico(CPU_Generico dropCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.DropCPUGenerico(dropCPU, ref parametro, ref comando))
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
        /*                     T I P O   C P U                     */
        public Boolean AgregarCPUTipo(Tipo_CPU newTCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.AgregandoCPUTipo(newTCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoCPUTipo(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CPUBL.MostrarCPUTipo(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarCPUTipo(Tipo_CPU newTCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.ModificarCPUTipo(newTCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarCPUTipo(Tipo_CPU dropTCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.DropCPUTipo(dropTCPU, ref parametro, ref comando))
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
        /*                     M O D E L O   C P U                 */
        public Boolean AgregarCPUModelo(ModeloCPU newMCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.AgregandoCPUModelo(newMCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoCPUModelo(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CPUBL.MostrarCPUModelo(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarCPUModelo(ModeloCPU newMCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.ModificarCPUModelo(newMCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarCPUModelo(ModeloCPU dropMCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CPUBL.DropCPUModelo(dropMCPU, ref parametro, ref comando))
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
        public DataTable InfoCPUGenericoCompleto(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CPUBL.MostrarCPUCompleto(ref instruccion))
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
        /*                     M O N I T O R                       */
        public Boolean AgregarMonitor(Monitor newMoni, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.AgregandoMonitor(newMoni, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoMonitor(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_PBL.MostrarMonitor(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarMonitor(Monitor newMoni, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.ModificarMonitor(newMoni, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarMonitor(Monitor dropMoni, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.DropMonitor(dropMoni, ref parametro, ref comando))
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
        /*                     T E C L A D O                       */
        public Boolean AgregarTeclado(Teclado newTecl, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.AgregandoTeclado(newTecl, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoTeclado(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_PBL.MostrarTeclado(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarTeclado(Teclado newTecl, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.ModificarTeclado(newTecl, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarTeclado(Teclado dropTecl, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.DropTeclado(dropTecl, ref parametro, ref comando))
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
        /*                        M O U S E                       */
        public Boolean AgregarMouse(Mouse newMouse, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.AgregandoMouse(newMouse, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoMouse(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_PBL.MostrarMouse(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarMouse(Mouse newMouse, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.ModificarMouse(newMouse, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarMouse(Mouse dropMouse, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_PBL.DropMouse(dropMouse, ref parametro, ref comando))
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

        /************************************************************/
        /*#########################################################*/

        /************************************************************/
        /*                     G A B I N E T E                     */
        public Boolean AgregarGabinete(Gabinete newGabi, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_GBL.AgregandoGabinete(newGabi, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoGabinete(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_GBL.MostrarGabinete(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarGabinete(Gabinete newGabi, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_GBL.ModificarGabinete(newGabi, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarGabinete(Gabinete dropGabi, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_GBL.DropGabinete(dropGabi, ref parametro, ref comando))
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

        /************************************************************/
        /*#########################################################*/

        /************************************************************/
        /*          I M A G E N E S   C P U                     */


    }
}
