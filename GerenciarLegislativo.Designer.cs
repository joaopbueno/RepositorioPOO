namespace Sistema_Eleitoral___Executivo
{
    partial class GerenciarLegislativo
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
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrarLegislativo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipoCandidato
            // 
            this.lblTipoCandidato.AutoSize = true;
            this.lblTipoCandidato.Location = new System.Drawing.Point(28, 62);
            this.lblTipoCandidato.Name = "lblTipoCandidato";
            this.lblTipoCandidato.Size = new System.Drawing.Size(88, 15);
            this.lblTipoCandidato.TabIndex = 1;
            this.lblTipoCandidato.Text = "Tipo Candidato";
            // 
            // cmbTipoCandidato
            // 
            this.cmbTipoCandidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCandidato.FormattingEnabled = true;
            this.cmbTipoCandidato.Items.AddRange(new object[] {
            "Vereador ",
            "Deputado Estadual",
            "Deputado Federal"});
            this.cmbTipoCandidato.Location = new System.Drawing.Point(130, 59);
            this.cmbTipoCandidato.Name = "cmbTipoCandidato";
            this.cmbTipoCandidato.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoCandidato.TabIndex = 2;
            // 
            // lblNomeCandidato
            // 
            this.lblNomeCandidato.AutoSize = true;
            this.lblNomeCandidato.Location = new System.Drawing.Point(28, 104);
            this.lblNomeCandidato.Name = "lblNomeCandidato";
            this.lblNomeCandidato.Size = new System.Drawing.Size(96, 15);
            this.lblNomeCandidato.TabIndex = 3;
            this.lblNomeCandidato.Text = "Nome Completo";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(28, 139);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(45, 15);
            this.lblPartido.TabIndex = 5;
            this.lblPartido.Text = "Partido";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 176);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(130, 96);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(121, 23);
            this.txtNomeCompleto.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 173);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 23);
            this.txtNumero.TabIndex = 10;
            // 
            // btnCadastrarLegislativo
            // 
            this.btnCadastrarLegislativo.Location = new System.Drawing.Point(169, 216);
            this.btnCadastrarLegislativo.Name = "btnCadastrarLegislativo";
            this.btnCadastrarLegislativo.Size = new System.Drawing.Size(82, 35);
            this.btnCadastrarLegislativo.TabIndex = 11;
            this.btnCadastrarLegislativo.Text = "Cadastrar";
            this.btnCadastrarLegislativo.UseVisualStyleBackColor = true;
            this.btnCadastrarLegislativo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro de Candidato";
            // 
            // cmbPartido
            // 
            this.cmbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Items.AddRange(new object[] {
            "PT",
            "PSL",
            "PSDB",
            "MDB"});
            this.cmbPartido.Location = new System.Drawing.Point(130, 136);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(121, 23);
            this.cmbPartido.TabIndex = 14;
            this.cmbPartido.SelectedIndexChanged += new System.EventHandler(this.cmbPartido_SelectedIndexChanged);
            // 
            // GerenciarLegislativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.cmbPartido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrarLegislativo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblNomeCandidato);
            this.Controls.Add(this.cmbTipoCandidato);
            this.Controls.Add(this.lblTipoCandidato);
            this.Name = "GerenciarLegislativo";
            this.Text = "GerenciarLegislativo";
            this.Load += new System.EventHandler(this.GerenciarLegislativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCandidato;
        private System.Windows.Forms.ComboBox cmbTipoCandidato;
        private System.Windows.Forms.Label lblNomeCandidato;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCadastrarLegislativo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPartido;
    }
}