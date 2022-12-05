namespace Sistema_Eleitoral___Executivo
{
    partial class Form2
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
            this.lblPresidente = new System.Windows.Forms.Label();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.btnBrancoPresidente = new System.Windows.Forms.Button();
            this.btnNuloPresidente = new System.Windows.Forms.Button();
            this.btnCorrigePresidente = new System.Windows.Forms.Button();
            this.btnConfirmaPresidente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presidente";
            // 
            // lblPresidente
            // 
            this.lblPresidente.AutoSize = true;
            this.lblPresidente.Location = new System.Drawing.Point(190, 118);
            this.lblPresidente.Name = "lblPresidente";
            this.lblPresidente.Size = new System.Drawing.Size(12, 15);
            this.lblPresidente.TabIndex = 1;
            this.lblPresidente.Text = "-";
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(132, 83);
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(124, 23);
            this.txtPresidente.TabIndex = 2;
            // 
            // btnBrancoPresidente
            // 
            this.btnBrancoPresidente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoPresidente.Location = new System.Drawing.Point(42, 156);
            this.btnBrancoPresidente.Name = "btnBrancoPresidente";
            this.btnBrancoPresidente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBrancoPresidente.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoPresidente.TabIndex = 13;
            this.btnBrancoPresidente.Text = "Branco";
            this.btnBrancoPresidente.UseVisualStyleBackColor = false;
            // 
            // btnNuloPresidente
            // 
            this.btnNuloPresidente.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloPresidente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloPresidente.Location = new System.Drawing.Point(151, 156);
            this.btnNuloPresidente.Name = "btnNuloPresidente";
            this.btnNuloPresidente.Size = new System.Drawing.Size(91, 42);
            this.btnNuloPresidente.TabIndex = 14;
            this.btnNuloPresidente.Text = "Nulo";
            this.btnNuloPresidente.UseVisualStyleBackColor = false;
            // 
            // btnCorrigePresidente
            // 
            this.btnCorrigePresidente.BackColor = System.Drawing.Color.Red;
            this.btnCorrigePresidente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigePresidente.Location = new System.Drawing.Point(262, 156);
            this.btnCorrigePresidente.Name = "btnCorrigePresidente";
            this.btnCorrigePresidente.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigePresidente.TabIndex = 15;
            this.btnCorrigePresidente.Text = "Corrige";
            this.btnCorrigePresidente.UseVisualStyleBackColor = false;
            // 
            // btnConfirmaPresidente
            // 
            this.btnConfirmaPresidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmaPresidente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirmaPresidente.Location = new System.Drawing.Point(69, 213);
            this.btnConfirmaPresidente.Name = "btnConfirmaPresidente";
            this.btnConfirmaPresidente.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmaPresidente.TabIndex = 16;
            this.btnConfirmaPresidente.Text = "Confirma";
            this.btnConfirmaPresidente.UseVisualStyleBackColor = false;
            this.btnConfirmaPresidente.Click += new System.EventHandler(this.btnConfirmaPresidente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 284);
            this.Controls.Add(this.btnConfirmaPresidente);
            this.Controls.Add(this.btnCorrigePresidente);
            this.Controls.Add(this.btnNuloPresidente);
            this.Controls.Add(this.btnBrancoPresidente);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.lblPresidente);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPresidente;
        private System.Windows.Forms.TextBox txtPresidente;
        private System.Windows.Forms.Button btnBrancoPresidente;
        private System.Windows.Forms.Button btnNuloPresidente;
        private System.Windows.Forms.Button btnCorrigePresidente;
        private System.Windows.Forms.Button btnConfirmaPresidente;
    }
}