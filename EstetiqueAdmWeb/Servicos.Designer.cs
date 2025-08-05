namespace EstetiqueAdmWeb
{
    partial class Servicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmpresaId = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto Cadastrados";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(41, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 31);
            this.txtNome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(41, 125);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 31);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(41, 175);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(201, 31);
            this.txtPreco.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(41, 222);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(201, 31);
            this.txtCategoria.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Purple;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Location = new System.Drawing.Point(553, 327);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(193, 74);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Purple;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizar.Location = new System.Drawing.Point(316, 327);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(193, 74);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Purple;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(49, 327);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(193, 74);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(41, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 31);
            this.txtId.TabIndex = 9;
            // 
            // txtEmpresaId
            // 
            this.txtEmpresaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresaId.Location = new System.Drawing.Point(41, 268);
            this.txtEmpresaId.Name = "txtEmpresaId";
            this.txtEmpresaId.Size = new System.Drawing.Size(201, 31);
            this.txtEmpresaId.TabIndex = 10;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(391, 292);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(201, 20);
            this.txtUrl.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Purple;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(563, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 33);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(276, 61);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(403, 212);
            this.pictureBoxImagem.TabIndex = 0;
            this.pictureBoxImagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstetiqueAdmWeb.Properties.Resources.ChatGPT_Image_4_de_ago__de_2025__23_10_14;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtEmpresaId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmpresaId;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}