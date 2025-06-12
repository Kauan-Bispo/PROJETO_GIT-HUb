using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_GIT_HUB
{
    public partial class frmMenuPrincipal : Form
    {
        string usuario;
        public frmMenuPrincipal(string user)
        {
            InitializeComponent();
            usuario = user;
        }



        private void btUsuario_Click(object sender, EventArgs e)
        {
            if (usuario == "ADMIN")
                new FrmCadastroUsu().ShowDialog();
            else
                MessageBox.Show("Somente ADMIN pode acessar.");
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            new FrmCadastroUsu().ShowDialog();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            new FrmProdutos().ShowDialog();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            new FrmCadastroPedido().ShowDialog();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            new FrmConsulta().ShowDialog();
        }
    }
}
