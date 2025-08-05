using MySql.Data.MySqlClient;
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
    public partial class Empresas : Form
    {
        Database db = new Database();

        string connStr = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;


        private void CarregarEmpresas()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM empresas";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewEmpresas.DataSource = dt;
                dataGridViewEmpresas.Columns["id"].Visible = false;
            }
        }



        public Empresas()
        {
            InitializeComponent();

            CarregarEmpresas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpresas.SelectedRows.Count > 0)
            {
                var row = dataGridViewEmpresas.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nome = row.Cells["nome"].Value.ToString();
                string endereco = row.Cells["endereco"].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "UPDATE empresas SET nome = @nome, endereco = @endereco WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Empresa atualizada com sucesso!");
                CarregarEmpresas();
            }
            else
            {
                MessageBox.Show("Selecione uma empresa para atualizar.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpresas.SelectedRows.Count > 0)
            {
                var row = dataGridViewEmpresas.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Deseja excluir esta empresa?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM empresas WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Empresa excluída.");
                    CarregarEmpresas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma empresa para excluir.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
