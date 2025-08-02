using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstetiqueAdmWeb
{
    public partial class Form1 : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        int tipo = Convert.ToInt32(reader["id_tipo_usuario"]);

                        MessageBox.Show($"Bem-vindo, {nome}!");

                        // Abre a tela principal
                        Form1 telaPrincipal = new Form1();
                        telaPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMensagem.Text = "Email ou senha inválidos.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }
    }
    
}
