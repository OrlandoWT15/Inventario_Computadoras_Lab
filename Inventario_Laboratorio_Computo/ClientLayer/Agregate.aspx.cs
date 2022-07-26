using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Rutas
using System.Configuration;
using System.Data;
using BusinessLayer;
using Entity;

namespace ClientLayer
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        private BL keyBL = null;
        string postLink = "btn btn-circle btn-lg btn-dark";
        string trueLink = "btn btn-circle btn-lg btn-success";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                keyBL = new BL(ConfigurationManager.ConnectionStrings["cnlocal"].ConnectionString);
                Session["keyBL"] = keyBL;
                LinkButton1.CssClass = trueLink;
                //Datos
                Session["Marca"] = SelectMarca();
                Session["Conector"] = Conectores(1);
                Session["Conectores"] = Conectores(0);
                ddlmarca_teclado.DataSource = (DataTable)Session["Marca"];
                ddlmarca_teclado.DataBind();
                ddlmarca_mouse.DataSource = (DataTable)Session["Marca"];
                ddlmarca_mouse.DataBind();
                ddlmarca_monitor.DataSource = (DataTable)Session["Marca"];
                ddlmarca_monitor.DataBind();
                ddlcon_teclado.DataSource = (ListItemCollection)Session["Conector"];
                ddlcon_teclado.DataBind();
                ddlcon_mouse.DataSource = (ListItemCollection)Session["Conector"];
                ddlcon_mouse.DataBind();
                ddlcon_monitor.DataSource = (ListItemCollection)Session["Conectores"];
                ddlcon_monitor.DataBind();
            }
            else
            {
                keyBL = (BL)Session["keyBL"];
                //datos
                ddlmarca_teclado.DataSource = (DataTable)Session["Marca"];
                ddlmarca_teclado.DataBind();
                ddlmarca_mouse.DataSource = (DataTable)Session["Marca"];
                ddlmarca_mouse.DataBind();
                ddlmarca_monitor.DataSource = (DataTable)Session["Marca"];
                ddlmarca_monitor.DataBind();
                ddlcon_teclado.DataSource = (ListItemCollection)Session["Conector"];
                ddlcon_teclado.DataBind();
                ddlcon_mouse.DataSource = (ListItemCollection)Session["Conector"];
                ddlcon_mouse.DataBind();
                ddlcon_monitor.DataSource = (ListItemCollection)Session["Conectores"];
                ddlcon_monitor.DataBind();
            }
        }
        private DataTable SelectMarca()
        {
            string vacio="";
            return keyBL.InfoMarcaGlobal(ref vacio,ref vacio);
        }
        private ListItemCollection Conectores(int estado)
        {
            ListItemCollection items = null;
            if (estado==1)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("USB", "USB"),
                    new ListItem("MINIDIN", "MINIDIN"),
                };
            }
            else
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("HDMI", "HDMI"),
                    new ListItem("VGA", "VGA"),
                };
            }
            
            return items;
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lblsub_teclado.Text = ddlcon_teclado.SelectedValue+" "+ddlmarca_teclado.SelectedValue;
            LinkButton1.CssClass = postLink;
        }
    }
}