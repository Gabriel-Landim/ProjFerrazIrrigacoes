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
    public partial class frmProdutos : Form
    {
        string operacao;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregarMarca();
            CarregarCategoria();
            CarregarUnidadeMedida();
            CarregarProduto();
        }

        private void CarregarMarca()
        {
            bllMarca objBusca = new bllMarca();
            cbMarca.DataSource = objBusca.CarregarMarca();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "NomeMarca";
            cbMarca.Text = "";
        }

        private void CarregarCategoria()
        {
            bllCategoriasTipo objBusca = new bllCategoriasTipo();
            cbCategoria.DataSource = objBusca.CarregarCategoria();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "CategoriaNome";
           cbCategoria.Text = "";
        }

        private void CarregarUnidadeMedida()
        {
            bllUnidadeMedidaTipos objBusca = new bllUnidadeMedidaTipos();
            cbUnidadeMedida.DataSource = objBusca.CarregarUnidadeMedida();
            cbUnidadeMedida.ValueMember = "Id";
            cbUnidadeMedida.DisplayMember = "NomeMedida";
            cbUnidadeMedida.Text = "";
        }

        private void CarregarProduto()
        {
            bllProduto objCarregar = new bllProduto();
            modProduto objDados = new modProduto();

            tbProdutoNome.Text = objDados.NomeProduto;
            tbDescricao.Text = objDados.DescricaoProduto;
            tbEstoque.Text = objDados.Estoque.ToString();
            tbValor.Text = objDados.ValorProduto.ToString();
            cbCategoria.SelectedValue = objDados.IdCategoriasTipo;
            cbMarca.SelectedValue = objDados.IdMarca;
            cbMarca.SelectedValue = objDados.IdMarca;
        }

        //private void gvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    bllProduto objBusca = new bllProduto();
        //    modProduto objDados = new modProduto();
        //    objDados = objBusca.BuscaPorCodigo(Convert.ToInt32(gvProdutos.Rows[e.RowIndex].Cells["Id"].Value));
        //    gvProdutos.Text = gvProdutos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
        //    tbEstoque.Text = gvProdutos.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
        //    tbValor.Text = gvProdutos.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
        //    tbProdutoNome.Text = gvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
        //    operacao = "A";

        //    pCategoria.Visible = false;
        //    pMarca.Visible = false;
        //    pUniMedida.Visible = false;

        //} 

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnMarcasAdd_Click(object sender, EventArgs e)
        {
            pMarca.Visible = true;
            pMarca.Location = new Point(24, 51);
        }

        private void BtnCategoriasAdd_Click(object sender, EventArgs e)
        {
            pCategoria.Visible = true;
            pCategoria.Location = new Point(24, 97);
        }

        private void BtnUniMedidasAdd_Click(object sender, EventArgs e)
        {
            pUniMedida.Visible = true;
            pUniMedida.Location = new Point(24, 144);
        }

        private void tbBuscaProduto_TextChanged_1(object sender, EventArgs e)
        {
            bllProduto objbusca = new bllProduto();
            gvProdutos.DataSource = objbusca.SelecionarPorNome(tbBuscaProduto.Text);
        }

        private void gvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = gvProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            tbProdutoNome.Text = gvProdutos.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();
            tbValor.Text = gvProdutos.Rows[e.RowIndex].Cells["ValorProduto"].Value.ToString();
            tbEstoque.Text = gvProdutos.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
            tbDescricao.Text = gvProdutos.Rows[e.RowIndex].Cells["DescricaoProduto"].Value.ToString();
            cbCategoria.SelectedValue = Convert.ToInt32(gvProdutos.Rows[e.RowIndex].Cells["IdCategoriasTipo"].Value);
            cbMarca.SelectedValue = Convert.ToInt32(gvProdutos.Rows[e.RowIndex].Cells["IdMarca"].Value);
            cbUnidadeMedida.SelectedValue = Convert.ToInt32(gvProdutos.Rows[e.RowIndex].Cells["IdUnidadeMedidaTipos"].Value);

            //cbCategoria.SelectedValue = 1;

            //btnGravar.Enabled = true;
            //btnEditar.Enabled = true;
            //tbNomeCliente.Enabled = true;
            //tbCpf.Enabled = true;
            //tbCep.Enabled = true;
            //cbCidade.Enabled = true;
            //tbRua.Enabled = true;
            //tbBairro.Enabled = true;
            //tbNumero.Enabled = true;
            //tbComplemento.Enabled = true;
            //tbTelefone.Enabled = true;
            //tbEmail.Enabled = true;
            //btGravar.Enabled = true;
            //btDeletar.Enabled = true;
            //pProcurarCliente.Visible = false;

            //Qual campo o cursor vai parar
            tbProdutoNome.Focus();
        }

        private void frmProdutos_Shown(object sender, EventArgs e)
        {
            CarregarProduto();
            CarregarMarca();
            CarregarCategoria();
            CarregarUnidadeMedida();
        }
    }
}
