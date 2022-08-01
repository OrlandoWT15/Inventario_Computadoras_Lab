using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Rutas
using System.IO;
using System.Configuration;
using System.Data;
using BusinessLayer;
using Entity;

namespace ClientLayer
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        private BL keyBL = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                keyBL = new BL(ConfigurationManager.ConnectionStrings["cnlocal"].ConnectionString);
                Session["keyBL"] = keyBL;
                //Tables
                Session["ComputadoraFinal"] = SelectComputadoraFinal();
                Session["Laboratorio"] = SelectLaboratorios();
                Session["Solido"] = SelectSolid();
                Session["Monitor"] = SelectMonitor();
                FillDataTables();
            }
            else
            {
                keyBL = (BL)Session["keyBL"];
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
        private DataTable SelectComputadoraFinal()
        {
            string vacio = "";
            return keyBL.InfoCompFinalCompletoFull(ref vacio,ref vacio);
        }
        private DataTable SelectLaboratorios()
        {
            string vacio = "";
            return keyBL.InfoUbicacion(ref vacio, ref vacio);
        }
        private DataTable SelectSolid()
        {
            string vacio = "";
            return keyBL.InfoUbicacionEstadoSolido(ref vacio, ref vacio);
        }
        private DataTable SelectMonitor()
        {
            string vacio = "";
            return keyBL.InfoMonitor(ref vacio, ref vacio);
        }

        private void ComputadoraFinal()
        {
            gvComputadoraFinal.DataSource = (DataTable)Session["ComputadoraFinal"];
            gvComputadoraFinal.DataBind();
        }
        private void Laboratorios()
        {
            gvLaboraatorioCom.DataSource = (DataTable)Session["Laboratorio"];
            gvLaboraatorioCom.DataBind();
        }
        private void EstadoSolido()
        {
            gvSolid.DataSource = (DataTable)Session["Solido"];
            gvSolid.DataBind();
        }
        private void Monitor()
        {
            DataTable mo = null;
            mo = (DataTable)Session["Monitor"];
            ListItem i = null;

            ddlMonitores.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow m in mo.Rows)
            {
                i = new ListItem("Conectores :" + m["conectores"] + "| Tamaño :" + m["tamano"], m["id_monitor"].ToString());
                ddlMonitores.Items.Add(i);
            }
        }
        private void FillDataTables()
        {
            //Computadorafinal
            ComputadoraFinal();
            Laboratorios();
            EstadoSolido();
            Monitor();
            //
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agregate.aspx");
        }

        protected void gvComputadoraFinal_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvComputadoraFinal.PageIndex = e.NewPageIndex;
            gvComputadoraFinal.DataSource = Session["ComputadoraFinal"];
            gvComputadoraFinal.DataBind();
        }
        protected void gvLaboraatorioCom_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLaboraatorioCom.PageIndex = e.NewPageIndex;
            gvLaboraatorioCom.DataSource = Session["Laboratorio"];
            gvLaboraatorioCom.DataBind();
        }
        protected void gvmonitores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvmonitores.PageIndex = e.NewPageIndex;
            gvmonitores.DataSource = Session["Monitor"];
            gvmonitores.DataBind();
        }
        protected void gvComputadoraFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titulo = "", mensaje = "", estado = "",ruta="";
            int tipo = 0;
            Boolean state = false;

            if (gvComputadoraFinal.SelectedIndex >= 0)
            {
                try
                {
                    state = keyBL.EliminarCompFinal(new ComputadoraFinal()
                    {
                        num_inv = gvComputadoraFinal.DataKeys[gvComputadoraFinal.SelectedIndex].Value.ToString()
                    }, ref estado, ref mensaje);
                }
                catch (Exception me)
                {
                    titulo = "Lo sentimos";
                    mensaje = mensaje + " " + me;
                    tipo = 2;
                }
                if (state)
                {
                    titulo = "Se ha eliminado";
                    tipo = 3;
                }
            }
            Message("computadoraInfo", titulo, mensaje, tipo);
            FillDataTables();
        }

        protected void ddlMonitores_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = null ;
            string vacio= "";
            if (ddlMonitores.SelectedIndex >= 0)
            {
                table = keyBL.InfoMonitorLaboratorio(new Monitor()
                {
                    Id = Convert.ToInt32(ddlMonitores.SelectedValue)
                }, ref vacio, ref vacio);
                gvmonitores.DataSource = table;
                gvmonitores.DataBind();
            }
        }
    }
}