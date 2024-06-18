using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;

namespace ProjFerrazIrrigacoes
{
    public partial class frmLancamentos : Form
    {
        int CodigoCaixa = 0;
        public frmLancamentos()
        {
            InitializeComponent();
        }
        private void frmLancamentos_Shown(object sender, EventArgs e)
        {
            VerificaCaixa();
            bllLancamento objbusca = new bllLancamento();
            gvLancamentos.DataSource = objbusca.CarregarLancamento(CodigoCaixa);
        }
        private void VerificaCaixa()
        {
            bllCaixa objBusca = new bllCaixa();

            CodigoCaixa = objBusca.BuscaPorCodigo();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                bllLancamento objbusca = new bllLancamento();
                modLancamento objDados = new modLancamento();

                objDados.Data = DateTime.Now;
                objDados.Movimento = Convert.ToString(cbMovimento.Text);
                objDados.Valor = Convert.ToDouble(tbValorLancamento.Text);
                objDados.Descricao = Convert.ToString(tbDescricao.Text);
                objDados.IdCaixa = CodigoCaixa;

                objbusca.InserirLancamento(objDados);

                gvLancamentos.DataSource = objbusca.CarregarLancamento(CodigoCaixa);

                MessageBox.Show("Lançamento realizado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        
    }
}
