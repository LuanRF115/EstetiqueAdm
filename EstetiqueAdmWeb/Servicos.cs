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
    public partial class Servicos : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        public Servicos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Digite o ID do serviço para buscar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM servicos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNome.Text = reader["nome_servico"].ToString();
                        txtDescricao.Text = reader["descricao"].ToString();
                        txtPreco.Text = reader["preco"].ToString();
                        txtCategoria.Text = reader["categoria"].ToString();
                        txtEmpresaId.Text = reader["empresa_id"].ToString();
                        txtUrl.Text = reader["imagem_url"].ToString();

                        try
                        {
                            pictureBoxImagem.Load(txtUrl.Text);
                        }
                        catch
                        {
                            pictureBoxImagem.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Serviço não encontrado.");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja excluir este serviço?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "DELETE FROM servicos WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.ExecuteNonQuery();
                }

                LimparCampos();
                MessageBox.Show("Serviço excluído.");
            }  
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBoxImagem.Load(txtUrl.Text);
            }
            catch
            {
                pictureBoxImagem.Image = null;
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = @"UPDATE servicos 
                               SET nome_servico = @nome, descricao = @descricao, preco = @preco, 
                                   categoria = @categoria, empresa_id = @empresa_id, imagem_url = @imagem 
                               WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@empresa_id", txtEmpresaId.Text);
                cmd.Parameters.AddWithValue("@imagem", txtUrl.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Serviço atualizado com sucesso!");
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtCategoria.Clear();
            txtEmpresaId.Clear();
            txtUrl.Clear();
            pictureBoxImagem.Image = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
