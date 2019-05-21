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

        public System.Data.DataSet RecuperarPaciente()
        {
            string sql = "SELECT * FROM pm_usuario ORDER BY nome";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, biblioteca.BancoDeDados.CriarConexao());

            System.Data.DataSet dsPaciente = new System.Data.DataSet();

            biblioteca.BancoDeDados.PreencherDataSet(dsPaciente, "Pacientes", cmd);

            return dsPaciente;
        }

        public System.Data.DataSet RecuperarVacina()
        {
            string sql = "SELECT * FROM pm_vacinas ORDER BY nomeVacina";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, biblioteca.BancoDeDados.CriarConexao());

            System.Data.DataSet dsVacina = new System.Data.DataSet();

            biblioteca.BancoDeDados.PreencherDataSet(dsVacina, "Vacinas", cmd);

            return dsVacina;
        }

        public void CadastraVacina(string nome, string lote)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_vacinas VALUES (@nome, GETDATE(), @lote)";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@lote", lote);


            BancoDeDados.ExecutarComando(cmd);

        }

        public void CadastrarVacinasUsuario(string vacina, string paciente, string dosagem, string idFunc)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_usuario_vacina VALUES (@vacina, @paciente, GETDATE(), @dosagem, @idFunc)";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@vacina", vacina);
            cmd.Parameters.AddWithValue("@paciente", paciente);
            cmd.Parameters.AddWithValue("@dosagem", dosagem);
            cmd.Parameters.AddWithValue("@idFunc", idFunc);


            BancoDeDados.ExecutarComando(cmd);

        }

        public DataTable RetornarVacinas()
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

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