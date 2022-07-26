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
                    <asp:Label ID="lblsub_teclado" runat="server" Text="Teclado">
                    </asp:Label>
                </div>
                <div class="card-body">
                    <div>
                        <div class="form-group">
                            <label>Conector</label>
                            <asp:DropDownList ID="ddlcon_teclado" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value">
                            </asp:DropDownList>
                        </div>
                        
                        <div class="form-group">
                            <label>Marca</label>
                            <asp:DropDownList ID="ddlmarca_teclado" runat="server" CssClass="form-control" DataTextField="Marca" DataValueField="Id_Marca">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Label ID="lblsub_mouse" runat="server" Text="Mouse">
                    </asp:Label>
                </div>
                <div class="card-body">
                    <div>
                        <div class="form-group">
                            <label>Conector</label>
                            <asp:DropDownList ID="ddlcon_mouse" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value">
                            </asp:DropDownList>
                        </div>
                        
                        <div class="form-group">
                            <label>Marca</label>
                            <asp:DropDownList ID="ddlmarca_mouse" runat="server" CssClass="form-control"  DataTextField="Marca" DataValueField="Id_Marca">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <asp:Label ID="lblsub_monitor" runat="server" Text="Monitor">
                    </asp:Label>
                </div>
                <div class="card-body">
                    <div>
                        <div class="form-group">
                            <label>Conectores</label>
                            <asp:DropDownList ID="ddlcon_monitor" runat="server" CssClass="form-control" datatextfield="Text" datavaluefield="Value">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Tamaño</label>
                            <div class="form-inline mb-2">
                                <asp:TextBox ID="txttam_longitud_monitor" runat="server" CssClass="form-control" AutoCompleteType="None" TextMode="Number" min="1" max="2000"></asp:TextBox>
                                <label class="px-2">X</label>
                                <asp:TextBox ID="txttam_ancho_monitor" runat="server" CssClass="form-control" AutoCompleteType="None" TextMode="Number" min="1" max="2000"></asp:TextBox>
                            </div>
                            
                        </div>
                        <div class="form-group">
                            <label>Marca</label>
                            <asp:DropDownList ID="ddlmarca_monitor" runat="server" CssClass="form-control" DataTextField="Marca" DataValueField="Id_Marca">
                                <asp:ListItem Text="--Selecciona--" Value=""/>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-xl-4 col-lg-5">
            <h3>
                Progreso
            </h3>
            <ul class="navbar-nav align-items-center justify-content-center bg-gradient-primary sidebar sidebar-dark accordion rounded" id="accordionSidebar">
                <li class="nav-item">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">
                        1
                    </asp:LinkButton>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
