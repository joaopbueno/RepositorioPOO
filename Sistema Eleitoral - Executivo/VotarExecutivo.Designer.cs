namespace Sistema_Eleitoral___Executivo
{
    partial class VotarExecutivo
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
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.lblDpFederal = new System.Windows.Forms.Label();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnNulo = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(141, 56);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(131, 23);
            this.txtVoto.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Deputado Federal";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirma.Location = new System.Drawing.Point(76, 183);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(260, 50);
            this.btnConfirma.TabIndex = 18;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // lblDpFederal
            // 
            this.lblDpFederal.AutoSize = true;
            this.lblDpFederal.Location = new System.Drawing.Point(200, 92);
            this.lblDpFederal.Name = "lblDpFederal";
            this.lblDpFederal.Size = new System.Drawing.Size(12, 15);
            this.lblDpFederal.TabIndex = 21;
            this.lblDpFederal.Text = "-";
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBranco.Location = new System.Drawing.Point(57, 124);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(86, 42);
            this.btnBranco.TabIndex = 15;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            // 
            // btnNulo
            // 
            this.btnNulo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNulo.Location = new System.Drawing.Point(164, 124);
            this.btnNulo.Name = "btnNulo";
            this.btnNulo.Size = new System.Drawing.Size(91, 42);
            this.btnNulo.TabIndex = 16;
            this.btnNulo.Text = "Nulo";
            this.btnNulo.UseVisualStyleBackColor = false;
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Red;
            this.btnCorrige.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrige.Location = new System.Drawing.Point(270, 124);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(96, 42);
            this.btnCorrige.TabIndex = 17;
            this.btnCorrige.Text = "Corrige";
            this.btnCorrige.UseVisualStyleBackColor = false;
            // 
            // VotarExecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 270);
            this.Controls.Add(this.lblDpFederal);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnCorrige);
            this.Controls.Add(this.btnNulo);
            this.Controls.Add(this.btnBranco);
            this.Name = "VotarExecutivo";
            this.Text = "VotarExecutivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label lblDpFederal;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnNulo;
        private System.Windows.Forms.Button btnCorrige;
    }
}