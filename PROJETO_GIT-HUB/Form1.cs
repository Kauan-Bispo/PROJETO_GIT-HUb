namespace PROJETO_GIT_HUB
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuario == "ADMIN" && senha == "123")
            {
                frmMenuPrincipal(usuario).Show();
                this.Hide();
                return;
            }

            if (File.Exists("usuarios.csv"))
            {
                var linhas = File.ReadAllLines("usuarios.csv");
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    if (dados[0] == usuario && dados[1] == senha)
                    {
                        new FrmMenu(usuario).Show();
                        this.Hide();
                        return;
                    }
                }
            }

            MessageBox.Show("Usuário ou senha inválidos.");
        }
    }
}
        
