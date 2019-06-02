using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;



namespace PM.biblioteca
{
    public class acessoSistema
    {
        public void CadastrarUsuario(string cpf, string nome, string senha, string email, string sexo, string dataNasc, string rg, string endereco, string cep, string telefone, string telefoneCel)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_usuario VALUES (@cpf, @nome, @senha, 1, @email, @sexo, @dataNasc, @rg, @endereco, @cep, @telefone, @telefoneCel, dateadd(hour,+3,getdate())";

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@dataNasc", dataNasc);
            cmd.Parameters.AddWithValue("@rg", rg);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@telefoneCel", telefoneCel);

            BancoDeDados.ExecutarComando(cmd);
        }


        public void CadastrarFuncionario(string cpf, string nome, string senha, string email, string coren, string uf)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "INSERT INTO pm_funcionario VALUES (@cpf, @nome, @senha, @email, @coren, @uf, dateadd(hour,+3,getdate())";

            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@coren", coren);
            cmd.Parameters.AddWithValue("@uf", uf);

            BancoDeDados.ExecutarComando(cmd);
        }

        public bool perfilPaciente(string cpf)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "SELECT 1 from pm_usuario join pm_perfil on pm_usuario.perfil_idPerfil = pm_perfil.idPerfil where pm_perfil.perfil = 'paciente' and pm_usuario.cpf= @cpf";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cpf", cpf);

            bool validarUsuario = false;

            string output = string.Empty;

            try
            {
                conn.Open();
                output = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {


            }

            if (output == "1")
            {
                validarUsuario = true;
                return validarUsuario;
            }

            return validarUsuario;

        }


        public bool perfilADM(string cpf)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "SELECT 1 from pm_usuario join pm_perfil on pm_usuario.perfil_idPerfil = pm_perfil.idPerfil where pm_perfil.perfil = 'adm' and pm_usuario.cpf= @cpf";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cpf", cpf);

            bool validarUsuario = false;

            string output = string.Empty;

            try
            {
                conn.Open();
                output = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {


            }

            if (output == "1")
            {
                validarUsuario = true;
                return validarUsuario;
            }

            return validarUsuario;
        }

        public bool acessoUsuario(string email, string senha)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "SELECT 1 FROM dbo.pm_usuario WHERE email = @email AND senha = @senha";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            bool validarUsuario = false;

            string output = string.Empty;

            try
            {
                conn.Open();
                output = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

            }


            if (output == "1")
            {
                validarUsuario = true;
                return validarUsuario;
            }

            return validarUsuario;


        }

        public bool acessoUsuarioAdm(string email, string senha)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            string sql = "SELECT 1 FROM dbo.pm_funcionario WHERE email = @email AND senha = @senha";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            bool validarUsuario = false;

            string output = string.Empty;

            try
            {
                conn.Open();
                output = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

            }


            if (output == "1")
            {
                validarUsuario = true;
                return validarUsuario;
            }

            return validarUsuario;


        }


        public string retornaNome(string email)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            conn.Open();

            string sql = "SELECT nome FROM dbo.pm_usuario WHERE email = @email";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            string nomePaciente = cmd.ExecuteScalar().ToString();

            return nomePaciente;
        }

        public string retornaIdUsuario(string email)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            conn.Open();

            string sql = "SELECT idUsuario FROM dbo.pm_usuario WHERE email = @email";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            string nomePaciente = cmd.ExecuteScalar().ToString();

            return nomePaciente;
        }

        public string retornaCoren(string email)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            conn.Open();

            string sql = "SELECT coren FROM dbo.pm_funcionario WHERE email = @email";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            string coren = cmd.ExecuteScalar().ToString();

            return coren;
        }

        public string retornaIdFuncionario(string email)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            conn.Open();

            string sql = "SELECT idFuncionario FROM dbo.pm_funcionario WHERE email = @email";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            string idFunc = cmd.ExecuteScalar().ToString();

            return idFunc;
        }

        public string retornaCPF(string email)
        {
            System.Data.SqlClient.SqlConnection conn = BancoDeDados.CriarConexao();

            conn.Open();

            string sql = "SELECT cpf FROM dbo.pm_usuario WHERE email = @email";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);

            string cpfPaciente = cmd.ExecuteScalar().ToString();

            return cpfPaciente;
        }

        public DataTable RetornarUsuariosVacinados()
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "SELECT u.nome, v.nomeVacina, uv.dosagem, uv.dataCadastro, f.uf, f.coren, v.lote FROM pm_usuario u " +
                              "INNER JOIN pm_usuario_vacina uv ON u.idUsuario = uv.fk_idUsuario " +
                              "INNER JOIN pm_vacinas v ON uv.fk_idVacina = v.idVacina " +
                              "INNER JOIN pm_funcionario f ON uv.fk_idFuncionario = f.idFuncionario",
                CommandType = CommandType.Text
            };

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;

        }

        public DataTable RetornarUsuarioVacinado(string idUsuario)
        {
            SqlConnection conn = BancoDeDados.CriarConexao();

            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "SELECT u.nome, v.nomeVacina, uv.dosagem, uv.dataCadastro, f.uf, f.coren, v.lote FROM pm_usuario u " +
                              "INNER JOIN pm_usuario_vacina uv ON u.idUsuario = uv.fk_idUsuario " +
                              "INNER JOIN pm_vacinas v ON uv.fk_idVacina = v.idVacina " +
                              "INNER JOIN pm_funcionario f ON uv.fk_idFuncionario = f.idFuncionario " +
                              "WHERE u.idUsuario = @idUsuario",
                CommandType = CommandType.Text


            };

            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            ad.Fill(dt);

            return dt;

        }
        public bool validarCpf(string cpf)
        {
            bool retorno = false;
            SqlConnection conn = BancoDeDados.CriarConexao();
            conn.Open();

            string sql = "SELECT cpf FROM dbo.pm_usuario where cpf='" + cpf + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            string cpfPaciente = cmd.ExecuteScalar().ToString();

            if (cpfPaciente != null)
            {
                retorno = true;
            }
            else
                retorno = false;

            return retorno;
        }
    }
}