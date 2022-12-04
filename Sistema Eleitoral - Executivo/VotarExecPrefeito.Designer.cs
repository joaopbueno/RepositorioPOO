namespace Sistema_Eleitoral___Executivo
{
    partial class VotarExecPrefeito
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
            this.lblDpFederal = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnNulo = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDpFederal
            // 
            this.lblDpFederal.AutoSize = true;
            this.lblDpFederal.Location = new System.Drawing.Point(178, 100);
            this.lblDpFederal.Name = "lblDpFederal";
            this.lblDpFederal.Size = new System.Drawing.Size(12, 15);
            this.lblDpFederal.TabIndex = 35;
            this.lblDpFederal.Text = "-";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(119, 64);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(131, 23);
            this.txtVoto.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "PREFEITO";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirma.Location = new System.Drawing.Point(54, 191);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(260, 50);
            this.btnConfirma.TabIndex = 32;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Red;
            this.btnCorrige.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrige.Location = new System.Drawing.Point(236, 132);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(96, 42);
            this.btnCorrige.TabIndex = 31;
            this.btnCorrige.Text = "Corrige";
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnNulo
            // 
            this.btnNulo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNulo.Location = new System.Drawing.Point(139, 132);
            this.btnNulo.Name = "btnNulo";
            this.btnNulo.Size = new System.Drawing.Size(91, 42);
            this.btnNulo.TabIndex = 30;
            this.btnNulo.Text = "Nulo";
            this.btnNulo.UseVisualStyleBackColor = false;
            this.btnNulo.Click += new System.EventHandler(this.btnNulo_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBranco.Location = new System.Drawing.Point(47, 132);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(86, 42);
            this.btnBranco.TabIndex = 29;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // VotarExecPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 266);
            this.Controls.Add(this.lblDpFederal);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnCorrige);
            this.Controls.Add(this.btnNulo);
            this.Controls.Add(this.btnBranco);
            this.Name = "VotarExecPrefeito";
            this.Text = "VotarExecPrefeito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDpFederal;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Button btnNulo;
        private System.Windows.Forms.Button btnBranco;
    }
}