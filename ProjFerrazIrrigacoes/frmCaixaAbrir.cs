using BLL;
using DAL;
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
    public partial class frmCaixaAbrir : Form
    {
        private bllCaixa caixaBll;
        public frmCaixaAbrir()
        {
            InitializeComponent();
            caixaBll = new bllCaixa();
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
