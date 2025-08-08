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
            if (dataGridViewEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma empresa para atualizar.");
                return;
            }

            // Garante que a última edição da célula foi aplicada
            dataGridViewEmpresas.EndEdit();

            var row = dataGridViewEmpresas.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string nome = row.Cells["nome"].Value?.ToString() ?? "";
            string endereco = row.Cells["endereco"].Value?.ToString() ?? "";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE empresas SET nome = @nome, endereco = @endereco WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empresa atualizada com sucesso!");
            CarregarEmpresas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma empresa para excluir.");
                return;
            }

            var row = dataGridViewEmpresas.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["id"].Value);

            var confirm = MessageBox.Show(
                "Deseja excluir esta empresa e todos os vínculos (serviços e agendamentos)?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm != DialogResult.Yes) return;

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Apagar agendamentos que dependem dos serviços da empresa
                        // (ajuste o nome das colunas conforme seu schema)
                        string deleteAg = @"
                    DELETE a FROM agendamentos a
                    INNER JOIN servicos s ON s.id = a.servico_id
                    WHERE s.empresa_id = @empresaId;
                ";
                        using (var cmdAg = new MySqlCommand(deleteAg, conn, tx))
                        {
                            cmdAg.Parameters.AddWithValue("@empresaId", id);
                            cmdAg.ExecuteNonQuery();
                        }

                        // 2) Apagar serviços da empresa
                        string deleteSrv = "DELETE FROM servicos WHERE empresa_id = @empresaId;";
                        using (var cmdSrv = new MySqlCommand(deleteSrv, conn, tx))
                        {
                            cmdSrv.Parameters.AddWithValue("@empresaId", id);
                            cmdSrv.ExecuteNonQuery();
                        }

                        // 3) Apagar a empresa
                        string deleteEmp = "DELETE FROM empresas WHERE id = @id;";
                        using (var cmdEmp = new MySqlCommand(deleteEmp, conn, tx))
                        {
                            cmdEmp.Parameters.AddWithValue("@id", id);
                            cmdEmp.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        tx.Rollback();
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                        return;
                    }
                }
            }

            MessageBox.Show("Empresa excluída com sucesso.");
            CarregarEmpresas();
        }

            

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
