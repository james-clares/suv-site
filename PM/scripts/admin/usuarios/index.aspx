<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PM.scripts.admin.usuarios.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../../static/css/bootstrap/dataTables.bootstrap4.css" rel="stylesheet" />
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Usuários
        </div>
        <div class="card-body">
           <div class="form-group">
              <div class="col-md-4">
               <a href="cadastro.aspx"><div class="btn btn-primary">Novo Usuario</div></a>
               <a href="inserir-vacina.aspx"><div class="btn btn-primary">Inserir Vacina</div></a>
               <a href="cadastro-funcionario.aspx"><div class="btn btn-primary">Novo Funcionário</div></a>
              </div>
           </div>
        </div>
    </div>
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Vacinas de usuários
        </div>
        <div class="card-body">
            <div class="table-responsive">
                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>Vacina</th>
                            <th>Lote</th>
                            <th>Dosagem</th>
                            <th>UF aplicador</th>
                            <th>Coren aplicador</th>
                            <th>Data Cadastro</th>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Nome</th>
                            <th>Vacina</th>
                            <th>Lote</th>
                            <th>Dosagem</th>
                            <th>UF aplicador</th>
                            <th>Coren aplicador</th>
                            <th>Data Cadastro</th>
                        </tr>
                    </tfoot>
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
    <script src="../../../static/js/jquery-3.0.0.min.js"></script>
    <script src="../../../static/js/jquery.dataTables.js"></script>
    <script src="../../../static/js/dataTables.bootstrap4.js"></script>
    <script src="../../../static/js/datatables-demo.js"></script>
</asp:Content>
