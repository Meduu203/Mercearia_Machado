using Mercearia_Machado;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

public class ProdutoSave
{
    private DatabaseConnection dbconnection;

    public ProdutoSave()
    {
        //conexao com banco de dados
        dbconnection = new DatabaseConnection();
    }
    public bool SalvarProduto(Produto produto)
    {
        //programa lê se ja tem dados iguais salvo 
        MySqlConnection connection = dbconnection.OpenConnection();
        if (connection == null)
        {
            return false;
        }
        //string de inserção no sql
        string query = @"INSERT INTO produto (Nome,Setor,Descricao,Valor)
                        VALUES
                        (@Nome,@Setor,@Descricao,@Valor)";
        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@Nome", produto.Nome);
            cmd.Parameters.AddWithValue("@Setor", produto.Setor);
            cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
            cmd.Parameters.AddWithValue("@Valor", produto.Valor);


            //tratamento de erro, se tentar salvar, salva certinho, se der algum erro, retorna qual é o erro pro usuario, facilitando pra quem for resolver
            try
            {
                cmd.ExecuteNonQuery();
                dbconnection.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as informações " + ex.Message);
                dbconnection.CloseConnection();
                return false;
            }


        }
    }
}