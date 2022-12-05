namespace Sistema_Eleitoral___Executivo
{
    partial class VotarGovernador
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
            this.btnBrancoGovernador = new System.Windows.Forms.Button();
            this.btnNuloGovernador = new System.Windows.Forms.Button();
            this.btnCorrigeGovernador = new System.Windows.Forms.Button();
            this.btnConfirmaGovernador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGovernador = new System.Windows.Forms.Label();
            this.txtGovernador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrancoGovernador
            // 
            this.btnBrancoGovernador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoGovernador.Location = new System.Drawing.Point(42, 145);
            this.btnBrancoGovernador.Name = "btnBrancoGovernador";
            this.btnBrancoGovernador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrancoGovernador.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoGovernador.TabIndex = 12;
            this.btnBrancoGovernador.Text = "Branco";
            this.btnBrancoGovernador.UseVisualStyleBackColor = false;
            // 
            // btnNuloGovernador
            // 
            this.btnNuloGovernador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloGovernador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloGovernador.Location = new System.Drawing.Point(155, 145);
            this.btnNuloGovernador.Name = "btnNuloGovernador";
            this.btnNuloGovernador.Size = new System.Drawing.Size(91, 42);
            this.btnNuloGovernador.TabIndex = 13;
            this.btnNuloGovernador.Text = "Nulo";
            this.btnNuloGovernador.UseVisualStyleBackColor = false;
            // 
            // btnCorrigeGovernador
            // 
            this.btnCorrigeGovernador.BackColor = System.Drawing.Color.Red;
            this.btnCorrigeGovernador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigeGovernador.Location = new System.Drawing.Point(271, 145);
            this.btnCorrigeGovernador.Name = "btnCorrigeGovernador";
            this.btnCorrigeGovernador.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigeGovernador.TabIndex = 14;
            this.btnCorrigeGovernador.Text = "Corrige";
            this.btnCorrigeGovernador.UseVisualStyleBackColor = false;
            this.btnCorrigeGovernador.Click += new System.EventHandler(this.btnCorrigeGovernador_Click);
            // 
            // btnConfirmaGovernador
            // 
            this.btnConfirmaGovernador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmaGovernador.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirmaGovernador.Location = new System.Drawing.Point(70, 206);
            this.btnConfirmaGovernador.Name = "btnConfirmaGovernador";
            this.btnConfirmaGovernador.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmaGovernador.TabIndex = 15;
            this.btnConfirmaGovernador.Text = "Confirma";
            this.btnConfirmaGovernador.UseVisualStyleBackColor = false;
            this.btnConfirmaGovernador.Click += new System.EventHandler(this.btnConfirmaGovernador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Governador";
            // 
            // lblGovernador
            // 
            this.lblGovernador.AutoSize = true;
            this.lblGovernador.Location = new System.Drawing.Point(194, 110);
            this.lblGovernador.Name = "lblGovernador";
            this.lblGovernador.Size = new System.Drawing.Size(12, 15);
            this.lblGovernador.TabIndex = 17;
            this.lblGovernador.Text = "-";
            this.lblGovernador.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGovernador
            // 
            this.txtGovernador.Location = new System.Drawing.Point(130, 75);
            this.txtGovernador.Name = "txtGovernador";
            this.txtGovernador.Size = new System.Drawing.Size(147, 23);
            this.txtGovernador.TabIndex = 18;
            // 
            // VotarGovernador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 278);
            this.Controls.Add(this.txtGovernador);
            this.Controls.Add(this.lblGovernador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmaGovernador);
            this.Controls.Add(this.btnCorrigeGovernador);
            this.Controls.Add(this.btnNuloGovernador);
            this.Controls.Add(this.btnBrancoGovernador);
            this.Name = "VotarGovernador";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrancoGovernador;
        private System.Windows.Forms.Button btnNuloGovernador;
        private System.Windows.Forms.Button btnCorrigeGovernador;
        private System.Windows.Forms.Button btnConfirmaGovernador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGovernador;
        private System.Windows.Forms.TextBox txtGovernador;
    }
}