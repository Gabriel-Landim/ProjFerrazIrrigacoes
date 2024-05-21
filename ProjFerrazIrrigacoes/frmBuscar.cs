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
    public partial class frmBuscar : Form
    {
        string operacao;
        public frmBuscar()
        {
            InitializeComponent();
        }

        //btnGravar
        private void button1_Click(object sender, EventArgs e)
        {
            bllCliente objgravar = new bllCliente();
            modCliente objdados = new modCliente();

            if (operacao == "I")
            {
                objdados.NomeCliente = tbNomeCliente.Text;

                objgravar.Inserir(objdados);
            }

            else
            {
                objdados.NomeCliente = tbNomeCliente.Text;
                objdados.Cpf = Convert.ToString(tbCPF.Text);
                objdados.Cep = Convert.ToString(tbCEP.Text);
                objdados.IdCidade = Convert.ToInt32(cbCidade.SelectedValue);
                objdados.Rua = Convert.ToString(tbEndereco.Text);
                objdados.Bairro = Convert.ToString(tbBairro.Text);
                objdados.NumeroEndereco = Convert.ToString(tbNumero.Text);
                objdados.Complemento = Convert.ToString(tbComplemento.Text);


                objgravar.Alterar(objdados);
            }
            MessageBox.Show("Gravação Efetuada!");
        }

        //btnAlterar
        private void button5_Click(object sender, EventArgs e)
        {
            operacao = "I";
            tbNomeCliente.Enabled = true;
            tbCPF.Enabled = true;
            tbCEP.Enabled = true;
            cbCidade.Enabled = true;
            tbEndereco.Enabled = true;
            tbBairro.Enabled = true;
            tbNumero.Enabled = true;
            tbComplemento.Enabled = true;
            MessageBox.Show("Alteração Efetuada!");
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente deseja excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bllCliente objexcluir = new bllCliente();
                objexcluir.Excluir(Convert.ToInt32(tbCodigo.Text));
                gvBuscaNome.DataSource = null;
                MessageBox.Show("Exclusão realizada com sucesso!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}