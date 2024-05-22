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
            this.TituloDashboard = new System.Windows.Forms.Label();
            this.PainelNav = new System.Windows.Forms.Panel();
            this.PanelCarregar = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnOrdemDeServico = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.PanelCadastro = new System.Windows.Forms.Panel();
            this.BtnCadastroCliente = new System.Windows.Forms.Button();
            this.BtnCadastroEmpresa = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelCadastro.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(922, 3);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(25, 25);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "X";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.BtnOrdemDeServico);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.BtnProdutos);
            this.panel1.Controls.Add(this.PanelCadastro);
            this.panel1.Controls.Add(this.BtnCadastro);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 577);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 506);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(201, 20);
            this.panel7.TabIndex = 10;
            // 
            // BtnOrdemDeServico
            // 
            this.BtnOrdemDeServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrdemDeServico.FlatAppearance.BorderSize = 0;
            this.BtnOrdemDeServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnOrdemDeServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnOrdemDeServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdemDeServico.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOrdemDeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnOrdemDeServico.Image = global::ProjFerrazIrrigacoes.Properties.Resources.OrdemDeServico;
            this.BtnOrdemDeServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOrdemDeServico.Location = new System.Drawing.Point(0, 461);
            this.BtnOrdemDeServico.Name = "BtnOrdemDeServico";
            this.BtnOrdemDeServico.Size = new System.Drawing.Size(201, 45);
            this.BtnOrdemDeServico.TabIndex = 9;
            this.BtnOrdemDeServico.Text = "Ordem de Serviço";
            this.BtnOrdemDeServico.UseVisualStyleBackColor = true;
            this.BtnOrdemDeServico.Click += new System.EventHandler(this.BtnOrdemDeServico_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 441);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 20);
            this.panel6.TabIndex = 8;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnBuscar.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 396);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(201, 45);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 376);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 20);
            this.panel5.TabIndex = 6;
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnProdutos.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Produtos;
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 331);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(201, 45);
            this.BtnProdutos.TabIndex = 5;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click_1);
            // 
            // PanelCadastro
            // 
            this.PanelCadastro.BackColor = System.Drawing.Color.Transparent;
            this.PanelCadastro.Controls.Add(this.BtnCadastroCliente);
            this.PanelCadastro.Controls.Add(this.BtnCadastroEmpresa);
            this.PanelCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCadastro.Location = new System.Drawing.Point(0, 234);
            this.PanelCadastro.Name = "PanelCadastro";
            this.PanelCadastro.Size = new System.Drawing.Size(201, 97);
            this.PanelCadastro.TabIndex = 4;
            // 
            // BtnCadastroCliente
            // 
            this.BtnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BtnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.BtnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroCliente.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroCliente.Location = new System.Drawing.Point(0, 45);
            this.BtnCadastroCliente.Name = "BtnCadastroCliente";
            this.BtnCadastroCliente.Size = new System.Drawing.Size(201, 45);
            this.BtnCadastroCliente.TabIndex = 5;
            this.BtnCadastroCliente.Text = "Cliente";
            this.BtnCadastroCliente.UseVisualStyleBackColor = false;
            this.BtnCadastroCliente.Click += new System.EventHandler(this.BtnCadastroCliente_Click);
            // 
            // BtnCadastroEmpresa
            // 
            this.BtnCadastroEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BtnCadastroEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnCadastroEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEmpresa.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCadastroEmpresa.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCadastroEmpresa.Location = new System.Drawing.Point(0, 0);
            this.BtnCadastroEmpresa.Name = "BtnCadastroEmpresa";
            this.BtnCadastroEmpresa.Size = new System.Drawing.Size(201, 45);
            this.BtnCadastroEmpresa.TabIndex = 4;
            this.BtnCadastroEmpresa.Text = "Empresa";
            this.BtnCadastroEmpresa.UseVisualStyleBackColor = false;
            this.BtnCadastroEmpresa.Click += new System.EventHandler(this.BtnCadastroEmpresa_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnCadastro.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Cadastro;
            this.BtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastro.Location = new System.Drawing.Point(0, 189);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(201, 45);
            this.BtnCadastro.TabIndex = 3;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click_1);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnDashboard.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Dashboard;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(201, 45);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dados";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(681, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 61);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjFerrazIrrigacoes.Properties.Resources.UsuarioBoi;
            this.pictureBox2.Location = new System.Drawing.Point(8, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 ExtraLight", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "4321";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Book", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Administrador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.PanelCarregar);
            this.Controls.Add(this.PainelNav);
            this.Controls.Add(this.TituloDashboard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelCadastro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TituloDashboard;
        private System.Windows.Forms.Panel PainelNav;
        private System.Windows.Forms.Panel PanelCarregar;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnOrdemDeServico;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Panel PanelCadastro;
        private System.Windows.Forms.Button BtnCadastroCliente;
        private System.Windows.Forms.Button BtnCadastroEmpresa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

