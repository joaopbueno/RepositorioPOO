namespace Sistema_Eleitoral___Executivo
{
    partial class VotarDpFederal
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
            this.btnBrancoDepFederal = new System.Windows.Forms.Button();
            this.btnNuloDepFederal = new System.Windows.Forms.Button();
            this.btnCorrigeDepFederal = new System.Windows.Forms.Button();
            this.btnConfirmaDepFederal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepFed = new System.Windows.Forms.TextBox();
            this.lblDpFederal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrancoDepFederal
            // 
            this.btnBrancoDepFederal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoDepFederal.Location = new System.Drawing.Point(30, 133);
            this.btnBrancoDepFederal.Name = "btnBrancoDepFederal";
            this.btnBrancoDepFederal.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoDepFederal.TabIndex = 8;
            this.btnBrancoDepFederal.Text = "Branco";
            this.btnBrancoDepFederal.UseVisualStyleBackColor = false;
            // 
            // btnNuloDepFederal
            // 
            this.btnNuloDepFederal.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloDepFederal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloDepFederal.Location = new System.Drawing.Point(137, 133);
            this.btnNuloDepFederal.Name = "btnNuloDepFederal";
            this.btnNuloDepFederal.Size = new System.Drawing.Size(91, 42);
            this.btnNuloDepFederal.TabIndex = 9;
            this.btnNuloDepFederal.Text = "Nulo";
            this.btnNuloDepFederal.UseVisualStyleBackColor = false;
            // 
            // btnCorrigeDepFederal
            // 
            this.btnCorrigeDepFederal.BackColor = System.Drawing.Color.Red;
            this.btnCorrigeDepFederal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigeDepFederal.Location = new System.Drawing.Point(243, 133);
            this.btnCorrigeDepFederal.Name = "btnCorrigeDepFederal";
            this.btnCorrigeDepFederal.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigeDepFederal.TabIndex = 10;
            this.btnCorrigeDepFederal.Text = "Corrige";
            this.btnCorrigeDepFederal.UseVisualStyleBackColor = false;
            this.btnCorrigeDepFederal.Click += new System.EventHandler(this.btnCorrigeDepFederal_Click);
            // 
            // btnConfirmaDepFederal
            // 
            this.btnConfirmaDepFederal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmaDepFederal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirmaDepFederal.Location = new System.Drawing.Point(49, 192);
            this.btnConfirmaDepFederal.Name = "btnConfirmaDepFederal";
            this.btnConfirmaDepFederal.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmaDepFederal.TabIndex = 11;
            this.btnConfirmaDepFederal.Text = "Confirma";
            this.btnConfirmaDepFederal.UseVisualStyleBackColor = false;
            this.btnConfirmaDepFederal.Click += new System.EventHandler(this.btnConfirmaDepFederal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deputado Federal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDepFed
            // 
            this.txtDepFed.Location = new System.Drawing.Point(114, 65);
            this.txtDepFed.Name = "txtDepFed";
            this.txtDepFed.Size = new System.Drawing.Size(131, 23);
            this.txtDepFed.TabIndex = 13;
            // 
            // lblDpFederal
            // 
            this.lblDpFederal.AutoSize = true;
            this.lblDpFederal.Location = new System.Drawing.Point(173, 101);
            this.lblDpFederal.Name = "lblDpFederal";
            this.lblDpFederal.Size = new System.Drawing.Size(12, 15);
            this.lblDpFederal.TabIndex = 14;
            this.lblDpFederal.Text = "-";
            this.lblDpFederal.Click += new System.EventHandler(this.label2_Click);
            // 
            // VotarDpFederal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 265);
            this.Controls.Add(this.lblDpFederal);
            this.Controls.Add(this.txtDepFed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmaDepFederal);
            this.Controls.Add(this.btnCorrigeDepFederal);
            this.Controls.Add(this.btnNuloDepFederal);
            this.Controls.Add(this.btnBrancoDepFederal);
            this.Name = "VotarDpFederal";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrancoDepFederal;
        private System.Windows.Forms.Button btnNuloDepFederal;
        private System.Windows.Forms.Button btnCorrigeDepFederal;
        private System.Windows.Forms.Button btnConfirmaDepFederal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepFed;
        private System.Windows.Forms.Label lblDpFederal;
    }
}