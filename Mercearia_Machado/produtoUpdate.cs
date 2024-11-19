using System;
using System.Windows.Forms;
using Mercearia_Machado;
using MySql.Data.MySqlClient;

public class ProdutoUpdate
{
    private DatabaseConnection dbconnection;
    public ProdutoUpdate()
    {
        dbconnection = new DatabaseConnection();
    }
    public bool AtualizaProduto(Produto produto)
    {
        try
        {
            using(MySqlConnection connection = dbconnection.OpenConnection())
            {
                if (connection == null)
                {
                    return false;
                }

                string query = @"UPDATE Produto
                SET
                Nome=@Nome, Setor=@Setor, Descricao=@Descricao, Valor=@Valor, Imagem=@Imagem
                WHERE Cod=@Cod";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cod", produto.Cod);
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Setor", produto.Setor);
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@Valor", produto.Valor);
                    command.Parameters.AddWithValue("@Imagem", produto.Imagem);




                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Não foi possível salvar " + ex);
            return false;
        }
    }
}