namespace Sistema_Eleitoral___Executivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSistemaEleitoral = new System.Windows.Forms.Label();
            this.btnCadastrarEleicao = new System.Windows.Forms.Button();
            this.btnAcessarEleicao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSistemaEleitoral
            // 
            this.lblSistemaEleitoral.AutoSize = true;
            this.lblSistemaEleitoral.Location = new System.Drawing.Point(94, 26);
            this.lblSistemaEleitoral.Name = "lblSistemaEleitoral";
            this.lblSistemaEleitoral.Size = new System.Drawing.Size(93, 15);
            this.lblSistemaEleitoral.TabIndex = 0;
            this.lblSistemaEleitoral.Text = "Sistema Eleitoral";
            // 
            // btnCadastrarEleicao
            // 
            this.btnCadastrarEleicao.Location = new System.Drawing.Point(12, 64);
            this.btnCadastrarEleicao.Name = "btnCadastrarEleicao";
            this.btnCadastrarEleicao.Size = new System.Drawing.Size(111, 37);
            this.btnCadastrarEleicao.TabIndex = 3;
            this.btnCadastrarEleicao.Text = "Cadastrar Eleição";
            this.btnCadastrarEleicao.UseVisualStyleBackColor = true;
            this.btnCadastrarEleicao.Click += new System.EventHandler(this.btnCadastrarEleicao_Click);
            // 
            // btnAcessarEleicao
            // 
            this.btnAcessarEleicao.Location = new System.Drawing.Point(147, 64);
            this.btnAcessarEleicao.Name = "btnAcessarEleicao";
            this.btnAcessarEleicao.Size = new System.Drawing.Size(121, 37);
            this.btnAcessarEleicao.TabIndex = 4;
            this.btnAcessarEleicao.Text = "Acessar Eleição";
            this.btnAcessarEleicao.UseVisualStyleBackColor = true;
            this.btnAcessarEleicao.Click += new System.EventHandler(this.btnAcessarEleicao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 115);
            this.Controls.Add(this.btnAcessarEleicao);
            this.Controls.Add(this.btnCadastrarEleicao);
            this.Controls.Add(this.lblSistemaEleitoral);
            this.Name = "Form1";
            this.Text = "Eleição - Executivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistemaEleitoral;
        private System.Windows.Forms.Button btnCadastrarEleicao;
        private System.Windows.Forms.Button btnAcessarEleicao;
    }

}
