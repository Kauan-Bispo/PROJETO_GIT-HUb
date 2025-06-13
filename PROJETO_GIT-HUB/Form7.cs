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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
            CarregarProdutos();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarProdutos()
        {
            if (!File.Exists(arquivoProdutos)) return;

            produtos.Clear();
            comboBox1.Items.Clear();

            var linhas = File.ReadAllLines(arquivoProdutos);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                string codigo = dados[0];
                string nome = dados[1];
                decimal preco = decimal.Parse(dados[2]);

                produtos[codigo] = (nome, preco);
                cmbProdutos.Items.Add($"{codigo} - {nome} - R$ {preco}");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text.Trim();
            if (!File.Exists(arquivoClientes)) return;

            var linhas = File.ReadAllLines(arquivoClientes);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados[0] == cpf)
                {
                    label5.Text = dados[1];
                    return;
                }
            }

            label5.Text = "Cliente não encontrado";

        }
    }
}


