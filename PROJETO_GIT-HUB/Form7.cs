using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_GIT_HUB
{
    public partial class FrmConsulta : Form
    {
        private string caminho pedidos = @"C:\Users\Usuario\OneDrive\Documento";
        private string caminho itenspedidos = @"C:\Users\Usuario\OneDrive\Documentos";

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
            if (!File.Exists(caminho pedidos)) return;

            listBox2.Items.Clear();
            listBox1.Items.Clear();

            var linhas = File.ReadAllLines(caminho pedios);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                string codigo = dados[0];
                string nome = dados[1];
                decimal preco = decimal.Parse(dados[2]);

                listBox2.[codigo] = (nome, preco);
                listBox1.Items.Add($"{codigo} - {nome} - R$ {preco}");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cpf = textBox1.Text.Trim();
            if (!File.Exists(caminho pedidos)) return;

            var linhas = File.ReadAllLines(caminho pedidos);
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


