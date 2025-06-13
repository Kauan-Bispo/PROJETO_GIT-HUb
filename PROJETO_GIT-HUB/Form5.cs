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
    public partial class FrmProdutos : Form
    {
        string = caminhoProduto = @"C:\Users\Usuario\OneDrive\Documentos";
     
    
        public FrmProdutos()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string codigo = textBox4.Text.Trim();
            string nome = textBox1.Text.Trim();
            string precoStr = textBox2.Text.Trim();
            string descricao = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoStr))
            {
                MessageBox.Show("Preencha Código, Nome e Preço.");
                return;
            }

            if (!decimal.TryParse(precoStr, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            var linhas = File.ReadAllLines(caminhoProduto).ToList();

            bool existe = linhas.Any(l => l.StartsWith(codigo + ";"));

            if (existe)
            {
                MessageBox.Show("Código já cadastrado.");
                return;
            }

            string novaLinha = $"{codigo};{nome};{preco};{descricao}";

            linhas.Add(novaLinha);

            File.WriteAllLines(caminhoProduto, linhas);

            MessageBox.Show("Produto cadastrado com sucesso.");
            
            CarregarProdutos();
            LimparCampos();



        }
        private void CarregarProdutos()
        {
            listBox1.Items.Clear();

            if (!File.Exists(caminhoProduto))
            {
                File.WriteAllText(caminhoProduto, "Codigo;Nome;Preco;Descricao\n");
                return;
            }

            var linhas = File.ReadAllLines(caminhoProduto).Skip(1);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length == 4)
                {
                    var item = new ListViewItem(dados[0]);
                    item.SubItems.Add(dados[1]);
                    item.SubItems.Add(dados[2]);
                    item.SubItems.Add(dados[3]);
                    listBox1.Items.Add(item);


                }
            }
        }
        

        private void LimparCampos()
        {
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string codigo = textBox4.Text.Trim();

            if (!File.Exists(caminhoProduto))
                return;

            var linhas = File.ReadAllLines(caminhoProduto).ToList();
            linhas = linhas.Where(l => l.Split(';')[0] != codigo).ToList();
            File.WriteAllLines(caminhoProduto, linhas);

            LimparCampos();
            CarregarProdutos();
        }

    }
}

    






