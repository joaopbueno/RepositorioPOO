namespace Sistema_Eleitoral___Executivo
{
    partial class VotarDpEstadual
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
            this.txtDepEst = new System.Windows.Forms.TextBox();
            this.btnBrancoDepEstadual = new System.Windows.Forms.Button();
            this.btnNuloDepEstadual = new System.Windows.Forms.Button();
            this.btnCorrigeDepEstadual = new System.Windows.Forms.Button();
            this.btnConfirmaDepEstadual = new System.Windows.Forms.Button();
            this.lblDepEstadual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deputado Estadual";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDepEst
            // 
            this.txtDepEst.Location = new System.Drawing.Point(120, 67);
            this.txtDepEst.Name = "txtDepEst";
            this.txtDepEst.Size = new System.Drawing.Size(134, 23);
            this.txtDepEst.TabIndex = 1;
            // 
            // btnBrancoDepEstadual
            // 
            this.btnBrancoDepEstadual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoDepEstadual.Location = new System.Drawing.Point(39, 142);
            this.btnBrancoDepEstadual.Name = "btnBrancoDepEstadual";
            this.btnBrancoDepEstadual.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoDepEstadual.TabIndex = 7;
            this.btnBrancoDepEstadual.Text = "Branco";
            this.btnBrancoDepEstadual.UseVisualStyleBackColor = false;
            // 
            // btnNuloDepEstadual
            // 
            this.btnNuloDepEstadual.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloDepEstadual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloDepEstadual.Location = new System.Drawing.Point(148, 142);
            this.btnNuloDepEstadual.Name = "btnNuloDepEstadual";
            this.btnNuloDepEstadual.Size = new System.Drawing.Size(91, 42);
            this.btnNuloDepEstadual.TabIndex = 8;
            this.btnNuloDepEstadual.Text = "Nulo";
            this.btnNuloDepEstadual.UseVisualStyleBackColor = false;
            this.btnNuloDepEstadual.Click += new System.EventHandler(this.btnNuloDepEstadual_Click);
            // 
            // btnCorrigeDepEstadual
            // 
            this.btnCorrigeDepEstadual.BackColor = System.Drawing.Color.Red;
            this.btnCorrigeDepEstadual.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigeDepEstadual.Location = new System.Drawing.Point(257, 142);
            this.btnCorrigeDepEstadual.Name = "btnCorrigeDepEstadual";
            this.btnCorrigeDepEstadual.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigeDepEstadual.TabIndex = 9;
            this.btnCorrigeDepEstadual.Text = "Corrige";
            this.btnCorrigeDepEstadual.UseVisualStyleBackColor = false;
            // 
            // btnConfirmaDepEstadual
            // 
            this.btnConfirmaDepEstadual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmaDepEstadual.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnConfirmaDepEstadual.Location = new System.Drawing.Point(69, 207);
            this.btnConfirmaDepEstadual.Name = "btnConfirmaDepEstadual";
            this.btnConfirmaDepEstadual.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmaDepEstadual.TabIndex = 10;
            this.btnConfirmaDepEstadual.Text = "Confirma";
            this.btnConfirmaDepEstadual.UseVisualStyleBackColor = false;
            this.btnConfirmaDepEstadual.Click += new System.EventHandler(this.btnConfirmaDepEstadual_Click);
            // 
            // lblDepEstadual
            // 
            this.lblDepEstadual.AutoSize = true;
            this.lblDepEstadual.Location = new System.Drawing.Point(179, 102);
            this.lblDepEstadual.Name = "lblDepEstadual";
            this.lblDepEstadual.Size = new System.Drawing.Size(12, 15);
            this.lblDepEstadual.TabIndex = 11;
            this.lblDepEstadual.Text = "-";
            this.lblDepEstadual.Click += new System.EventHandler(this.label2_Click);
            // 
            // VotarDpEstadual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 283);
            this.Controls.Add(this.lblDepEstadual);
            this.Controls.Add(this.btnConfirmaDepEstadual);
            this.Controls.Add(this.btnCorrigeDepEstadual);
            this.Controls.Add(this.btnNuloDepEstadual);
            this.Controls.Add(this.btnBrancoDepEstadual);
            this.Controls.Add(this.txtDepEst);
            this.Controls.Add(this.label1);
            this.Name = "VotarDpEstadual";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepEst;
        private System.Windows.Forms.Button btnBrancoDepEstadual;
        private System.Windows.Forms.Button btnNuloDepEstadual;
        private System.Windows.Forms.Button btnCorrigeDepEstadual;
        private System.Windows.Forms.Button btnConfirmaDepEstadual;
        private System.Windows.Forms.Label lblDepEstadual;
    }
}