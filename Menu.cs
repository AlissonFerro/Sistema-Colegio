using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {

        Lista listar = new Lista();
        //Menu menu = new Menu();


        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Buscar buscar = new Buscar();
            buscar.Show();
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = new Disciplina();
            disciplina.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }
    }
}
