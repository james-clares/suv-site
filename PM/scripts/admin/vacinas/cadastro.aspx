<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="PM.scripts.admin.vacinas.cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Cadastro de Vacina
        </div>
        <div class="card-body">

            <div class="col-md-4">
                <div class="form-group">
                    <label>Nome</label>
                    <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>Lote</label>
                    <asp:TextBox ID="txtLote" runat="server"  CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                
                <asp:Button ID="Button1" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnSalvarVacina_Click"/>
                <asp:Button ID="btnLogin" runat="server" Text="Voltar" class="btn btn-primary" OnClick="btnVoltar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
