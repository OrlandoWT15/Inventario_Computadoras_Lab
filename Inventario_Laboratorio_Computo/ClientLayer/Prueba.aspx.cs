using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;
using System.Data;
using Entity;

namespace ClientLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private BL keyBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                keyBL = new BL(ConfigurationManager.ConnectionStrings["cnlocal"].ConnectionString);
                Session["keyBL"] = keyBL;
            }
            else
            {
                keyBL = (BL)Session["keyBL"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mensaje = "", estado = "";
            /*Insertar*/
            //keyBL.AgregarDiscoDuro(new DiscoDuro()
            //{
            //    TipoDisco = "M.2",
            //    Conector = "PCI EXPRESS 3.0",
            //    Capacidad = "500GB",
            //    F_MarcaDisco = 30,
            //    Extra = "0"
            //}, ref estado, ref mensaje);
            //Button1.Text = mensaje;
            /*Insertar*/

            /*Mostrar*/
            //DataTable infodd = null;
            //infodd = keyBL.InfoDiscoduro(ref estado, ref mensaje);
            //if (infodd != null)
            //{
            //    Button1.Text = mensaje;
            //}
            /*Mostrar*/

            /*Actualizar*/
            //keyBL.ActualizarDiscoDuro(new DiscoDuro()
            //{
            //    id = 8,
            //    TipoDisco = "M.2",
            //    Conector = "PCI EXPRESS 3.0",
            //    Capacidad = "1T",
            //    F_MarcaDisco = 30,
            //    Extra = "0"
            //}, ref estado, ref mensaje);
            //Button1.Text = mensaje;
            /*Actualizar*/

            /*Eliminar*/
            //keyBL.EliminarDiscoduro(new DiscoDuro()
            //{
            //    id = 8,
            //}, ref estado, ref mensaje);
            //Button1.Text = mensaje;
            /*Eliminar*/


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mensaje = "", estado = "";
            /*Insertar*/
            //keyBL.AgregarRAM(new RAM()
            //{
            //    Capacidad = 16,
            //    Velocidad = "2500",
            //    F_TipoR = 8,
            //}, ref estado, ref mensaje);
            //Button2.Text = mensaje;
            /*Insertar*/

            /*Mostrar*/
            //DataTable infodd = null;
            //infodd = keyBL.InfoRAMCompleto(ref estado, ref mensaje);
            //if (infodd != null)
            //{
            //    Button2.Text = mensaje;
            //}
            /*Mostrar*/

            /*Actualizar*/
            //keyBL.ActualizarRAM(new RAM()
            //{
            //    Id = 7,
            //    Capacidad = 16,
            //    Velocidad = "3600",
            //    F_TipoR = 8
            //}, ref estado, ref mensaje);
            //Button2.Text = mensaje;
            /*Actualizar*/

            /*Eliminar*/
            //keyBL.EliminarRAM(new RAM()
            //{
            //    Id = 7,
            //}, ref estado, ref mensaje);
            //Button2.Text = mensaje;
            /*Eliminar*/
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string mensaje = "", estado = "";
            /*Insertar*/
            //keyBL.AgregarCPUModelo(new ModeloCPU()
            //{
            //    modeloCPU = "Ryzen 7",
            //    F_Marca = 24
            //}, ref estado, ref mensaje);
            //Button3.Text = mensaje;
            /*Insertar*/

            /*Mostrar*/
            //DataTable infodd = null;
            //infodd = keyBL.InfoCPUGenericoCompleto(ref estado, ref mensaje);
            //if (infodd != null)
            //{
            //    Button3.Text = mensaje+" Muestra correcta";
            //}
            /*Mostrar*/

            /*Actualizar*/
            //keyBL.ActualizarCPUTipo(new Tipo_CPU()
            //{
            //    Id = 15,
            //    Tipo = "Ryzen 5 5600G",
            //    Familia = "AMD Ryzen™ Processors",
            //    Velocidad = "3GHz",
            //    Extra = "",
            //    F_Modelocpu = 13
            //}, ref estado, ref mensaje);
            //Button3.Text = mensaje;
            /*Actualizar*/

            /*Eliminar*/
            //keyBL.EliminarCPUGenerico(new CPU_Generico()
            //{
            //    id = 14,
            //}, ref estado, ref mensaje);
            //Button3.Text = mensaje;
            /*Eliminar*/
        }
    }
}