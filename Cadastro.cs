using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        SqlConnection conexao = new SqlConnection("Server = CCH03LABF11\\SQLEXPRESS; Database = COLEGIO; Trusted_Connection = True;");

        public Cadastro()
        {
            InitializeComponent();
            comboBox1.Items.Add("Manhã");
            comboBox1.Items.Add("Tarde");
            comboBox1.Items.Add("Noite");
            panelResponsavel.Visible = false;
            btnCadastrarResponsavel.Visible = false;

            txtNomedep.Text = "asdf";
            txtSobrenomeDep.Text = "asdf";
            txtCpfAluno.Text = "1234";
            txtTelefoneDep.Text = "123465";
            txtEmailDep.Text = "as@afa";

        }

        public void limpaCamposAluno()
        {
            txtCpfAluno.Clear();
            txtCpfResponsavel.Clear();
            txtNome.Clear();
            txtNomedep.Clear();
            txtSobrenome.Clear();
            txtSobrenomeDep.Clear();
            txtTelefoneDep.Clear();
            txtEmailDep.Clear();
        }

        public void preencheAluno(SqlCommand comando, int maiorIdade)
        {
            

            comando.Parameters.AddWithValue("@NOME", txtNomedep.Text);
            comando.Parameters.AddWithValue("@SOBRENOME", txtSobrenomeDep.Text);
            comando.Parameters.AddWithValue("@CPF", txtCpfAluno.Text);
            comando.Parameters.AddWithValue("@DATANASCIMENTO", dateDataNascimento.Text.ToString());
            comando.Parameters.AddWithValue("@MAIORIDADE", maiorIdade);
            comando.Parameters.AddWithValue("@TURNO", comboBox1.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefoneDep.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmailDep.Text);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMatDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT INTO Aluno(NOME_ALUNO, SOBRENOME_ALUNO, CPF, DATA_NASCIMENTO, MAIOR_IDADE, TURNO, TELEFONE, EMAIL)" +
                " VALUES(@NOME, @SOBRENOME, @CPF, @DATANASCIMENTO, @MAIORIDADE,@TURNO, @TELEFONE, @EMAIL)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            string dataNascimento = dateDataNascimento.Text;
            string[] dataSeparada = dataNascimento.Split('/');
            int ano = int.Parse(dataSeparada[2]);
            DateTime date1 = DateTime.Now.Date;
            int anoAtual = date1.Year;
            int maiorIdade = 1;

            if (!txtEmailDep.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido");
                conexao.Close();
                return;
            }

            if ((anoAtual - ano) < 16)
            {
                panelResponsavel.Visible = true;
                btnCadastrarResponsavel.Visible = true;
                btnCadastrar.Visible = false;
                maiorIdade = 0;

            }

            else
            {
                conexao.Open();

                preencheAluno(comando, maiorIdade);
                MessageBox.Show("Aluno Cadastrado");

                comando.ExecuteNonQuery();

                conexao.Close();
                limpaCamposAluno();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Cadastro.ActiveForm.Hide();
            Menu menu = new Menu();
            menu.Show();

        }

        private void btnCadastrarResponsavel_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT INTO Aluno(NOME_ALUNO, SOBRENOME_ALUNO, CPF, DATA_NASCIMENTO, MAIOR_IDADE, TURNO, TELEFONE, EMAIL)" +
                " VALUES(@NOME, @SOBRENOME, @CPF, @DATANASCIMENTO, @MAIORIDADE,@TURNO, @TELEFONE, @EMAIL)";
            SqlCommand comando = new SqlCommand(strSQL, conexao);

            conexao.Open();
            preencheAluno(comando, 0);
            comando.ExecuteNonQuery();
            conexao.Close();

            string sqlResp = "INSERT INTO Responsavel(NOME_RESPONSAVEL, SOBRENOME_RESPONSAVEL, CPF, RN_MATRICULA, TELEFONE, EMAIL) " +
                "VALUES(@NOME, @SOBRENOME, @CPF, @RN_MATRICULA, @TELEFONE, @EMAIL)";
            SqlCommand comandoResp = new SqlCommand(sqlResp, conexao);

            if (!txtEmailResp.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido");
                return;
            }

            string strSelect = "SELECT RN_MATRICULA, CPF FROM ALUNO";
            SqlCommand select = new SqlCommand(strSelect, conexao);

            conexao.Open();
            var dataReader = select.ExecuteScalar();
            
            string rn = dataReader.ToString(); 

            comandoResp.Parameters.AddWithValue("@NOME", txtNome.Text);
            comandoResp.Parameters.AddWithValue("@SOBRENOME", txtSobrenome.Text);
            comandoResp.Parameters.AddWithValue("@CPF", txtCpfResponsavel.Text);
            comandoResp.Parameters.AddWithValue("@TELEFONE", txtTelefoneResp.Text);
            comandoResp.Parameters.AddWithValue("@EMAIL", txtEmailResp.Text);
            comandoResp.Parameters.AddWithValue("@RN_MATRICULA", rn);
            
            comandoResp.ExecuteNonQuery();
            MessageBox.Show("Aluno Cadastrado");

            limpaCamposAluno();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtCpfResponsavel.Clear();
            txtTelefoneResp.Clear();
            txtEmailResp.Clear();

            conexao.Close();
            
        }
    }
}
