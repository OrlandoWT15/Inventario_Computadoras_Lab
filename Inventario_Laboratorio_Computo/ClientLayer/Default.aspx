<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientLayer.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
        <h1 class="h3 mb-0 text-gray-800">
            Dashboard
        </h1>
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" OnClick="LinkButton1_Click">
           <i class="fas fa-plus fa-sm text-white-50"></i> 
            Generar Registro
        </asp:LinkButton>
    </div>
    <!-- Content Row -->
    <div class="row">

    </div>
</asp:Content>
