﻿namespace ProjFerrazIrrigacoes
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
            this.components = new System.ComponentModel.Container();
            this.TituloDashboard = new System.Windows.Forms.Label();
            this.PainelNav = new System.Windows.Forms.Panel();
            this.PanelCarregar = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelOrdemDeServico = new System.Windows.Forms.Panel();
            this.btnVendas = new System.Windows.Forms.Button();
            this.PanelBuscar = new System.Windows.Forms.Panel();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnBuscarProdutos = new System.Windows.Forms.Button();
            this.PanelCadastro = new System.Windows.Forms.Panel();
            this.BtnCadastroCliente = new System.Windows.Forms.Button();
            this.BtnCadastroProdutos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCaixa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLancamentos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnOrdemDeServico = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelOrdemDeServico.SuspendLayout();
            this.PanelBuscar.SuspendLayout();
            this.PanelCadastro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloDashboard
            // 
            this.TituloDashboard.AutoSize = true;
            this.TituloDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 25F, System.Drawing.FontStyle.Bold);
            this.TituloDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TituloDashboard.Location = new System.Drawing.Point(268, 27);
            this.TituloDashboard.Name = "TituloDashboard";
            this.TituloDashboard.Size = new System.Drawing.Size(209, 44);
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
            this.PainelNav.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelNav_Paint);
            // 
            // PanelCarregar
            // 
            this.PanelCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.PanelCarregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCarregar.Location = new System.Drawing.Point(258, 100);
            this.PanelCarregar.Name = "PanelCarregar";
            this.PanelCarregar.Size = new System.Drawing.Size(985, 620);
            this.PanelCarregar.TabIndex = 7;
            this.PanelCarregar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCarregar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 144);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.PanelOrdemDeServico);
            this.panel1.Controls.Add(this.BtnOrdemDeServico);
            this.panel1.Controls.Add(this.PanelBuscar);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnEmpresa);
            this.panel1.Controls.Add(this.PanelCadastro);
            this.panel1.Controls.Add(this.BtnCadastro);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PanelOrdemDeServico
            // 
            this.PanelOrdemDeServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.PanelOrdemDeServico.Controls.Add(this.btnLancamentos);
            this.PanelOrdemDeServico.Controls.Add(this.btnVendas);
            this.PanelOrdemDeServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOrdemDeServico.Location = new System.Drawing.Point(0, 612);
            this.PanelOrdemDeServico.Name = "PanelOrdemDeServico";
            this.PanelOrdemDeServico.Size = new System.Drawing.Size(258, 90);
            this.PanelOrdemDeServico.TabIndex = 10;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.btnVendas.ForeColor = System.Drawing.Color.Transparent;
            this.btnVendas.Location = new System.Drawing.Point(0, 0);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(258, 45);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // PanelBuscar
            // 
            this.PanelBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.PanelBuscar.Controls.Add(this.BtnBuscarCliente);
            this.PanelBuscar.Controls.Add(this.BtnBuscarProdutos);
            this.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBuscar.Location = new System.Drawing.Point(0, 463);
            this.PanelBuscar.Name = "PanelBuscar";
            this.PanelBuscar.Size = new System.Drawing.Size(258, 92);
            this.PanelBuscar.TabIndex = 8;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BtnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.BtnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarCliente.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarCliente.Location = new System.Drawing.Point(0, 45);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(258, 45);
            this.BtnBuscarCliente.TabIndex = 6;
            this.BtnBuscarCliente.Text = "Cliente";
            this.BtnBuscarCliente.UseVisualStyleBackColor = false;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // BtnBuscarProdutos
            // 
            this.BtnBuscarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BtnBuscarProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscarProdutos.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProdutos.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarProdutos.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscarProdutos.Location = new System.Drawing.Point(0, 0);
            this.BtnBuscarProdutos.Name = "BtnBuscarProdutos";
            this.BtnBuscarProdutos.Size = new System.Drawing.Size(258, 45);
            this.BtnBuscarProdutos.TabIndex = 5;
            this.BtnBuscarProdutos.Text = "Produtos";
            this.BtnBuscarProdutos.UseVisualStyleBackColor = false;
            this.BtnBuscarProdutos.Click += new System.EventHandler(this.BtnBuscarProdutos_Click);
            // 
            // PanelCadastro
            // 
            this.PanelCadastro.BackColor = System.Drawing.Color.Transparent;
            this.PanelCadastro.Controls.Add(this.BtnCadastroCliente);
            this.PanelCadastro.Controls.Add(this.BtnCadastroProdutos);
            this.PanelCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCadastro.Location = new System.Drawing.Point(0, 258);
            this.PanelCadastro.Name = "PanelCadastro";
            this.PanelCadastro.Size = new System.Drawing.Size(258, 91);
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
            this.BtnCadastroCliente.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroCliente.Location = new System.Drawing.Point(0, 45);
            this.BtnCadastroCliente.Name = "BtnCadastroCliente";
            this.BtnCadastroCliente.Size = new System.Drawing.Size(258, 45);
            this.BtnCadastroCliente.TabIndex = 5;
            this.BtnCadastroCliente.Text = "Cliente";
            this.BtnCadastroCliente.UseVisualStyleBackColor = false;
            this.BtnCadastroCliente.Click += new System.EventHandler(this.BtnCadastroCliente_Click);
            // 
            // BtnCadastroProdutos
            // 
            this.BtnCadastroProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.BtnCadastroProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroProdutos.FlatAppearance.BorderSize = 0;
            this.BtnCadastroProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastroProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroProdutos.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCadastroProdutos.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCadastroProdutos.Location = new System.Drawing.Point(0, 0);
            this.BtnCadastroProdutos.Name = "BtnCadastroProdutos";
            this.BtnCadastroProdutos.Size = new System.Drawing.Size(258, 45);
            this.BtnCadastroProdutos.TabIndex = 4;
            this.BtnCadastroProdutos.Text = "Produtos";
            this.BtnCadastroProdutos.UseVisualStyleBackColor = false;
            this.BtnCadastroProdutos.Click += new System.EventHandler(this.BtnCadastroProdutos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbCargo);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbUsuario);
            this.panel3.Location = new System.Drawing.Point(972, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 48);
            this.panel3.TabIndex = 10;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("RBNo3.1 ExtraLight", 10F, System.Drawing.FontStyle.Bold);
            this.lbCargo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbCargo.Location = new System.Drawing.Point(57, 22);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(87, 18);
            this.lbCargo.TabIndex = 14;
            this.lbCargo.Text = "VENDEDOR";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("RBNo3.1 Book", 11F, System.Drawing.FontStyle.Bold);
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(56, 5);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(69, 19);
            this.lbUsuario.TabIndex = 11;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lbCaixa);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(846, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 48);
            this.panel4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Book", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 16;
            // 
            // lbCaixa
            // 
            this.lbCaixa.AutoSize = true;
            this.lbCaixa.Font = new System.Drawing.Font("RBNo3.1 ExtraLight", 10F, System.Drawing.FontStyle.Bold);
            this.lbCaixa.ForeColor = System.Drawing.Color.Crimson;
            this.lbCaixa.Location = new System.Drawing.Point(38, 23);
            this.lbCaixa.Name = "lbCaixa";
            this.lbCaixa.Size = new System.Drawing.Size(72, 18);
            this.lbCaixa.TabIndex = 14;
            this.lbCaixa.Text = "OFFILINE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Book", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "CAIXA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("RBNo3.1 Book", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(69, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 18);
            this.textBox2.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLancamentos
            // 
            this.btnLancamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.btnLancamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLancamentos.FlatAppearance.BorderSize = 0;
            this.btnLancamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnLancamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnLancamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamentos.Font = new System.Drawing.Font("RBNo3.1 Book", 12F, System.Drawing.FontStyle.Bold);
            this.btnLancamentos.ForeColor = System.Drawing.Color.Transparent;
            this.btnLancamentos.Location = new System.Drawing.Point(0, 45);
            this.btnLancamentos.Name = "btnLancamentos";
            this.btnLancamentos.Size = new System.Drawing.Size(258, 45);
            this.btnLancamentos.TabIndex = 7;
            this.btnLancamentos.Text = "Lançamentos";
            this.btnLancamentos.UseVisualStyleBackColor = false;
            this.btnLancamentos.Click += new System.EventHandler(this.btnLancamentos_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Caixa;
            this.pictureBox3.Location = new System.Drawing.Point(5, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ProjFerrazIrrigacoes.Properties.Resources.UsuarioBoi;
            this.pictureBox2.Location = new System.Drawing.Point(9, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = global::ProjFerrazIrrigacoes.Properties.Resources.exit1;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSair.Location = new System.Drawing.Point(1221, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(15, 15);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnOrdemDeServico
            // 
            this.BtnOrdemDeServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOrdemDeServico.FlatAppearance.BorderSize = 0;
            this.BtnOrdemDeServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnOrdemDeServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnOrdemDeServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrdemDeServico.Font = new System.Drawing.Font("RBNo3.1 Book", 14F, System.Drawing.FontStyle.Bold);
            this.BtnOrdemDeServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnOrdemDeServico.Image = global::ProjFerrazIrrigacoes.Properties.Resources.OrdemDeServico;
            this.BtnOrdemDeServico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOrdemDeServico.Location = new System.Drawing.Point(0, 555);
            this.BtnOrdemDeServico.Name = "BtnOrdemDeServico";
            this.BtnOrdemDeServico.Size = new System.Drawing.Size(258, 57);
            this.BtnOrdemDeServico.TabIndex = 9;
            this.BtnOrdemDeServico.Text = "Ordem de Serviço";
            this.BtnOrdemDeServico.UseVisualStyleBackColor = true;
            this.BtnOrdemDeServico.Click += new System.EventHandler(this.BtnOrdemDeServico_Click_1);
            this.BtnOrdemDeServico.Leave += new System.EventHandler(this.BtnOrdemDeServico_Leave);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("RBNo3.1 Book", 14F, System.Drawing.FontStyle.Bold);
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnBuscar.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(0, 406);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(258, 57);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            this.BtnBuscar.Leave += new System.EventHandler(this.BtnBuscar_Leave);
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Font = new System.Drawing.Font("RBNo3.1 Book", 14F, System.Drawing.FontStyle.Bold);
            this.BtnEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnEmpresa.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Produtos;
            this.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpresa.Location = new System.Drawing.Point(0, 349);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(258, 57);
            this.BtnEmpresa.TabIndex = 5;
            this.BtnEmpresa.Text = "Empresa";
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            this.BtnEmpresa.Leave += new System.EventHandler(this.BtnEmpresa_Leave);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastro.FlatAppearance.BorderSize = 0;
            this.BtnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastro.Font = new System.Drawing.Font("RBNo3.1 Book", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnCadastro.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Cadastro;
            this.BtnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCadastro.Location = new System.Drawing.Point(0, 201);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(258, 57);
            this.BtnCadastro.TabIndex = 3;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click_1);
            this.BtnCadastro.Leave += new System.EventHandler(this.BtnCadastro_Leave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("RBNo3.1 Book", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.BtnDashboard.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Dashboard;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(258, 57);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjFerrazIrrigacoes.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1243, 720);
            this.Controls.Add(this.panel4);
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
            this.panel1.ResumeLayout(false);
            this.PanelOrdemDeServico.ResumeLayout(false);
            this.PanelBuscar.ResumeLayout(false);
            this.PanelCadastro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel PanelOrdemDeServico;
        private System.Windows.Forms.Button BtnOrdemDeServico;
        private System.Windows.Forms.Panel PanelBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Panel PanelCadastro;
        private System.Windows.Forms.Button BtnCadastroCliente;
        private System.Windows.Forms.Button BtnCadastroProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button BtnBuscarProdutos;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbCaixa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLancamentos;
    }
}

