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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
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


            tbNome.Text = objDados.NomeCliente;
            tbCep.Text = objDados.Cep;
            tbBairro.Text = objDados.Bairro;
            tbCpf.Text = objDados.Cpf;
            tbComplemento.Text = objDados.Complemento;
            tbNumero.Text = objDados.NumeroEndereco;
            tbTelefone.Text = objDados.TelefoneCliente;
            cbCidade.SelectedValue = objDados.IdCidade;
            tbRua.Text = objDados.Rua;

        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            bllCliente objcadastrar = new bllCliente();
            modCliente objdados = new modCliente();

            objdados.Id = 1;
            tbNome.Text = objdados.NomeCliente;
            tbCep.Text = objdados.Cep;
            tbBairro.Text = objdados.Bairro;
            tbCpf.Text = objdados.Cpf;
            tbComplemento.Text = objdados.Complemento;
            tbNumero.Text = objdados.NumeroEndereco;
            tbTelefone.Text = objdados.TelefoneCliente;
            cbCidade.SelectedValue = objdados.IdCidade;
            tbRua.Text = objdados.Rua;

            objcadastrar.Alterar(objdados);

            MessageBox.Show("Cliente cadastrado com Sucesso!");
        }
    }
}
