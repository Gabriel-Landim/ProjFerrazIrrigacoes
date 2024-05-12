namespace ProjFerrazIrrigacoes
{
    partial class frmCadastro
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.TituloDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloDashboard
            // 
            this.TituloDashboard.AutoSize = true;
            this.TituloDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 10F, System.Drawing.FontStyle.Bold);
            this.TituloDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloDashboard.Location = new System.Drawing.Point(26, 18);
            this.TituloDashboard.Name = "TituloDashboard";
            this.TituloDashboard.Size = new System.Drawing.Size(141, 18);
            this.TituloDashboard.TabIndex = 2;
            this.TituloDashboard.Text = "Area de Cadastros";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.TituloDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label TituloDashboard;
    }
}