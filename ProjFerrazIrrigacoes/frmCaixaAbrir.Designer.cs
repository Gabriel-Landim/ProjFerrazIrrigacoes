namespace ProjFerrazIrrigacoes
{
    partial class frmCaixaAbrir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TituloDashboard = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnAbrirCaixa);
            this.panel1.Controls.Add(this.tbValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbData);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TituloDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 412);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Sair21;
            this.btnSair.Location = new System.Drawing.Point(333, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 31);
            this.btnSair.TabIndex = 63;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCaixa.ForeColor = System.Drawing.Color.Gold;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(67, 351);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(243, 34);
            this.btnAbrirCaixa.TabIndex = 62;
            this.btnAbrirCaixa.Text = "Abrir Caixa";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            this.tbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbValor.Location = new System.Drawing.Point(62, 276);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(255, 23);
            this.tbValor.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(59, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor";
            // 
            // cbData
            // 
            this.cbData.Enabled = false;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(62, 229);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(255, 21);
            this.cbData.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data de Fechamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbUsuario
            // 
            this.cbUsuario.Enabled = false;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(62, 133);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(255, 21);
            this.cbUsuario.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuário";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(66, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 10);
            this.panel2.TabIndex = 3;
            // 
            // TituloDashboard
            // 
            this.TituloDashboard.AutoSize = true;
            this.TituloDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 20F, System.Drawing.FontStyle.Bold);
            this.TituloDashboard.ForeColor = System.Drawing.Color.Gold;
            this.TituloDashboard.Location = new System.Drawing.Point(58, 18);
            this.TituloDashboard.Name = "TituloDashboard";
            this.TituloDashboard.Size = new System.Drawing.Size(259, 35);
            this.TituloDashboard.TabIndex = 2;
            this.TituloDashboard.Text = "Abertura de Caixa";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(57, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Data de Abertura";
            // 
            // frmCaixaAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(387, 419);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixaAbrir";
            this.Text = "frmCaixaAbrir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TituloDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}