using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PrjEscola
{
    class Conexao
    {
        //Declare o objeto de conexão passando como parâmetro a string de conexão
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=Bd_Escola.accdb";
        // variável que representa a conexão com o banco
        private static OleDbConnection conn = null;
        //***********************************
        // método que permite obter a conexão
        public static OleDbConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new OleDbConnection(connString);
            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!!");
                // ops! o que aconteceu?

                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }
            return conn;
        }
        //***********************************
        // método que permite fechar a conexão
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
