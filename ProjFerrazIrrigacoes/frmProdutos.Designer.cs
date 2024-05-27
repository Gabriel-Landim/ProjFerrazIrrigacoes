namespace ProjFerrazIrrigacoes
{
    partial class frmProdutos
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
            this.tbEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.LBBuscar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvProdutos = new System.Windows.Forms.DataGridView();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtProduto = new System.Windows.Forms.Label();
            this.tbProdutoNome = new System.Windows.Forms.TextBox();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.tbCategoria = new System.Windows.Forms.ComboBox();
            this.tbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pMarca = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pUniMedida = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnMarcaAdd = new System.Windows.Forms.Button();
            this.BtnUniMedidasAdd = new System.Windows.Forms.Button();
            this.BtnCategoriasAdd = new System.Windows.Forms.Button();
            this.BtnMarcasAdd = new System.Windows.Forms.Button();
            this.btnCategoriaAdd = new System.Windows.Forms.Button();
            this.btnUniMedidaAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            this.pMarca.SuspendLayout();
            this.pCategoria.SuspendLayout();
            this.pUniMedida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEditar
            // 
            this.tbEditar.Font = new System.Drawing.Font("RBNo3.1 Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.tbEditar.Location = new System.Drawing.Point(155, 437);
            this.tbEditar.Name = "tbEditar";
            this.tbEditar.Size = new System.Drawing.Size(106, 34);
            this.tbEditar.TabIndex = 2;
            this.tbEditar.Text = "Editar";
            this.tbEditar.UseVisualStyleBackColor = true;
            this.tbEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("RBNo3.1 Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btExcluir.Location = new System.Drawing.Point(389, 437);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(106, 34);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // LBBuscar
            // 
            this.LBBuscar.AutoSize = true;
            this.LBBuscar.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBBuscar.Location = new System.Drawing.Point(292, 31);
            this.LBBuscar.Name = "LBBuscar";
            this.LBBuscar.Size = new System.Drawing.Size(134, 21);
            this.LBBuscar.TabIndex = 4;
            this.LBBuscar.Text = "Buscar Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.gvProdutos);
            this.panel1.Controls.Add(this.tbBusca);
            this.panel1.Location = new System.Drawing.Point(296, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 251);
            this.panel1.TabIndex = 7;
            // 
            // gvProdutos
            // 
            this.gvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.gvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdutos.Location = new System.Drawing.Point(6, 27);
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.Size = new System.Drawing.Size(170, 216);
            this.gvProdutos.TabIndex = 1;
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(6, 8);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(170, 20);
            this.tbBusca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unidade Medida";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(31, 214);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(232, 20);
            this.tbValor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(29, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estoque";
            // 
            // tbEstoque
            // 
            this.tbEstoque.Location = new System.Drawing.Point(31, 260);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(232, 20);
            this.tbEstoque.TabIndex = 15;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("RBNo3.1 Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnGravar.Location = new System.Drawing.Point(273, 437);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(106, 34);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Font = new System.Drawing.Font("RBNo3.1 Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btVoltar.Location = new System.Drawing.Point(505, 437);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(106, 34);
            this.btVoltar.TabIndex = 17;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estoque";
            // 
            // BtProduto
            // 
            this.BtProduto.AutoSize = true;
            this.BtProduto.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtProduto.Location = new System.Drawing.Point(30, 284);
            this.BtProduto.Name = "BtProduto";
            this.BtProduto.Size = new System.Drawing.Size(126, 21);
            this.BtProduto.TabIndex = 22;
            this.BtProduto.Text = "Nome Produto";
            this.BtProduto.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbProdutoNome
            // 
            this.tbProdutoNome.Location = new System.Drawing.Point(33, 308);
            this.tbProdutoNome.Name = "tbProdutoNome";
            this.tbProdutoNome.Size = new System.Drawing.Size(232, 20);
            this.tbProdutoNome.TabIndex = 21;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(32, 168);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(231, 21);
            this.cbUnidadeMedida.TabIndex = 25;
            // 
            // tbCategoria
            // 
            this.tbCategoria.FormattingEnabled = true;
            this.tbCategoria.Location = new System.Drawing.Point(32, 122);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(231, 21);
            this.tbCategoria.TabIndex = 26;
            // 
            // tbMarca
            // 
            this.tbMarca.FormattingEnabled = true;
            this.tbMarca.Location = new System.Drawing.Point(31, 77);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(231, 21);
            this.tbMarca.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(32, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 20);
            this.textBox2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(88, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Descrição";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 401);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 30);
            this.textBox3.TabIndex = 30;
            // 
            // pMarca
            // 
            this.pMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pMarca.Controls.Add(this.btnMarcaAdd);
            this.pMarca.Controls.Add(this.textBox4);
            this.pMarca.Controls.Add(this.label9);
            this.pMarca.Location = new System.Drawing.Point(484, 54);
            this.pMarca.Name = "pMarca";
            this.pMarca.Size = new System.Drawing.Size(243, 48);
            this.pMarca.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Adicionar marca";
            // 
            // pCategoria
            // 
            this.pCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pCategoria.Controls.Add(this.btnCategoriaAdd);
            this.pCategoria.Controls.Add(this.textBox5);
            this.pCategoria.Controls.Add(this.label12);
            this.pCategoria.Location = new System.Drawing.Point(484, 100);
            this.pCategoria.Name = "pCategoria";
            this.pCategoria.Size = new System.Drawing.Size(243, 48);
            this.pCategoria.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(2, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Adicionar categoria";
            // 
            // pUniMedida
            // 
            this.pUniMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pUniMedida.Controls.Add(this.btnUniMedidaAdd);
            this.pUniMedida.Controls.Add(this.textBox9);
            this.pUniMedida.Controls.Add(this.label14);
            this.pUniMedida.Location = new System.Drawing.Point(484, 147);
            this.pUniMedida.Name = "pUniMedida";
            this.pUniMedida.Size = new System.Drawing.Size(243, 48);
            this.pUniMedida.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(2, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Unidade de Medida";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("RBNo3.1 Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox9.Location = new System.Drawing.Point(5, 24);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(212, 22);
            this.textBox9.TabIndex = 35;
            this.textBox9.Text = "Exemplo: METRO-M";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("RBNo3.1 Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox4.Location = new System.Drawing.Point(5, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Exemplo: KRONA";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("RBNo3.1 Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox5.Location = new System.Drawing.Point(5, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 22);
            this.textBox5.TabIndex = 37;
            this.textBox5.Text = "Exemplo: TUBULAÇÃO";
            // 
            // btnMarcaAdd
            // 
            this.btnMarcaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnMarcaAdd.FlatAppearance.BorderSize = 0;
            this.btnMarcaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMarcaAdd.ForeColor = System.Drawing.Color.White;
            this.btnMarcaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnMarcaAdd.Location = new System.Drawing.Point(220, 22);
            this.btnMarcaAdd.Name = "btnMarcaAdd";
            this.btnMarcaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnMarcaAdd.TabIndex = 39;
            this.btnMarcaAdd.UseVisualStyleBackColor = false;
            // 
            // BtnUniMedidasAdd
            // 
            this.BtnUniMedidasAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnUniMedidasAdd.FlatAppearance.BorderSize = 0;
            this.BtnUniMedidasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUniMedidasAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnUniMedidasAdd.ForeColor = System.Drawing.Color.White;
            this.BtnUniMedidasAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar;
            this.BtnUniMedidasAdd.Location = new System.Drawing.Point(268, 167);
            this.BtnUniMedidasAdd.Name = "BtnUniMedidasAdd";
            this.BtnUniMedidasAdd.Size = new System.Drawing.Size(19, 22);
            this.BtnUniMedidasAdd.TabIndex = 38;
            this.BtnUniMedidasAdd.UseVisualStyleBackColor = false;
            this.BtnUniMedidasAdd.Click += new System.EventHandler(this.BtnUniMedidasAdd_Click);
            // 
            // BtnCategoriasAdd
            // 
            this.BtnCategoriasAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnCategoriasAdd.FlatAppearance.BorderSize = 0;
            this.BtnCategoriasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoriasAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCategoriasAdd.ForeColor = System.Drawing.Color.White;
            this.BtnCategoriasAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar;
            this.BtnCategoriasAdd.Location = new System.Drawing.Point(269, 121);
            this.BtnCategoriasAdd.Name = "BtnCategoriasAdd";
            this.BtnCategoriasAdd.Size = new System.Drawing.Size(19, 22);
            this.BtnCategoriasAdd.TabIndex = 37;
            this.BtnCategoriasAdd.UseVisualStyleBackColor = false;
            this.BtnCategoriasAdd.Click += new System.EventHandler(this.BtnCategoriasAdd_Click);
            // 
            // BtnMarcasAdd
            // 
            this.BtnMarcasAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnMarcasAdd.FlatAppearance.BorderSize = 0;
            this.BtnMarcasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcasAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnMarcasAdd.ForeColor = System.Drawing.Color.White;
            this.BtnMarcasAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar;
            this.BtnMarcasAdd.Location = new System.Drawing.Point(269, 77);
            this.BtnMarcasAdd.Name = "BtnMarcasAdd";
            this.BtnMarcasAdd.Size = new System.Drawing.Size(19, 22);
            this.BtnMarcasAdd.TabIndex = 18;
            this.BtnMarcasAdd.UseVisualStyleBackColor = false;
            this.BtnMarcasAdd.Click += new System.EventHandler(this.BtnMarcasAdd_Click);
            // 
            // btnCategoriaAdd
            // 
            this.btnCategoriaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoriaAdd.FlatAppearance.BorderSize = 0;
            this.btnCategoriaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCategoriaAdd.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnCategoriaAdd.Location = new System.Drawing.Point(219, 21);
            this.btnCategoriaAdd.Name = "btnCategoriaAdd";
            this.btnCategoriaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnCategoriaAdd.TabIndex = 40;
            this.btnCategoriaAdd.UseVisualStyleBackColor = false;
            // 
            // btnUniMedidaAdd
            // 
            this.btnUniMedidaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnUniMedidaAdd.FlatAppearance.BorderSize = 0;
            this.btnUniMedidaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniMedidaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUniMedidaAdd.ForeColor = System.Drawing.Color.White;
            this.btnUniMedidaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnUniMedidaAdd.Location = new System.Drawing.Point(219, 23);
            this.btnUniMedidaAdd.Name = "btnUniMedidaAdd";
            this.btnUniMedidaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnUniMedidaAdd.TabIndex = 41;
            this.btnUniMedidaAdd.UseVisualStyleBackColor = false;
            // 
            // frmProdutos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.BtnUniMedidasAdd);
            this.Controls.Add(this.BtnCategoriasAdd);
            this.Controls.Add(this.pUniMedida);
            this.Controls.Add(this.pCategoria);
            this.Controls.Add(this.pMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtProduto);
            this.Controls.Add(this.tbProdutoNome);
            this.Controls.Add(this.BtnMarcasAdd);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBBuscar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.tbEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            this.pMarca.ResumeLayout(false);
            this.pMarca.PerformLayout();
            this.pCategoria.ResumeLayout(false);
            this.pCategoria.PerformLayout();
            this.pUniMedida.ResumeLayout(false);
            this.pUniMedida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label LBBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvProdutos;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button BtnMarcasAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BtProduto;
        private System.Windows.Forms.TextBox tbProdutoNome;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.ComboBox tbCategoria;
        private System.Windows.Forms.ComboBox tbMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel pMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pUniMedida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button BtnCategoriasAdd;
        private System.Windows.Forms.Button BtnUniMedidasAdd;
        private System.Windows.Forms.Button btnMarcaAdd;
        private System.Windows.Forms.Button btnCategoriaAdd;
        private System.Windows.Forms.Button btnUniMedidaAdd;
    }
}