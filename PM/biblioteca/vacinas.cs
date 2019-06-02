using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PM.biblioteca
{
    public class vacinas
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public DataSet RecuperarPaciente()
        {
            string sql = "SELECT * FROM pm_usuario ORDER BY nome";

            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, biblioteca.BancoDeDados.CriarConexao());

            DataSet dsPaciente = new System.Data.DataSet();

            BancoDeDados.PreencherDataSet(dsPaciente, "Pacientes", cmd);

            return dsPaciente;
        }

        public DataSet RecuperarVacina()
        {
            string sql = "SELECT * FROM pm_vacinas ORDER BY nomeVacina";

            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, biblioteca.BancoDeDados.CriarConexao());

            DataSet dsVacina = new System.Data.DataSet();

            BancoDeDados.PreencherDataSet(dsVacina, "Vacinas", cmd);

            return dsVacina;
        }

        public void CadastraVacina(string nome, string lote)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_vacinas VALUES (@nome, dateadd(hour,+3,getdate()), @lote)";

            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@lote", lote);
            BancoDeDados.ExecutarComando(cmd);

        }

        public void CadastrarVacinasUsuario(string vacina, string paciente, string dosagem, string idFunc)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_usuario_vacina VALUES (@vacina, @paciente, dateadd(hour,+3,getdate()), @dosagem, @idFunc)";

            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);           

            cmd.Parameters.AddWithValue("@vacina", vacina);
            cmd.Parameters.AddWithValue("@paciente", paciente);
            cmd.Parameters.AddWithValue("@dosagem", dosagem);
            cmd.Parameters.AddWithValue("@idFunc", idFunc);

            BancoDeDados.ExecutarComando(cmd);
        }

        public DataTable RetornarVacinas()
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "SELECT nomeVacina, lote, dataCadastro from pm_vacinas",
                CommandType = CommandType.Text
            };

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
    }
}