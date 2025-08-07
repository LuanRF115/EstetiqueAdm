using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstetiqueAdmWeb
{
    public partial class Usuarios : Form
    {
        string connStr = "SERVER=localhost;DATABASE=bd_estetique;UID=root;PASSWORD=" +
            ";";
        private object dataGridViewEmpresas;

        public Usuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT id, nome, cpf, email, senha, endereco, telefone, id_tipo_usuario FROM usuarios";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsuarios.DataSource = dt;
                dataGridViewUsuarios.Columns["id"].Visible = false; 
            }
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewUsuarios.SelectedRows[0].Index;

                int id = Convert.ToInt32(dataGridViewUsuarios.Rows[rowIndex].Cells["id"].Value);
                string nome = dataGridViewUsuarios.Rows[rowIndex].Cells["nome"].Value.ToString();
                string cpf = dataGridViewUsuarios.Rows[rowIndex].Cells["cpf"].Value.ToString();
                string email = dataGridViewUsuarios.Rows[rowIndex].Cells["email"].Value.ToString();
                string senha = dataGridViewUsuarios.Rows[rowIndex].Cells["senha"].Value.ToString();
                string endereco = dataGridViewUsuarios.Rows[rowIndex].Cells["endereco"].Value.ToString();
                string telefone = dataGridViewUsuarios.Rows[rowIndex].Cells["telefone"].Value.ToString();
                int tipo = Convert.ToInt32(dataGridViewUsuarios.Rows[rowIndex].Cells["id_tipo_usuario"].Value);

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = @"UPDATE usuarios 
                                   SET nome = @nome, cpf = @cpf, email = @email, senha = @senha, 
                                       endereco = @endereco, telefone = @telefone, id_tipo_usuario = @tipo 
                                   WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário atualizado com sucesso!");
                CarregarUsuarios();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para atualizar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsuarios.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();

                        
                        string deleteAgendamentos = "DELETE FROM agendamentos WHERE consumidor_id = @id";
                        MySqlCommand cmdAg = new MySqlCommand(deleteAgendamentos, conn);
                        cmdAg.Parameters.AddWithValue("@id", id);
                        cmdAg.ExecuteNonQuery();

                        
                        string deleteUsuario = "DELETE FROM usuarios WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(deleteUsuario, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário excluído.");
                    CarregarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
