using BLL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFerrazIrrigacoes
{
    public partial class frmDashboard : Form
    {
        int CodigoCaixa = 0;
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            VerificaCaixa();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void VerificaCaixa()
        {
            bllCaixa objBusca = new bllCaixa();

            CodigoCaixa = objBusca.BuscaPorCodigo();

            if (CodigoCaixa == 0)
            {
                lbTotalCaixa.Text = "0";
            }

            else if (CodigoCaixa != 0)
            {
                bllCaixa objSaldo = new bllCaixa();
                lbTotalCaixa.Text = Convert.ToString(objSaldo.CalculaCaixa(CodigoCaixa));
            }

            modCaixa objDados = new modCaixa();
            objDados = objBusca.ConsultaDataAbertura(CodigoCaixa);
            lbAbertura.Text = "R$ " + objDados.TotalInicial.ToString();

            bllLancamento calculo = new bllLancamento();
            CodigoCaixa = objBusca.BuscaPorCodigo();


            lbVendas.Text = "R$ " + Convert.ToString(calculo.TotalLancamento(CodigoCaixa));

            bllCliente cliente = new bllCliente();
            lbClientes.Text = Convert.ToString(cliente.CalculaCliente());

            List<double> lista = new List<double>();
            lista = objBusca.GraficoCaixas();
            cGraficoCaixas.DataSource = lista;  

        }
    }
}
