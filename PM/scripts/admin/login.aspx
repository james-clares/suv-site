<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PM.scripts.admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../static/css/sb-admin.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body class="bg-dark">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Login</div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="txtEmail" required="" runat="server" CssClass="form-control"></asp:TextBox>
                            <label for="inputEmail">Email</label>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="txtSenha" required="" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <label for="inputPassword">Senha</label>
                        </div>
                    </div>
                        <asp:Button ID="btnLogin" runat="server" Text="Logar" class="btn btn-primary btn-block" OnClick="btnLogin_Click" />

                   
                </form>

            </div>
        </div>
    </div>
</body>
</html>
