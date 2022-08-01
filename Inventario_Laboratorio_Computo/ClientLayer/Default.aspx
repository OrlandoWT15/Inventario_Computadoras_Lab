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
        <div class="container-fluid">
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Tabla de Computadoras</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <asp:GridView ID="gvComputadoraFinal" runat="server" CssClass="table table-bordered" PageSize="5"
                            AutoGenerateColumns="false" 
                            OnPageIndexChanging="gvComputadoraFinal_PageIndexChanging" 
                            OnSelectedIndexChanged="gvComputadoraFinal_SelectedIndexChanged"
                            DataKeyNames="N. Serie">
                            <Columns>
                                <asp:ImageField DataImageUrlField="urlimage_one" HeaderText="Imagen" ControlStyle-Width="64" ControlStyle-Height="64"></asp:ImageField>
                                <asp:ImageField DataImageUrlField="urlimage_two" HeaderText="Imagen" ControlStyle-Width="64" ControlStyle-Height="64"></asp:ImageField>
                                <asp:ImageField DataImageUrlField="urlimage_three" HeaderText="Imagen" ControlStyle-Width="64" ControlStyle-Height="64"></asp:ImageField>
                                <asp:BoundField DataField="estado" HeaderText="estado" />
                                <asp:BoundField DataField="N. Serie"  HeaderText="N. Serie"/>
                                <asp:BoundField DataField="N. CPU" HeaderText="N. CPU" />
                                <asp:BoundField DataField="Modelo" HeaderText="Modelo"/>
                                <asp:BoundField DataField="N. Teclado" HeaderText="N. Teclado"/>
                                <asp:BoundField DataField="conector" HeaderText="conecto"/>
                                <asp:BoundField DataField="N. mouse" HeaderText="N. mouse"/>
                                <asp:BoundField DataField="conector" HeaderText="conector"/>
                                <asp:BoundField DataField="N. Monitor" HeaderText="N. Monitor"/>
                                <asp:BoundField DataField="Tamaño" HeaderText="Tamaño"/>
                                <asp:BoundField DataField="Capacidad" HeaderText="Capacidad"/>
                                <asp:BoundField DataField="Velocidad de RAM" HeaderText="Velocidad de RAM"/>
                                <asp:BoundField DataField="Capacidad de RAM" HeaderText="Capacidad de RAM"/>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid col-4">
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Laboratorios Con Conputadoras</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <asp:GridView ID="gvLaboraatorioCom" runat="server" CssClass="table table-bordered" PageSize="5" OnPageIndexChanging="gvLaboraatorioCom_PageIndexChanging">
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid col-8">
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Laboratorios Con Conputadoras de estado solido</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <asp:GridView ID="gvSolid" runat="server" CssClass="table table-bordered" PageSize="5" OnPageIndexChanging="gvLaboraatorioCom_PageIndexChanging">
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid col-4">
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Monitores</h6>
                </div>
                <div class="card-body">
                    <asp:DropDownList ID="ddlMonitores" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlMonitores_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="container-fluid col-8">
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">Laboratorios Con Conputadoras de estado solido</h6>
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <asp:GridView ID="gvmonitores" runat="server" CssClass="table table-bordered" PageSize="5" OnPageIndexChanging="gvmonitores_PageIndexChanging">
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div
    </div>
</asp:Content>
