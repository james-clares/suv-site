<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/masterpage/masterpage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PM.pt.perfil.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphConteudo" runat="server">
    <style>
        .p20 {
            padding: 20px;
        }
    </style>
    <link href="../../../static/css/conta/bootstrap.css" rel="stylesheet" />
    <div class ="container">
        <div class="camera-wrapper">
            <div id="camera" class="camera-wrap">
                 
                <img src="../../../static/images/banner-aba-paciente.jpg" style="width: 100%;"/>
            </div>
        </div>
        <div class="col-md-12">
            
                <div class="p20">
                   <h3>MINHAS VACINAS</h3>
                   <p>Nesta área você poderá visualizar o seu histórico de vacinas.</p>
                </div>

        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" style="width:100%;" cellspacing:"0">
                    <thead>
                        <tr>
                            <th><strong>Nome</strong></th>
                            <th><strong>Vacina</strong></th>
                            <th><strong>Lote</strong></th>
                            <th><strong>Dosagem</strong></th>
                            <th><strong>UF aplicador</strong></th>
                            <th><strong>Coren aplicador</strong></th>
                            <th><strong>Data Cadastro</strong></th>
                    </thead>
                    <tbody>
                        <asp:ListView runat="server" ID="lvListaUsuario" >
                            <ItemTemplate>
                                <tr>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrNomeUsuario" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrVacina" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrLote" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrDosagem" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrUf" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrCoren" /></td>
                                    <td><asp:Literal Text="text" runat="server"  ID="ltrDataCadastro"/><td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </tbody>
                </table>
            </div>
        </div>
       
    </div>
</asp:Content>
