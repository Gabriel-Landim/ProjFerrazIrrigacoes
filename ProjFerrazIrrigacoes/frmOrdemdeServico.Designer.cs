namespace ProjFerrazIrrigacoes
{
    partial class frmOrdemdeServico
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
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.tbPreçoUnit = new System.Windows.Forms.MaskedTextBox();
            this.tbValor = new System.Windows.Forms.MaskedTextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pProcurarCliente = new System.Windows.Forms.Panel();
            this.tbBuscaProdutoCompra = new System.Windows.Forms.TextBox();
            this.gvProdutosComprados = new System.Windows.Forms.DataGridView();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.tbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.tbMaodeObra = new System.Windows.Forms.MaskedTextBox();
            this.tbDesconto = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pProcurarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosComprados)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.btnNovaVenda);
            this.panel2.Controls.Add(this.tbPreçoUnit);
            this.panel2.Controls.Add(this.tbValor);
            this.panel2.Controls.Add(this.btAdicionar);
            this.panel2.Controls.Add(this.tbQuantidade);
            this.panel2.Controls.Add(this.cbProduto);
            this.panel2.Controls.Add(this.cbMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbUnidadeMedida);
            this.panel2.Controls.Add(this.cbCategoria);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(29, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 440);
            this.panel2.TabIndex = 57;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnNovaVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btnNovaVenda.Location = new System.Drawing.Point(7, 5);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(303, 40);
            this.btnNovaVenda.TabIndex = 54;
            this.btnNovaVenda.Text = "NovaVenda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // tbPreçoUnit
            // 
            this.tbPreçoUnit.Enabled = false;
            this.tbPreçoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbPreçoUnit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPreçoUnit.Location = new System.Drawing.Point(160, 304);
            this.tbPreçoUnit.Name = "tbPreçoUnit";
            this.tbPreçoUnit.Size = new System.Drawing.Size(115, 23);
            this.tbPreçoUnit.TabIndex = 53;
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbValor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbValor.Location = new System.Drawing.Point(160, 335);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(115, 23);
            this.tbValor.TabIndex = 52;
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btAdicionar.Location = new System.Drawing.Point(82, 380);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(119, 34);
            this.btAdicionar.TabIndex = 51;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbQuantidade.Location = new System.Drawing.Point(160, 273);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(115, 23);
            this.tbQuantidade.TabIndex = 50;
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(21, 209);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(254, 21);
            this.cbProduto.TabIndex = 47;
            this.cbProduto.TextChanged += new System.EventHandler(this.cbProduto_TextChanged);
            this.cbProduto.Leave += new System.EventHandler(this.cbProduto_Leave);
            // 
            // cbMarca
            // 
            this.cbMarca.Enabled = false;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(20, 65);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(255, 21);
            this.cbMarca.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Unidade Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(98, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(40, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quantidade";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.Enabled = false;
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(21, 159);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(254, 21);
            this.cbUnidadeMedida.TabIndex = 39;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(21, 112);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(254, 21);
            this.cbCategoria.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(17, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 42;
            this.label6.Tag = "";
            this.label6.Text = "Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 45;
            this.label7.Tag = "";
            this.label7.Text = "Preço Unitário";
            // 
            // pProcurarCliente
            // 
            this.pProcurarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pProcurarCliente.Controls.Add(this.tbBuscaProdutoCompra);
            this.pProcurarCliente.Controls.Add(this.gvProdutosComprados);
            this.pProcurarCliente.Controls.Add(this.btAlterar);
            this.pProcurarCliente.Controls.Add(this.btDeletar);
            this.pProcurarCliente.Location = new System.Drawing.Point(336, 116);
            this.pProcurarCliente.Name = "pProcurarCliente";
            this.pProcurarCliente.Size = new System.Drawing.Size(365, 452);
            this.pProcurarCliente.TabIndex = 53;
            // 
            // tbBuscaProdutoCompra
            // 
            this.tbBuscaProdutoCompra.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.tbBuscaProdutoCompra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbBuscaProdutoCompra.Location = new System.Drawing.Point(9, 32);
            this.tbBuscaProdutoCompra.Name = "tbBuscaProdutoCompra";
            this.tbBuscaProdutoCompra.Size = new System.Drawing.Size(346, 30);
            this.tbBuscaProdutoCompra.TabIndex = 31;
            this.tbBuscaProdutoCompra.Text = "Digite o produto";
            this.tbBuscaProdutoCompra.TextChanged += new System.EventHandler(this.tbBuscaProdutoCompra_TextChanged);
            // 
            // gvProdutosComprados
            // 
            this.gvProdutosComprados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.gvProdutosComprados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdutosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdutosComprados.Location = new System.Drawing.Point(9, 55);
            this.gvProdutosComprados.Name = "gvProdutosComprados";
            this.gvProdutosComprados.Size = new System.Drawing.Size(346, 346);
            this.gvProdutosComprados.TabIndex = 20;
            this.gvProdutosComprados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProdutosComprados_CellDoubleClick);
            // 
            // btAlterar
            // 
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btAlterar.Location = new System.Drawing.Point(59, 407);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(119, 34);
            this.btAlterar.TabIndex = 58;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btDeletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btDeletar.Location = new System.Drawing.Point(188, 407);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(119, 34);
            this.btDeletar.TabIndex = 59;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.tbTelefone);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cbCliente);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(29, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 41);
            this.panel3.TabIndex = 60;
            // 
            // tbTelefone
            // 
            this.tbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.tbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefone.Enabled = false;
            this.tbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbTelefone.Location = new System.Drawing.Point(529, 10);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(133, 23);
            this.tbTelefone.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(440, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Telefone";
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(81, 7);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(255, 28);
            this.cbCliente.TabIndex = 52;
            this.cbCliente.Leave += new System.EventHandler(this.cbCliente_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cliente";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbId.Location = new System.Drawing.Point(386, 10);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(50, 23);
            this.tbId.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(358, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btnConcluirVenda);
            this.panel1.Controls.Add(this.btnPagamento);
            this.panel1.Controls.Add(this.tbValorTotal);
            this.panel1.Controls.Add(this.tbMaodeObra);
            this.panel1.Controls.Add(this.tbDesconto);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(707, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 251);
            this.panel1.TabIndex = 58;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnConcluirVenda.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConcluirVenda.Location = new System.Drawing.Point(13, 202);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(235, 34);
            this.btnConcluirVenda.TabIndex = 61;
            this.btnConcluirVenda.Text = "Concluir venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            // 
            // btnPagamento
            // 
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btnPagamento.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPagamento.Location = new System.Drawing.Point(44, 151);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(172, 34);
            this.btnPagamento.TabIndex = 60;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbValorTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbValorTotal.Location = new System.Drawing.Point(133, 103);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(115, 23);
            this.tbValorTotal.TabIndex = 56;
            this.tbValorTotal.TextChanged += new System.EventHandler(this.tbValorTotal_TextChanged);
            // 
            // tbMaodeObra
            // 
            this.tbMaodeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbMaodeObra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMaodeObra.Location = new System.Drawing.Point(133, 72);
            this.tbMaodeObra.Name = "tbMaodeObra";
            this.tbMaodeObra.Size = new System.Drawing.Size(115, 23);
            this.tbMaodeObra.TabIndex = 55;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbDesconto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDesconto.Location = new System.Drawing.Point(133, 41);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(115, 23);
            this.tbDesconto.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(26, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Valor Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(34, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 23);
            this.label15.TabIndex = 34;
            this.label15.Text = "Desconto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(7, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 23);
            this.label17.TabIndex = 45;
            this.label17.Tag = "";
            this.label17.Text = "Mão de Obra";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(336, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 37);
            this.panel4.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RBNo3.1 Book", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.label12.Location = new System.Drawing.Point(76, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "Itens Comprados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(29, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 37);
            this.panel5.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("RBNo3.1 Book", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.label11.Location = new System.Drawing.Point(65, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 28);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nova Compra";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(707, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 37);
            this.panel6.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("RBNo3.1 Book", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.label13.Location = new System.Drawing.Point(79, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "Extrato";
            // 
            // frmOrdemdeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pProcurarCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdemdeServico";
            this.Text = "frmOrdemdeServico";
            this.Shown += new System.EventHandler(this.frmOrdemdeServico_Shown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pProcurarCliente.ResumeLayout(false);
            this.pProcurarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutosComprados)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pProcurarCliente;
        private System.Windows.Forms.TextBox tbBuscaProdutoCompra;
        private System.Windows.Forms.DataGridView gvProdutosComprados;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox tbPreçoUnit;
        private System.Windows.Forms.MaskedTextBox tbValor;
        private System.Windows.Forms.MaskedTextBox tbValorTotal;
        private System.Windows.Forms.MaskedTextBox tbMaodeObra;
        private System.Windows.Forms.MaskedTextBox tbDesconto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNovaVenda;
    }
}