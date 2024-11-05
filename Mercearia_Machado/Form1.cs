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
    public partial class frmMenu : Form
    {
        private DatabaseConnection dbConnection;
        FuncionarioRepository tabelaproprietario = new FuncionarioRepository();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrasenha_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrasenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '\0';
        }

        private void btnMostrasenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;
            bool loginvalido = tabelaproprietario.Login(nome, senha); 
            if (loginvalido)
            {
                MessageBox.Show("Bem Vindo ao Nosso Sistema: " + nome);
                frmTelaInicial abrimenu = new frmTelaInicial();
                abrimenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos");
            } 
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void txtLogin_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.PasswordChar = '\0';
        }
    }
}
