using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario("Usuario", "1234");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usuario.comparaLogin(txtLogin.Text) && usuario.comparaSenha(txtSenha.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha incorreto");
            }


        }
    }
}

