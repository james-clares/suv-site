<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PM.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="static/fonts/font-awesome.css" rel="stylesheet" />
    <link href="static/fonts/icon-font.min.css" rel="stylesheet" />
    <link href="static/fonts/material-design-iconic-font.min.css" rel="stylesheet" />
    <link href="static/css/login/main.css" rel="stylesheet" />
    <link href="static/css/login/util.css" rel="stylesheet" />

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
        
					<span class="login100-form-title p-b-59">
						Bem Vindo ao Portal!
					</span>

					<div class="wrap-input100 validate-input" data-validate = "E-mail inválido: ex@abc.xyz">
						<label class="label-input100">Email</label>
						<asp:TextBox ID="txtEmail" required="" runat="server" CssClass="form-control"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Senha inválida">
						<label class="label-input100">Senha</label>
						<asp:TextBox ID="txtSenha" required="" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

				

						<div class="wrap-login100-form-btn">
							
							<asp:Button ID="btnLogin" runat="server" Text="Logar" class="login100-form-btn" OnClick="btnLogin_Click"/>
						</div>

				</form>

                <p style="text-align:center; margin-top: 100px;"><a href="cadastro.aspx">Ainda não sou cadastrado</a></p>
			</div>
		</div>
	</div>
</body>
</html>
