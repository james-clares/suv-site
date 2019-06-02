using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM.scripts.admin.vacinas
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSalvarVacina_Click(object sender, EventArgs e)
        {
            biblioteca.vacinas novaVacina = new biblioteca.vacinas();

            novaVacina.CadastraVacina(txtNome.Text, txtLote.Text);
            Response.Redirect("/scripts/admin/vacinas/index.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e) {
            Response.Redirect("/scripts/admin/vacinas/index.aspx");
        }
    }
}