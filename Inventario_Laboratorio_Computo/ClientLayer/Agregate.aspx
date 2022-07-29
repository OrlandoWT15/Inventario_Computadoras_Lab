<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Agregate.aspx.cs" Inherits="ClientLayer.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">
            Agregar Registro 
        </h1>
        <p>
            El registro de una computadora se va hacer por una serie de pasos, para que puedan completar el registro 
            de la computadora con toda la información necesaria. 
        </p>
    </div>
    <!-- Content Row -->
    <div class="row">
        <div class="col-xl-8 col-lg-7">
            <h3>
                <asp:Label ID="lbltitulo" runat="server" Text="Perifericos">
                </asp:Label>
            </h3>
            <!-- Content Card -->
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <!-- View 1 -->
                    <asp:Label ID="lblsub_CPUGenerico" runat="server" Text="CPU Completo" Visible="false">
                    </asp:Label>
                    <!-- END View 1 -->
                </div>
                <div class="card-body">
                    <!-- View 1 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_tipo" runat="server" Text="Tipo de CPU" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlCPUGenerico_tipo" runat="server" DataTextField="Tipo" DataValueField="id_Tcpu" Visible="true" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblmarca_CPUGenerico" runat="server" Text="Marca" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_CPUGenerico" runat="server" DataTextField="Marca" DataValueField="f_marca" Visible="true" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_modelo" runat="server" Text="Modelo" Visible="true"></asp:Label>
                            <asp:TextBox ID="txtCPUGenerico_modelo" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblCPUGenerico_modelo_small" runat="server" Text="En el modelo, se refiere a él tipo de nomenclatura que cuenta el CPU, por ejemplo i5-10400F." CssClass="form-text text-muted text-xs"></asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_descripcion" runat="server" Text="Descripción del CPU" Visible="true"></asp:Label>
                            <asp:TextBox ID="txtCPUGenerico_descripcion" runat="server"  Visible="true" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblCPUGenerico_descripcion_small" runat="server" Text="Complementa la información con más detalles del procesador, los cuales sean necesarios para comentar." Visible="true" CssClass="form-text text-muted text-xs" ></asp:Label>

                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_tiporam" runat="server" Text="Capacidad de RAM" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlCPUGenerico_tiporam" runat="server"  Visible="true" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_tipogabinete" runat="server" Text="Modelo de Gabinete" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlCPUGenerico_tipogabinete" runat="server"  Visible="true" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCPUGenerico_imagen" runat="server" Text="Imagen" Visible="true"></asp:Label>
                            <asp:FileUpload ID="oFile" runat="server" CssClass="form-control-file btn-dark" />

                        </div>
                        <asp:Button ID="btnCPUGenerico" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnCPUGenerico_Click" Visible="true"/>
                    </div>
                    <!-- END View 1 -->
                </div>
            </div>
        </div>
        <!-- Nav -->
        <div class="col-xl-4 col-lg-5">
            <h3>
                Navegación
            </h3>
            <ul class="navbar-nav align-items-center justify-content-center bg-gradient-primary sidebar sidebar-dark accordion rounded" id="accordionSidebar">
                <li class="nav-item">
                    <asp:LinkButton ID="lbl_cpu" runat="server" CssClass="text-white" OnClick="lbl_cpu_Click" Enabled="false">
                        <i class="fas fa-fw fa-cube"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br />
                <li class="nav-item">
                    <asp:LinkButton ID="lbl_com" runat="server" CssClass="text-white" OnClick="lbl_com_Click" Enabled="true">
                        <i class="fas fa-fw fa-desktop"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:LinkButton ID="lbl_ubi" runat="server" CssClass="text-white" OnClick="lbl_ubi_Click" Enabled="true">
                        <i class="fas fa-fw fa-map-marked"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
            </ul>
        </div>
    </div>
</asp:Content>
