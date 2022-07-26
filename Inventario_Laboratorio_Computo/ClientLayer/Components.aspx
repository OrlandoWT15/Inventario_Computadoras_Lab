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
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <!-- View 1 -->
                    <asp:Label ID="lblsub_mouse" runat="server" Text="Mouse" Visible="true">
                    </asp:Label>
                    <!-- END View 1 -->
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
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Label ID="lblsub_monitor" runat="server" Text="Monitor" Visible="true">
                    </asp:Label>
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
                        <div class="form-row align-items-center">
                            <div class="col-auto my-1">
                                <asp:Button ID="btnPerifericos" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnPerifericos_Click" Visible="true"/>
                            </div>
                        </div>
                    </div>
                    <!-- END View 1 -->
                </div>
            </div>
        </div>
        <div class="col-xl-4 col-lg-5">
            <h3>
                Navegación
            </h3>
            <ul class="navbar-nav align-items-center justify-content-center bg-gradient-primary sidebar sidebar-dark accordion rounded" id="accordionSidebar">
                <li class="nav-item">
                    <asp:LinkButton ID="lbl1" runat="server" CssClass="text-white" href="Components.aspx">
                        <i class="fas fa-fw fa-desktop"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br />
                <li class="nav-item">
                    <asp:LinkButton ID="lbl2" runat="server" CssClass="text-white" href="Cabinet.aspx">
                        <i class="fas fa-fw fa-cube"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:LinkButton ID="lbl3" runat="server" CssClass="text-white" href="#">
                        <i class="fas fa-fw fa-cubes"></i>
                    </asp:LinkButton>
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:LinkButton ID="lbl4" runat="server" CssClass="text-white" href="#">
                        <i class="fas fa-fw fa-map-marked"></i>
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
