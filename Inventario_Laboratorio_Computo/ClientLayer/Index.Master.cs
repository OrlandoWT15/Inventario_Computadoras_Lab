using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Rutas
using System.Configuration;
using BusinessLayer;
using Entity;

namespace ClientLayer
{
    public partial class Index : System.Web.UI.MasterPage
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
    }
}