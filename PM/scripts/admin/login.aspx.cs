using PM.biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PM.scripts.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            acessoSistema log = new acessoSistema();

            bool validarUsuario = log.acessoUsuarioAdm(txtEmail.Text, txtSenha.Text);

            if (validarUsuario)
            { 
                acessoSistema coren = new acessoSistema();
                acessoSistema idFunc = new acessoSistema();
                Session["coren"] = coren.retornaCoren(txtEmail.Text);
                Session["idFunc"] = idFunc.retornaIdFuncionario(txtEmail.Text);
                Response.Redirect("/scripts/admin/index.aspx");
            }
            Response.Write("<script>alert('E-mail ou senha inválido(os)');</script>");
        }
    }
}