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
    }
}