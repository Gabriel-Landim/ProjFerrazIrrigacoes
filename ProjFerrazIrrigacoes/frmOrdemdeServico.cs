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
using DAL;
using Modelo;

namespace ProjFerrazIrrigacoes
{
    public partial class frmOrdemdeServico : Form
    {
        Comprar objCmp;
        int Codigovenda = 0;

        private BindingList<bllItensVenda> ItensVenda;

        public frmOrdemdeServico()
        {
            InitializeComponent();

            objCmp = new Comprar();

            tbQuantidade.DataBindings.Add("Text", objCmp, "QuantidadeProdutotb", true, DataSourceUpdateMode.OnPropertyChanged);
            tbPreçoUnit.DataBindings.Add("Text", objCmp, "ValorProdutotb", true, DataSourceUpdateMode.OnPropertyChanged);
            tbValor.DataBindings.Add("Text", objCmp, "ValorCompratb", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public class Comprar
        {
            public decimal ValorProdutotb { get; set; }
            public decimal QuantidadeProdutotb { get; set; }
            public decimal ValorCompratb { get { return ValorProdutotb * QuantidadeProdutotb; } }
        }

        private void frmOrdemdeServico_Shown(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarMarca();
            CarregarUnidadeMedida();
            CarregarProduto();
            CarregaCliente();
        }

        private void CarregarProduto()
        {
            bllProduto objBusca = new bllProduto();
            modProduto objDados = new modProduto();

            cbProduto.DataSource = objBusca.CarregarProduto();
            cbProduto.ValueMember = "Id";
            cbProduto.DisplayMember = "NomeProduto";
        }

        private void BuscaPorCodigo(int id)
        {
            bllProduto objBusca = new bllProduto();
            modProduto objDados = new modProduto();

            objDados = objBusca.BuscaPorCodigo(id);
            tbPreçoUnit.Text = objDados.ValorProduto.ToString();
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

        private void CarregaCliente()
        {
            bllCliente objCarregar = new bllCliente();
            modCliente objDados = new modCliente();

            cbCliente.DataSource = objCarregar.CarregarDadosCliente();
            cbCliente.ValueMember = "Id";
            cbCliente.DisplayMember = "NomeCliente";
        }

        private void BuscaPorCodigoCliente(int Clienteid)
        {
            bllCliente objBusca = new bllCliente();
            modCliente objDados = new modCliente();

            objDados = objBusca.BuscaPorCodigoCliente(Clienteid);
            tbTelefone.Text = objDados.TelefoneCliente.ToString();
            tbId.Text = objDados.Id.ToString();
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            //CarregarProduto();
            // BuscaPorCodigo(Convert.ToInt32(cbProduto.SelectedValue));
        }

        private void cbProduto_Leave(object sender, EventArgs e)
        {
            BuscaPorCodigo(Convert.ToInt32(cbProduto.SelectedValue));
            //BuscaPorCodigoCliente(Convert.ToInt32(cbCliente.SelectedValue));
        }

        private void cbCliente_Leave(object sender, EventArgs e)
        {
            BuscaPorCodigoCliente(Convert.ToInt32(cbCliente.SelectedValue));
        }

        private void gvProdutosComprados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = gvProdutosComprados.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            tbPreçoUnit.Text = gvProdutosComprados.Rows[e.RowIndex].Cells["ValorProdutoUnit"].Value.ToString();
            tbQuantidade.Text = gvProdutosComprados.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString();
            tbValor.Text = gvProdutosComprados.Rows[e.RowIndex].Cells["ValorTotalProdutos"].Value.ToString();
        }

        private void tbBuscaProdutoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            bllItensVenda objbusca = new bllItensVenda();
            modItensVenda objDados = new modItensVenda();
            objDados.IdVenda = Codigovenda;
            objDados.IdProduto = Convert.ToInt32(cbProduto.SelectedValue);
            objDados.Quantidade = Convert.ToInt32(tbQuantidade.Text);
            objDados.ValorProdutoUnit = Convert.ToDouble(tbPreçoUnit.Text);
            objDados.ValorTotalProdutos = Convert.ToDouble(tbValor.Text);

            objbusca.InsereItem(objDados);

            
            gvProdutosComprados.DataSource = objbusca.CarregaItensVenda(Codigovenda);

            CalculaValorTotal();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            dalVenda objInsere = new dalVenda();
            modVenda objDados = new modVenda();
            objDados.DataVenda = DateTime.Now;
            Codigovenda = objInsere.Insere(objDados);
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (gvProdutosComprados.SelectedRows.Count > 0)
            {
                // Confirmação de exclusão
                DialogResult result = MessageBox.Show("Você tem certeza que deseja deletar a linha selecionada? ",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Pega a linha selecionada
                        int selectedIndex = gvProdutosComprados.SelectedRows[0].Index;

                        //Obtém o ID ou chave da linha selecionada, caso necessário para deletar do banco de dados
                        int rowID = Convert.ToInt32(gvProdutosComprados[0, selectedIndex].Value);

                        // Remove a linha do DataGridView

                        //gvProdutosComprados.Rows.RemoveAt(selectedIndex);

                        // Remova a linha do banco de dados, se necessário
                        bllItensVenda objDeletar = new bllItensVenda();
                        objDeletar.Excluir(rowID);

                        gvProdutosComprados.DataSource = objDeletar.CarregaItensVenda(Codigovenda);

                        CalculaValorTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar a linha: " + ex.Message);
                    }

                }
               
                
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para deletar. ");
            }     
        }

        private void tbValorTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculaValorTotal()
        {
            bllItensVenda objCalcula = new bllItensVenda();
            modItensVenda objDados = new modItensVenda();

            double ValorTotal = objCalcula.Calcula(Codigovenda);
            double MaodeObra = ValorTotal * 0.4;

            tbValorTotal.Text = Convert.ToString(ValorTotal);
            tbMaodeObra.Text = Convert.ToString(MaodeObra);

        }

        private void CalculaDesconto()
        {
            double ValorTotal = Convert.ToDouble(tbValorTotal.Text);
            double MaodeObra = Convert.ToDouble(tbMaodeObra.Text);
            double Desconto = Convert.ToDouble(tbDesconto.Text);

            Desconto = (ValorTotal - ((Desconto / 100) * ValorTotal));
            ValorTotal = Desconto;

        }

    }
}
