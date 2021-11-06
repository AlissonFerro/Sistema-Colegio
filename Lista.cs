using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Lista : Form
    {

        SqlConnection conexao = new SqlConnection("Server = CCH03LABF11\\SQLEXPRESS; Database = COLEGIO; Trusted_Connection = True;");
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            string selec = "SELECT * FROM ALUNO";
            SqlCommand comando = new SqlCommand(selec, conexao);

            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                string[] somenteData = dataReader[3].ToString().Split(' ');
                listBox.Items.Add("Nome: " + dataReader[0] + " Sobrenome: " + dataReader[1] + " CPF: " + dataReader[2] + " Data de nascimento: " + somenteData[0]);

            }
            conexao.Close();

        }

        private void btnListarResp_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string selec = "SELECT * FROM RESPONSAVEL";
            SqlCommand comando = new SqlCommand(selec, conexao);

            conexao.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                listBox.Items.Add(dataReader[0] + " - " + dataReader[1] + " - " + dataReader[2]);

            }
            conexao.Close();
        }
    }
}
