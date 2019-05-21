using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            acessoSistema log = new acessoSistema();

            bool validarUsuario = log.acessoUsuario(txtEmail.Text, txtSenha.Text);

            if (validarUsuario)
            {
                acessoSistema nomePaciente = new acessoSistema();
                acessoSistema cpfPaciente = new acessoSistema();
                acessoSistema idUsuario = new acessoSistema();
                Session["nome"] = nomePaciente.retornaNome(txtEmail.Text);
                Session["cpf"] = cpfPaciente.retornaCPF(txtEmail.Text);
                Session["idUsuario"] = idUsuario.retornaIdUsuario(txtEmail.Text);
                Response.Redirect("/pt/index.aspx");
            }

            Response.Write("<script>alert('E-mail ou senha inválido(os)');</script>");

        }
    }
}