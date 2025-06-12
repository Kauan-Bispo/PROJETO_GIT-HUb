using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_GIT_HUB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cep = textBox3.Text.Trim();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    dynamic endereco = JsonConvert.DeserializeObject(json);

                    textBox5.Text = endereco.logradouro;
                    textBox7.Text = endereco.bairro;
                    textBox9.Text = endereco.localidade;
                    textBox10.Text = endereco.uf;
                }
            }
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            string cpf = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(cpf)) return;

            string[] dados = new string[]
            {
                cpf, textBox1.Text, textBox4.Text, textBox3.Text, textBox5.Text,
                textBox6.Text, textBox7.Text, textBox9.Text, textBox10.Text,
                textBox8.Text, textBox12.Text
            };

            var linha = string.Join(",", dados);
            var linhas = File.Exists("clientes.csv") ? File.ReadAllLines("clientes.csv").ToList() : new System.Collections.Generic.List<string>();

            linhas.RemoveAll(l => l.StartsWith(cpf + ","));
            linhas.Add(linha);

            File.WriteAllLines("clientes.csv", linhas);
            MessageBox.Show("Cliente salvo com sucesso.");
        }
    }
}

