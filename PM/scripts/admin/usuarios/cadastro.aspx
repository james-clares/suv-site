<%@ Page Title="Cadastro de Usuário" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="PM.scripts.admin.usuarios.cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .col-md-6, .col-md-5, .col-md-4 {
            float: left;
        }
    </style>
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Cadastro de Usuário
        </div>
        <div class="card-body">

            <div class="col-md-6">
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Senha</label>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>Nome</label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>CPF</label>
                    <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>RG</label>
                    <asp:TextBox ID="txtRg" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-5">
                <div class="form-group">
                    <label>Sexo</label>
                    <asp:DropDownList ID="ddlGenero" runat="server" class="form-control">
                        <asp:ListItem Value="0" Text="Selecione" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
                        <asp:ListItem Value="F" Text="Feminino"></asp:ListItem>
                        <asp:ListItem Value="O" Text="Outro"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-5">
                <div class="form-group">
                    <label>Data de Nascimento</label>
                    <asp:TextBox ID="txtDataNasc" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">
                    <label>CEP</label>
                    <asp:TextBox ID="txtCep" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Endereço</label>
                    <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Telefone</label>
                    <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Telefone Celular</label>
                    <asp:TextBox ID="txtCel" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-6">
                <div class="form-group">

                    <asp:Button ID="Button1" runat="server" Text="Salvar" class="btn btn-success" OnClick="btnCadastrarUsuario_Click" />
                    <asp:Button ID="btnLogin" runat="server" Text="Voltar" class="btn btn-primary" OnClick="btnVoltar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>