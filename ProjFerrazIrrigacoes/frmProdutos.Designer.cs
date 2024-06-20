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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.LBBuscar = new System.Windows.Forms.Label();
            this.gvProdutos = new System.Windows.Forms.DataGridView();
            this.tbBuscaProduto = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tbProdutoNome = new System.Windows.Forms.TextBox();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.BtnUniMedidasAdd = new System.Windows.Forms.Button();
            this.BtnCategoriasAdd = new System.Windows.Forms.Button();
            this.BtnMarcasAdd = new System.Windows.Forms.Button();
            this.pBuscaProduto = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pMarca = new System.Windows.Forms.Panel();
            this.btnMarcaAdd = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pUniMedida = new System.Windows.Forms.Panel();
            this.btnUniMedidaAdd = new System.Windows.Forms.Button();
            this.tbUnidMedida = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pCategoria = new System.Windows.Forms.Panel();
            this.btnCategoriaAdd = new System.Windows.Forms.Button();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            this.pBuscaProduto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pMarca.SuspendLayout();
            this.pUniMedida.SuspendLayout();
            this.pCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnEditar.Location = new System.Drawing.Point(268, 534);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnExcluir.Location = new System.Drawing.Point(502, 534);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 34);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // LBBuscar
            // 
            this.LBBuscar.AutoSize = true;
            this.LBBuscar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.LBBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBBuscar.Location = new System.Drawing.Point(448, 44);
            this.LBBuscar.Name = "LBBuscar";
            this.LBBuscar.Size = new System.Drawing.Size(149, 23);
            this.LBBuscar.TabIndex = 4;
            this.LBBuscar.Text = "Buscar Produto";
            // 
            // gvProdutos
            // 
            this.gvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.gvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdutos.Location = new System.Drawing.Point(4, 23);
            this.gvProdutos.Name = "gvProdutos";
            this.gvProdutos.Size = new System.Drawing.Size(440, 405);
            this.gvProdutos.TabIndex = 1;
            this.gvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProdutos_CellDoubleClick);
            // 
            // tbBuscaProduto
            // 
            this.tbBuscaProduto.Location = new System.Drawing.Point(3, 4);
            this.tbBuscaProduto.Name = "tbBuscaProduto";
            this.tbBuscaProduto.Size = new System.Drawing.Size(441, 20);
            this.tbBuscaProduto.TabIndex = 0;
            this.tbBuscaProduto.TextChanged += new System.EventHandler(this.tbBuscaProduto_TextChanged_1);
            // 
            // tbValor
            // 
            this.tbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbValor.Location = new System.Drawing.Point(28, 361);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(134, 23);
            this.tbValor.TabIndex = 12;
            // 
            // tbEstoque
            // 
            this.tbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbEstoque.Location = new System.Drawing.Point(168, 361);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(93, 23);
            this.tbEstoque.TabIndex = 15;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnGravar.Location = new System.Drawing.Point(386, 534);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(114, 34);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnLimpar.Location = new System.Drawing.Point(618, 534);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 34);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tbProdutoNome
            // 
            this.tbProdutoNome.Location = new System.Drawing.Point(29, 193);
            this.tbProdutoNome.Name = "tbProdutoNome";
            this.tbProdutoNome.Size = new System.Drawing.Size(232, 20);
            this.tbProdutoNome.TabIndex = 21;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(29, 138);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(231, 21);
            this.cbUnidadeMedida.TabIndex = 25;
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(30, 92);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(231, 21);
            this.cbCategoria.TabIndex = 26;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(29, 48);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(231, 21);
            this.cbMarca.TabIndex = 27;
            // 
            // tbId
            // 
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbId.Location = new System.Drawing.Point(64, 390);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(196, 23);
            this.tbId.TabIndex = 28;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(29, 242);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(232, 90);
            this.tbDescricao.TabIndex = 30;
            // 
            // BtnUniMedidasAdd
            // 
            this.BtnUniMedidasAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnUniMedidasAdd.FlatAppearance.BorderSize = 0;
            this.BtnUniMedidasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUniMedidasAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnUniMedidasAdd.ForeColor = System.Drawing.Color.White;
            this.BtnUniMedidasAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnUniMedidasAdd.Image")));
            this.BtnUniMedidasAdd.Location = new System.Drawing.Point(266, 137);
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
            this.BtnCategoriasAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategoriasAdd.Image")));
            this.BtnCategoriasAdd.Location = new System.Drawing.Point(267, 91);
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
            this.BtnMarcasAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnMarcasAdd.Image")));
            this.BtnMarcasAdd.Location = new System.Drawing.Point(267, 46);
            this.BtnMarcasAdd.Name = "BtnMarcasAdd";
            this.BtnMarcasAdd.Size = new System.Drawing.Size(19, 22);
            this.BtnMarcasAdd.TabIndex = 18;
            this.BtnMarcasAdd.UseVisualStyleBackColor = false;
            this.BtnMarcasAdd.Click += new System.EventHandler(this.BtnMarcasAdd_Click);
            // 
            // pBuscaProduto
            // 
            this.pBuscaProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pBuscaProduto.Controls.Add(this.tbBuscaProduto);
            this.pBuscaProduto.Controls.Add(this.gvProdutos);
            this.pBuscaProduto.Location = new System.Drawing.Point(449, 70);
            this.pBuscaProduto.Name = "pBuscaProduto";
            this.pBuscaProduto.Size = new System.Drawing.Size(449, 432);
            this.pBuscaProduto.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbId);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.BtnUniMedidasAdd);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.BtnCategoriasAdd);
            this.panel2.Controls.Add(this.tbDescricao);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.cbMarca);
            this.panel2.Controls.Add(this.cbCategoria);
            this.panel2.Controls.Add(this.BtnMarcasAdd);
            this.panel2.Controls.Add(this.tbValor);
            this.panel2.Controls.Add(this.cbUnidadeMedida);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.tbProdutoNome);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbEstoque);
            this.panel2.Location = new System.Drawing.Point(124, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 432);
            this.panel2.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(24, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 29;
            this.label13.Text = "Marca";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(25, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "Categoria";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(25, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 23);
            this.label16.TabIndex = 31;
            this.label16.Text = "Unidade Medida";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(25, 335);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 33;
            this.label17.Text = "Valor";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(173, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 23);
            this.label18.TabIndex = 34;
            this.label18.Text = "Estoque";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Control;
            this.label19.Location = new System.Drawing.Point(25, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 23);
            this.label19.TabIndex = 42;
            this.label19.Tag = "";
            this.label19.Text = "Produto";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(24, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 23);
            this.label20.TabIndex = 45;
            this.label20.Tag = "";
            this.label20.Text = "Descrição";
            // 
            // pMarca
            // 
            this.pMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.pMarca.Controls.Add(this.btnMarcaAdd);
            this.pMarca.Controls.Add(this.tbMarca);
            this.pMarca.Controls.Add(this.label9);
            this.pMarca.Location = new System.Drawing.Point(956, 172);
            this.pMarca.Name = "pMarca";
            this.pMarca.Size = new System.Drawing.Size(304, 48);
            this.pMarca.TabIndex = 58;
            this.pMarca.Visible = false;
            // 
            // btnMarcaAdd
            // 
            this.btnMarcaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnMarcaAdd.FlatAppearance.BorderSize = 0;
            this.btnMarcaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMarcaAdd.ForeColor = System.Drawing.Color.White;
            this.btnMarcaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnMarcaAdd.Location = new System.Drawing.Point(236, 22);
            this.btnMarcaAdd.Name = "btnMarcaAdd";
            this.btnMarcaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnMarcaAdd.TabIndex = 39;
            this.btnMarcaAdd.UseVisualStyleBackColor = false;
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbMarca.Location = new System.Drawing.Point(5, 23);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(225, 20);
            this.tbMarca.TabIndex = 36;
            this.tbMarca.Text = "Exemplo: KRONA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RBNo3.1 Light", 11F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Adicionar marca";
            // 
            // pUniMedida
            // 
            this.pUniMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.pUniMedida.Controls.Add(this.btnUniMedidaAdd);
            this.pUniMedida.Controls.Add(this.tbUnidMedida);
            this.pUniMedida.Controls.Add(this.label14);
            this.pUniMedida.Font = new System.Drawing.Font("RBNo3.1 Light", 11F, System.Drawing.FontStyle.Bold);
            this.pUniMedida.Location = new System.Drawing.Point(956, 267);
            this.pUniMedida.Name = "pUniMedida";
            this.pUniMedida.Size = new System.Drawing.Size(304, 48);
            this.pUniMedida.TabIndex = 60;
            this.pUniMedida.Visible = false;
            // 
            // btnUniMedidaAdd
            // 
            this.btnUniMedidaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnUniMedidaAdd.FlatAppearance.BorderSize = 0;
            this.btnUniMedidaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniMedidaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUniMedidaAdd.ForeColor = System.Drawing.Color.White;
            this.btnUniMedidaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnUniMedidaAdd.Location = new System.Drawing.Point(236, 22);
            this.btnUniMedidaAdd.Name = "btnUniMedidaAdd";
            this.btnUniMedidaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnUniMedidaAdd.TabIndex = 41;
            this.btnUniMedidaAdd.UseVisualStyleBackColor = false;
            // 
            // tbUnidMedida
            // 
            this.tbUnidMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnidMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbUnidMedida.Location = new System.Drawing.Point(5, 24);
            this.tbUnidMedida.Name = "tbUnidMedida";
            this.tbUnidMedida.Size = new System.Drawing.Size(225, 20);
            this.tbUnidMedida.TabIndex = 35;
            this.tbUnidMedida.Text = "Exemplo: METRO-M";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("RBNo3.1 Light", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(2, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "Adicionar Unidade de Medida";
            // 
            // pCategoria
            // 
            this.pCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.pCategoria.Controls.Add(this.btnCategoriaAdd);
            this.pCategoria.Controls.Add(this.tbCategoria);
            this.pCategoria.Controls.Add(this.label12);
            this.pCategoria.Location = new System.Drawing.Point(956, 219);
            this.pCategoria.Name = "pCategoria";
            this.pCategoria.Size = new System.Drawing.Size(304, 48);
            this.pCategoria.TabIndex = 59;
            this.pCategoria.Visible = false;
            // 
            // btnCategoriaAdd
            // 
            this.btnCategoriaAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoriaAdd.FlatAppearance.BorderSize = 0;
            this.btnCategoriaAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCategoriaAdd.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaAdd.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Adicionar2;
            this.btnCategoriaAdd.Location = new System.Drawing.Point(236, 21);
            this.btnCategoriaAdd.Name = "btnCategoriaAdd";
            this.btnCategoriaAdd.Size = new System.Drawing.Size(19, 22);
            this.btnCategoriaAdd.TabIndex = 40;
            this.btnCategoriaAdd.UseVisualStyleBackColor = false;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbCategoria.Location = new System.Drawing.Point(5, 22);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(225, 20);
            this.tbCategoria.TabIndex = 37;
            this.tbCategoria.Text = "Exemplo: TUBULAÇÃO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RBNo3.1 Light", 11F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(2, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "Adicionar categoria";
            // 
            // frmProdutos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.pMarca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pUniMedida);
            this.Controls.Add(this.pBuscaProduto);
            this.Controls.Add(this.pCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.LBBuscar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.Shown += new System.EventHandler(this.frmProdutos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).EndInit();
            this.pBuscaProduto.ResumeLayout(false);
            this.pBuscaProduto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pMarca.ResumeLayout(false);
            this.pMarca.PerformLayout();
            this.pUniMedida.ResumeLayout(false);
            this.pUniMedida.PerformLayout();
            this.pCategoria.ResumeLayout(false);
            this.pCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label LBBuscar;
        private System.Windows.Forms.DataGridView gvProdutos;
        private System.Windows.Forms.TextBox tbBuscaProduto;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button BtnMarcasAdd;
        private System.Windows.Forms.TextBox tbProdutoNome;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button BtnCategoriasAdd;
        private System.Windows.Forms.Button BtnUniMedidasAdd;
        private System.Windows.Forms.Panel pBuscaProduto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pMarca;
        private System.Windows.Forms.Button btnMarcaAdd;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pUniMedida;
        private System.Windows.Forms.Button btnUniMedidaAdd;
        private System.Windows.Forms.TextBox tbUnidMedida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pCategoria;
        private System.Windows.Forms.Button btnCategoriaAdd;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label label12;
    }
}