using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            acessoSistema usuario = new acessoSistema();

            string genero = ddlGenero.SelectedValue;

            if (usuario.validarCpf(txtCpf.Text))
            {
                Response.Write("<script>alert('Já existe um cadastro com este CPF!');</script>");
            }
            else
            {
                usuario.CadastrarUsuario(txtCpf.Text, txtNome.Text, txtSenha.Text, txtEmail.Text, genero, txtDataNasc.Text, txtRg.Text, txtEndereco.Text, txtCep.Text, txtTelefone.Text, txtCel.Text);

                Response.Redirect("index.aspx");
                Response.Write("<script>alert('Cadastro realizado!');</script>");
            }
        }
    }
}