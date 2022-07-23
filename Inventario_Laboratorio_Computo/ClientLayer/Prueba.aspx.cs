using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using System.Configuration;

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
            Button1.Text = keyBL.PruebaConexion();
        }
    }
}