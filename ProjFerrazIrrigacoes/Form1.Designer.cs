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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TituloDashboard = new System.Windows.Forms.Label();
            this.PainelNav = new System.Windows.Forms.Panel();
            this.PanelCarregar = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.BtnOrdemDeServico = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.BtnOrdemDeServico);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnProdutos);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnCadastro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 577);
            this.panel1.TabIndex = 0;
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
            // TituloDashboard
            // 
            this.TituloDashboard.AutoSize = true;
            this.TituloDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 20F, System.Drawing.FontStyle.Bold);
            this.TituloDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloDashboard.Location = new System.Drawing.Point(229, 34);
            this.TituloDashboard.Name = "TituloDashboard";
            this.TituloDashboard.Size = new System.Drawing.Size(165, 35);
            this.TituloDashboard.TabIndex = 1;
            this.TituloDashboard.Text = "Dashboard";
            // 
            // PainelNav
            // 
            this.PainelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.PainelNav.Location = new System.Drawing.Point(0, 193);
            this.PainelNav.Name = "PainelNav";
            this.PainelNav.Size = new System.Drawing.Size(3, 100);
            this.PainelNav.TabIndex = 2;
            // 
            // PanelCarregar
            // 
            this.PanelCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.PanelCarregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCarregar.Location = new System.Drawing.Point(201, 100);
            this.PanelCarregar.Name = "PanelCarregar";
            this.PanelCarregar.Size = new System.Drawing.Size(750, 477);
            this.PanelCarregar.TabIndex = 7;
            // 
            // BtnOrdemDeServico
            // 
            this.BtnOrdemDeServico.FlatAppearance.BorderSize = 0;
            this.BtnOrdemDeServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdemDeServico.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOrdemDeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnOrdemDeServico.Image = global::ProjFerrazIrrigacoes.Properties.Resources.OrdemDeServico;
            this.BtnOrdemDeServico.Location = new System.Drawing.Point(0, 324);
            this.BtnOrdemDeServico.Name = "BtnOrdemDeServico";
            this.BtnOrdemDeServico.Size = new System.Drawing.Size(201, 42);
            this.BtnOrdemDeServico.TabIndex = 9;
            this.BtnOrdemDeServico.Text = "Ordem de Serviço";
            this.BtnOrdemDeServico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOrdemDeServico.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnBuscar.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Buscar;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 282);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(201, 42);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnProdutos.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Produtos;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 240);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(201, 42);
            this.BtnProdutos.TabIndex = 7;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnDashboard.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Dashboard;
            this.BtnDashboard.Location = new System.Drawing.Point(1, 151);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(200, 42);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "Dados";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnCadastro.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Cadastro;
            this.BtnCadastro.Location = new System.Drawing.Point(0, 194);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(201, 42);
            this.BtnCadastro.TabIndex = 1;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("RBNo3.1 Thin", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(601, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 24);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Digite o que deseja...";
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(900, 45);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(25, 25);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PanelCarregar);
            this.Controls.Add(this.PainelNav);
            this.Controls.Add(this.TituloDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Label TituloDashboard;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnOrdemDeServico;
        private System.Windows.Forms.Panel PainelNav;
        private System.Windows.Forms.Panel PanelCarregar;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSair;
    }
}

