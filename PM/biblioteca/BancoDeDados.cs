﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace PM.biblioteca
{
    public class BancoDeDados
    {
        public static readonly String StringDeConexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;

        public static System.Data.SqlClient.SqlConnection CriarConexao()
        {
            return new SqlConnection(StringDeConexao);
        }

        public static int ExecutarComando(System.Data.IDbCommand cmd)
        {
            bool abriuConexao = false;
            int retorno;


            if (cmd.Connection.State == ConnectionState.Closed)
            {
                abriuConexao = true;
                cmd.Connection.Open();
            }


            retorno = cmd.ExecuteNonQuery();

            if (abriuConexao)
                cmd.Connection.Close();

            return retorno;
        }

        public static object RecuperarValor(System.Data.IDbCommand cmd)
        {
            bool abriuConexao = false;
            object retorno = new object();


            if (cmd.Connection.State == ConnectionState.Closed)
            {
                abriuConexao = true;
                cmd.Connection.Open();
            }


            retorno = cmd.ExecuteScalar();

            if (abriuConexao)
                cmd.Connection.Close();

            return retorno;
        }

        public static void PreencherDataSet(System.Data.DataSet ds, string nomeTabela, System.Data.IDbCommand cmd)
        {
            bool abriuConexao = false;



            if (cmd.Connection.State == ConnectionState.Closed)
            {
                abriuConexao = true;
                cmd.Connection.Open();
            }



            SqlDataAdapter adp = new SqlDataAdapter((SqlCommand)cmd);
            adp.Fill(ds, nomeTabela);

            if (abriuConexao)
                cmd.Connection.Close();
        }

    }
}