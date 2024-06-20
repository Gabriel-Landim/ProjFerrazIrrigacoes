namespace ProjFerrazIrrigacoes
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cGraficoCaixas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbVendas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbTotalCaixa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAbertura = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGraficoCaixas)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel6.Controls.Add(this.cGraficoCaixas);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(361, 251);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(553, 287);
            this.panel6.TabIndex = 9;
            // 
            // cGraficoCaixas
            // 
            this.cGraficoCaixas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.cGraficoCaixas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.cGraficoCaixas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cGraficoCaixas.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.cGraficoCaixas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cGraficoCaixas.Legends.Add(legend1);
            this.cGraficoCaixas.Location = new System.Drawing.Point(37, 47);
            this.cGraficoCaixas.Name = "cGraficoCaixas";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Caixa";
            series1.YValueMembers = "TotalFinal";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cGraficoCaixas.Series.Add(series1);
            this.cGraficoCaixas.Size = new System.Drawing.Size(484, 217);
            this.cGraficoCaixas.TabIndex = 1;
            this.cGraficoCaixas.Text = "Grapichs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("RBNo3.1 Light", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gráficos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lbClientes);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(83, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 285);
            this.panel5.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Detalhes referentes ao dia";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("RBNo3.1 Bold", 100F, System.Drawing.FontStyle.Bold);
            this.lbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.lbClientes.Location = new System.Drawing.Point(16, 57);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(230, 173);
            this.lbClientes.TabIndex = 2;
            this.lbClientes.Text = "21";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("RBNo3.1 Light", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(30, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Número de Clientes";
            // 
            // lbVendas
            // 
            this.lbVendas.AutoSize = true;
            this.lbVendas.Font = new System.Drawing.Font("RBNo3.1 Bold", 21F, System.Drawing.FontStyle.Bold);
            this.lbVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.lbVendas.Location = new System.Drawing.Point(70, 56);
            this.lbVendas.Name = "lbVendas";
            this.lbVendas.Size = new System.Drawing.Size(160, 36);
            this.lbVendas.TabIndex = 0;
            this.lbVendas.Text = "R$ 41.247";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel4.Controls.Add(this.lbTotalCaixa);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(372, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 138);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Money;
            this.pictureBox3.Location = new System.Drawing.Point(18, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lbTotalCaixa
            // 
            this.lbTotalCaixa.AutoSize = true;
            this.lbTotalCaixa.Font = new System.Drawing.Font("RBNo3.1 Bold", 21F, System.Drawing.FontStyle.Bold);
            this.lbTotalCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            this.lbTotalCaixa.Location = new System.Drawing.Point(126, 59);
            this.lbTotalCaixa.Name = "lbTotalCaixa";
            this.lbTotalCaixa.Size = new System.Drawing.Size(36, 36);
            this.lbTotalCaixa.TabIndex = 0;
            this.lbTotalCaixa.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detalhes retirados do caixa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("RBNo3.1 Light", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total do Caixa";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbVendas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(83, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 138);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Money;
            this.pictureBox2.Location = new System.Drawing.Point(13, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalhes retirados do caixa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("RBNo3.1 Light", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbAbertura);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(656, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 138);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjFerrazIrrigacoes.Properties.Resources.Money;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbAbertura
            // 
            this.lbAbertura.AutoSize = true;
            this.lbAbertura.Font = new System.Drawing.Font("RBNo3.1 Bold", 21F, System.Drawing.FontStyle.Bold);
            this.lbAbertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.lbAbertura.Location = new System.Drawing.Point(69, 60);
            this.lbAbertura.Name = "lbAbertura";
            this.lbAbertura.Size = new System.Drawing.Size(158, 36);
            this.lbAbertura.TabIndex = 0;
            this.lbAbertura.Text = "R$ 11.354";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("RBNo3.1 Light", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Detalhes retirados do caixa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("RBNo3.1 Light", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(70, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total de Abertura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RBNo3.1 Bold", 21F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(76, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "R$";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGraficoCaixas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbVendas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbTotalCaixa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAbertura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart cGraficoCaixas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}