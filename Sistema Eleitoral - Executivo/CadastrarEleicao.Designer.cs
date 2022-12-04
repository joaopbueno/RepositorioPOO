namespace Sistema_Eleitoral___Executivo
{
    partial class CadastrarEleicao
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
            this.lblAnoEleicao = new System.Windows.Forms.Label();
            this.txtAnoEleicao = new System.Windows.Forms.TextBox();
            this.btnCadastrarEleicao = new System.Windows.Forms.Button();
            this.cmbTipoEleicao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnoEleicao
            // 
            this.lblAnoEleicao.AutoSize = true;
            this.lblAnoEleicao.Location = new System.Drawing.Point(12, 60);
            this.lblAnoEleicao.Name = "lblAnoEleicao";
            this.lblAnoEleicao.Size = new System.Drawing.Size(72, 15);
            this.lblAnoEleicao.TabIndex = 0;
            this.lblAnoEleicao.Text = "Ano Eleição:";
            // 
            // txtAnoEleicao
            // 
            this.txtAnoEleicao.Location = new System.Drawing.Point(90, 57);
            this.txtAnoEleicao.MaxLength = 4;
            this.txtAnoEleicao.Name = "txtAnoEleicao";
            this.txtAnoEleicao.Size = new System.Drawing.Size(122, 23);
            this.txtAnoEleicao.TabIndex = 1;
            this.txtAnoEleicao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoEleicao_KeyPress);
            // 
            // btnCadastrarEleicao
            // 
            this.btnCadastrarEleicao.Location = new System.Drawing.Point(127, 91);
            this.btnCadastrarEleicao.Name = "btnCadastrarEleicao";
            this.btnCadastrarEleicao.Size = new System.Drawing.Size(85, 23);
            this.btnCadastrarEleicao.TabIndex = 2;
            this.btnCadastrarEleicao.Text = "Cadastrar";
            this.btnCadastrarEleicao.UseVisualStyleBackColor = true;
            this.btnCadastrarEleicao.Click += new System.EventHandler(this.btnCadastrarEleicao_Click);
            // 
            // cmbTipoEleicao
            // 
            this.cmbTipoEleicao.AllowDrop = true;
            this.cmbTipoEleicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEleicao.FormattingEnabled = true;
            this.cmbTipoEleicao.Items.AddRange(new object[] {
            "Legislativo",
            "Executivo"});
            this.cmbTipoEleicao.Location = new System.Drawing.Point(91, 20);
            this.cmbTipoEleicao.Name = "cmbTipoEleicao";
            this.cmbTipoEleicao.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoEleicao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Eleicao:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 91);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(52, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastrarEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 126);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoEleicao);
            this.Controls.Add(this.btnCadastrarEleicao);
            this.Controls.Add(this.txtAnoEleicao);
            this.Controls.Add(this.lblAnoEleicao);
            this.Name = "CadastrarEleicao";
            this.Text = "CadastrarEleicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnoEleicao;
        private System.Windows.Forms.TextBox txtAnoEleicao;
        private System.Windows.Forms.Button btnCadastrarEleicao;
        private System.Windows.Forms.ComboBox cmbTipoEleicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}