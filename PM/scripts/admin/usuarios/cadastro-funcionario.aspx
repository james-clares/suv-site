<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="cadastro-funcionario.aspx.cs" Inherits="PM.scripts.admin.usuarios.cadastro_funcionario" %>
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
            Cadastro de Funcionário
        </div>
         <div class="card-body">
             
            <div class="col-md-6">
                <div class="form-group">
                    <label>E-mail</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Senha</label>
                    <asp:TextBox ID="txtSenha" runat="server" textMode="password" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
             <div class="col-md-5">
                <div class="form-group">
                    <label>CPF</label>
                    <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-5">
                <div class="form-group">
                    <label>Nome</label>
                    <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>UF</label>
                    <asp:DropDownList ID="ddlUf" runat="server" class="form-control">
                        <asp:ListItem Value="0" Text="Selecione" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="AC" Text="AC"></asp:ListItem>
                        <asp:ListItem Value="AL" Text="AL"></asp:ListItem>
                        <asp:ListItem Value="AM" Text="AM"></asp:ListItem>
                        <asp:ListItem Value="AP" Text="AP"></asp:ListItem>
                        <asp:ListItem Value="BA" Text="BA"></asp:ListItem>
                        <asp:ListItem Value="CE" Text="CE"></asp:ListItem>
                        <asp:ListItem Value="DF" Text="DF"></asp:ListItem>
                        <asp:ListItem Value="ES" Text="ES"></asp:ListItem>
                        <asp:ListItem Value="GO" Text="GO"></asp:ListItem>
                        <asp:ListItem Value="MA" Text="MA"></asp:ListItem>
                        <asp:ListItem Value="MG" Text="MG"></asp:ListItem>
                        <asp:ListItem Value="MS" Text="MS"></asp:ListItem>
                        <asp:ListItem Value="MT" Text="MT"></asp:ListItem>
                        <asp:ListItem Value="PA" Text="PA"></asp:ListItem>
                        <asp:ListItem Value="PB" Text="PB"></asp:ListItem>
                        <asp:ListItem Value="PE" Text="PE"></asp:ListItem>
                        <asp:ListItem Value="PI" Text="PI"></asp:ListItem>
                        <asp:ListItem Value="PR" Text="PR"></asp:ListItem>
                        <asp:ListItem Value="RJ" Text="RJ"></asp:ListItem>
                        <asp:ListItem Value="RN" Text="RN"></asp:ListItem>
                        <asp:ListItem Value="RO" Text="RO"></asp:ListItem>
                        <asp:ListItem Value="RR" Text="RR"></asp:ListItem>
                        <asp:ListItem Value="RS" Text="RS"></asp:ListItem>
                        <asp:ListItem Value="SC" Text="SC"></asp:ListItem>
                        <asp:ListItem Value="SE" Text="SE"></asp:ListItem>
                        <asp:ListItem Value="SP" Text="SP"></asp:ListItem>
                        <asp:ListItem Value="TO" Text="TO"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>COREN</label>
                    <asp:TextBox ID="txtCoren" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">

                    <asp:Button ID="Button1" runat="server" Text="Salvar" class="btn btn-success" OnClick="btnCadastrarFuncionario_Click" />
                    <asp:Button ID="btnLogin" runat="server" Text="Voltar" class="btn btn-primary" OnClick="btnVoltar_Click" />
                </div>
            </div>
         </div>
    </div>
</asp:Content>
