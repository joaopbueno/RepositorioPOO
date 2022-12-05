namespace Sistema_Eleitoral___Executivo
{
    partial class VotarVereador
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
            this.txtVereador = new System.Windows.Forms.TextBox();
            this.btnBrancoVereador = new System.Windows.Forms.Button();
            this.btnNuloVereador = new System.Windows.Forms.Button();
            this.btnCorrigeVereador = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblNomeVereador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vereador";
            // 
            // txtVereador
            // 
            this.txtVereador.Location = new System.Drawing.Point(132, 68);
            this.txtVereador.Name = "txtVereador";
            this.txtVereador.Size = new System.Drawing.Size(121, 23);
            this.txtVereador.TabIndex = 3;
            // 
            // btnBrancoVereador
            // 
            this.btnBrancoVereador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrancoVereador.Location = new System.Drawing.Point(32, 145);
            this.btnBrancoVereador.Name = "btnBrancoVereador";
            this.btnBrancoVereador.Size = new System.Drawing.Size(86, 42);
            this.btnBrancoVereador.TabIndex = 6;
            this.btnBrancoVereador.Text = "Branco";
            this.btnBrancoVereador.UseVisualStyleBackColor = false;
            // 
            // btnNuloVereador
            // 
            this.btnNuloVereador.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuloVereador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuloVereador.Location = new System.Drawing.Point(144, 145);
            this.btnNuloVereador.Name = "btnNuloVereador";
            this.btnNuloVereador.Size = new System.Drawing.Size(91, 42);
            this.btnNuloVereador.TabIndex = 7;
            this.btnNuloVereador.Text = "Nulo";
            this.btnNuloVereador.UseVisualStyleBackColor = false;
            this.btnNuloVereador.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCorrigeVereador
            // 
            this.btnCorrigeVereador.BackColor = System.Drawing.Color.Red;
            this.btnCorrigeVereador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCorrigeVereador.Location = new System.Drawing.Point(259, 145);
            this.btnCorrigeVereador.Name = "btnCorrigeVereador";
            this.btnCorrigeVereador.Size = new System.Drawing.Size(96, 42);
            this.btnCorrigeVereador.TabIndex = 8;
            this.btnCorrigeVereador.Text = "Corrige";
            this.btnCorrigeVereador.UseVisualStyleBackColor = false;
            this.btnCorrigeVereador.Click += new System.EventHandler(this.btnCorrigeVereador_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(68, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Confirma";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblNomeVereador
            // 
            this.lblNomeVereador.AutoSize = true;
            this.lblNomeVereador.Location = new System.Drawing.Point(180, 103);
            this.lblNomeVereador.Name = "lblNomeVereador";
            this.lblNomeVereador.Size = new System.Drawing.Size(12, 15);
            this.lblNomeVereador.TabIndex = 10;
            this.lblNomeVereador.Text = "-";
            this.lblNomeVereador.Click += new System.EventHandler(this.lblNomeVereador_Click);
            // 
            // VotarVereador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 280);
            this.Controls.Add(this.lblNomeVereador);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCorrigeVereador);
            this.Controls.Add(this.btnNuloVereador);
            this.Controls.Add(this.btnBrancoVereador);
            this.Controls.Add(this.txtVereador);
            this.Controls.Add(this.label1);
            this.Name = "VotarVereador";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVereador;
        private System.Windows.Forms.Button btnBrancoVereador;
        private System.Windows.Forms.Button btnNuloVereador;
        private System.Windows.Forms.Button btnCorrigeVereador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblNomeVereador;
    }
}