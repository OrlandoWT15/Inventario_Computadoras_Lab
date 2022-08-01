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
                Session["CPUGenerico"] = SelectCPUGenerico();
                Session["Teclado"] = SelectTeclado();
                Session["Mouse"] = SelectMouse();
                Session["Monitor"] = SelectMonitor();
                Session["Estado"] = Conectores(1);
                Session["DiscoD"] = SelectDuroD();
                Session["Laboratorio"] = SelectLaboratorio();
                

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
        private DataTable SelectCPUGenerico()
        {
            string vacio = "";
            return keyBL.InfoCPUGenericoCompleto(ref vacio, ref vacio);
        }

        private DataTable SelectTeclado()
        {
            string vacio = "";
            return keyBL.InfoTecladoCompleto(ref vacio, ref vacio);
        }
        private DataTable SelectMouse()
        {
            string vacio = "";
            return keyBL.InfoMouseCompleto(ref vacio, ref vacio);
        }
        private DataTable SelectMonitor()
        {
            string vacio = "";
            return keyBL.InfoMonitorCompleto(ref vacio, ref vacio);
        }
        private DataTable SelectDuroD()
        {
            string vacio = "";
            return keyBL.InfoDiscoduro(ref vacio, ref vacio);
        }
        private DataTable SelectLaboratorio()
        {
            string vacio = "";
            return keyBL.InfoLaboratorio(ref vacio, ref vacio);
        }
        private ListItemCollection Conectores(int estado = 0)
        {
            ListItemCollection items = null;
            if (estado == 1)
            {
                items = new ListItemCollection
                {
                    new ListItem("Bueno", "0"),
                    new ListItem("Malo", "1"),
                };
            }
            return items;
        }

        private DataTable SelectVelocidadRam(Int16 capacidad)
        {
            string vacio = "";
            return keyBL.InfoRAMCapacidad(new RAM() 
            { 
                Capacidad=capacidad            
            },ref vacio,ref vacio);
        }   
        private DataTable SelectMarcaMouse()
        {
            string vacio = "";
            return keyBL.InfoComponenteMarcaMouse(ref vacio, ref vacio);
        }

        private void Estado()
        {
            Boolean bandera = false;
            if (lbl_cpu.Enabled != true)
            {
                lbl_cpu.CssClass = trueLink;
                lbltitulo.Text = "CPU Completo";
                lbl_com.CssClass = postLink;
                lbl_datadisk.CssClass = postLink;
                lbl_ubi.CssClass = postLink;
                
            }
            if (lbl_com.Enabled != true)
            {
                lbl_com.CssClass = trueLink;
                lbltitulo.Text = "Computadora Registro";
                lbl_cpu.CssClass = postLink;
                lbl_datadisk.CssClass = postLink;
                lbl_ubi.CssClass = postLink;
                
            }
            if (lbl_datadisk.Enabled != true)
            {
                lbl_datadisk.CssClass = trueLink;
                lbltitulo.Text = "Estado de almacenamiento";
                lbl_ubi.CssClass = postLink;
                lbl_cpu.CssClass = postLink;
                lbl_com.CssClass = postLink;
            }
            if (lbl_ubi.Enabled != true)
            {
                lbl_ubi.CssClass = trueLink;
                lbltitulo.Text = "Ubicación";
                lbl_cpu.CssClass = postLink;
                lbl_datadisk.CssClass = postLink;
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
                lblComputadoraFinal_inv.Visible = false;
                lblComputadoraFinal_cpu.Visible = false;
                lblComputadoraFinal_cpu_tipo.Visible = false;
                lblComputadoraFinal_teclado.Visible = false;
                lblComputadoraFinal_teclado_tipo.Visible = false;
                lblComputadoraFinal_monitor.Visible = false;
                lblComputadoraFinal_monitor_tipo.Visible = false;
                lblComputadoraFinal_mouse.Visible = false;
                lblComputadoraFinal_mouse_tipo.Visible = false;
                lblComputadoraFinal_estado.Visible = false;
                lblComputadoraFinal_image.Visible = false;

                txtComputadoraFinal_inv.Visible = false;
                txtComputadoraFinal_cpu.Visible = false;
                txtComputadoraFinal_teclado.Visible = false;
                txtComputadoraFinal_monitor.Visible = false;
                txtComputadoraFinal_mouse.Visible = false;
                
                ddlComputadoraFinal_cpu_tipo.Visible = false;
                ddlComputadoraFinal_teclado_tipo.Visible = false;
                ddlComputadoraFinal_monitor_tipo.Visible = false;
                ddlComputadoraFinal_mouse_tipo.Visible = false;
                

                fuComputadoraFinal_image_One.Visible = false;
                fuComputadoraFinal_image_Two.Visible = false;
                fuComputadoraFinal_image_Three.Visible = false;
                btnComputadoraFinal.Visible = false;
                rblComputadoraFinal_estado.Visible = false;
            }
            else
            {
                lblComputadoraFinal_inv.Visible = true;
                lblComputadoraFinal_cpu.Visible = true;
                lblComputadoraFinal_cpu_tipo.Visible = true;
                lblComputadoraFinal_teclado.Visible = true;
                lblComputadoraFinal_teclado_tipo.Visible = true;
                lblComputadoraFinal_monitor.Visible = true;
                lblComputadoraFinal_monitor_tipo.Visible = true;
                lblComputadoraFinal_mouse.Visible = true;
                lblComputadoraFinal_mouse_tipo.Visible = true;
                lblComputadoraFinal_estado.Visible = true;
                lblComputadoraFinal_image.Visible = true;

                txtComputadoraFinal_inv.Visible = true;
                txtComputadoraFinal_cpu.Visible = true;
                txtComputadoraFinal_teclado.Visible = true;
                txtComputadoraFinal_monitor.Visible = true;
                txtComputadoraFinal_mouse.Visible = true;

                ddlComputadoraFinal_cpu_tipo.Visible = true;
                ddlComputadoraFinal_teclado_tipo.Visible = true;
                ddlComputadoraFinal_monitor_tipo.Visible = true;
                ddlComputadoraFinal_mouse_tipo.Visible = true;
                

                fuComputadoraFinal_image_One.Visible = true;
                fuComputadoraFinal_image_Two.Visible = true;
                fuComputadoraFinal_image_Three.Visible = true;
                btnComputadoraFinal.Visible = true;
                rblComputadoraFinal_estado.Visible = true;
            }
        }
        private void Vista_3(Boolean estado = false)
        {
            if (estado != true)
            {
                lblsub_cantdisk.Visible = false;    
                lblCantDisc_numinv.Visible = false;
                lblCantDisc_disc_tipo.Visible = false;

                txtCantDisc_numinv.Visible = false;

                ddlCantDisc_disc_tipo.Visible = false;

                btnCantDisc.Visible = false;
            }
            else
            {
                lblsub_cantdisk.Visible = true;
                lblCantDisc_numinv.Visible = true;
                lblCantDisc_disc_tipo.Visible = true;

                txtCantDisc_numinv.Visible = true;

                ddlCantDisc_disc_tipo.Visible = true;

                btnCantDisc.Visible = true;
            }
        }
        private void Vista_4(Boolean estado = false)
        {
            if (estado != true)
            {
                lblsub_ubicacion.Visible = false;
                lblUbicacion_numinv.Visible = false;
                lblUbicacion_lab_tipo.Visible = false;

                txtUbicacion_numinv.Visible = false;

                ddlUbicacion_lab_tipo.Visible = false;

                btnUbicacion_.Visible = false;
            }
            else
            {
                lblsub_ubicacion.Visible = true;
                lblUbicacion_numinv.Visible = true;
                lblUbicacion_lab_tipo.Visible = true;

                txtUbicacion_numinv.Visible = true;

                ddlUbicacion_lab_tipo.Visible = true;

                btnUbicacion_.Visible = true;
            }
        }
        private void PastPage(int i = 0)
        {
            if (i == 0)
            {
                //Mas vistas
                Vista_3();
                Vista_2();
                Vista_4();
                lbl_datadisk.Enabled = true;
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
                Vista_4();
                lbl_datadisk.Enabled = true;
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
                Vista_4();
                lbl_com.Enabled = true;
                lbl_cpu.Enabled = true;
                lbl_ubi.Enabled = true;
                lbl_datadisk.Enabled = false;
                Estado();
                Vista_3(true);
            }
            if (i == 3)
            {
                Vista_3();
                Vista_2();
                Vista_1();
                lbl_datadisk.Enabled = true;
                lbl_com.Enabled = true;
                lbl_cpu.Enabled = true;
                lbl_ubi.Enabled = false;
                Estado();
                Vista_4(true);
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
        private void fillcpugenerico()
        {
            DataTable cpu = null;
            cpu = (DataTable)Session["CPUGenerico"];
            ListItem i = null;

            ddlComputadoraFinal_cpu_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow c in cpu.Rows)
            {
                i = new ListItem("Tipo de CPU :"+c["Tipo"]+"| Modelo :"+c["Modelo"],c["id_CPU"].ToString());
                ddlComputadoraFinal_cpu_tipo.Items.Add(i);
            }
        }
        private void fillteclado()
        {
            DataTable tec = null;
            tec = (DataTable)Session["Teclado"];
            ListItem i = null;

            ddlComputadoraFinal_teclado_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach(DataRow t in tec.Rows)
            {
                i = new ListItem("Conector :"+t["conector"]+"| Marca :"+t["Marca"],t["id_teclado"].ToString());
                ddlComputadoraFinal_teclado_tipo.Items.Add(i);
            }
        }
        private void fillmouse()
        {
            DataTable mo = null;
            mo = (DataTable)Session["Mouse"];
            ListItem i = null;

            ddlComputadoraFinal_mouse_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow m in mo.Rows)
            {
                i = new ListItem("Conector :"+m["conector"]+"| Marca :"+m["Marca"],m["id_mouse"].ToString());
                ddlComputadoraFinal_mouse_tipo.Items.Add(i);
            }
        }
        private void fillmonitor()
        {
            DataTable mo = null;
            mo = (DataTable)Session["Monitor"];
            ListItem i = null;

            ddlComputadoraFinal_monitor_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow m in mo.Rows)
            {
                i = new ListItem("Conectores :"+m["conectores"]+"| Tamaño :"+m["tamano"],m["id_monitor"].ToString());
                ddlComputadoraFinal_monitor_tipo.Items.Add(i );
            }
        }
        private void fillDiscoD()
        {
            DataTable dd = null;
            dd = (DataTable)Session["DiscoD"];
            ListItem i = null;

            ddlCantDisc_disc_tipo.Items.Insert(0, "--- Selecciona una Opción ---");
            foreach (DataRow d in dd.Rows)
            {
                i = new ListItem("Tipo de almacenamiento :"+d["TipoDisco"]+ " | Conector :"+d["conector"]+" | Marca :"+d["Marca"]+" | Capacidad :"+d["Capacidad"], d["id_Disco"].ToString());
                ddlCantDisc_disc_tipo.Items.Add(i);
            }
        }
        private string fillnumber(Random numref)
        {
            Random num = null;
            string inv = "";
            num = numref;
            for (int i=0;i<10;i++)
            {
                inv = inv + num.Next(0,9);
            }
            num = null; 
            return inv;
        }
        private void fillnumnberCollection()
        {
            Random num = new Random();

            txtComputadoraFinal_inv.Text = fillnumber(num);
            txtComputadoraFinal_cpu.Text = fillnumber( num);
            txtComputadoraFinal_teclado.Text = fillnumber( num);
            txtComputadoraFinal_mouse.Text = fillnumber( num);
            txtComputadoraFinal_monitor.Text = fillnumber( num);
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

            //Vista2
            fillcpugenerico();
            fillteclado();
            fillmouse();
            fillmonitor();
            rblComputadoraFinal_estado.DataSource = (ListItemCollection)Session["Estado"];
            rblComputadoraFinal_estado.DataBind();
            fillnumnberCollection();
            //Vista2

            //Vista3
            fillDiscoD();
            //Vista3

            //Vistda4
            ddlUbicacion_lab_tipo.DataSource = (DataTable)Session["Laboratorio"];
            ddlUbicacion_lab_tipo.DataValueField = "nombre_laboratorio";
            ddlUbicacion_lab_tipo.DataTextField = "nombre_laboratorio";
            ddlUbicacion_lab_tipo.DataBind();
            ddlUbicacion_lab_tipo.Items.Insert(0,"--- Selecciona una Opción ---");
            //Vistda4
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
            PastPage(3);
        }
        protected void lbl_datadisk_Click(object sender, EventArgs e)
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
        protected void rblComputadoraFinal_estado_Load(object sender, EventArgs e)
        {
            if (rblComputadoraFinal_estado.SelectedIndex == 1)
            {
                fuComputadoraFinal_image_One.Enabled = true;
                fuComputadoraFinal_image_Two.Enabled = true;
                fuComputadoraFinal_image_Three.Enabled = true;
            }
            if (rblComputadoraFinal_estado.SelectedIndex == 0)
            {
                fuComputadoraFinal_image_One.Enabled = true;
            }
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

        protected void btnComputadoraFinal_Click(object sender, EventArgs e)
        {
            string mensaje = "", estado = "", titulo = "", ruta = "", strFilePath = "", id = "", id_2 = "", id_3 = "", name = "", name_2="", name_3="", ext="", ext_2="", ext_3="";
            int tipo = 0, tam = 0, tam_2 = 0, tam_3 = 0;
            Boolean state = false ;

            try
            {
                state = keyBL.AgregarCompFinal(new ComputadoraFinal()
                { 
                    num_inv=txtComputadoraFinal_inv.Text,
                    num_scpu=txtComputadoraFinal_cpu.Text,
                    F_cpug=Convert.ToInt32(ddlComputadoraFinal_cpu_tipo.SelectedValue),
                    num_steclado=txtComputadoraFinal_mouse.Text,
                    F_tecladog= Convert.ToInt32(ddlComputadoraFinal_teclado_tipo.SelectedValue),
                    num_smouse =txtComputadoraFinal_mouse.Text,
                    F_mouseg= Convert.ToInt32(ddlComputadoraFinal_mouse_tipo.SelectedValue),
                    num_smonitor=txtComputadoraFinal_monitor.Text,
                    F_mong= Convert.ToInt32(ddlComputadoraFinal_monitor_tipo.SelectedValue),
                    Estado=rblComputadoraFinal_estado.SelectedItem.Text,
                },ref estado,ref mensaje);
                if (state)
                {
                    ruta = Server.MapPath("~/Resources/cpu/");
                    if (rblComputadoraFinal_estado.SelectedItem.Text == "Malo")
                    {

                        if (fuComputadoraFinal_image_One.HasFile && fuComputadoraFinal_image_Two.HasFile && fuComputadoraFinal_image_Three.HasFile)
                        {
                            ext = Path.GetExtension(fuComputadoraFinal_image_One.FileName).ToLower();
                            ext_2 = Path.GetExtension(fuComputadoraFinal_image_Two.FileName).ToLower();
                            ext_3 = Path.GetExtension(fuComputadoraFinal_image_Three.FileName).ToLower();
                            name = fuComputadoraFinal_image_One.FileName;
                            name_2 = fuComputadoraFinal_image_Two.FileName;
                            name_3 = fuComputadoraFinal_image_Three.FileName;
                            tam = fuComputadoraFinal_image_One.PostedFile.ContentLength;
                            tam_2 = fuComputadoraFinal_image_Two.PostedFile.ContentLength;
                            tam_3 = fuComputadoraFinal_image_Three.PostedFile.ContentLength;
                            if ((ext == ".png" && tam <= 1048576) && (ext_2 == ".png" && tam_2 <= 1048576) && (ext_3 == ".png" && tam_3 <= 1048576))
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
                                    strFilePath = ruta + name_2;
                                    if (File.Exists(strFilePath))
                                    {
                                        mensaje = name_2 + ", ya existe!";
                                        tipo = 1;
                                    }
                                    else
                                    {
                                        strFilePath = ruta + name_3;
                                        if (File.Exists(strFilePath))
                                        {
                                            mensaje = name_3 + ", ya existe!";
                                            tipo = 1;
                                        }
                                        else
                                        {
                                            id = @"\Resources\cpu\" + name;
                                            id_2 = @"\Resources\cpu\" + name_2;
                                            id_3 = @"\Resources\cpu\" + name_3;

                                            strFilePath = ruta + name;
                                            fuComputadoraFinal_image_One.PostedFile.SaveAs(strFilePath);
                                            strFilePath = ruta + name_2;
                                            fuComputadoraFinal_image_Two.PostedFile.SaveAs(strFilePath);
                                            strFilePath = ruta + name_3;
                                            fuComputadoraFinal_image_Three.PostedFile.SaveAs(strFilePath);

                                            state = keyBL.AgregarImagenesCompuFinal(new Imagenes_ComFinal() 
                                            { 
                                                urlimage_one=id,
                                                urlimage_two=id_2,
                                                urlimage_three=id_3,
                                                F_ComputadoraFinal= txtComputadoraFinal_inv.Text
                                            },ref mensaje, ref estado);
                                            if (state)
                                            {
                                                titulo = "Computadora Final && sus imaegenes son correctas";
                                                tipo = 3;
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
                    }
                    else
                    {
                        if (fuComputadoraFinal_image_One.HasFile)
                        {
                            ext = Path.GetExtension(fuComputadoraFinal_image_One.FileName).ToLower();
                            name = fuComputadoraFinal_image_One.FileName;
                            tam = fuComputadoraFinal_image_One.PostedFile.ContentLength;
                            if (ext == ".png" && tam <= 1048576)
                            {
                                if (!Directory.Exists(ruta))
                                {
                                    Directory.CreateDirectory(ruta);
                                }
                                strFilePath = ruta + name;
                                if (File.Exists(strFilePath))
                                {
                                    mensaje = name + ", ya existe!";
                                    titulo = "Lo lamento!!";
                                    tipo = 1;
                                }
                                else
                                {
                                    id = @"\Resources\cpu\" + name;
                                    strFilePath = ruta + name;
                                    fuComputadoraFinal_image_One.PostedFile.SaveAs(strFilePath);

                                    state = keyBL.AgregarImagenesCompuFinal(new Imagenes_ComFinal()
                                    {
                                        urlimage_one = id,
                                        urlimage_two = "",
                                        urlimage_three = "",
                                        F_ComputadoraFinal = txtComputadoraFinal_inv.Text
                                    }, ref estado, ref mensaje);
                                    if (state)
                                    {
                                        titulo = "Computadora Final & sus imagenes son correctas";
                                        tipo = 3;
                                    }
                                }
                            }
                            else
                            {
                                titulo = "La imagen es muy grande";
                                tipo = 2;
                            }
                        }
                    }
                }
                else
                {
                    titulo = "Lo la mento tú Computadora Final no se agrego verifica tús campos sean correctos";
                    tipo = 2;
                }
                PastPage(2);
                txtCantDisc_numinv.Text = txtComputadoraFinal_inv.Text;
            }
            catch (Exception r)
            {
                titulo = "Erro : ";
                mensaje = mensaje + r;
                tipo = 2;
            }
            Message("COP",titulo,mensaje,tipo);
        }

        protected void btnCantDisc_Click(object sender, EventArgs e)
        {
            string titulo = "", mensaje = "", estado = "";
            int tipo = 0;
            Boolean state = false;

            if (txtCantDisc_numinv.Text!="")
            {
                try
                {
                    state = keyBL.AgregarCantDiscoDuro(new CantDisc()
                    {
                        num_inv = txtCantDisc_numinv.Text,
                        F_Dico = Convert.ToInt32(ddlCantDisc_disc_tipo.SelectedValue)
                    }, ref estado, ref mensaje);
                }
                catch (Exception me)
                {
                    mensaje = mensaje + " " + me;
                }
                if (state)
                {
                    titulo = "Almacenamiento";
                    tipo = 3;
                    txtUbicacion_numinv.Text = txtCantDisc_numinv.Text;
                }
            }
            else
            {
                titulo = "Losentimos !!";
                mensaje = "Debe tener una número de inventario para que podamos proceder su registro";
                tipo = 2;
            }
            Message("GuardarCant",titulo,mensaje,tipo);
            if (state)
            {
                PastPage(3);
            }
        }

        protected void btnUbicacion__Click(object sender, EventArgs e)
        {
            string titulo = "", mensaje = "", estado = "";
            int tipo = 0;
            Boolean state = false;

            if (txtUbicacion_numinv.Text!="")
            {
                try
                {
                    state=keyBL.AgregarUbicacion(new Ubicacion() 
                    { 
                        num_inv=txtUbicacion_numinv.Text,
                        nombre_laboratorio=ddlUbicacion_lab_tipo.Text
                    },ref estado,ref mensaje);
                }
                catch (Exception me)
                {
                    titulo = "Lo sentimos";
                    mensaje = mensaje + " " + e;
                    tipo = 2;
                }
                if (state)
                {
                    titulo = "Ubicación agregada";
                    mensaje = mensaje + ". Muchas gracias por agregar un registo";
                    tipo = 3;
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                titulo = "Lo sentimos";
                mensaje = "Debes tener un num de inventario para que puedas agregar una Ubicación";
                tipo = 2;
            }
            Message("GuardadoUbicación",titulo,mensaje,tipo);
        }
    }
}