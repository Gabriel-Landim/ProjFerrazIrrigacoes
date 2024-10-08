﻿using BLL;
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
            tbEmail.Text = objDados.Email;
            cbCidade.SelectedValue = objDados.IdCidade;
            tbRua.Text = objDados.Rua;

        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (tbRua.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Rua");
                return;
            }
            if (tbBairro.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Bairro");
                return;
            }
            if (cbCidade.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Cidade");
                return;
            }
            if (tbCep.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Cep");
                return;
            }
            if (tbComplemento.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Complemento");
                return;
            }
            if (tbEmail.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Email");
                return;
            }
            if (tbNumero.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Numero Residencial");
                return;
            }
            if (tbTelefone.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Telefone");
                return;
            }

            bllCliente objcadastrar = new bllCliente();
            modCliente objdados = new modCliente();

            objdados.NomeCliente = tbNome.Text;
            objdados.Cep = tbCep.Text;
            objdados.Bairro = tbBairro.Text;
            objdados.Cpf = tbCpf.Text;
            objdados.Complemento = tbComplemento.Text;
            objdados.NumeroEndereco = tbNumero.Text;
            objdados.TelefoneCliente = tbTelefone.Text;
            objdados.Email = tbEmail.Text;
            objdados.IdCidade = Convert.ToInt32(cbCidade.SelectedValue);
            objdados.Rua = tbRua.Text;

            objcadastrar.Inserir(objdados);

            MessageBox.Show("Cliente cadastrado com Sucesso!");
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
