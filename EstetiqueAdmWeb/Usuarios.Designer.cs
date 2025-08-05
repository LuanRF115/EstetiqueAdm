namespace EstetiqueAdmWeb
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(120, 57);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(548, 260);
            this.dataGridViewUsuarios.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Purple;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(282, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Usuarios Cadastrados";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Purple;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(137, 348);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 56);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Purple;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(495, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 56);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Purple;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(24, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 33);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstetiqueAdmWeb.Properties.Resources.ChatGPT_Image_4_de_ago__de_2025__23_10_14;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 455);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}