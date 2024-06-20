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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.dtAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtFechamento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.panel2.Location = new System.Drawing.Point(73, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 10);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Usuário";
            // 
            // cbUsuario
            // 
            this.cbUsuario.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(67, 72);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(255, 25);
            this.cbUsuario.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(62, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data de Fechamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(62, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Valor";
            // 
            // tbValor
            // 
            this.tbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValor.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold);
            this.tbValor.Location = new System.Drawing.Point(66, 251);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(255, 21);
            this.tbValor.TabIndex = 51;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCaixa.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(55, 313);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(119, 34);
            this.btnAbrirCaixa.TabIndex = 62;
            this.btnAbrirCaixa.Text = "Abrir";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Sair21;
            this.btnSair.Location = new System.Drawing.Point(336, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 31);
            this.btnSair.TabIndex = 63;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 65;
            this.label2.Text = "Data de Abertura";
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCaixa.Font = new System.Drawing.Font("RBNo3.1 Light", 15F, System.Drawing.FontStyle.Bold);
            this.btnFecharCaixa.ForeColor = System.Drawing.Color.Crimson;
            this.btnFecharCaixa.Location = new System.Drawing.Point(206, 313);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(119, 34);
            this.btnFecharCaixa.TabIndex = 66;
            this.btnFecharCaixa.Text = "Fechar";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // dtAbertura
            // 
            this.dtAbertura.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtAbertura.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtAbertura.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.dtAbertura.Location = new System.Drawing.Point(69, 131);
            this.dtAbertura.Name = "dtAbertura";
            this.dtAbertura.Size = new System.Drawing.Size(254, 25);
            this.dtAbertura.TabIndex = 67;
            // 
            // dtFechamento
            // 
            this.dtFechamento.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechamento.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtFechamento.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.dtFechamento.Location = new System.Drawing.Point(67, 191);
            this.dtFechamento.Name = "dtFechamento";
            this.dtFechamento.Size = new System.Drawing.Size(254, 25);
            this.dtFechamento.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.dtFechamento);
            this.panel1.Controls.Add(this.dtAbertura);
            this.panel1.Controls.Add(this.btnFecharCaixa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAbrirCaixa);
            this.panel1.Controls.Add(this.tbValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 382);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 68);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.label6.Location = new System.Drawing.Point(90, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status do caixa";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.panel4.Controls.Add(this.btnSair);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 34);
            this.panel4.TabIndex = 20;
            // 
            // frmCaixaAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(378, 495);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixaAbrir";
            this.Text = "frmCaixaAbrir";
            this.Shown += new System.EventHandler(this.frmCaixaAbrir_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.DateTimePicker dtAbertura;
        private System.Windows.Forms.DateTimePicker dtFechamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}