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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbEditar_Click(object sender, EventArgs e)
        {
            bllUsuario objLogar = new bllUsuario();
            modUsuario ObjDados = new modUsuario();
            ObjDados = objLogar.Logar(tbEmail.Text, tbSenha.Text);
            
            if (ObjDados.Id != 0)
            {              
                Form1 tela = new Form1();
                this.Visible = false;
                tela.NomeUsuario = ObjDados.Nome;
                tela.CargoUsuario = ObjDados.Cargo;
                tela.ShowDialog();               
                this.Close();
                tela.Dispose();

            }

            else
            {
                MessageBox.Show("Email ou Senha inválido!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmLoginCadastro telaCadastro = new frmLoginCadastro();
            telaCadastro.ShowDialog();
            telaCadastro.Dispose();
        }
    }
}
