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
            cbUnidadeMedida.DataSource = objBusca.CarregarUnidadeMedida();
            cbUnidadeMedida.ValueMember = "Id";
            cbUnidadeMedida.DisplayMember = "Nome";
        }

        private void gvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bllProduto objBusca = new bllProduto();
            modProduto objDados = new modProduto();
            objDados = objBusca.BuscaPorCodigo(Convert.ToInt32(gvProdutos.Rows[e.RowIndex].Cells["Id"].Value));
            gvProdutos.Text = gvProdutos.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
            tbEstoque.Text = gvProdutos.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
            tbValor.Text = gvProdutos.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
            tbProdutoNome.Text = gvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            operacao = "A";

            pCategoria.Visible = false;
            pMarca.Visible = false;
            pUniMedida.Visible = false;

        }

        private void tbBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            bllProduto objbusca = new bllProduto();
            gvProdutos.DataSource = objbusca.SelecionarPorNome(tbBusca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
    }
}
