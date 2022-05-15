using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBanco
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //Maximiza o form principal
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var encerrar = MessageBox.Show("Deseja encerrar o programa?", "Utilizando Banco", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(encerrar == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //manter apenas um único form aberto
            if (Application.OpenForms.OfType<frmSalvar>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSalvar>().First().Focus();
            }
            else
            {
                frmSalvar frms = new frmSalvar();
                frms.Show();
            }
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //manter apenas um único form aberto
            if (Application.OpenForms.OfType<frmCliente>().Count() > 0)
            {
                Application.OpenForms.OfType<frmCliente>().First().Focus();
            }
            else
            {
                frmCliente frmc = new frmCliente();
                frmc.Show();
            }
        }
    }
}
