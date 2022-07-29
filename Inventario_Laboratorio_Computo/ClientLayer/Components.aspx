<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Components.aspx.cs" Inherits="ClientLayer.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="h3 mb-0 text-gray-800">
            Agregar Registro  de Componentes
    </h1>

    <!-- Divider -->
    <hr class="sidebar-divider">

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
                    <asp:Label ID="lblsub_teclado" runat="server" Text="Teclado" Visible="true">
                    </asp:Label>
                    <!-- END View 1 -->
                    <!-- View 2 -->
                    <asp:Label ID="lblsub_gabinete" runat="server" Text="Gabinete" Visible="false">
                    </asp:Label>
                    <!-- END View 2 -->
                    <!-- View 3 -->
                    <asp:Label ID="lblsub_discoduro" runat="server" Text="Discoduro" Visible="false">
                    </asp:Label>
                    <!-- END View 3 -->
                    <!-- View 4 -->
                    <asp:Label ID="Label1" runat="server" Text="Laboratorio" Visible="false">
                    </asp:Label>
                    <!-- END View 4 -->
                </div>
                <div class="card-body">
                    <!-- View 1 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_con_0" runat="server" Text="Conector" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlcon_teclado" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value" Visible="true">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_ma_0" runat="server" Text="Marca" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_teclado" runat="server" CssClass="form-control" DataTextField="Marca" DataValueField="f_marca" Visible="true">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <!-- END View 1 -->
                    <!-- View 2 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblGabinete_modelo" runat="server" Text="Modelo" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtGmodelo" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblGabinete_forma" runat="server" Text="Forma" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlgab_tipoforma" runat="server" CssClass="form-control" DataTextField="Text" DataValueField="Value" Visible="false">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblGabinete_ma_0" runat="server" Text="Marca" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_gabinete" runat="server" CssClass="form-control"  DataTextField="Marca" DataValueField="f_marca" Visible="false">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                        <asp:Button ID="btnGabinete" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGabinete_Click" Visible="false"/>
                    </div>
                    <!-- END View 2 -->
                    <!-- View 3 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblDiscoD_TipoD" runat="server" Text="Tipo de Disco Duro" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddldisd_tipo" runat="server" CssClass="form-control" DataTextField="Text" DataValueField="Value" Visible="false">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDiscoD_conector" runat="server" Text="Forma" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddldisd_conector" runat="server" CssClass="form-control" DataTextField="Text" DataValueField="Value" Visible="false">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDiscoD_capacidad" runat="server" Text="Capacidad" Visible="false"></asp:Label>
                            <div class="form-row">
                                <asp:TextBox ID="txtdisD_capacidad" runat="server" CssClass="form-control w-25" Visible="false" AutoCompleteType="None" TextMode="Number" min="1" max="1024"></asp:TextBox>
                                <asp:DropDownList ID="ddldisd_capacidad" runat="server" Visible="false" CssClass="form-control w-25"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDiscoD_ma_0" runat="server" Text="Marca" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_discod" runat="server" CssClass="form-control"  DataTextField="Marca" DataValueField="f_marca" Visible="false">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDiscoduroD_extra" runat="server" Text="Extra" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtdisD_extra" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnDiscuduro" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnDiscuduro_Click" Visible="false"/>
                    </div>
                    <!-- END View 3 -->
                    <!-- View 4 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblLaboratorio_nom" runat="server" Text="Nombre del laboratorio" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtLaboratorio_nom" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnLaboratorio" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnLaboratorio_Click" Visible="false"/>
                    </div>
                    <!-- END View 4 -->
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <!-- View 1 -->
                    <asp:Label ID="lblsub_mouse" runat="server" Text="Mouse" Visible="true">
                    </asp:Label>
                    <!-- END View 1 -->
                    <!-- View 3 -->
                    <asp:Label ID="lblsub_ram" runat="server" Text="RAM" Visible="false">
                    </asp:Label>
                    <!-- END View 3 -->
                     
                </div>
                <div class="card-body">
                    <!-- View 1 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_con_1" runat="server" Text="Conector" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlcon_mouse" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value" Visible="true">
                            </asp:DropDownList>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_ma_1" runat="server" Text="Marca" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_mouse" runat="server" CssClass="form-control"  DataTextField="Marca" DataValueField="f_marca" Visible="true">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <!-- END View 1 -->
                    <!-- View 3 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblRam_capacidad" runat="server" Text="Capacidad" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtRam_capacidad" runat="server" CssClass="form-control" Visible="false" TextMode="Number" min="0" max="128"></asp:TextBox>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="lblRam_velocidad" runat="server" Text="Velocidad" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtRam_velocidad" runat="server" CssClass="form-control" Visible="false" TextMode="Number" step="0.001" min="0" max="6000"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRam_TipoR" runat="server" Text="Tipo de Memoria RAM" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlRam_TipoR" runat="server" CssClass="form-control" Visible="false"  DataTextField="Tipo" DataValueField="id_tipoRam"></asp:DropDownList>
                        </div>
                        <asp:Button ID="btnRam" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnRam_Click" Visible="false"/>
                    </div>
                    <!-- END View 3 -->
                     
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <!-- View 1 -->
                    <asp:Label ID="lblsub_monitor" runat="server" Text="Monitor" Visible="true">
                    </asp:Label>
                    <!-- END View 1 -->
                    <!-- View 3 -->
                    <asp:Label ID="lblsub_modelocpu" runat="server" Text="Modelo CPU" Visible="false">
                    </asp:Label>
                    <!-- END View 3 -->
                </div>
                <div class="card-body">
                    <!-- View 1 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_con_2" runat="server" Text="Conectores" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlcon_monitor" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value" Visible="true">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_tamano" runat="server" Text="Tamaño" Visible="true"></asp:Label>
                            
                            <div class="form-inline mb-2">
                                <asp:TextBox ID="txttam_longitud_monitor" runat="server" CssClass="form-control" AutoCompleteType="None" TextMode="Number" min="1" max="2000" Visible="true"></asp:TextBox>
                                <asp:Label ID="lblPerifericos_x" runat="server" Text="X" Visible="true" CssClass="px-2"></asp:Label>
                                <asp:TextBox ID="txttam_ancho_monitor" runat="server" CssClass="form-control" AutoCompleteType="None" TextMode="Number" min="1" max="2000" Visible="true"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblPerifericos_ma_2" runat="server" Text="Marca" Visible="true"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_monitor" runat="server" CssClass="form-control" DataTextField="Marca" DataValueField="f_marca" Visible="true">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                        <asp:Button ID="btnPerifericos" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnPerifericos_Click" Visible="true"/>
                    </div>
                    <!-- END View 1 -->
                    <!-- View 3 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblModelCPU_modelo" runat="server" Text="Modelo" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtModeloCPU_modelo" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblmarca_model_1" runat="server" Text="Marca" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlmarca_modelocpu" runat="server" CssClass="form-control" DataTextField="Marca" DataValueField="f_marca" Visible="false">
                            </asp:DropDownList>
                        </div>
                        <asp:Button ID="btnModeloCPU" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnModeloCPU_Click" Visible="false"/>
                    </div>
                    <!-- END View 3 -->
                </div> 
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <!-- View 3 -->
                    <asp:Label ID="lblsub_tipocpu" runat="server" Text="Tipo de CPU" Visible="false">
                    </asp:Label>
                    <!-- END View 3 -->
                </div>
                <div class="card-body">
                    <!-- View 3 -->
                    <div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoCPU_tipo" runat="server" Text="Tipo de CPU" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtTipoCPU_tipo" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblTipoCPU_tipo_small" runat="server" CssClas="form-text text-muted" Visible="false">
                                El tipo de cpu se refiere a que nomclatura tiene el cpu. ejemplo: Core i6.
                            </asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoCPU_familia" runat="server" Text="Familia" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtTipoCPU_familia" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
                            <asp:Label ID="lblTipoCPU_familia_small" runat="server" Text="Familia del cpu por ejemplo AMD Ryzen™ Processors" CssClas="form-text text-muted" Visible="false">
                            </asp:Label>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoCPU_velocidad" runat="server" Text="Velocidad" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtTipoCPU_velocidad" runat="server" Visible="false" CssClass="form-control" TextMode="Number" step="0.001" min="0" max="6000"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoCPU_tipocpu" runat="server" Text="Tipo dE CPU" Visible="false"></asp:Label>
                            <asp:DropDownList ID="ddlTipoCPU_tipocpu" runat="server" CssClass="form-control" DataTextField="modeloCPU" DataValueField="id_modcpu" Visible="false">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoCPU_extra" runat="server" Text="Extra" Visible="false"></asp:Label>
                            <asp:TextBox ID="txtTipoCPU_extra" runat="server" Visible="false" CssClass="form-control" Rows="3"></asp:TextBox>
                        </div>
                        <asp:Button ID="btnTipoCPU" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnTipoCPU_Click" Visible="false"/>
                    </div>
                    <!-- END View 3 -->
                </div>
            </div>
        </div>
        <div class="col-xl-4 col-lg-5">
            <h3>
                Navegación
            </h3>
            <ul class="navbar-nav align-items-center justify-content-center bg-gradient-primary sidebar sidebar-dark accordion rounded" id="accordionSidebar">
                <li class="nav-item">
                    <asp:LinkButton ID="lbl1" runat="server" CssClass="text-white" href="Components.aspx" Enabled="false">
                        <i class="fas fa-fw fa-desktop"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br />
                <li class="nav-item">
                    <asp:LinkButton ID="lbl2" runat="server" CssClass="text-white" OnClick="lbl2_Click" Enabled="true">
                        <i class="fas fa-fw fa-cube"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:LinkButton ID="lbl3" runat="server" CssClass="text-white" OnClick="lbl3_Click" Enabled="true">
                        <i class="fas fa-fw fa-cubes"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:LinkButton ID="lbl4" runat="server" CssClass="text-white" OnClick="lbl4_Click" Enabled="true">
                        <i class="fas fa-fw fa-map-marked"></i>
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
