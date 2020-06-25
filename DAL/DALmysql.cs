using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PROJETOMVCB21.DAL
{
    public class DALmysql
    {
      private  string string_conexao = "Persist Security info=false; server=localhost;database=PROJETOMVCB21;user=root;password=1234;";
        private MySqlConnection conexao;
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch(MySqlException e)
            {
                throw new Exception("Problemas an conexão com o Banco de Dados" + e.Message);
            }
        }
        public void executarcomando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel executar a instrução no Banco de dados" + e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
        //metodo da clasae que retorna dados do banco
        public DataTable executarconsulta(string sql)
        {
            try
            { conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);

                dados.Fill(dt);
                return dt;

            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel executar a consulta no Banco de dados" + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}