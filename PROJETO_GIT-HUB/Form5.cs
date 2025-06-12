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

            if (codigo == "" || nome == "" || precoStr == "")
                return;

            if (!decimal.TryParse(precoStr, out decimal preco))
                return;

            Produto produto = new Produto
            {
                Codigo = codigo,
                Nome = nome,
                Preco = preco,
                Descricao = descricao
            };

            if (File.Exists(caminhoArquivo))
            {
                var linhas = File.ReadAllLines(caminhoArquivo);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    if (dados[0] == codigo)
                        return;
                }
            }

            File.AppendAllText(caminhoArquivo, produto.ToString() + Environment.NewLine);
            LimparCampos();
            CarregarProdutos();

        }
        private void CarregarProdutos()
        {
            listBox1.Items.Clear();

            if (!File.Exists(caminhoArquivo))
                return;

            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas)
                listBox1.Items.Add(linha);
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
            string codigo = textBox4.Text.Trim();
            string nome = textBox1.Text.Trim();
            string precoStr = textBox2.Text.Trim();
            string descricao = textBox3.Text.Trim();

            if (!decimal.TryParse(precoStr, out decimal preco))
                return;

            if (!File.Exists(caminhoArquivo))
                return;

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            for (int i = 0; i < linhas.Count; i++)
            {
                var dados = linhas[i].Split(';');
                if (dados[0] == codigo)
                {
                    linhas[i] = $"{codigo};{nome};{preco};{descricao}";
                    break;
                }
            }

            File.WriteAllLines(caminhoArquivo, linhas);
            LimparCampos();
            CarregarProdutos();

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string codigo = textBox4.Text.Trim();

            if (!File.Exists(caminhoArquivo))
                return;

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            linhas = linhas.Where(l => l.Split(';')[0] != codigo).ToList();
            File.WriteAllLines(caminhoArquivo, linhas);

            LimparCampos();
            CarregarProdutos();
        }

    }
}

    






