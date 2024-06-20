namespace ProjFerrazIrrigacoes
{
    partial class frmBuscar
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
            this.btGravar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gvBuscaNome = new System.Windows.Forms.DataGridView();
            this.pProcurarCliente = new System.Windows.Forms.Panel();
            this.tbBuscaCliente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbCep = new System.Windows.Forms.MaskedTextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextoVertical1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextoVertical2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscaNome)).BeginInit();
            this.pProcurarCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btGravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btGravar.Location = new System.Drawing.Point(232, 550);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(119, 34);
            this.btGravar.TabIndex = 13;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btAlterar.Location = new System.Drawing.Point(358, 550);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(119, 34);
            this.btAlterar.TabIndex = 17;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Enabled = false;
            this.btDeletar.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.btDeletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.btDeletar.Location = new System.Drawing.Point(481, 550);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(119, 34);
            this.btDeletar.TabIndex = 18;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.button3.Location = new System.Drawing.Point(605, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 34);
            this.button3.TabIndex = 19;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gvBuscaNome
            // 
            this.gvBuscaNome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.gvBuscaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBuscaNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBuscaNome.Location = new System.Drawing.Point(4, 28);
            this.gvBuscaNome.Name = "gvBuscaNome";
            this.gvBuscaNome.Size = new System.Drawing.Size(440, 391);
            this.gvBuscaNome.TabIndex = 20;
            this.gvBuscaNome.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBuscaNome_CellDoubleClick);
            // 
            // pProcurarCliente
            // 
            this.pProcurarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pProcurarCliente.Controls.Add(this.tbBuscaCliente);
            this.pProcurarCliente.Controls.Add(this.gvBuscaNome);
            this.pProcurarCliente.Location = new System.Drawing.Point(441, 88);
            this.pProcurarCliente.Name = "pProcurarCliente";
            this.pProcurarCliente.Size = new System.Drawing.Size(447, 422);
            this.pProcurarCliente.TabIndex = 21;
            // 
            // tbBuscaCliente
            // 
            this.tbBuscaCliente.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscaCliente.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbBuscaCliente.Location = new System.Drawing.Point(4, 3);
            this.tbBuscaCliente.Name = "tbBuscaCliente";
            this.tbBuscaCliente.Size = new System.Drawing.Size(440, 25);
            this.tbBuscaCliente.TabIndex = 31;
            this.tbBuscaCliente.Text = "Busque pelo Nome";
            this.tbBuscaCliente.TextChanged += new System.EventHandler(this.tbBuscaCliente_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.tbCep);
            this.panel2.Controls.Add(this.cbCidade);
            this.panel2.Controls.Add(this.tbComplemento);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbBairro);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbNumero);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbRua);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(122, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 295);
            this.panel2.TabIndex = 22;
            // 
            // tbCep
            // 
            this.tbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCep.Location = new System.Drawing.Point(27, 252);
            this.tbCep.Mask = "00000-000";
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(232, 23);
            this.tbCep.TabIndex = 28;
            this.tbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbCidade
            // 
            this.cbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(27, 199);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(232, 21);
            this.cbCidade.TabIndex = 26;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbComplemento.Location = new System.Drawing.Point(27, 89);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(193, 23);
            this.tbComplemento.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label11.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(24, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Complemento";
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbBairro.Location = new System.Drawing.Point(27, 142);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(232, 23);
            this.tbBairro.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label10.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(24, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bairro";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNumero.Location = new System.Drawing.Point(226, 89);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(33, 23);
            this.tbNumero.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(230, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nº";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label7.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(24, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "CEP";
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbRua.Location = new System.Drawing.Point(27, 36);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(232, 23);
            this.tbRua.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label5.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(24, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Telefone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(29, 135);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 20);
            this.tbEmail.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Light", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbId.Location = new System.Drawing.Point(390, 8);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(47, 23);
            this.tbId.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("RBNo3.1 Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(362, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "ID";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.tbNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbNomeCliente.Location = new System.Drawing.Point(84, 8);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(268, 23);
            this.tbNomeCliente.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbCpf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Location = new System.Drawing.Point(122, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 171);
            this.panel1.TabIndex = 31;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTelefone.Location = new System.Drawing.Point(29, 88);
            this.tbTelefone.Mask = "(00)00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(232, 23);
            this.tbTelefone.TabIndex = 28;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbCpf
            // 
            this.tbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCpf.Location = new System.Drawing.Point(29, 39);
            this.tbCpf.Mask = "000.000.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(232, 23);
            this.tbCpf.TabIndex = 27;
            this.tbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbNomeCliente);
            this.panel3.Controls.Add(this.tbId);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(441, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 38);
            this.panel3.TabIndex = 32;
            // 
            // TextoVertical1
            // 
            this.TextoVertical1.BackColor = System.Drawing.Color.Transparent;
            this.TextoVertical1.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.TextoVertical1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextoVertical1.Location = new System.Drawing.Point(-29, -11);
            this.TextoVertical1.Name = "TextoVertical1";
            this.TextoVertical1.Size = new System.Drawing.Size(74, 175);
            this.TextoVertical1.TabIndex = 31;
            this.TextoVertical1.Click += new System.EventHandler(this.TextoVertical1_Click);
            this.TextoVertical1.Paint += new System.Windows.Forms.PaintEventHandler(this.TextoVertical1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.TextoVertical1);
            this.panel5.Location = new System.Drawing.Point(100, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 171);
            this.panel5.TabIndex = 35;
            // 
            // TextoVertical2
            // 
            this.TextoVertical2.BackColor = System.Drawing.Color.Transparent;
            this.TextoVertical2.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.TextoVertical2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextoVertical2.Location = new System.Drawing.Point(-28, 43);
            this.TextoVertical2.Name = "TextoVertical2";
            this.TextoVertical2.Size = new System.Drawing.Size(74, 183);
            this.TextoVertical2.TabIndex = 33;
            this.TextoVertical2.Paint += new System.Windows.Forms.PaintEventHandler(this.TextoVertical2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.TextoVertical2);
            this.panel4.Location = new System.Drawing.Point(100, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 295);
            this.panel4.TabIndex = 34;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pProcurarCliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscaNome)).EndInit();
            this.pProcurarCliente.ResumeLayout(false);
            this.pProcurarCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gvBuscaNome;
        private System.Windows.Forms.Panel pProcurarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbBuscaCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TextoVertical1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TextoVertical2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.MaskedTextBox tbCep;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
    }
}