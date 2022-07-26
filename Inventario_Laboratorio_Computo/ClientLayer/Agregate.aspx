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
                        <asp:Button ID="btnPerifericos" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnPerifericos_Click" Visible="true"/>
                    </div>
                    <!-- END View 1 -->
                </div>
            </div>
        </div>
        <div class="col-xl-4 col-lg-5">
            <h3>
                Progreso
            </h3>
            <ul class="navbar-nav align-items-center justify-content-center bg-gradient-primary sidebar sidebar-dark accordion rounded" id="accordionSidebar">
                <li class="nav-item">
                    <asp:Label ID="lbl1" Enabled="true" Text="1" runat="server" />
                </li>
                <hr class="sidebar-divider my-0">
                <br />
                <li class="nav-item">
                   <asp:Label ID="lbl2" Enabled="false" Text="2" runat="server" />
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:Label ID="lbl3" Enabled="false" Text="3" runat="server" />
                </li>
                <hr class="sidebar-divider my-0">
                <br/>
                <li class="nav-item">
                    <asp:Label ID="lbl4" Enabled="false" Text="4" runat="server" />
                </li>
            </ul>
        </div>
    </div>
</asp:Content>
