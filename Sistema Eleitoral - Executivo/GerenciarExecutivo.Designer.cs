namespace Sistema_Eleitoral___Executivo
{
    partial class GerenciarExecutivo
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
            this.lblTipoCandidato = new System.Windows.Forms.Label();
            this.cmbTipoCandidato = new System.Windows.Forms.ComboBox();
            this.lblNomeCandidato = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipoCandidato
            // 
            this.lblTipoCandidato.AutoSize = true;
            this.lblTipoCandidato.Location = new System.Drawing.Point(26, 77);
            this.lblTipoCandidato.Name = "lblTipoCandidato";
            this.lblTipoCandidato.Size = new System.Drawing.Size(88, 15);
            this.lblTipoCandidato.TabIndex = 0;
            this.lblTipoCandidato.Text = "Tipo Candidato";
            // 
            // cmbTipoCandidato
            // 
            this.cmbTipoCandidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCandidato.FormattingEnabled = true;
            this.cmbTipoCandidato.Items.AddRange(new object[] {
            "Presidente",
            "Governador Estadual",
            "Prefeito"});
            this.cmbTipoCandidato.Location = new System.Drawing.Point(136, 74);
            this.cmbTipoCandidato.Name = "cmbTipoCandidato";
            this.cmbTipoCandidato.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoCandidato.TabIndex = 1;
            this.cmbTipoCandidato.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCandidato_SelectedIndexChanged);
            // 
            // lblNomeCandidato
            // 
            this.lblNomeCandidato.AutoSize = true;
            this.lblNomeCandidato.Location = new System.Drawing.Point(26, 110);
            this.lblNomeCandidato.Name = "lblNomeCandidato";
            this.lblNomeCandidato.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCandidato.TabIndex = 2;
            this.lblNomeCandidato.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(136, 107);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(121, 23);
            this.txtNomeCompleto.TabIndex = 3;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(26, 176);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(45, 15);
            this.lblPartido.TabIndex = 4;
            this.lblPartido.Text = "Partido";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 205);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numero";
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(136, 173);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(121, 23);
            this.txtPartido.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(136, 202);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 23);
            this.txtNumero.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(151, 249);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 34);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(26, 263);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(67, 20);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro de Candidato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(136, 139);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(121, 23);
            this.txtIdade.TabIndex = 12;
            // 
            // GerenciarExecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 295);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCandidato);
            this.Controls.Add(this.cmbTipoCandidato);
            this.Controls.Add(this.lblTipoCandidato);
            this.Name = "GerenciarExecutivo";
            this.Text = "GerenciarExecutivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCandidato;
        private System.Windows.Forms.ComboBox cmbTipoCandidato;
        private System.Windows.Forms.Label lblNomeCandidato;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdade;
    }
}