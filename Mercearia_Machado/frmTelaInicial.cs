using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_Machado
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adicionarProduto abrimenu = new adicionarProduto();
            abrimenu.ShowDialog();
        }

        private void adicionarProdutoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adicionarProduto abrimenu = new adicionarProduto();
            abrimenu.ShowDialog();
        }
    }
}
