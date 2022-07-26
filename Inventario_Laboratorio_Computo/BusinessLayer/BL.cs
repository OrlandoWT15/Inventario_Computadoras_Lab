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
        private Com_CPU_BL key_CPUBL = new Com_CPU_BL();
        private Com_Perifericos_BL key_PBL = new Com_Perifericos_BL();
        private Com_Componente_BL key_COMBL = new Com_Componente_BL();
        //Business layer de Gabinete
        private Com_Gabinete_BL key_GBL = new Com_Gabinete_BL();
        //Business layer de Imagenes
        private Img_Imagenes_BL key_IBL = new Img_Imagenes_BL();
        //Business layer de Ubicacion
        private Ubi_Ubicacion_BL key_UBL = new Ubi_Ubicacion_BL();
        //Business layer de Actualizacion
        private Actualizacion_BL key_ACBL = new Actualizacion_BL();
        //Business layer de Marca
        private Marca_BL key_MBL = new Marca_BL();
        //Business layer de Computadora Final
        private ComputadoraFinal_BL key_CFBL = new ComputadoraFinal_BL();

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
        /*             I M A G E N E S   C P U                     */
        public Boolean AgregarImagenesCPU(Imagenes_CPU newImaCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.AgregandoImagenCPU(newImaCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoImagenesCPU(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_IBL.MostrarImagenCPU(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarImagenesCPU(Imagenes_CPU newImaCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.ModificarImagenCPU(newImaCPU, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarImagenesCPU(Imagenes_CPU dropImaCPU, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.DropImagenCPU(dropImaCPU, ref parametro, ref comando))
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
        /*         I M A G E N E S   C O M P U   F I N A L         */
        public Boolean AgregarImagenesCompuFinal(Imagenes_ComFinal newImaCompFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.AgregandoImagenCompFinal(newImaCompFinal, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoImagenesCompuFinal(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_IBL.MostrarImagenCompFinal(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarImagenesCompuFinal(Imagenes_ComFinal newImaCompFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.ModificarImagenCompFinal(newImaCompFinal, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarImagenesCompuFinal(Imagenes_ComFinal dropImaCompFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_IBL.DropImagenCompFinal(dropImaCompFinal, ref parametro, ref comando))
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
        /*               L A B O R A T O R I O                     */
        public Boolean AgregarLaboratorio(Laboratorio newLab, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.AgregandoLaboratorio(newLab, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoLaboratorio(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_UBL.MostrarLaboratorio(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarLaboratorio(Laboratorio newLab, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.ModificarLaboratorio(newLab, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarLaboratorio(Laboratorio dropLab, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.DropLaboratorio(dropLab, ref parametro, ref comando))
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
        /*                   U B I C A C I O N                     */
        public Boolean AgregarImagenesUbicacion(Ubicacion newImaUbicacion, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.AgregandoUbicacion(newImaUbicacion, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoImagenesUbicacion(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_UBL.MostrarUbicacion(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarImagenesUbicacion(Ubicacion newImaUbicacion, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.ModificarUbicacion(newImaUbicacion, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarImagenesUbicacion(Ubicacion dropImaUbicacion, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_UBL.DropUbicacion(dropImaUbicacion, ref parametro, ref comando))
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
        /*                 A C T U A L I Z A C I O N               */
        public Boolean AgregarActualizacion(Actualizacion newAct, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_ACBL.AgregandoActualizar(newAct, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoActualizacion(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_ACBL.MostrarActualizar(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarActualizacion(Actualizacion newAct, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_ACBL.ModificarActualizar(newAct, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarActualizacion(Actualizacion dropAct, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_ACBL.DropActualizar(dropAct, ref parametro, ref comando))
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
        /*                     M A R C A                           */
        public Boolean AgregarMarca(Marca newMarca, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_MBL.AgregandoMarca(newMarca, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoMarca(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_MBL.MostrarMarca(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarMarca(Marca newMarca, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_MBL.ModificarMarca(newMarca, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarMarca(Marca dropMarca, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_MBL.DropMarca(dropMarca, ref parametro, ref comando))
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
        public DataTable InfoMarcaGlobal(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_MBL.MostrarMarcaGlobal(ref instruccion))
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
        /*                     C O M P O N E N T E                 */
        public Boolean AgregarComponente(Componente newCom, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.AgregandoComponente(newCom, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoComponente(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_COMBL.MostrarComponente(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarComponente(Componente newCom, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.ModificarComponente(newCom, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarComponente(Componente dropCom, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.DropComponente(dropCom, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        /*          C O M P O N E N T E   &&   M A R C A          */
        public Boolean AgregarComponenteMarca(Componente_Marca newComMa, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.AgregandoComponenteMarca(newComMa, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoComponenteMarca(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_COMBL.MostrarComponenteMarca(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarComponenteMarca(Componente_Marca newComMa, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.ModificarComponenteMarca(newComMa, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarComponenteMarca(Componente_Marca dropComMa, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_COMBL.DropComponenteMarca(dropComMa, ref parametro, ref comando))
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
        public DataTable InfoComponenteMarcaTeclado(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_COMBL.MostrarComponenteMarcaTeclado(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public DataTable InfoComponenteMarcaMouse(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_COMBL.MostrarComponenteMarcaMouse(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public DataTable InfoComponenteMarcaMonitor(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_COMBL.MostrarComponenteMarcaMonitor(ref instruccion))
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
        /*                  C O M P U   F I N A L                  */
        public Boolean AgregarCompFinal(ComputadoraFinal newComFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CFBL.AgregandoCompFinal(newComFinal, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public DataTable InfoCompFinal(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CFBL.MostrarCompFinal(ref instruccion))
            {
                obtener = keyDAL.DBLectura(instruccion, keyDAL.EstadoCn(ref estado), ref salida);
                if (obtener != null)
                {
                    tabla = obtener.Tables[0];
                }
            }
            return tabla;
        }
        public Boolean ActualizarCompFinal(ComputadoraFinal newComFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CFBL.ModificarCompFinal(newComFinal, ref parametro, ref comando))
            {
                respuesta = keyDAL.BaseSegura(comando, keyDAL.EstadoCn(ref estado), ref salida, parametro);
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public Boolean EliminarCompFinal(ComputadoraFinal dropComFinal, ref string estado, ref string salida)
        {
            SqlParameter[] parametro = null;
            string comando = "";
            Boolean respuesta;

            estado = "";
            salida = "";

            if (key_CFBL.DropCompFinal(dropComFinal, ref parametro, ref comando))
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
        public DataTable InfoCompFinalCompleto(ref string estado, ref string salida)
        {
            string instruccion = "";
            DataSet obtener = null;
            DataTable tabla = null;

            if (key_CFBL.MostrarComponenCompFinal(ref instruccion))
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
