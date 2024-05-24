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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
            
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarMarca();
            CarregarUnidadeMedida();
            CarregarProduto();
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
            cbMarca.SelectedValue = objDados.IdMarca;
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
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
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
    }
}
