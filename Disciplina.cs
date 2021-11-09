using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Disciplina : Form
    {
        SqlConnection conexao = new SqlConnection("Server = CCH03LABF11\\SQLEXPRESS; Database = COLEGIO; Trusted_Connection = True;");
        public Disciplina()
        {
            InitializeComponent();

            listBox1.Items.Clear();

            string selec = "SELECT NOME FROM Disciplina";
            SqlCommand comando = new SqlCommand(selec, conexao);

            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                listBox1.Items.Add("Nome: " + dataReader[0]);
            }
            conexao.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT INTO Disciplina(NOME) VALUES(@NOME)";
            SqlCommand comando = new SqlCommand(strSQL, conexao);

            conexao.Open();
            comando.Parameters.AddWithValue("@NOME", txtDisciplina.Text);

            comando.ExecuteNonQuery();

            conexao.Close();

            txtDisciplina.Clear();

        }
    }
}
