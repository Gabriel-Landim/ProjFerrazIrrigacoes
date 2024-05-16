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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregarMarca();
            CarregarCategoria();
            CarregarUnidadeMedida();
        }

        private void CarregarMarca()
        {
            bllMarca objBusca = new bllMarca();
            cbMarca.DataSource = objBusca.CarregarMarca();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Nome";
        }

        private void CarregarCategoria()
        {
            bllCategoriasTipo objBusca = new bllCategoriasTipo();
            cbCategoria.DataSource = objBusca.CarregarCategoria();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Nome";
        }

        private void CarregarUnidadeMedida()
        {
            bllUnidadeMedidaTipos objBusca = new bllUnidadeMedidaTipos();
            cbUnidadeMedida.DataSource = objBusca.CarregarUnidadeMedida();
            cbUnidadeMedida.ValueMember = "Id";
            cbUnidadeMedida.DisplayMember = "Nome";
        }

        private void gvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bllProduto objBusca = new bllProduto();
            modProduto objDados = new modProduto();
            objDados = objBusca.BuscaPorCodigo(Convert.ToInt32(gvProduto.Rows[e.RowIndex].Cells["Id"].Value));
            tbdescricao.Text = gvProduto.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
            tbEstoque.Text = gvProduto.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
            tbValor.Text = gvProduto.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
            tbProdutoNome.Text = gvProduto.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            operacao = "A";
        }

        private void tbBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            bllProduto objbusca = new bllProduto();
            gvProduto.DataSource = objbusca.SelecionarPorNome(tbBuscaProduto.Text);
        }
    }
}
