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
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(406, 83);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(302, 179);
            this.pictureBoxImagem.TabIndex = 0;
            this.pictureBoxImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(41, 125);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(41, 175);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(201, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(41, 222);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(201, 20);
            this.txtCategoria.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(547, 308);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(193, 74);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "button1";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(318, 308);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(193, 74);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "button2";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(41, 308);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(193, 74);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(41, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtEmpresaId
            // 
            this.txtEmpresaId.Location = new System.Drawing.Point(41, 262);
            this.txtEmpresaId.Name = "txtEmpresaId";
            this.txtEmpresaId.Size = new System.Drawing.Size(201, 20);
            this.txtEmpresaId.TabIndex = 10;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(463, 268);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(201, 20);
            this.txtUrl.TabIndex = 11;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Servicos";
            this.Text = "Servicos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
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
    }
}