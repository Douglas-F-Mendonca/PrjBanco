using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjBanco.Class;

namespace prjBanco
{
    public partial class frmSalvar : Form
    {
        public frmSalvar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            f.RazaoSocial = txtRazaoSocial.Text;
            f.Email = txtEmail.Text;

            Fornecedor.cadastrar(f);

            MessageBox.Show("Fornecedor salvo com sucesso!");

            limparCampos();
        }

        private void limparCampos()
        {
            txtID.Clear();
            txtRazaoSocial.Clear();
            txtEmail.Clear();
            txtRazaoSocial.Focus();
        }
    }
}
