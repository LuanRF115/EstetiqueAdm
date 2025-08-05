namespace EstetiqueAdmWeb
{
    partial class Empresas
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
            this.dataGridViewEmpresas = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(122, 65);
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(548, 260);
            this.dataGridViewEmpresas.TabIndex = 0;
            this.dataGridViewEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Purple;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizar.Location = new System.Drawing.Point(122, 357);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 56);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Purple;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(511, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 56);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Purple;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(276, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Empresas Cadastradas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Purple;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 33);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstetiqueAdmWeb.Properties.Resources.ChatGPT_Image_4_de_ago__de_2025__23_10_14;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridViewEmpresas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}