namespace ProjFerrazIrrigacoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox7;
            System.Windows.Forms.PictureBox pictureBox6;
            System.Windows.Forms.PictureBox pictureBox5;
            System.Windows.Forms.PictureBox pictureBox4;
            System.Windows.Forms.PictureBox pictureBox3;
            System.Windows.Forms.PictureBox pictureBox2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.BtnOrdem = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(pictureBox7);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(pictureBox6);
            this.panel1.Controls.Add(pictureBox5);
            this.panel1.Controls.Add(pictureBox4);
            this.panel1.Controls.Add(pictureBox3);
            this.panel1.Controls.Add(pictureBox2);
            this.panel1.Controls.Add(this.BtnConfiguracoes);
            this.panel1.Controls.Add(this.BtnOrdem);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnProdutos);
            this.panel1.Controls.Add(this.BtnCadastro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(175)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 124);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnConfiguracoes.Location = new System.Drawing.Point(2, 482);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Size = new System.Drawing.Size(186, 42);
            this.BtnConfiguracoes.TabIndex = 1;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConfiguracoes.UseVisualStyleBackColor = true;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnOrdem
            // 
            this.BtnOrdem.FlatAppearance.BorderSize = 0;
            this.BtnOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdem.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOrdem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnOrdem.Location = new System.Drawing.Point(0, 338);
            this.BtnOrdem.Name = "BtnOrdem";
            this.BtnOrdem.Size = new System.Drawing.Size(186, 42);
            this.BtnOrdem.TabIndex = 1;
            this.BtnOrdem.Text = "Ordem de Serviço";
            this.BtnOrdem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOrdem.UseVisualStyleBackColor = true;
            this.BtnOrdem.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnBuscar.Location = new System.Drawing.Point(0, 290);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(186, 42);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnProdutos.Location = new System.Drawing.Point(0, 242);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(186, 42);
            this.BtnProdutos.TabIndex = 1;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnCadastro.Location = new System.Drawing.Point(0, 194);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(186, 42);
            this.BtnCadastro.TabIndex = 1;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 144);
            this.panel2.TabIndex = 0;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(207)))));
            this.BtnDashboard.Location = new System.Drawing.Point(1, 151);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(186, 42);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 20F, System.Drawing.FontStyle.Bold);
            this.Dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard.Location = new System.Drawing.Point(207, 19);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(165, 35);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Dashboard";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Dashboard;
            pictureBox7.Location = new System.Drawing.Point(170, 153);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(26, 37);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Configuracoes;
            pictureBox6.Location = new System.Drawing.Point(165, 490);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(22, 29);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = global::ProjFerrazIrrigacoes.Properties.Resources.OrdemDeServico;
            pictureBox5.Location = new System.Drawing.Point(172, 345);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(22, 29);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Buscar;
            pictureBox4.Location = new System.Drawing.Point(172, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(22, 29);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Produtos;
            pictureBox3.Location = new System.Drawing.Point(172, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(22, 29);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Cadastro;
            pictureBox2.Location = new System.Drawing.Point(172, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(22, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjFerrazIrrigacoes.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnConfiguracoes;
        private System.Windows.Forms.Button BtnOrdem;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label Dashboard;
    }
}

