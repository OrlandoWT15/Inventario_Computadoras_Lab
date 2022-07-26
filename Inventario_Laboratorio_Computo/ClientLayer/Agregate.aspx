﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Agregate.aspx.cs" Inherits="ClientLayer.Formulario_web11" %>
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
                    <!-- View 2 -->
                    <asp:Label ID="lblsub_ComFinal" runat="server" Text="Computadora Final" Visible="false">
                    </asp:Label>
                    <!-- END View 2 -->
                     <!-- View 3 -->
                    <asp:Label ID="lblsub_cantdisk" runat="server" Text="Espacio de almacenamiento" Visible="false">
                    </asp:Label>
                    <!-- END View 3 -->
                    <!-- View 4 -->
                    <asp:Label ID="lblsub_ubicacion" runat="server" Text="Ubicación" Visible="false">
                    </asp:Label>
                    <!-- END View 4 -->
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
                    <!-- View 2 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_inv" runat="server" Text="N. de Inventario" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtComputadoraFinal_inv" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_cpu" runat="server" Text="N. de Serie del CPU" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtComputadoraFinal_cpu" runat="server" Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_cpu_tipo" runat="server" Text="Tipo de CPU" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlComputadoraFinal_cpu_tipo" runat="server" Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_teclado" runat="server" Text="N. de Serie de Teclado" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtComputadoraFinal_teclado" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_teclado_tipo" runat="server" Text="Teclado" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlComputadoraFinal_teclado_tipo" runat="server"  Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_mouse" runat="server" Text="N. de Serie de Mouse" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtComputadoraFinal_mouse" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_mouse_tipo" runat="server" Text="Mouse" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlComputadoraFinal_mouse_tipo" runat="server"  Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_monitor" runat="server" Text="N. de Serie de Monitor" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtComputadoraFinal_monitor" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_monitor_tipo" runat="server" Text="Monitor" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlComputadoraFinal_monitor_tipo" runat="server"  Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_estado" runat="server" Text="Estado" Visible="false"></asp:Label>
                            <asp:RadioButtonList ID="rblComputadoraFinal_estado" runat="server" Visible="false" OnLoad="rblComputadoraFinal_estado_Load" AutoPostBack="true"> 
                            </asp:RadioButtonList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblComputadoraFinal_image" runat="server" Text="Imagen" Visible="false"></asp:Label>
                            <asp:FileUpload ID="fuComputadoraFinal_image_One" runat="server" CssClass="form-control-file btn-dark disabled" Visible="false" Enabled="false"/>
                            <asp:FileUpload ID="fuComputadoraFinal_image_Two" runat="server" CssClass="form-control-file btn-dark disabled" Visible="false" Enabled="false"/>
                            <asp:FileUpload ID="fuComputadoraFinal_image_Three" runat="server" CssClass="form-control-file btn-dark disabled" Visible="false" Enabled="false"/>
                        </div>
                        <asp:Button ID="btnComputadoraFinal" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnComputadoraFinal_Click" Visible="false"/>
                    </div>
                    <!-- END View 2 -->
                    <!-- View 3 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblCantDisc_numinv" runat="server" Text="N. de Inventario" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtCantDisc_numinv" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblCantDisc_disc_tipo" runat="server" Text="Almacenamiento" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlCantDisc_disc_tipo" runat="server" Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <asp:Button ID="btnCantDisc" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnCantDisc_Click" Visible="false"/>
                    </div>
                    <!-- END View 3 -->
                    <!-- View 4 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblUbicacion_numinv" runat="server" Text="N. de Inventario" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtUbicacion_numinv" runat="server"  Visible="false" Enabled="false" CssClass="form-control disabledTextInput"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblUbicacion_lab_tipo" runat="server" Text="Laboratorio" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlUbicacion_lab_tipo" runat="server" Visible="false" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <asp:Button ID="btnUbicacion_" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnUbicacion__Click" Visible="false"/>
                    </div>
                    <!-- END View 4 -->
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
                    <asp:LinkButton ID="lbl_datadisk" runat="server" CssClass="text-white" OnClick="lbl_datadisk_Click" Enabled="true">
                        <i class="fas fa-fw fa-database"></i>
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
