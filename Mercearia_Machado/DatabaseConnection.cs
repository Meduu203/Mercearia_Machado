using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mercearia_Machado
{
    internal class DatabaseConnection
    {
        //define o Endereço onde o banco de dados esta alocado
        //server = é o local do banco
        //Database = nome o banco
        //Uid = usuario admin do banco e Pwd senha do usuario admin do bd
        private string connectionString = "Server=Localhost;Database=bar;Uid=root;Pwd=;";

        //crie uma variavel para conexão
        private MySqlConnection connection;

        public MySqlConnection OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao Abrir Conexão: " + ex.Message);
                return null;

            }
        }

        //metodo para fechar o banco
        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
