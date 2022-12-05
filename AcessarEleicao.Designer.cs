namespace Sistema_Eleitoral___Executivo
{
    partial class AcessarEleicao
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
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.cbmTipoEleicao = new System.Windows.Forms.ComboBox();
            this.txtAnoEleicao = new System.Windows.Forms.TextBox();
            this.lblTipoEleicao = new System.Windows.Forms.Label();
            this.lblAnoEleicao = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Location = new System.Drawing.Point(243, 112);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(75, 43);
            this.btnGerenciar.TabIndex = 0;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // cbmTipoEleicao
            // 
            this.cbmTipoEleicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmTipoEleicao.FormattingEnabled = true;
            this.cbmTipoEleicao.Items.AddRange(new object[] {
            "Legislativo",
            "Executivo"});
            this.cbmTipoEleicao.Location = new System.Drawing.Point(93, 21);
            this.cbmTipoEleicao.Name = "cbmTipoEleicao";
            this.cbmTipoEleicao.Size = new System.Drawing.Size(217, 23);
            this.cbmTipoEleicao.TabIndex = 1;
            // 
            // txtAnoEleicao
            // 
            this.txtAnoEleicao.Location = new System.Drawing.Point(93, 54);
            this.txtAnoEleicao.MaxLength = 4;
            this.txtAnoEleicao.Name = "txtAnoEleicao";
            this.txtAnoEleicao.Size = new System.Drawing.Size(217, 23);
            this.txtAnoEleicao.TabIndex = 2;
            this.txtAnoEleicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoEleicao_KeyPress);
            // 
            // lblTipoEleicao
            // 
            this.lblTipoEleicao.AutoSize = true;
            this.lblTipoEleicao.Location = new System.Drawing.Point(17, 24);
            this.lblTipoEleicao.Name = "lblTipoEleicao";
            this.lblTipoEleicao.Size = new System.Drawing.Size(70, 15);
            this.lblTipoEleicao.TabIndex = 3;
            this.lblTipoEleicao.Text = "Tipo Eleicao";
            // 
            // lblAnoEleicao
            // 
            this.lblAnoEleicao.AutoSize = true;
            this.lblAnoEleicao.Location = new System.Drawing.Point(17, 57);
            this.lblAnoEleicao.Name = "lblAnoEleicao";
            this.lblAnoEleicao.Size = new System.Drawing.Size(69, 15);
            this.lblAnoEleicao.TabIndex = 4;
            this.lblAnoEleicao.Text = "Ano Eleicao";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(17, 112);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(100, 71);
            this.btnVotar.TabIndex = 5;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(243, 161);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(130, 112);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(100, 72);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // AcessarEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 196);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.lblAnoEleicao);
            this.Controls.Add(this.lblTipoEleicao);
            this.Controls.Add(this.txtAnoEleicao);
            this.Controls.Add(this.cbmTipoEleicao);
            this.Controls.Add(this.btnGerenciar);
            this.Name = "AcessarEleicao";
            this.Text = "AcessarEleicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.ComboBox cbmTipoEleicao;
        private System.Windows.Forms.TextBox txtAnoEleicao;
        private System.Windows.Forms.Label lblTipoEleicao;
        private System.Windows.Forms.Label lblAnoEleicao;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorio;
    }
}