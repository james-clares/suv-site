using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;
using System.Data;
namespace PM.scripts.admin.vacinas
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lvListaVacina.ItemDataBound += LvListaVacina_ItemDataBound;
            ListarVacinas();
        }

        private void LvListaVacina_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            DataRow row = (DataRow)e.Item.DataItem;
            Literal ltrNomeVacina = (Literal)e.Item.FindControl("ltrNomeVacina");
            Literal ltrLote = (Literal)e.Item.FindControl("ltrLote");
            Literal ltrDataCadastro = (Literal)e.Item.FindControl("ltrDataCadastro");

            ltrNomeVacina.Text = row["nomeVacina"].ToString();
            ltrLote.Text = row["lote"].ToString();
            ltrDataCadastro.Text = row["dataCadastro"].ToString();
        }

        protected void ListarVacinas()
        {
            biblioteca.vacinas acesso = new biblioteca.vacinas();            
            DataTable dt = acesso.RetornarVacinas();
            lvListaVacina.DataSource = dt.Rows;
            lvListaVacina.DataBind();
        }
    }
}