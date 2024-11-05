using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mercearia_Machado
{
    internal class FuncionarioRepository
    {
        private DatabaseConnection dbconnection;

        //iniciar a conexão
        public FuncionarioRepository()
        {
            dbconnection = new DatabaseConnection();
        }
        //Verificar o Login

        public bool Login(string login, string senha)
        {
            MySqlConnection connection = dbconnection.OpenConnection();
            if (connection == null)
            {
                return false;
            }

            string query = "SELECT * FROM proprietario WHERE Login=@Login AND Senha=@Senha";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Senha", senha);

                //confirmação da leitura
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    bool loginValido = reader.HasRows;
                    dbconnection.CloseConnection();
                    return loginValido;
                }

            }
        }

    }
}
