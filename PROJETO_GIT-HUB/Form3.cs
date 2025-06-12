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
    public partial class FrmCadastroUsu : Form
    {
        public FrmCadastroUsu()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            dgvDados.Rows.Clear();

            if (File.Exists("usuarios.csv"))
            {
                var linhas = File.ReadAllLines("usuarios.csv");
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    dgvDados.Rows.Add(dados[0], dados[1]);
                }
            }
        }
        private void FrmCadastroUsu_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            var linhas = File.Exists("usuarios.csv") ? File.ReadAllLines("usuarios.csv").ToList() : new System.Collections.Generic.List<string>();

            bool existe = false;
            for (int i = 0; i < linhas.Count; i++)
            {
                if (linhas[i].StartsWith(usuario + ","))
                {
                    linhas[i] = usuario + "," + senha;
                    existe = true;
                    break;
                }
            }

            if (!existe)
                linhas.Add(usuario + "," + senha);

            File.WriteAllLines("usuarios.csv", linhas);
            CarregarUsuarios();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            if (usuario == "ADMIN")
            {
                MessageBox.Show("Não pode excluir ADMIN.");
                return;
            }

            if (!File.Exists("usuarios.csv")) return;

            var linhas = File.ReadAllLines("usuarios.csv").ToList();
            linhas = linhas.Where(l => !l.StartsWith(usuario + ",")).ToList();
            File.WriteAllLines("usuarios.csv", linhas);
            CarregarUsuarios();

        }
    }
}

       

