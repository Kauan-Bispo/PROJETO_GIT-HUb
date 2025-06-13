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
    public partial class FrmCadastroPedido : Form
    {
        string arquivoClientes = "clientes.csv";
        string arquivoProdutos = "produtos.csv";
        string arquivoPedidos = "pedidos.csv";
        string arquivoItensPedido = "itens_pedido.csv";

        Dictionary<string, (string Nome, decimal Preco)> produtos = new();
        List<(string CodProduto, string NomeProduto, int Quantidade, decimal TotalItem)> itensPedido = new();
        decimal totalPedido = 0;

        public FrmCadastroPedido()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codPedido = textBox1.Text.Trim();
            string cpf = textBox2.Text.Trim();

            if (codPedido == "" || cpf == "" || itensPedido.Count == 0) return;

            var pedidoLinha = $"{codPedido};{cpf};{totalPedido}";
            File.AppendAllText(arquivoPedidos, pedidoLinha + Environment.NewLine);

            foreach (var item in itensPedido)
            {
                string itemLinha = $"{codPedido};{item.CodProduto};{item.Quantidade};{item.TotalItem}";
                File.AppendAllText(arquivoItensPedido, itemLinha + Environment.NewLine);
            }

            MessageBox.Show("Pedido salvo com sucesso!");
            

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cpf = textBox2.Text.Trim();
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
                comboBox1.Items.Add($"{codigo} - {nome} - R$ {preco}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            if (!int.TryParse(textBox3.Text, out int qtd) || qtd <= 0) return;

            var selecao = comboBox1.SelectedItem.ToString();
            var partes = selecao.Split(" - ");
            string codProduto = partes[0];
            string nomeProduto = partes[1];
            decimal preco = produtos[codProduto].Preco;

            decimal totalItem = preco * qtd;
            itensPedido.Add((codProduto, nomeProduto, qtd, totalItem));
            totalPedido += totalItem;

        }
    }
}

