using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelo;

namespace ProjFerrazIrrigacoes
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
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
            bllEmpresa objCarregar = new bllEmpresa();
            modEmpresa objDados = new modEmpresa();
            objDados = objCarregar.CarregarDadosEmpresa();

            tbNomeFantasia.Text = objDados.NomeFantasia;
            tbCep.Text = objDados.Cep;
            tbBairro.Text = objDados.Bairro;
            tbCnpj.Text = objDados.Cnpj;
            tbComplemento.Text = objDados.Complemento;
            tbNumero.Text = objDados.NumeroEndereco;
            tbRazaoSocial.Text = objDados.RazaoSocial;
            tbTelefone.Text = objDados.Telefone;
            cbCidade.SelectedValue = objDados.IdCidade;
            tbRua.Text = objDados.Rua;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            bllEmpresa objcadastrar = new bllEmpresa();
            modEmpresa objdados = new modEmpresa();

            objdados.Id = 1;
            objdados.NomeFantasia = tbNomeFantasia.Text;
            objdados.RazaoSocial = tbRazaoSocial.Text;
            objdados.Cnpj = tbCnpj.Text;
            objdados.Cep = tbCep.Text;
            objdados.Telefone = tbTelefone.Text;
            objdados.Rua = tbRua.Text;
            objdados.Bairro = tbBairro.Text;
            objdados.NumeroEndereco = tbNumero.Text;
            objdados.Complemento = tbComplemento.Text;
            objdados.IdCidade = Convert.ToInt32(cbCidade.SelectedValue);

            objcadastrar.Alterar(objdados);

            MessageBox.Show("Empresa Cadastrada com Sucesso!");
        }
    }
}
