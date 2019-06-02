using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM.scripts.admin.usuarios
{
    public partial class inserir_vacina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarPacientes();
                CarregarVacinas();
            }
        }

        private void CarregarPacientes()
        {
            biblioteca.vacinas vacinaPaciente = new biblioteca.vacinas()
            {
                Codigo = "",
                Descricao = "Selecione..."
            };

            List<biblioteca.vacinas> vacinas = new List<biblioteca.vacinas>();

            DataSet ds = vacinaPaciente.RecuperarPaciente();
            DataRowCollection linhas = ds.Tables[0].Rows;

            vacinas.Add(vacinaPaciente);
            foreach (DataRow linha in linhas)
            {
                biblioteca.vacinas nova = new biblioteca.vacinas()
                {
                    Codigo = linha["idUsuario"].ToString(),
                    Descricao = linha["nome"].ToString()
                };
                vacinas.Add(nova);
            }

            ddlPacientes.DataValueField = "Codigo";
            ddlPacientes.DataTextField = "Descricao";
            ddlPacientes.DataSource = vacinas;
            ddlPacientes.DataBind();
        }

        private void CarregarVacinas()
        {
            biblioteca.vacinas vacinaPaciente = new biblioteca.vacinas()
            {
                Codigo = "",
                Descricao = "Selecione..."
            };

            List<biblioteca.vacinas> vacinas = new List<biblioteca.vacinas>();

            DataSet ds = vacinaPaciente.RecuperarVacina();
            DataRowCollection linhas = ds.Tables[0].Rows;

            vacinas.Add(vacinaPaciente);
            foreach (DataRow linha in linhas)
            {
                biblioteca.vacinas nova = new biblioteca.vacinas()
                {
                    Codigo = linha["idVacina"].ToString(),
                    Descricao = linha["nomeVacina"].ToString()
                };
                vacinas.Add(nova);
            }

            ddlVacinas.DataValueField = "Codigo";
            ddlVacinas.DataTextField = "Descricao";
            ddlVacinas.DataSource = vacinas;
            ddlVacinas.DataBind();
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string paciente = ddlPacientes.SelectedValue;
            string vacina = ddlVacinas.SelectedValue;
            string dosagem = ddlDosagem.SelectedValue;
            string idFunc = Session["idFunc"].ToString();

            biblioteca.vacinas inserirVacina = new biblioteca.vacinas();

            inserirVacina.CadastrarVacinasUsuario(vacina, paciente, dosagem, idFunc);
            Response.Redirect("/scripts/admin/usuarios/index.aspx");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/scripts/admin/usuarios/index.aspx");
        }
    }
}