<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/masterADM.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PM.scripts.admin.vacinas.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../../static/css/bootstrap/dataTables.bootstrap4.css" rel="stylesheet" />
    <div class="card mb-3">
        <div class="card-header">
            <i class="fas fa-table"></i>
            Vacinas
        </div>
        <div class="card-body">
            <div class="form-group">
                <div class="col-md-4">
                    <a href="cadastro.aspx"><div class="btn btn-success">Nova Vacina</div></a>
                    <!-- <div class="btn btn-danger">Deletar Vacina</div> -->
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
                            <th>Vacina</th>
                            <th>Lote</th>
                            <th>Data Cadastro</th>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Vacina</th>
                            <th>Lote</th>
                            <th>Data Cadastro</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <asp:ListView runat="server" ID="lvListaVacina" >
                            <ItemTemplate>
                                <tr>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrNomeVacina" /></td>
                                    <td><asp:Literal Text="text" runat="server" ID="ltrLote" /></td>
                                    <td> <asp:Literal Text="text" runat="server"  ID="ltrDataCadastro"/><td>
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
