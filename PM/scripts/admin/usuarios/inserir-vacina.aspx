<%@ Page Title="Cadastro de Vacina" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="inserir-vacina.aspx.cs" Inherits="PM.scripts.admin.usuarios.inserir_vacina" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Inserir Vacina
        </div>
        <div class="card-body">

            <div class="col-md-4">
                <div class="form-group">
                    <label>Paciente</label>
                    <asp:DropDownList ID="ddlPacientes" runat="server" class="form-control">
                     <asp:ListItem Value="" Text="Selecione..."/>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label>Vacina</label>
                    <asp:DropDownList ID="ddlVacinas" runat="server" class="form-control">
                     <asp:ListItem Value="" Text="Selecione..."/>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label>Dosagem</label>
                    <asp:DropDownList ID="ddlDosagem" runat="server" class="form-control">
                      <asp:ListItem Value="0" Text="Selecione" Selected="True"></asp:ListItem>
                      <asp:ListItem Value="1º dosagem" Text="1º dosagem"></asp:ListItem>
                      <asp:ListItem Value="2º dosagem" Text="2º dosagem"></asp:ListItem>
                      <asp:ListItem Value="3º dosagem" Text="3º dosagem"></asp:ListItem>
                      <asp:ListItem Value="1º dosagem reforço" Text="1º dosagem reforço"></asp:ListItem>
                      <asp:ListItem Value="2º dosagem reforço" Text="2º dosagem reforço"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <asp:button id="btnSalvar" runat="server" text="Salvar" class="btn btn-success"  OnClick="btnSalvar_Click"/>
                <asp:button id="btnVoltar" runat="server" text="Voltar" class="btn btn-primary"  OnClick="btnVoltar_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
