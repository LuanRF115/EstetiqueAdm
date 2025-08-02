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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpresas
            // 
            this.dataGridViewEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpresas.Location = new System.Drawing.Point(122, 46);
            this.dataGridViewEmpresas.Name = "dataGridViewEmpresas";
            this.dataGridViewEmpresas.Size = new System.Drawing.Size(548, 260);
            this.dataGridViewEmpresas.TabIndex = 0;
            this.dataGridViewEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(122, 339);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 56);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "button1";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(511, 339);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(159, 56);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "button2";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(315, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "label1";
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridViewEmpresas);
            this.Name = "Empresas";
            this.Text = "Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpresas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTitulo;
    }
}