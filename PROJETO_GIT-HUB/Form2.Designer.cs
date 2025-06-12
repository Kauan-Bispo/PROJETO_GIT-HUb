namespace PROJETO_GIT_HUB
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btClientes = new Button();
            btProdutos = new Button();
            btPedidos = new Button();
            btUsuario = new Button();
            btConsulta = new Button();
            SuspendLayout();
            // 
            // btClientes
            // 
            btClientes.Location = new Point(12, 12);
            btClientes.Name = "btClientes";
            btClientes.Size = new Size(178, 42);
            btClientes.TabIndex = 0;
            btClientes.Text = "CADASTRO DE CLIENTES";
            btClientes.UseVisualStyleBackColor = true;
            btClientes.Click += btClientes_Click;
            // 
            // btProdutos
            // 
            btProdutos.Location = new Point(196, 12);
            btProdutos.Name = "btProdutos";
            btProdutos.Size = new Size(193, 42);
            btProdutos.TabIndex = 1;
            btProdutos.Text = "CADASTRO DE PRODUTOS";
            btProdutos.UseVisualStyleBackColor = true;
            btProdutos.Click += btProdutos_Click;
            // 
            // btPedidos
            // 
            btPedidos.Location = new Point(196, 72);
            btPedidos.Name = "btPedidos";
            btPedidos.Size = new Size(193, 42);
            btPedidos.TabIndex = 2;
            btPedidos.Text = "CADASTRO DE PEDIDOS";
            btPedidos.UseVisualStyleBackColor = true;
            btPedidos.Click += btPedidos_Click;
            // 
            // btUsuario
            // 
            btUsuario.Location = new Point(17, 72);
            btUsuario.Name = "btUsuario";
            btUsuario.Size = new Size(173, 42);
            btUsuario.TabIndex = 3;
            btUsuario.Text = "CADASTRO DE USUÁRIOS";
            btUsuario.UseVisualStyleBackColor = true;
            btUsuario.Click += btUsuario_Click;
            // 
            // btConsulta
            // 
            btConsulta.Location = new Point(122, 120);
            btConsulta.Name = "btConsulta";
            btConsulta.Size = new Size(159, 56);
            btConsulta.TabIndex = 4;
            btConsulta.Text = "CONSULTA DE PEDIDOS";
            btConsulta.UseVisualStyleBackColor = true;
            btConsulta.Click += btConsulta_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 213);
            Controls.Add(btConsulta);
            Controls.Add(btUsuario);
            Controls.Add(btPedidos);
            Controls.Add(btProdutos);
            Controls.Add(btClientes);
            Name = "frmMenuPrincipal";
            Text = "MenuPrincipal";
            Load += frmMenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btClientes;
        private Button btProdutos;
        private Button btPedidos;
        private Button btUsuario;
        private Button btConsulta;
    }
}