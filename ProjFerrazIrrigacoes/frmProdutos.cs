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
        public frmProdutos()
        {
            InitializeComponent();
        }

        int i;
        string operacao;
       
 

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
            tbMarca.DataSource = objBusca.CarregarMarca();
            tbMarca.ValueMember = "Id";
            tbMarca.DisplayMember = "Nome";
        }

        private void CarregarCategoria()
        {
            bllCategoriasTipo objBusca = new bllCategoriasTipo();
            tbCategoria.DataSource = objBusca.CarregarCategoria();
            tbCategoria.ValueMember = "Id";
            tbCategoria.DisplayMember = "Nome";
        }

        private void CarregarUnidadeMedida()
        {
            bllUnidadeMedidaTipos objBusca = new bllUnidadeMedidaTipos();
            tbUnidadeMedida.DataSource = objBusca.CarregarUnidadeMedida();
            tbUnidadeMedida.ValueMember = "Id";
            tbUnidadeMedida.DisplayMember = "Nome";
        }

        private void gvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bllProduto objBusca = new bllProduto();
            modProduto objDados = new modProduto();
            objDados = objBusca.BuscaPorCodigo(Convert.ToInt32(gvProduto.Rows[e.RowIndex].Cells["Id"].Value));
            tbDescricao.Text = gvProduto.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
