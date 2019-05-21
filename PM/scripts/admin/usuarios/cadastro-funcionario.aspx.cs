using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM.scripts.admin.usuarios
{
    public partial class cadastro_funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {

            acessoSistema func = new acessoSistema();

            string uf = ddlUf.SelectedValue;

            func.CadastrarFuncionario(txtCpf.Text, txtNome.Text, txtSenha.Text, txtEmail.Text, txtCoren.Text, uf);



        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/scripts/admin/usuarios/index.aspx");
        }

    }
}