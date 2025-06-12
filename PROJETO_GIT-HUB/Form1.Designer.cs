namespace PROJETO_GIT_HUB
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtSenha = new TextBox();
            btEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "USUÁRIO";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 42);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(156, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            label2.Click += label2_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 112);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(156, 23);
            txtSenha.TabIndex = 3;
            // 
            // btEntrar
            // 
            btEntrar.Location = new Point(48, 194);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(84, 31);
            btEntrar.TabIndex = 4;
            btEntrar.Text = "ENTRAR";
            btEntrar.UseVisualStyleBackColor = true;
            btEntrar.Click += btEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 256);
            Controls.Add(btEntrar);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtSenha;
        private Button btEntrar;
    }
}
