namespace Sistema_Eleitoral___Executivo
{
    partial class Relatorio
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPreseidente = new System.Windows.Forms.Label();
            this.lbGovernador = new System.Windows.Forms.Label();
            this.lbPrefeito = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(238, 259);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(143, 49);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRESIDENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "GOVERNADOR ESTADUAL:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "PREFEITO:";
            // 
            // lbPreseidente
            // 
            this.lbPreseidente.AutoSize = true;
            this.lbPreseidente.Location = new System.Drawing.Point(129, 35);
            this.lbPreseidente.Name = "lbPreseidente";
            this.lbPreseidente.Size = new System.Drawing.Size(12, 15);
            this.lbPreseidente.TabIndex = 8;
            this.lbPreseidente.Text = "-";
            // 
            // lbGovernador
            // 
            this.lbGovernador.AutoSize = true;
            this.lbGovernador.Location = new System.Drawing.Point(189, 115);
            this.lbGovernador.Name = "lbGovernador";
            this.lbGovernador.Size = new System.Drawing.Size(12, 15);
            this.lbGovernador.TabIndex = 9;
            this.lbGovernador.Text = "-";
            // 
            // lbPrefeito
            // 
            this.lbPrefeito.AutoSize = true;
            this.lbPrefeito.Location = new System.Drawing.Point(93, 189);
            this.lbPrefeito.Name = "lbPrefeito";
            this.lbPrefeito.Size = new System.Drawing.Size(12, 15);
            this.lbPrefeito.TabIndex = 10;
            this.lbPrefeito.Text = "-";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(58, 259);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(143, 49);
            this.btnGerarRelatorio.TabIndex = 11;
            this.btnGerarRelatorio.Text = "Gerar Relatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 320);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.lbPrefeito);
            this.Controls.Add(this.lbGovernador);
            this.Controls.Add(this.lbPreseidente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPreseidente;
        private System.Windows.Forms.Label lbGovernador;
        private System.Windows.Forms.Label lbPrefeito;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}