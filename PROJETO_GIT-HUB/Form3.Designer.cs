﻿namespace PROJETO_GIT_HUB
{
    partial class FrmCadastroUsu
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
            dgvDados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btSalvar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            btLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(215, 24);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(365, 299);
            dgvDados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 108);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "SENHA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 23);
            textBox2.TabIndex = 4;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(35, 199);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(91, 31);
            btSalvar.TabIndex = 5;
            btSalvar.Text = "SALVAR";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(35, 248);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(91, 29);
            btEditar.TabIndex = 6;
            btEditar.Text = "EDITAR";
            btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(35, 300);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(91, 23);
            btExcluir.TabIndex = 7;
            btExcluir.Text = "EXCLUIR";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(35, 341);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(91, 23);
            btLimpar.TabIndex = 8;
            btLimpar.Text = "LIMPAR";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 376);
            Controls.Add(btLimpar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btSalvar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Name = "FrmCadastroUsu";
            Text = "CADASTRO DE USUÁRIO";
            Load += FrmCadastroUsu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btSalvar;
        private Button btEditar;
        private Button btExcluir;
        private Button btLimpar;
    }
}