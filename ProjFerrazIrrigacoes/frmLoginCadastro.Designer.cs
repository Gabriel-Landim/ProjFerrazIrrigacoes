namespace ProjFerrazIrrigacoes
{
    partial class frmLoginCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCadastrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCargo = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cargo";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.tbSenha.Location = new System.Drawing.Point(64, 332);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(254, 25);
            this.tbSenha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(61, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.tbEmail.Location = new System.Drawing.Point(65, 281);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(254, 25);
            this.tbEmail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(61, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cadastro de Usuário";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 34);
            this.panel1.TabIndex = 18;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Sair2;
            this.btSair.Location = new System.Drawing.Point(352, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(21, 23);
            this.btSair.TabIndex = 17;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ferraz Irrigações";
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.tbCadastrar.FlatAppearance.BorderSize = 0;
            this.tbCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbCadastrar.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold);
            this.tbCadastrar.ForeColor = System.Drawing.Color.White;
            this.tbCadastrar.Location = new System.Drawing.Point(77, 406);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Size = new System.Drawing.Size(226, 39);
            this.tbCadastrar.TabIndex = 19;
            this.tbCadastrar.Text = "CADASTRAR";
            this.tbCadastrar.UseVisualStyleBackColor = false;
            this.tbCadastrar.Click += new System.EventHandler(this.tbCadastrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 68);
            this.panel2.TabIndex = 19;
            // 
            // tbCargo
            // 
            this.tbCargo.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.tbCargo.FormattingEnabled = true;
            this.tbCargo.Location = new System.Drawing.Point(65, 232);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(254, 25);
            this.tbCargo.TabIndex = 20;
            this.tbCargo.SelectedIndexChanged += new System.EventHandler(this.tbCargo_SelectedIndexChanged);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.tbNome.Location = new System.Drawing.Point(65, 181);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(254, 25);
            this.tbNome.TabIndex = 9;
            // 
            // frmLoginCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(378, 495);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginCadastro";
            this.Text = "frmLoginCadastro";
            this.Load += new System.EventHandler(this.frmLoginCadastro_Load);
            this.Shown += new System.EventHandler(this.frmLoginCadastro_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tbCadastrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ComboBox tbCargo;
        private System.Windows.Forms.TextBox tbNome;
    }
}