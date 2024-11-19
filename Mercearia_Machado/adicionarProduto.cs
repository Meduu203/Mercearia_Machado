using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_Machado
{
    public partial class adicionarProduto : Form
    {
        private DatabaseConnection dbconnections = new DatabaseConnection();
        public void LiberaCampos()
        {
            //Desbloquear as coisas
            txtCodprod.Enabled = false;
            txtNomeproduto.Enabled = true;
            cbbSetorprod.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            btnCarregarImagem.Enabled = true;
        }
        public Produto BuscarProdPeloCod(int codigo)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (MySqlConnection connection = dbConnection.OpenConnection())
            {
                if (connection == null) return null;

                string query = "SELECT Nome, Setor, Descricao, Valor, Imagem FROM produto WHERE Cod = @Cod";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Cod", codigo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Produto produto = new Produto
                            {
                                Cod = codigo,
                                Nome = reader["Nome"].ToString(),
                                Setor = reader["Setor"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                Valor = reader["Valor"].ToString(),
                                Imagem = reader["Imagem"] as byte[]
                            };
                            return produto;
                        }
                        else
                        {
                            return null; // Produto não encontrado
                        }
                    }
                }
            }
        }
        public void TravaCampos()
        {
            //Desbloquear as coisas
            txtCodprod.Enabled = false;
            txtNomeproduto.Enabled = false;
            cbbSetorprod.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled=false;
            btnPesquisaCod.Enabled = false;
        }
        public void PesquisarCampos()
        {
            //deixar somente o campo COD ativo pra pesquisar e trazer o produto
            txtCodprod.Enabled = true;
            txtNomeproduto.Enabled = false;
            cbbSetorprod.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            label2.Enabled = true;
        }
        public adicionarProduto()
        {
            InitializeComponent();
        }
        public void LimpaCampos()
        {
            txtCodprod.Text = string.Empty;
            txtNomeproduto.Text = string.Empty;
            cbbSetorprod.Text = string.Empty;
            txtValor.Text = string.Empty;
            pictureBoxImagem.Image = null;
            txtDescricao.Text = string.Empty;
            

        }




        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (txtCodprod.Text == string.Empty)
            {
                codigo = 0;
            }
            else
            {
                codigo = int.Parse(txtCodprod.Text);
            }
            // Converte a imagem do PictureBox para byte array
            byte[] imagemProduto = null;
            if (pictureBoxImagem.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxImagem.Image.Save(ms, pictureBoxImagem.Image.RawFormat);
                    imagemProduto = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de salvar.");
                return;
            }

            Produto produto = new Produto()
            {
                Nome = txtNomeproduto.Text.Trim(),
                Setor = cbbSetorprod.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),
                Valor = txtValor.Text.Trim(),
                Imagem = imagemProduto // Atribui a imagem convertida
            };
            ProdutoSave salvar = new ProdutoSave();
            ProdutoUpdate atualizar = new ProdutoUpdate();
            if (codigo > 0)
            {
                produto.Cod = codigo;
                if (atualizar.AtualizaProduto(produto))
                {
                    MessageBox.Show("Salvo com Sucesso!");
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao salvar!");
                }
            }
            else
            {
                if (salvar.SalvarProduto(produto))
                {
                    MessageBox.Show("Produto adicionado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao salvar!");
                }
            }
            // Valida se uma imagem foi carregada
            if (pictureBoxImagem.Image == null)
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de salvar.");
                return;
            }


          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCarregarImagem.Enabled = false;
            btnNovo.Enabled = true;
            PesquisarCampos();
            btnSalvar.Enabled = false;
            btnPesquisaCod.Enabled = true;
            btnPesquisaCod.Visible = true;
            LimpaCampos();
            txtCodprod.Focus();
            btnEditar.Enabled = true;
            btnEditar.Visible = true;
            btnAtualizarProd.Enabled = false;
            btnAtualizarProd.Visible = false;
            lblValor.Visible = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblValor.Visible = true;
            LimpaCampos();
            LiberaCampos();
            //botões
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnCarregarImagem.Enabled = true;
            btnAtualizarProd.Enabled = false;
            cbbSetorprod.Text = string.Empty;
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodprod.Enabled = false;
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância de OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtra o tipo de arquivos para mostrar apenas imagens
                openFileDialog.Filter = "Arquivos de imagem (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Selecione uma imagem";

                // Verifica se o usuário selecionou um arquivo e clicou em "OK"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Carrega a imagem selecionada no PictureBox
                    pictureBoxImagem.Image = new Bitmap(openFileDialog.FileName);
                    pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta a imagem ao tamanho do PictureBox
                }
            }

        }

        private void adicionarProduto_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCarregarImagem.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;
            TravaCampos();

            
        }

        private void btnPesquisaCod_Click(object sender, EventArgs e)
        {
            // Desabilita o botão de salvar e habilita o botão de atualizar
            btnSalvar.Enabled=false;
            btnEditarProd.Enabled = true;
            btnEditarProd.Visible = true;
            // Verifica se o código inserido é um número válido
            int codigo = int.Parse(txtCodprod.Text);
            Produto prodAtual= new Produto();

            // Preenche os campos com os dados do produto
            prodAtual = BuscarProdPeloCod(codigo);
                txtCodprod.Text = prodAtual.Cod.ToString();
                txtDescricao.Text = prodAtual.Descricao.ToString();
                txtNomeproduto.Text = prodAtual.Nome.ToString();
                txtValor.Text = prodAtual.Valor.ToString();
                cbbSetorprod.Text = prodAtual.Setor.ToString();
            // Exibe a imagem, se existir
            if (prodAtual.Imagem != null && prodAtual.Imagem.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(prodAtual.Imagem))
                    {
                        pictureBoxImagem.Image = Image.FromStream(ms);
                        pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o tamanho
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao exibir a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBoxImagem.Image = null; // Limpa o PictureBox em caso de erro
                }
            }
            else
            {
                pictureBoxImagem.Image = null; // Limpa o PictureBox se não houver imagem
            }

            btnPesquisaCod.Enabled = false;
        }

        private void btnAtualizarProd_Click(object sender, EventArgs e)
        {
            int codigo;
            // Converte a imagem do PictureBox para byte array
            byte[] imagemProduto = null;
            if (pictureBoxImagem.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxImagem.Image.Save(ms, pictureBoxImagem.Image.RawFormat);
                    imagemProduto = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Por favor, carregue uma imagem antes de salvar.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Por favor, insira um valor para o produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus(); // Coloca o foco no campo Valor
                return; // Cancela o processamento do botão salvar
            }

            // Verifica se o valor inserido é numérico
            if (!decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("O valor inserido é inválido. Por favor, insira um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus(); // Coloca o foco no campo Valor
                return; // Cancela o processamento do botão salvar
            }
            Produto produto = new Produto()
            {
                Nome = txtNomeproduto.Text.Trim(),
                Setor = cbbSetorprod.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),
                Valor = txtValor.Text.Trim(),
                Imagem = imagemProduto // Atribui a imagem convertida
            };
            if (txtCodprod.Text == string.Empty)
            {
                codigo = 0;
            }
            else
            {
                codigo = int.Parse(txtCodprod.Text);
            }
            ProdutoUpdate atualizar = new ProdutoUpdate();
            if (codigo > 0)
            {
                produto.Cod = codigo;
                if (atualizar.AtualizaProduto(produto))
                {
                    MessageBox.Show("Atualizado com Sucesso!");
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar!");
                }
            }

            TravaCampos();
            btnAtualizarProd.Visible = false;
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            btnAtualizarProd.Enabled = true;
            btnAtualizarProd.Visible = true;
            btnEditarProd.Enabled = false;
            btnEditarProd.Visible = false;
            LiberaCampos();
            lblValor.Visible = true;

        }
    }
}
