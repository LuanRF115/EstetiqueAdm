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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(120, 57);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(548, 260);
            this.dataGridViewUsuarios.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(353, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "label1";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(137, 348);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 56);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "button1";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(495, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 56);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "button1";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(679, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 41);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "button1";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
    }
}