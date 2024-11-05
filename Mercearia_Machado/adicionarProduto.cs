using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_Machado
{
    public partial class adicionarProduto : Form
    {
        public void LiberaCampos()
        {
            //Desbloquear as coisas
            txtCodprod.Enabled = false;
            txtNomeproduto.Enabled = true;
            cbbSetorprod.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtCodprod.Enabled = false;
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
                codigo=int.Parse(txtCodprod.Text);
            }
            Produto produto = new Produto()
            {
                Nome = txtNomeproduto.Text.Trim(),
                Setor = cbbSetorprod.Text.Trim(),
                Descricao = txtDescricao.Text.Trim(),
                Valor = txtValor.Text.Trim(),

            };
            ProdutoSave salvar = new ProdutoSave();
            ProdutoUpdate atualizar = new ProdutoUpdate();
            if (codigo>0)
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LiberaCampos();
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
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
            LimpaCampos();
            LiberaCampos();
            //botões
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCodprod.Enabled=false;
        }
    }
    
}
