using BLL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFerrazIrrigacoes
{
    public partial class frmBuscar : Form
    {
        string operacao;
        public frmBuscar()
        {           
            InitializeComponent();     
            
        }
        private void frmBuscar_Load(object sender, EventArgs e)
        { 
            CarregaCidade();
            CarregaDados();
            BloqueiaTela();
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
           
            tbNomeCliente.Text = objDados.NomeCliente;
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
        private void BloqueiaTela()
        {
            tbBairro.Enabled = false;
            tbCep.Enabled = false;
            tbComplemento.Enabled = false;
            tbCpf.Enabled = false;
            tbEmail.Enabled = false;
            tbId.Enabled = true;
            tbNomeCliente.Enabled = false;
            tbNumero.Enabled = false;
            tbRua.Enabled = false;
            tbTelefone.Enabled = false;
            btDeletar.Enabled = false;
            btGravar.Enabled = false;
        }

        //private void LimpaTela()
        //{
        //    tbCodigo.Clear();
        //    tbTitulo.Clear();
        //    gvLivro.DataSource = null;
        //}

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try 
            {
                DialogResult result = MessageBox.Show("Realmente deseja excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bllCliente objexcluir = new bllCliente();
                    objexcluir.Excluir(Convert.ToInt32(tbId.Text));
                    gvBuscaNome.DataSource = null;
                    MessageBox.Show("Exclusão realizada com sucesso!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            
            if(tbRua.Text.Trim() == "")
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


            bllCliente objgravar = new bllCliente();
            modCliente objdados = new modCliente();

                if (operacao == "I")
                {
                    objdados.NomeCliente = tbNomeCliente.Text;
                    objgravar.Inserir(objdados);
                }

                else
                {
                    objdados.Id = Convert.ToInt32(tbId.Text);
                    objdados.NomeCliente = tbNomeCliente.Text;
                    objdados.Cpf = Convert.ToString(tbCpf.Text);
                    objdados.Cep = Convert.ToString(tbCep.Text);
                    objdados.IdCidade = Convert.ToInt32(cbCidade.SelectedValue);
                    objdados.Rua = Convert.ToString(tbRua.Text);
                    objdados.Bairro = Convert.ToString(tbBairro.Text);
                    objdados.NumeroEndereco = Convert.ToString(tbNumero.Text);
                    objdados.Complemento = Convert.ToString(tbComplemento.Text);
                    objdados.TelefoneCliente = Convert.ToString(tbTelefone.Text);
                    objdados.Email = Convert.ToString(tbEmail.Text);

                    objgravar.Alterar(objdados);
                }
                MessageBox.Show("Alteração Efetuada!");
            

            

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //operacao = "I";
            tbNomeCliente.Enabled = true;
            tbCpf.Enabled = true;
            tbCep.Enabled = true;
            cbCidade.Enabled = true;
            tbRua.Enabled = true;
            tbBairro.Enabled = true;
            tbNumero.Enabled = true;
            tbComplemento.Enabled = true;
            tbTelefone.Enabled = true;
            tbEmail.Enabled = true;

            btDeletar.Enabled = true;
            btGravar.Enabled = true;
        }
        private void tbBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            bllCliente objbusca = new bllCliente();
            gvBuscaNome.DataSource = objbusca.SelecionarPorNome(tbBuscaCliente.Text);

            gvBuscaNome.Columns[10].Visible = false;
            gvBuscaNome.Columns[11].Visible = false;
        }

        private void gvBuscaNome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            tbNomeCliente.Text = gvBuscaNome.Rows[e.RowIndex].Cells["NomeCliente"].Value.ToString();
            tbBairro.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Bairro"].Value.ToString();
            tbCep.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Cep"].Value.ToString();
            tbComplemento.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Complemento"].Value.ToString();
            tbCpf.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Cpf"].Value.ToString();
            tbEmail.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            tbNumero.Text = gvBuscaNome.Rows[e.RowIndex].Cells["NumeroEndereco"].Value.ToString();
            tbRua.Text = gvBuscaNome.Rows[e.RowIndex].Cells["Rua"].Value.ToString();
            tbTelefone.Text = gvBuscaNome.Rows[e.RowIndex].Cells["TelefoneCliente"].Value.ToString();
            cbCidade.SelectedValue = gvBuscaNome.Rows[e.RowIndex].Cells["IdCidade"].Value;
            operacao = "A";

            //btGravar.Enabled = true;
            //btDeletar.Enabled = true;
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
            pProcurarCliente.Visible = false;

            //Qual campo o cursor vai parar
            tbNomeCliente.Focus();
        }

        private void TextoVertical1_Click(object sender, EventArgs e)
        {

        }

        private void TextoVertical1_Paint(object sender, PaintEventArgs e)
        {
            Font MinhaFonte = new Font("RBNo3.1 bold", 13);
            Brush MeuBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Dados Pessoais", MinhaFonte, MeuBrush, 0, 0);
        }

        private void label12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextoVertical2_Paint(object sender, PaintEventArgs e)
        {
            Font MinhaFonte = new Font("RBNo3.1 bold", 13);
            Brush MeuBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            e.Graphics.TranslateTransform(30, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Localização", MinhaFonte, MeuBrush, 0, 0);
        }

        private void tbCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}