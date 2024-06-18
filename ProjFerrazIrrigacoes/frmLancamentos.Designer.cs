namespace ProjFerrazIrrigacoes
{
    partial class frmLancamentos
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
            this.pProcurarCliente = new System.Windows.Forms.Panel();
            this.tbBuscaProdutoCompra = new System.Windows.Forms.TextBox();
            this.gvLancamentos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValorLancamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMovimento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pProcurarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLancamentos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pProcurarCliente
            // 
            this.pProcurarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pProcurarCliente.Controls.Add(this.tbBuscaProdutoCompra);
            this.pProcurarCliente.Controls.Add(this.gvLancamentos);
            this.pProcurarCliente.Location = new System.Drawing.Point(479, 55);
            this.pProcurarCliente.Name = "pProcurarCliente";
            this.pProcurarCliente.Size = new System.Drawing.Size(365, 452);
            this.pProcurarCliente.TabIndex = 62;
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
            // 
            // gvLancamentos
            // 
            this.gvLancamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.gvLancamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLancamentos.Location = new System.Drawing.Point(9, 55);
            this.gvLancamentos.Name = "gvLancamentos";
            this.gvLancamentos.Size = new System.Drawing.Size(346, 386);
            this.gvLancamentos.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.tbDescricao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbValorLancamento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btAdicionar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbMovimento);
            this.panel2.Location = new System.Drawing.Point(156, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 450);
            this.panel2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // tbDescricao
            // 
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbDescricao.Location = new System.Drawing.Point(20, 222);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(254, 91);
            this.tbDescricao.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Descrição";
            // 
            // tbValorLancamento
            // 
            this.tbValorLancamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValorLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbValorLancamento.Location = new System.Drawing.Point(21, 168);
            this.tbValorLancamento.Name = "tbValorLancamento";
            this.tbValorLancamento.Size = new System.Drawing.Size(254, 23);
            this.tbValorLancamento.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Valor";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Movimento";
            // 
            // cbMovimento
            // 
            this.cbMovimento.FormattingEnabled = true;
            this.cbMovimento.Items.AddRange(new object[] {
            "C",
            "D"});
            this.cbMovimento.Location = new System.Drawing.Point(20, 119);
            this.cbMovimento.Name = "cbMovimento";
            this.cbMovimento.Size = new System.Drawing.Size(254, 21);
            this.cbMovimento.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RBNo3.1 Book", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.label12.Location = new System.Drawing.Point(102, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "Lançamentos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(479, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 37);
            this.panel4.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(156, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 37);
            this.panel1.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Book", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(63, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lançamentos";
            // 
            // frmLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pProcurarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLancamentos";
            this.Text = "frmLancamentos";
            this.Shown += new System.EventHandler(this.frmLancamentos_Shown);
            this.pProcurarCliente.ResumeLayout(false);
            this.pProcurarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLancamentos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pProcurarCliente;
        private System.Windows.Forms.TextBox tbBuscaProdutoCompra;
        private System.Windows.Forms.DataGridView gvLancamentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValorLancamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMovimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}