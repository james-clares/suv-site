<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="PM.cadastro" %>

<!DOCTYPE html>

<head runat="server">
    <title>Cadastro de Usuário</title>
    <link href="static/fonts/font-awesome.css" rel="stylesheet" />
    <link href="static/fonts/icon-font.min.css" rel="stylesheet" />
    <link href="static/fonts/material-design-iconic-font.min.css" rel="stylesheet" />
    <link href="static/css/login/main.css" rel="stylesheet" />
    <link href="static/css/login/util.css" rel="stylesheet" />
    <link href="static/css/sb-admin.css" rel="stylesheet" />
</head>
<style>
    .login100-form-btn{
        background-color: purple;
        cursor: pointer;
    }
    .imagem-centro img {
           background-repeat: no-repeat;
            background-position: center;
            position: absolute;
            width: 500px;
            height: 350px;
            z-index: 1;
            right: 53%;
            top: 27%;
    }
</style>
<body style="background-color: #999999;">
    <div class="limiter">
		<div class="container-login100">
			<div class="login100-more" style="background-image: url('static/images/imagem2.png');"></div>

            <div class="imagem-centro"><img src="static/images/imagem1.jpg"/></div>
			<div class="wrap-login100 p-l-50 p-r-50 p-t-72 p-b-50">
                 <form id="form1" class="login100-form validate-form" runat="server">
        
					<div class="col-md-6">
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Senha</label>
                    <asp:TextBox ID="txtSenha" required="" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>Nome</label>
                    <asp:TextBox ID="txtNome" required="" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-group">
                    <label>CPF</label>
                    <asp:TextBox ID="txtCpf" required="" runat="server" CssClass="form-control"></asp:TextBox>
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
            <div class="col-md-12">
                <div class="form-group">

                    <asp:Button ID="Button1" runat="server" Text="Salvar" class="btn btn-success" OnClick="btnCadastrarUsuario_Click" />
                </div>
            </div>
				</form>

                <p style="text-align:center; margin-top: 100px;"><a href="index.aspx">Já sou cadastrado</a></p>
			</div>
		</div>
	</div>
</body>