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
            

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.Show();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empresas formUsuarios = new Empresas();
            formUsuarios.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servicos formUsuarios = new Servicos();
            formUsuarios.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
    
}
