namespace Sistema_Eleitoral___Executivo
{
    partial class VotarPrefeito
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
            this.txtPrefeito = new System.Windows.Forms.TextBox();
            this.lblPrefeito = new System.Windows.Forms.Label();
            this.btnNuloPrefeito = new System.Windows.Forms.Button();
            this.btnBrancoPrefeito = new System.Windows.Forms.Button();
            this.btnCorrigePrefeito = new System.Windows.Forms.Button();
            this.btnConfirmaPrefeito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefeito";
            // 
            // txtPrefeito
            // 
            this.txtPrefeito.Location = new System.Drawing.Point(124, 64);
            this.txtPrefeito.Name = "txtPrefeito";
            this.txtPrefeito.Size = new System.Drawing.Size(129, 23);
            this.txtPrefeito.TabIndex = 1;
            // 
            // lblPrefeito
            // 
            this.lblPrefeito.AutoSize = true;
            this.lblPrefeito.Location = new System.Drawing.Point(185, 99);
            this.lblPrefeito.Name = "lblPrefeito";
            this.lblPrefeito.Size = new System.Drawing.Size(12, 15);
            this.lblPrefeito.TabIndex = 2;
            this.lblPrefeito.Text = "-";
            this.lblPrefeito.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNuloPrefeito
            // 
            this.btnNuloPrefeito.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloPrefeito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloPrefeito.Location = new System.Drawing.Point(147, 128);
            this.btnNuloPrefeito.Name = "btnNuloPrefeito";
            this.btnNuloPrefeito.Size = new System.Drawing.Size(91, 42);
            this.btnNuloPrefeito.TabIndex = 10;
            this.btnNuloPrefeito.Text = "Nulo";
            this.btnNuloPrefeito.UseVisualStyleBackColor = false;
            // 
            // btnBrancoPrefeito
            // 
            this.btnBrancoPrefeito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoPrefeito.Location = new System.Drawing.Point(40, 128);
            this.btnBrancoPrefeito.Name = "btnBrancoPrefeito";
            this.btnBrancoPrefeito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrancoPrefeito.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoPrefeito.TabIndex = 11;
            this.btnBrancoPrefeito.Text = "Branco";
            this.btnBrancoPrefeito.UseVisualStyleBackColor = false;
            // 
            // btnCorrigePrefeito
            // 
            this.btnCorrigePrefeito.BackColor = System.Drawing.Color.Red;
            this.btnCorrigePrefeito.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigePrefeito.Location = new System.Drawing.Point(262, 128);
            this.btnCorrigePrefeito.Name = "btnCorrigePrefeito";
            this.btnCorrigePrefeito.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigePrefeito.TabIndex = 12;
            this.btnCorrigePrefeito.Text = "Corrige";
            this.btnCorrigePrefeito.UseVisualStyleBackColor = false;
            // 
            // btnConfirmaPrefeito
            // 
            this.btnConfirmaPrefeito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmaPrefeito.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirmaPrefeito.Location = new System.Drawing.Point(63, 195);
            this.btnConfirmaPrefeito.Name = "btnConfirmaPrefeito";
            this.btnConfirmaPrefeito.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmaPrefeito.TabIndex = 13;
            this.btnConfirmaPrefeito.Text = "Confirma";
            this.btnConfirmaPrefeito.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 274);
            this.Controls.Add(this.btnConfirmaPrefeito);
            this.Controls.Add(this.btnCorrigePrefeito);
            this.Controls.Add(this.btnBrancoPrefeito);
            this.Controls.Add(this.btnNuloPrefeito);
            this.Controls.Add(this.lblPrefeito);
            this.Controls.Add(this.txtPrefeito);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrefeito;
        private System.Windows.Forms.Label lblPrefeito;
        private System.Windows.Forms.Button btnNuloPrefeito;
        private System.Windows.Forms.Button btnBrancoPrefeito;
        private System.Windows.Forms.Button btnCorrigePrefeito;
        private System.Windows.Forms.Button btnConfirmaPrefeito;
    }
}