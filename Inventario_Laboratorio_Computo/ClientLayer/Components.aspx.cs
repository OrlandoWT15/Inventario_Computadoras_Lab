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
                Session["ConectorF"] = Conectores(2);
                Session["Gabinete"] = SelectMarcaGabinete();
                Session["ConectorTD"] = Conectores(3);
                Session["ConectorCD"] = Conectores(4);
                Session["ConectorCAD"] = Conectores(5);
                Session["DiscoDuro"] = SelectMarcaDiscoDuro();
                Session["TipoRAM"] = SelectTipoRam();
                Session["ModeloCPU"] = SelectMarcaModeloCPU();
                Session["TipoCPU"] = SelectTipoCPU();
                FillDDL();
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
        private DataTable SelectMarcaGabinete()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaGabinete(ref vacio, ref vacio);
        }
        private DataTable SelectMarcaDiscoDuro()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaDiscoDuro(ref vacio, ref vacio);
        }
        private DataTable SelectMarcaModeloCPU()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaModeloCPU(ref vacio, ref vacio);
        }
        private DataTable SelectTipoRam()
        {
            string vacio = "";
            return keyBL.InfoTipoRAM(ref vacio, ref vacio);
        }
        private DataTable SelectTipoCPU()
        {
            string vacio = "";
            return keyBL.InfoCPUModelo(ref vacio, ref vacio);
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
            if(estado==0)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("HDMI", "HDMI"),
                    new ListItem("VGA", "VGA"),
                };
            }
            if (estado == 2)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("Torre", "Torre"),
                    new ListItem("Media Torre", "Media Torre"),
                    new ListItem("Mini Torre", "Mini Torre"),
                    new ListItem("Servidor", "Servidor"),
                    new ListItem("Switch", "Switch"),
                    new ListItem("Router", "Router"),
                };
            }
            if (estado == 3)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("NVMe Card", "NVMe Card"),
                    new ListItem("NVMe SSD", "NVMe SSD"),
                    new ListItem("SATA SSD", "SATA SSD"),
                    new ListItem("M.2 SSD", "M.2 SSD"),
                    new ListItem("HDD DiscoMecanico", "HDD DiscoMecanico"),
                };
            }
            if (estado == 4)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("SATA", "SATA"),
                    new ListItem("IDE", "IDE"),
                    new ListItem("PCI", "PCI"),
                    new ListItem("PCIe", "PCIe"),
                    new ListItem("AGP", "AGP"),
                    new ListItem("SATA ll", "SATA ll"),
                    new ListItem("SATA lll", "SATA lll"),
                    new ListItem("MVMe", "MVMe"),
                };
            }
            if (estado == 5)
            {
                items = new ListItemCollection
                {
                    new ListItem("--Selecciona--", ""),
                    new ListItem("GB", "GB"),
                    new ListItem("TB", "TB"),
                };
            }
            return items;
        }
        private void Estado()
        {
            Boolean bandera = false;
            if (lbl1.Enabled != true)
            {
                lbl1.CssClass = trueLink;
                lbltitulo.Text = "Perifericos";
                lbl2.CssClass = postLink;
                lbl3.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl2.Enabled != true)
            {
                lbl2.CssClass = trueLink;
                lbltitulo.Text = "Gabinete";
                lbl1.CssClass = postLink;
                lbl3.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl3.Enabled != true)
            {
                lbl3.CssClass = trueLink;
                lbltitulo.Text = "Componentes Internos Hardware";
                lbl1.CssClass = postLink;
                lbl2.CssClass = postLink;
                lbl4.CssClass = postLink;
            }
            if (lbl4.Enabled != true)
            {
                lbl4.CssClass = trueLink;
                lbltitulo.Text = "Ubicación";
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
                    tipo = "danger";
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
        private void Vista_2(Boolean estado = false)
        {
            if (estado != true)
            {
                lblsub_gabinete.Visible = false;
                lblGabinete_modelo.Visible = false;
                lblGabinete_forma.Visible = false;
                lblGabinete_ma_0.Visible = false;
                ddlgab_tipoforma.Visible = false;
                ddlmarca_gabinete.Visible = false;
                txtGmodelo.Visible = false;
                btnGabinete.Visible = false;
            }
            else
            {
                lblsub_gabinete.Visible = true;
                lblGabinete_modelo.Visible = true;
                lblGabinete_forma.Visible = true;
                lblGabinete_ma_0.Visible = true;
                ddlgab_tipoforma.Visible = true;
                ddlmarca_gabinete.Visible = true;
                txtGmodelo.Visible = true;
                btnGabinete.Visible = true;
            }
        }
        private void Vista_3(Boolean estado = false)
        {
            if (estado != true)
            {
                lblsub_discoduro.Visible = false;
                lblDiscoD_conector.Visible = false;
                lblDiscoD_capacidad.Visible = false;
                lblDiscoD_ma_0.Visible = false;
                lblDiscoduroD_extra.Visible = false;
                lblDiscoD_TipoD.Visible = false;
                lblsub_ram.Visible = false;
                lblRam_capacidad.Visible = false;
                lblRam_velocidad.Visible = false;
                lblRam_TipoR.Visible = false;
                lblsub_modelocpu.Visible = false;
                lblModelCPU_modelo.Visible = false;
                lblmarca_model_1.Visible = false;
                lblsub_tipocpu.Visible = false;
                lblTipoCPU_tipo.Visible = false;
                lblTipoCPU_familia.Visible = false;
                lblTipoCPU_velocidad.Visible = false;
                lblTipoCPU_tipocpu.Visible = false;
                lblTipoCPU_extra.Visible = false;
                lblTipoCPU_familia_small.Visible = false;
                lblTipoCPU_tipo_small.Visible = false;

                ddldisd_tipo.Visible = false;
                ddldisd_conector.Visible = false;
                ddlmarca_discod.Visible = false;
                ddldisd_capacidad.Visible = false;
                ddlRam_TipoR.Visible = false;
                ddlmarca_modelocpu.Visible = false;
                ddlTipoCPU_tipocpu.Visible = false;

                txtdisD_capacidad.Visible = false;
                txtdisD_extra.Visible = false;
                txtRam_capacidad.Visible = false;
                txtRam_velocidad.Visible = false;
                txtModeloCPU_modelo.Visible = false;
                txtTipoCPU_tipo.Visible = false;
                txtTipoCPU_familia.Visible = false;
                txtTipoCPU_velocidad.Visible = false;
                txtTipoCPU_extra.Visible = false;


                btnDiscuduro.Visible = false;
                btnRam.Visible = false;
                btnModeloCPU.Visible = false;
                btnTipoCPU.Visible = false;
            }
            else
            {
                lblsub_discoduro.Visible = true;
                lblDiscoD_conector.Visible = true;
                lblDiscoD_capacidad.Visible = true;
                lblDiscoD_ma_0.Visible = true;
                lblDiscoduroD_extra.Visible = true;
                lblDiscoD_TipoD.Visible = true;
                lblsub_ram.Visible = true;
                lblRam_capacidad.Visible = true;
                lblRam_velocidad.Visible = true;
                lblRam_TipoR.Visible = true;
                lblsub_modelocpu.Visible = true;
                lblModelCPU_modelo.Visible = true;
                lblmarca_model_1.Visible = true;
                lblsub_tipocpu.Visible = true;
                lblTipoCPU_tipo.Visible = true;
                lblTipoCPU_familia.Visible = true;
                lblTipoCPU_velocidad.Visible = true;
                lblTipoCPU_tipocpu.Visible = true;
                lblTipoCPU_extra.Visible = true;
                lblTipoCPU_familia_small.Visible = true;
                lblTipoCPU_tipo_small.Visible = true;

                ddldisd_tipo.Visible = true;
                ddldisd_conector.Visible = true;
                ddlmarca_discod.Visible = true;
                ddldisd_capacidad.Visible = true;
                ddlRam_TipoR.Visible = true;
                ddlmarca_modelocpu.Visible = true;
                ddlTipoCPU_tipocpu.Visible = true;


                txtdisD_capacidad.Visible = true;
                txtdisD_extra.Visible = true;
                txtRam_capacidad.Visible = true;
                txtRam_velocidad.Visible = true;
                txtRam_velocidad.Visible = true;
                txtModeloCPU_modelo.Visible = true;
                txtTipoCPU_tipo.Visible = true;
                txtTipoCPU_familia.Visible = true;
                txtTipoCPU_velocidad.Visible = true;
                txtTipoCPU_extra.Visible = true;

                btnDiscuduro.Visible = true;
                btnRam.Visible = true;
                btnModeloCPU.Visible = true;
                btnTipoCPU.Visible = true;
            }
        }
        private void Vista_4(Boolean estado = false)
        {
            if (estado != true)
            {
                lblLaboratorio_nom.Visible = false;

                txtLaboratorio_nom.Visible = false;

                btnLaboratorio.Visible = false;
            }
            else
            {
                lblLaboratorio_nom.Visible = true;

                txtLaboratorio_nom.Visible = true;

                btnLaboratorio.Visible = true;
            }
        }
        private void PastPage(int i=0)
        {
            if (i==0)
            {
                //Mas vistas
                Vista_3();
                Vista_2();
                Vista_4();
                lbl4.Enabled = true;
                lbl3.Enabled = true;
                lbl2.Enabled = true;
                lbl1.Enabled = false;
                Estado();
                Vista_1(true);
            }
            if (i == 1)
            {
                Vista_3();
                Vista_1();
                Vista_4();
                lbl4.Enabled = true;
                lbl3.Enabled = true;
                lbl1.Enabled = true;
                lbl2.Enabled = false;
                Estado();
                Vista_2(true);
            }
            if (i == 2)
            {
                Vista_2();
                Vista_1();
                Vista_4();
                lbl4.Enabled = true;
                lbl2.Enabled = true;
                lbl1.Enabled = true;
                lbl3.Enabled = false;
                Estado();
                Vista_3(true);
            }
            if (i == 3)
            {
                Vista_2();
                Vista_1();
                Vista_3();
                lbl4.Enabled = false;
                lbl2.Enabled = true;
                lbl1.Enabled = true;
                lbl3.Enabled = true;
                Estado();
                Vista_4(true);
            }
        }
        private void FillDDL()
        {
            ddlmarca_teclado.DataSource = (DataTable)Session["Teclado"];
            ddlmarca_teclado.DataBind();
            ddlmarca_mouse.DataSource = (DataTable)Session["Mouse"];
            ddlmarca_mouse.DataBind();
            ddlmarca_monitor.DataSource = (DataTable)Session["Monitor"];
            ddlmarca_monitor.DataBind();
            ddlmarca_gabinete.DataSource = (DataTable)Session["Gabinete"];
            ddlmarca_gabinete.DataBind();
            ddlmarca_discod.DataSource = (DataTable)Session["DiscoDuro"];
            ddlmarca_discod.DataBind(); 
            ddlmarca_modelocpu.DataSource = (DataTable)Session["ModeloCPU"];
            ddlmarca_modelocpu.DataBind();
            ddlRam_TipoR.DataSource = (DataTable)Session["TipoRAM"];
            ddlRam_TipoR.DataBind();
            ddlTipoCPU_tipocpu.DataSource = (DataTable)Session["TipoCPU"];
            ddlTipoCPU_tipocpu.DataBind();

            ddlcon_teclado.DataSource = (ListItemCollection)Session["Conector"];
            ddlcon_teclado.DataBind();
            ddlcon_mouse.DataSource = (ListItemCollection)Session["Conector"];
            ddlcon_mouse.DataBind();
            ddlcon_monitor.DataSource = (ListItemCollection)Session["Conectores"];
            ddlcon_monitor.DataBind();
            ddlgab_tipoforma.DataSource = (ListItemCollection)Session["ConectorF"];
            ddlgab_tipoforma.DataBind();
            ddldisd_tipo.DataSource = (ListItemCollection)Session["ConectorTD"];
            ddldisd_tipo.DataBind();
            ddldisd_conector.DataSource = (ListItemCollection)Session["ConectorCD"];
            ddldisd_conector.DataBind();
            ddldisd_capacidad.DataSource = (ListItemCollection)Session["ConectorCAD"];
            ddldisd_capacidad.DataBind();
        }
        private void cleanPerifericos()
        {
            txttam_longitud_monitor.Text = "";
            txttam_ancho_monitor.Text = "";
            FillDDL();
        }
        private void cleanGabinete()
        {
            txtGmodelo.Text = "";
            FillDDL();
        }
        private void cleanDiscoDuro()
        {
            txtdisD_capacidad.Text = "";
            txtdisD_extra.Text = "";
            FillDDL();
        }
        private void cleanRam()
        {
            txtRam_capacidad.Text = "";
            txtRam_velocidad.Text = "";
            FillDDL();
        }
        private void cleanModelocpu()
        {
            txtModeloCPU_modelo.Text = "";
            FillDDL();
        }
        private void cleanTipocpu()
        {
            txtTipoCPU_tipo.Text = "";
            txtTipoCPU_familia.Text = "";
            txtTipoCPU_velocidad.Text = "";
            txtTipoCPU_extra.Text = "";
            FillDDL();
        }
        private void cleanLaboratorio()
        {
            txtLaboratorio_nom.Text = "";
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
                cleanPerifericos();
            }
            else
            {
                Message("periferico", "Lo la mento!!!", mensaje, 2);
            }
        }

        protected void lbl2_Click(object sender, EventArgs e)
        {
            PastPage(1);
        }

        protected void btnGabinete_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate = false;

            estate = keyBL.AgregarGabinete(new Gabinete()
            {
                Modelo = txtGmodelo.Text,
                TipoForma = ddlgab_tipoforma.SelectedValue,
                F_Marca = Convert.ToInt32(ddlmarca_gabinete.SelectedValue)
            }, ref estado, ref mensaje);
            if (estate)
            {
                Message("periferico", " Se guardo correctamente", mensaje, 3);
                cleanGabinete();
            }
            else
            {
                Message("periferico", "Lo la mento!!!", mensaje, 2);
            }
        }

        protected void lbl3_Click(object sender, EventArgs e)
        {
            PastPage(2);
        }

        protected void lbl4_Click(object sender, EventArgs e)
        {
            PastPage(3);
        }
        protected void btnDiscuduro_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate = false;

            estate = keyBL.AgregarDiscoDuro(new DiscoDuro()
            {
                TipoDisco=ddldisd_tipo.SelectedValue,
                Conector=ddldisd_conector.SelectedValue,
                Capacidad=txtdisD_capacidad.Text+ddldisd_capacidad.SelectedValue,
                F_MarcaDisco=Convert.ToInt32(ddlmarca_discod.SelectedValue),
                Extra=txtdisD_extra.Text
            }, ref estado, ref mensaje);
            if (estate)
            {
                Message("discoduro", " Se guardo correctamente", mensaje, 3);
                cleanRam();
            }
            else
            {
                Message("discoduro", "Lo la mento!!!", mensaje, 1);
            }
            
        }

        protected void btnRam_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate = false;

            estate = keyBL.AgregarRAM(new RAM()
            {
                Capacidad=Convert.ToInt16(txtRam_capacidad.Text),
                Velocidad=txtRam_velocidad.Text+" MHz",
                F_TipoR=Convert.ToInt32(ddlRam_TipoR.SelectedValue)
            }, ref estado, ref mensaje);
            if (estate)
            {
                Message("RAM", " Se guardo correctamente", mensaje, 3);
                cleanDiscoDuro();
            }
            else
            {
                Message("RAM", "Lo la mento!!!", mensaje, 1);
            }
        }

        protected void btnModeloCPU_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate = false;

            estate = keyBL.AgregarCPUModelo(new ModeloCPU()
            {
                modeloCPU=txtModeloCPU_modelo.Text,
                F_Marca=Convert.ToInt32(ddlmarca_modelocpu.SelectedValue)
            }, ref estado, ref mensaje);
            if (estate)
            {
                Message("ModeloCPU", " Se guardo correctamente", mensaje, 3);
                cleanModelocpu();
            }
            else
            {
                Message("ModeloCPU", "Lo la mento!!!", mensaje, 1);
            }
        }

        protected void btnTipoCPU_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "";
            Boolean estate = false;

            estate = keyBL.AgregarCPUTipo(new Tipo_CPU()
            {
                Tipo = txtTipoCPU_tipo.Text,
                Familia = txtTipoCPU_familia.Text,
                Velocidad = txtTipoCPU_velocidad.Text+" MHz",
                F_Modelocpu = Convert.ToInt32(ddlTipoCPU_tipocpu.SelectedValue),
                Extra = txtTipoCPU_extra.Text
            }, ref estado, ref mensaje);
            if (estate)
            {
                Message("TipoCPU", " Se guardo correctamente", mensaje, 3);
                cleanTipocpu();
            }
            else
            {
                Message("TipoCPU", "Lo la mento!!!", mensaje, 1);
            }
        }

        protected void btnLaboratorio_Click(object sender, EventArgs e)
        {
            string estado = "", mensaje = "",titulo="";
            int tipo = 0;
            Boolean estate = false;

            estate = keyBL.AgregarLaboratorio(new Laboratorio()
            {
               Nombre_Laboratorio=txtLaboratorio_nom.Text
            }, ref estado, ref mensaje);
            if (estate)
            {
                tipo = 3;
                titulo = "Se agrego un nuevo laboratorio";
                cleanLaboratorio();
            }
            else
            {
                titulo = "Lo la mento!!";
                tipo = 2;
            }
                Message("discoduro", titulo, mensaje,tipo);
        }
    }
}