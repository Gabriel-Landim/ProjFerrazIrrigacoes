﻿using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFerrazIrrigacoes
{
    public partial class frmCaixaAbrir : Form
    {
        int CodigoCaixa = 0;
        private bllCaixa caixaBll;
        public frmCaixaAbrir()
        {
            InitializeComponent();
            caixaBll = new bllCaixa();
            
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarregaUsuario()
        {
            bllUsuario objBusca = new bllUsuario();
            cbUsuario.DataSource = objBusca.CarregaUsuario();
            cbUsuario.ValueMember = "Id";
            cbUsuario.DisplayMember = "Nome";
        }

        private void frmCaixaAbrir_Shown(object sender, EventArgs e)
        {
            CarregaUsuario();
            VerificaCaixa();
        }
        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                modCaixa caixa = new modCaixa
                {
                    UsuarioId = Convert.ToInt32(cbUsuario.SelectedValue),
                    DataAbertura = DateTime.Now,
                    TotalInicial = Convert.ToDouble(tbValor.Text)
                };
                caixaBll.AbrirCaixa(caixa);

                MessageBox.Show("Caixa aberto com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }

        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataFechamento = DateTime.Parse(dtFechamento.Text);
                decimal totalFinal = decimal.Parse(tbValor.Text);

                caixaBll.FecharCaixa(CodigoCaixa, dataFechamento, totalFinal);

                MessageBox.Show("Caixa fechado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro:{ex.Message}");
            }
        }
        private void VerificaCaixa()
        {
            bllCaixa objBusca = new bllCaixa();

            CodigoCaixa = objBusca.BuscaPorCodigo();

            if (CodigoCaixa == 0)
            {
                btnFecharCaixa.Visible = false;
            }

            else if (CodigoCaixa != 0)
            {
                btnAbrirCaixa.Visible = false;

                bllCaixa objSaldo = new bllCaixa();
                tbValor.Text = Convert.ToString(objSaldo.CalculaCaixa(CodigoCaixa));
            }
        }
    }
}
