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
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        private BL keyBL = null;
        string postLink = "rounded-circle btn-lg  bg-gray-700";
        string trueLink = "btn btn-circle btn-lg btn-success";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                keyBL = new BL(ConfigurationManager.ConnectionStrings["cnlocal"].ConnectionString);
                Session["keyBL"] = keyBL;
                //Load
                Estado();
                //Datos
                Session["Teclado"] = SelectMarcaTeclado();
                Session["Mouse"] = SelectMarcaMouse();
                Session["Monitor"] = SelectMarcaMonitor();
                Session["Conector"] = Conectores(1);
                Session["Conectores"] = Conectores(0);
                FillDDLPerifericos();
            }
            else
            {
                keyBL = (BL)Session["keyBL"];
                Estado();
            }
        }
        private DataTable SelectMarcaTeclado()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaTeclado(ref vacio, ref vacio);
        }
        private DataTable SelectMarcaMouse()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaMouse(ref vacio, ref vacio);
        }
        private DataTable SelectMarcaMonitor()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaMonitor(ref vacio, ref vacio);
        }
        private ListItemCollection Conectores(int estado)
        {
            ListItemCollection items = null;
            if (estado == 1)
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
        private void Estado()
        {
            Boolean bandera = false;
            if (lbl1.Enabled != false)
            {
                lbl1.CssClass = trueLink;
                lbltitulo.Text = "Perifericos";
                lbl2.CssClass = postLink;
                lbl3.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl2.Enabled != false)
            {
                lbl2.CssClass = trueLink;
                lbl1.CssClass = postLink;
                lbl3.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl3.Enabled != false)
            {
                lbl3.CssClass = trueLink;
                lbl1.CssClass = postLink;
                lbl2.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl4.Enabled != false)
            {
                lbl4.CssClass = trueLink;
                lbl3.CssClass = postLink;
                lbl2.CssClass = postLink;
                lbl1.CssClass = postLink;
            }
        }
        private void Message(string etiqueta, string titulo, string mensaje, int state)
        {
            string tipo = "";
            switch (state)
            {
                case 1:
                    tipo = "warning";
                    break;
                case 2:
                    tipo = "error";
                    break;
                case 3:
                    tipo = "success";
                    break;
                case 4:
                    tipo = "info";
                    break;
            }
            ClientScript.RegisterClientScriptBlock(this.GetType(), etiqueta,
            "swal('" + titulo + "!', '" + mensaje + "!', '" + tipo + "')", true);
        }
        private void Vista_1(Boolean estado = false)
        {
            if (estado != true)
            {
                lblsub_teclado.Visible = false;
                lblsub_mouse.Visible = false;
                lblsub_monitor.Visible = false;
                lblPerifericos_con_0.Visible = false;
                lblPerifericos_con_1.Visible = false;
                lblPerifericos_con_2.Visible = false;
                lblPerifericos_ma_0.Visible = false;
                lblPerifericos_ma_1.Visible = false;
                lblPerifericos_ma_2.Visible = false;
                lblPerifericos_tamano.Visible = false;
                lblPerifericos_x.Visible = false;
                ddlcon_teclado.Visible = false;
                ddlcon_mouse.Visible = false;
                ddlcon_monitor.Visible = false;
                ddlmarca_teclado.Visible = false;
                ddlmarca_mouse.Visible = false;
                ddlmarca_monitor.Visible = false;
                txttam_longitud_monitor.Visible = false;
                txttam_ancho_monitor.Visible = false;
                btnPerifericos.Visible = false;
            }
            else
            {
                lblsub_teclado.Visible = true;
                lblsub_mouse.Visible = true;
                lblsub_monitor.Visible = true;
                lblPerifericos_con_0.Visible = true;
                lblPerifericos_con_1.Visible = true;
                lblPerifericos_con_2.Visible = true;
                lblPerifericos_ma_0.Visible = true;
                lblPerifericos_ma_1.Visible = true;
                lblPerifericos_ma_2.Visible = true;
                lblPerifericos_tamano.Visible = true;
                lblPerifericos_x.Visible = true;
                ddlcon_teclado.Visible = true;
                ddlcon_mouse.Visible = true;
                ddlcon_monitor.Visible = true;
                ddlmarca_teclado.Visible = true;
                ddlmarca_mouse.Visible = true;
                ddlmarca_monitor.Visible = true;
                txttam_longitud_monitor.Visible = true;
                txttam_ancho_monitor.Visible = true;
                btnPerifericos.Visible = true;
            }

        }
        private void FillDDLPerifericos()
        {
            ddlmarca_teclado.DataSource = (DataTable)Session["Teclado"];
            ddlmarca_teclado.DataBind();
            ddlmarca_mouse.DataSource = (DataTable)Session["Mouse"];
            ddlmarca_mouse.DataBind();
            ddlmarca_monitor.DataSource = (DataTable)Session["Monitor"];
            ddlmarca_monitor.DataBind();
            ddlcon_teclado.DataSource = (ListItemCollection)Session["Conector"];
            ddlcon_teclado.DataBind();
            ddlcon_mouse.DataSource = (ListItemCollection)Session["Conector"];
            ddlcon_mouse.DataBind();
            ddlcon_monitor.DataSource = (ListItemCollection)Session["Conectores"];
            ddlcon_monitor.DataBind();
        }
        private void cleanPerifericos()
        {
            txttam_longitud_monitor.Text = "";
            txttam_ancho_monitor.Text = "";
        }

        protected void btnPerifericos_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate1 = false, estate2 = false, estate3 = false;
            estate1 = keyBL.AgregarTeclado(new Teclado()
            {
                Conector = ddlcon_teclado.SelectedValue,
                F_marcat = Convert.ToInt32(ddlmarca_teclado.SelectedValue)
            }, ref estado, ref mensaje);
            estate2 = keyBL.AgregarMouse(new Mouse()
            {
                conector = ddlcon_mouse.SelectedValue,
                F_marcamouse = Convert.ToInt32(ddlmarca_mouse.SelectedValue)
            }, ref estado, ref mensaje);
            estate3 = keyBL.AgregarMonitor(new Monitor()
            {
                Conectores = ddlcon_monitor.SelectedValue,
                Tamanio = txttam_longitud_monitor.Text + "x" + txttam_ancho_monitor.Text,
                F_marcam = Convert.ToInt32(ddlmarca_monitor.SelectedValue)
            }, ref estado, ref mensaje);

            if (estate1 && estate2 && estate3)
            {
                Message("periferico", " Todo se guardo correctamente", mensaje, 3);
                Estado();
                FillDDLPerifericos();
                cleanPerifericos();
            }
            else
            {
                Message("periferico", "Lo la mento!!!", mensaje, 2);
            }
        }
    }
}