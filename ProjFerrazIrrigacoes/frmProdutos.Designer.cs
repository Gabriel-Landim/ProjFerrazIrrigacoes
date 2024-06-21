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
            ((System.ComponentModel.ISupportInitialize)(this.gvProdutos)).BeginInit();
            this.pBuscaProduto.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.tbDescricao);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.cbMarca);
            this.panel2.Controls.Add(this.cbCategoria);
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
            // frmProdutos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pBuscaProduto);
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
        private System.Windows.Forms.TextBox tbProdutoNome;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDescricao;
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
    }
}