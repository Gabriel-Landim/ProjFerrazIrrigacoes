using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using BLL;
using Modelo;
using DAL;


namespace ProjFerrazIrrigacoes
{
    public partial class Form1 : Form
    {
        int CodigoCaixa = 0;
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        public void TrocaCaixa(bool status)
        {
            if (status)
            {
                lbCaixa.Text = "Aberto";
            }
            else
            {
                lbCaixa.Text = "Fechado";
            }
            
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr GetProcAddress(
            int nLeftRect,
            int nTopRect,
            int nLeftReact,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private Boolean ShowPanel = false;
        public Form1()
        {
            InitializeComponent();
            SubPanel();
            SubPanelBuscar();
            SubPanelOrdemDeServico();
            VerificaCaixa();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));          

            TituloDashboard.Text = "DashBoard";
            this.PanelCarregar.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            //int a;
            //a = 1;
            //string tr;
        }

        private void BtnCadastro_Click_1(object sender, EventArgs e)
        {
            ShowPanel = !ShowPanel;
            SubPanel();
            PainelNav.Height = BtnCadastro.Height;
            PainelNav.Top = BtnCadastro.Top;
            BtnCadastro.BackColor = Color.FromArgb(99, 115, 130);

            TituloDashboard.Text = "Cadastro";

        }

        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            PainelNav.Height = BtnDashboard.Height;
            PainelNav.Top = BtnDashboard.Top;
            PainelNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(99, 115, 130);

            TituloDashboard.Text = "DashBoard";
            this.PanelCarregar.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }
       

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            ShowPanel = !ShowPanel;
            SubPanelBuscar();
            PainelNav.Height = BtnEmpresa.Height;
            PainelNav.Top = BtnEmpresa.Top;
            BtnEmpresa.BackColor = Color.FromArgb(99, 115, 130);
        }

        private void BtnOrdemDeServico_Click_1(object sender, EventArgs e)
        {
            ShowPanel = !ShowPanel;
            SubPanelOrdemDeServico();
            PainelNav.Height = BtnOrdemDeServico.Height;
            PainelNav.Top = BtnOrdemDeServico.Top;
            BtnOrdemDeServico.BackColor = Color.FromArgb(99, 115, 130);

            TituloDashboard.Text = "Ordem de Servico";
            this.PanelCarregar.Controls.Clear();
            frmOrdemdeServico FrmOrdemdeServico_Vrb = new frmOrdemdeServico() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmOrdemdeServico_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmOrdemdeServico_Vrb);
            FrmOrdemdeServico_Vrb.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SubPanel() {
            if (ShowPanel)
            {
                PanelCadastro.Height = 90;
            }
            else {
                PanelCadastro.Height = 0;
            }
        }
        private void SubPanelBuscar()
        {
            if (ShowPanel)
            {

                PanelBuscar.Height = 90;
            }
            else
            {
                PanelBuscar.Height = 0;
            }
        }
        private void SubPanelOrdemDeServico()
        {
            if (ShowPanel)
            {

                PanelOrdemDeServico.Height = 46;
            }
            else
            {
                PanelOrdemDeServico.Height = 0;
            }
        }



        private void BtnCadastroCliente_Click(object sender, EventArgs e)
        {
            TituloDashboard.Text = "Cadastro Cliente";
            this.PanelCarregar.Controls.Clear();
            frmCadastroCliente FrmCadastroCriente_Vrb = new frmCadastroCliente() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCadastroCriente_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmCadastroCriente_Vrb);
            FrmCadastroCriente_Vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 0, false);
            //ColorBlend cb = new ColorBlend();
            //cb.Positions = new[] { 0, 1 / 6f, 2 / 6f, 3 / 6f, 4 / 6f, 5 / 6f, 1 };
            //cb.Colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
            //br.InterpolationColors = cb;
            //// rotate
            //br.RotateTransform(45);
            //// paint
            //e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void BtnCadastroProdutos_Click(object sender, EventArgs e)
        {
            TituloDashboard.Text = "Cadastro Produto";
            this.PanelCarregar.Controls.Clear();
            frmCadastroProdutos FrmCadastroProdutos_Vrb = new frmCadastroProdutos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCadastroProdutos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmCadastroProdutos_Vrb);
            FrmCadastroProdutos_Vrb.Show();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            PainelNav.Height = BtnEmpresa.Height;
            PainelNav.Top = BtnEmpresa.Top;
            BtnEmpresa.BackColor = Color.FromArgb(99, 115, 130);


            TituloDashboard.Text = "Cadastro Empresa";
            this.PanelCarregar.Controls.Clear();
            frmCadastro FrmCadastro_Vrb = new frmCadastro() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCadastro_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmCadastro_Vrb);
            FrmCadastro_Vrb.Show();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            TituloDashboard.Text = "Buscar Cliente";
            this.PanelCarregar.Controls.Clear();
            frmBuscar FrmBuscar_Vrb = new frmBuscar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmBuscar_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmBuscar_Vrb);
            FrmBuscar_Vrb.Show();
        }

        private void BtnBuscarProdutos_Click(object sender, EventArgs e)
        {
            PainelNav.Height = BtnDashboard.Height;
            PainelNav.Top = BtnDashboard.Top;
            PainelNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(99, 115, 130);

            TituloDashboard.Text = "Buscar Produto";
            this.PanelCarregar.Controls.Clear();
            frmProdutos FrmProdutos_Vrb = new frmProdutos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmProdutos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmProdutos_Vrb);
            FrmProdutos_Vrb.Show();
        }

        private void PanelCarregar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PainelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(33, 43, 53);
        }

        private void BtnOrdemDeServico_Leave(object sender, EventArgs e)
        {
            BtnOrdemDeServico.BackColor = Color.FromArgb(33, 43, 53);
        }

        private void BtnCadastro_Leave(object sender, EventArgs e)
        {
            BtnCadastro.BackColor = Color.FromArgb(33, 43, 53);
        }

        private void BtnEmpresa_Leave(object sender, EventArgs e)
        {
            BtnEmpresa.BackColor = Color.FromArgb(33, 43, 53);
        }

        private void BtnBuscar_Leave(object sender, EventArgs e)
        {
            BtnBuscar.BackColor = Color.FromArgb(33, 43, 53);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLancamentos_Click(object sender, EventArgs e)
        {
            TituloDashboard.Text = "Lançamentos";
            this.PanelCarregar.Controls.Clear();
            frmLancamentos FrmLancamentos_Vrb = new frmLancamentos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmLancamentos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PanelCarregar.Controls.Add(FrmLancamentos_Vrb);
            FrmLancamentos_Vrb.Show();
        }

        private void VerificaCaixa()
        {
            bllCaixa objBusca = new bllCaixa();

            CodigoCaixa = objBusca.BuscaPorCodigo();

            if (CodigoCaixa == 0)
            {
                lbCaixa.Text = "FECHADO";
                lbCaixa.ForeColor = Color.Red;
            }

            else if (CodigoCaixa != 0)
            {
                lbCaixa.Text = "ABERTO";
                lbCaixa.ForeColor = Color.Green;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VerificaCaixa();
        }
    }
    }

