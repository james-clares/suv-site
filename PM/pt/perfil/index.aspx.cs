using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;
using System.Data;

namespace PM.pt.perfil
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lvListaUsuario.ItemDataBound += LvListaUsuario_ItemDataBound;
            ListarUsuariosVacinados();
        }

        private void LvListaUsuario_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            DataRow row = (DataRow)e.Item.DataItem;
            Literal ltrNomeUsuario = (Literal)e.Item.FindControl("ltrNomeUsuario");
            Literal ltrVacina = (Literal)e.Item.FindControl("ltrVacina");
            Literal ltrDosagem = (Literal)e.Item.FindControl("ltrDosagem");
            Literal ltrUf = (Literal)e.Item.FindControl("ltrUf");
            Literal ltrCoren = (Literal)e.Item.FindControl("ltrCoren");
            Literal ltrLote = (Literal)e.Item.FindControl("ltrLote");
            Literal ltrDataCadastro = (Literal)e.Item.FindControl("ltrDataCadastro");

            ltrNomeUsuario.Text = row["nome"].ToString();
            ltrVacina.Text = row["nomeVacina"].ToString();
            ltrLote.Text = row["lote"].ToString();
            ltrDosagem.Text = row["dosagem"].ToString();
            ltrUf.Text = row["uf"].ToString();
            ltrCoren.Text = row["coren"].ToString();
            ltrDataCadastro.Text = row["dataCadastro"].ToString();


        }

        protected void ListarUsuariosVacinados()
        {
            acessoSistema listaUsuario = new acessoSistema();

            string idUsuario = Session["idUsuario"].ToString();

            DataTable dt = listaUsuario.RetornarUsuarioVacinado(idUsuario);

            lvListaUsuario.DataSource = dt.Rows;

            lvListaUsuario.DataBind();




        }
    }
}