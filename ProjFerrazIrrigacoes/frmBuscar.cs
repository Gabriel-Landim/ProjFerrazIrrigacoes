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
            CarregaCidade();
            CarregaDados();
        }

        private void CarregaCidade()
        {
            bllCidade objBusca = new bllCidade();
            cbCidade.DataSource = objBusca.CarregaCidade();
            cbCidade.ValueMember = "Id";
            cbCidade.DisplayMember = "CidadeNome";
        }
        private void CarregaDados()
        {
            bllCliente objCarregar = new bllCliente();
            modCliente objDados = new modCliente();


            tbNomeCliente.Text = objDados.NomeCliente;
            tbCep.Text = objDados.Cep;
            tbBairro.Text = objDados.Bairro;
            tbCpf.Text = objDados.Cpf;
            tbComplemento.Text = objDados.Complemento;
            tbNumero.Text = objDados.NumeroEndereco;
            tbTelefone.Text = objDados.TelefoneCliente;
            tbEmail.Text = objDados.Email;
            cbCidade.SelectedValue = objDados.IdCidade;
            tbRua.Text = objDados.Rua;
        }
        //btnAlterar

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente deseja excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bllCliente objexcluir = new bllCliente();
                objexcluir.Excluir(Convert.ToInt32(tbId.Text));
                gvBuscaNome.DataSource = null;
                MessageBox.Show("Exclusão realizada com sucesso!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
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
                objdados.Cpf = Convert.ToString(tbCpf.Text);
                objdados.Cep = Convert.ToString(tbCep.Text);
                objdados.IdCidade = Convert.ToInt32(cbCidade.SelectedValue);
                objdados.Rua = Convert.ToString(tbRua.Text);
                objdados.Bairro = Convert.ToString(tbBairro.Text);
                objdados.NumeroEndereco = Convert.ToString(tbNumero.Text);
                objdados.Complemento = Convert.ToString(tbComplemento.Text);
                objdados.TelefoneCliente = Convert.ToString(tbTelefone.Text);
                objdados.Email = Convert.ToString(tbEmail.Text);

                objgravar.Alterar(objdados);
            }
            MessageBox.Show("Gravação Efetuada!");
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            operacao = "I";
            tbNomeCliente.Enabled = true;
            tbCpf.Enabled = true;
            tbCep.Enabled = true;
            cbCidade.Enabled = true;
            tbRua.Enabled = true;
            tbBairro.Enabled = true;
            tbNumero.Enabled = true;
            tbComplemento.Enabled = true;
            tbTelefone.Enabled = true;
            tbEmail.Enabled = true;
            MessageBox.Show("Alteração Efetuada!");
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}