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
    public partial class Formulario_web11 : System.Web.UI.Page
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
                Session["Gabinete"] = SelectGabinete();
                Session["TipoCPU"] = SelectTipoCPU();
                Session["TipoRAM"] = SelectTipoRam();
                Session["MarcaModeloCPU"] = SelectMarcaModeloCPU();

                //Session["Teclado"] = SelectMarcaTeclado();
                //Session["Mouse"] = SelectMarcaMouse();
                //Session["Monitor"] = SelectMarcaMonitor();
                //Session["DiscoDuro"] = SelectMarcaDiscoDuro();

                FillDDL();
            }
            else
            {
                keyBL = (BL)Session["keyBL"];
                Estado();
            }
        }
        private DataTable SelectGabinete()
        {
            string vacio = "";
            return keyBL.InfoGabinete(ref vacio, ref vacio);
        }
        private DataTable SelectTipoRam()
        {
            string vacio = "";
            return keyBL.InfoRAMCompleto(ref vacio, ref vacio);
        }
        private DataTable SelectTipoCPU()
        {
            string vacio = "";
            return keyBL.InfoCPUTipo(ref vacio, ref vacio);
        }
        private DataTable SelectMarcaModeloCPU()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaModeloCPU(ref vacio, ref vacio);
        }

        private DataTable SelectVelocidadRam(Int16 capacidad)
        {
            string vacio = "";
            return keyBL.InfoRAMCapacidad(new RAM() 
            { 
                Capacidad=capacidad            
            },ref vacio,ref vacio);
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
        private DataTable SelectMarcaDiscoDuro()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaDiscoDuro(ref vacio, ref vacio);
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
            return items;
        }

        private void Estado()
        {
            Boolean bandera = false;
            if (lbl_cpu.Enabled != true)
            {
                lbl_cpu.CssClass = trueLink;
                lbltitulo.Text = "CPU Completo";
                lbl_com.CssClass = postLink;
                lbl_ubi.CssClass = postLink;
                
            }
            if (lbl_com.Enabled != true)
            {
                lbl_com.CssClass = trueLink;
                lbltitulo.Text = "Computadora Registro";
                lbl_cpu.CssClass = postLink;
                lbl_ubi.CssClass = postLink;
                
            }
            if (lbl_ubi.Enabled != true)
            {
                lbl_ubi.CssClass = trueLink;
                lbltitulo.Text = "Ubicación";
                lbl_cpu.CssClass = postLink;
                lbl_com.CssClass = postLink;
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
                lblsub_CPUGenerico.Visible = false;
                lblCPUGenerico_tipo.Visible = false;
                lblmarca_CPUGenerico.Visible = false;
                lblCPUGenerico_modelo.Visible = false;
                lblCPUGenerico_descripcion.Visible = false;
                lblCPUGenerico_tiporam.Visible = false;
                lblCPUGenerico_tipogabinete.Visible = false;
                lblCPUGenerico_imagen.Visible = false;
                lblCPUGenerico_modelo_small.Visible = false;
                lblCPUGenerico_descripcion_small.Visible = false;
    
                txtCPUGenerico_descripcion.Visible = false;
                txtCPUGenerico_modelo.Visible = false;

                ddlCPUGenerico_tipo.Visible = false;
                ddlmarca_CPUGenerico.Visible = false;
                ddlCPUGenerico_tiporam.Visible = false;
                ddlCPUGenerico_tipogabinete.Visible = false;

                oFile.Visible = false;
                btnCPUGenerico.Visible = false;
            }
            else
            {
                lblsub_CPUGenerico.Visible = true;
                lblCPUGenerico_tipo.Visible = true;
                lblmarca_CPUGenerico.Visible = true;
                lblCPUGenerico_modelo.Visible = true;
                lblCPUGenerico_descripcion.Visible = true;
                lblCPUGenerico_tiporam.Visible = true;
                lblCPUGenerico_tipogabinete.Visible = true;
                lblCPUGenerico_imagen.Visible = true;
                lblCPUGenerico_modelo_small.Visible = true;
                lblCPUGenerico_descripcion_small.Visible = true;

                txtCPUGenerico_descripcion.Visible = true;
                txtCPUGenerico_modelo.Visible = true;

                ddlCPUGenerico_tipo.Visible = true;
                ddlmarca_CPUGenerico.Visible = true;
                ddlCPUGenerico_tiporam.Visible = true;
                ddlCPUGenerico_tipogabinete.Visible = true;

                oFile.Visible = true;
                btnCPUGenerico.Visible = true;
            }

        }
        private void Vista_2(Boolean estado = false)
        {
            if (estado != true)
            {

            }
            else
            {

            }
        }
        private void Vista_3(Boolean estado = false)
        {
            if (estado != true)
            {
                
            }
            else
            {


            }
        }
        private void PastPage(int i = 0)
        {
            if (i == 0)
            {
                //Mas vistas
                Vista_3();
                Vista_2();
                lbl_ubi.Enabled = true;
                lbl_com.Enabled = true;
                lbl_cpu.Enabled = false;
                Estado();
                Vista_1(true);
            }
            if (i == 1)
            {
                Vista_3();
                Vista_1();
                lbl_ubi.Enabled = true;
                lbl_cpu.Enabled = true;
                lbl_com.Enabled = false;
                Estado();
                Vista_2(true);
            }
            if (i == 2)
            {
                Vista_2();
                Vista_1();
                lbl_com.Enabled = true;
                lbl_cpu.Enabled = true;
                lbl_ubi.Enabled = false;
                Estado();
                Vista_3(true);
            }
        }
        private void fillRam()
        {
            DataTable ram = null;
            ram = (DataTable)Session["TipoRAM"];
            ListItem i = null;

            ddlCPUGenerico_tiporam.Items.Insert(0,"--- Selecciona una Opción ---");
            foreach (DataRow r in ram.Rows)
            {
                i = new ListItem("Capacidad : "+r["Capacidad"] + " | Velocidad : " + r["Velocidad"]+" | Tipo de RAM : "+r["Tipo"], r["id_RAM"].ToString());
                ddlCPUGenerico_tiporam.Items.Add(i);
            }
        }
        private void fillGabinete()
        {
            DataTable gab = null;
            gab = (DataTable)Session["Gabinete"];
            ListItem i = null;

            ddlCPUGenerico_tipogabinete.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow g in gab.Rows)
            {
                i = new ListItem("Modelo : "+g["Modelo"]+" | Froma del gabinete : "+g["TipoForma"],g["id_Gabinete"].ToString());
                ddlCPUGenerico_tipogabinete.Items.Add(i);
            }
        }

        private void FillDDL()
        {
            
            //Vista1
            ddlCPUGenerico_tipo.DataSource = (DataTable)Session["TipoCPU"];
            ddlCPUGenerico_tipo.DataBind();
            ddlCPUGenerico_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            fillRam();
            fillGabinete();
            ddlmarca_CPUGenerico.DataSource = (DataTable)Session["MarcaModeloCPU"];
            ddlmarca_CPUGenerico.DataBind();
            ddlmarca_CPUGenerico.Items.Insert(0, "--- Selecciona una Opción ---");
            //Vista1
        }

        protected void lbl_cpu_Click(object sender, EventArgs e)
        {
            PastPage();
        }

        protected void lbl_com_Click(object sender, EventArgs e)
        {
            PastPage(1);
        }

        protected void lbl_ubi_Click(object sender, EventArgs e)
        {
            PastPage(2);
        }

        protected int ImageId(string encontrar)
        {
            DataTable id = null;
            DataRow recid = null;
            int idencontrado = 0;
            string vacio="";
            id = keyBL.InfoImagenCPUId(new Imagenes_CPU()
            {
                urlimage_one = encontrar
            }, ref vacio, ref vacio);
            if (id!=null)
            {
                idencontrado = Convert.ToInt32(id.Rows[0]["Id_Image"]);
            }
            
            return idencontrado;
        }
        private void CleanCPU()
        {
            ddlCPUGenerico_tipo.ClearSelection();
            ddlCPUGenerico_tipogabinete.ClearSelection();
            ddlCPUGenerico_tiporam.ClearSelection();
            ddlmarca_CPUGenerico.ClearSelection();
            txtCPUGenerico_descripcion.Text="";
            txtCPUGenerico_modelo.Text="";
        }
        protected void btnCPUGenerico_Click(object sender, EventArgs e)
        {
            string mensaje = "", estado = "",ext,ruta, strFilePath,id,name,titulo="";
            int tam,tipo = 0;
            Boolean respuesta = false,estate=false;

            ruta = Server.MapPath("~/Resources/cpu/");

            if (oFile.HasFile)
            {
                ext = Path.GetExtension(oFile.FileName).ToLower();
                name = oFile.FileName;
                tam = oFile.PostedFile.ContentLength;
                if (ext == ".png" && tam<= 1048576)
                {
                    if (!Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }
                    strFilePath = ruta + name;
                    if (File.Exists(strFilePath))
                    {
                        mensaje = name + ", ya existe!";
                        tipo = 1;
                    }
                    else
                    {
                        id = @"\Resources\cpu\" + name;
                        respuesta = keyBL.AgregarImagenesCPU(new Imagenes_CPU()
                        {
                            urlimage_one= id
                        },ref estado,ref mensaje);
                        if (respuesta)
                        {
                            oFile.PostedFile.SaveAs(strFilePath);
                            //Imagen guarda
                            if (File.Exists(strFilePath))
                            {
                                estate=keyBL.AgregarCPUGenerico(new CPU_Generico() 
                                {
                                    F_Tcpu=Convert.ToInt32(ddlCPUGenerico_tipo.SelectedValue),
                                    F_Marca=Convert.ToInt32(ddlmarca_CPUGenerico.SelectedValue),
                                    Modelo=txtCPUGenerico_modelo.Text,
                                    Descripcion=txtCPUGenerico_descripcion.Text,
                                    F_TipoRam=Convert.ToInt32(ddlCPUGenerico_tiporam.SelectedValue),
                                    F_Gabinete=Convert.ToInt32(ddlCPUGenerico_tipogabinete.SelectedValue),
                                    F_Imagenes=ImageId(id)
                                },ref estado,ref mensaje);
                                if (estate)
                                {
                                    tipo = 3;
                                    titulo = "La imagen y el Cpu se anguardado correctamente";
                                    CleanCPU();
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                mensaje = "Click 'Browse' Selecciona la imagen.";
                tipo = 4;
            }

            Message("CPUGenerico",titulo,mensaje,tipo);
        }

    }
}