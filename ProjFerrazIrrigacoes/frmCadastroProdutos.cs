﻿using System;
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
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
            
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarMarca();
            CarregarUnidadeMedida();
            CarregarProduto();
            tbProduto.Focus();
        }
        private void CarregarProduto()
        {
            bllProduto objCarregar = new bllProduto();
            modProduto objDados = new modProduto();

            tbProduto.Text = objDados.NomeProduto;
            tbDescricao.Text = objDados.DescricaoProduto;
            tbEstoque.Text = objDados.Estoque.ToString();
            tbValor.Text = objDados.ValorProduto.ToString();
            cbCategoria.SelectedValue = objDados.IdCategoriasTipo;
            cbUnidadeMedida.SelectedValue = objDados.IdUnidadeMedidaTipos;
            cbMarca.SelectedValue = objDados.IdMarca;
        }
        private void CarregarMarca()
        {
            bllMarca objBusca = new bllMarca();
            cbMarca.DataSource = objBusca.CarregarMarca();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "NomeMarca";
        }
        private void CarregarCategoria()
        {
            bllCategoriasTipo objBusca = new bllCategoriasTipo();
            cbCategoria.DataSource = objBusca.CarregarCategoria();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "CategoriaNome";
        }
        private void CarregarUnidadeMedida()
        {
            bllUnidadeMedidaTipos objBusca = new bllUnidadeMedidaTipos();
            cbUnidadeMedida.DataSource = objBusca.CarregarUnidadeMedida();
            cbUnidadeMedida.ValueMember = "Id";
            cbUnidadeMedida.DisplayMember = "NomeMedida";
            cbUnidadeMedida.Text = "";
        }
       

        private void BtnMarcasAdd_Click(object sender, EventArgs e)
        {
            pMarca.Visible = true;

        }

        private void BtnCategoriasAdd_Click(object sender, EventArgs e)
        {
            pCategoria.Visible = true;
        }

        private void BtnUniMedidasAdd_Click(object sender, EventArgs e)
        {
            pUniMedida.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Categoria");
                return;
            }
            if (cbMarca.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Marca");
                return;
            }
            if (cbUnidadeMedida.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Unidade de Medida");
                return;
            }
            if (tbEstoque.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Estoque");
                return;
            }
            if (tbProduto.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Produto");
                return;
            }
            if (tbValor.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Valor");
                return;
            }
            if (tbDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Descrição");
                return;
            }

            bllProduto objcadastrar = new bllProduto();
            modProduto objdados = new modProduto();

            objdados.NomeProduto = tbProduto.Text;
            objdados.ValorProduto = Convert.ToDouble(tbValor.Text);
            objdados.DescricaoProduto = tbDescricao.Text;
            objdados.Estoque = Convert.ToInt32(tbEstoque.Text);
            objdados.IdMarca = Convert.ToInt32(cbMarca.SelectedValue);
            objdados.IdCategoriasTipo = Convert.ToInt32(cbCategoria.SelectedValue);
            objdados.IdUnidadeMedidaTipos = Convert.ToInt32(cbUnidadeMedida.SelectedValue);

            objcadastrar.Inserir(objdados);

            MessageBox.Show("Produto cadastrado com Sucesso!");
        }

        private void gvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbBusca_TextChanged(object sender, EventArgs e)
        {
            bllProduto objbusca = new bllProduto();
            gvProdutos.DataSource = objbusca.SelecionarPorNome(tbBusca.Text);

            gvProdutos.Columns[0].Visible = false;
            gvProdutos.Columns[5].Visible = false;
            gvProdutos.Columns[6].Visible = false;
            gvProdutos.Columns[7].Visible = false;

        }

        private void btnMarcaAdd_Click(object sender, EventArgs e)
        {
            bllMarca objcadastrar = new bllMarca();
            modMarca objdados = new modMarca();

            objdados.NomeMarca = tbMarca.Text;

            objcadastrar.Inserir(objdados);

            CarregarMarca();
            MessageBox.Show("Marca cadastrada com Sucesso!");

            pMarca.Visible = false;
        }

        private void btnCategoriaAdd_Click(object sender, EventArgs e)
        {
            bllCategoriasTipo objcadastrar = new bllCategoriasTipo();
            modCategoriasTipos objdados = new modCategoriasTipos();

            objdados.CategoriaNome = tbCategoria.Text;

            objcadastrar.Inserir(objdados);

            CarregarCategoria();
            MessageBox.Show("Categoria cadastrada com Sucesso!");

            pCategoria.Visible = false;

        }

        private void btnUniMedidaAdd_Click(object sender, EventArgs e)
        {
            bllUnidadeMedidaTipos objcadastrar = new bllUnidadeMedidaTipos();
            modUnidadeMedidaTipos objdados = new modUnidadeMedidaTipos();

            objdados.NomeMedida = tbUnidMedida.Text;

            objcadastrar.Inserir(objdados);

            CarregarUnidadeMedida();
            MessageBox.Show("Unidade de Medida cadastrada com Sucesso!");

            pUniMedida.Visible = false;
        }
    }
}
