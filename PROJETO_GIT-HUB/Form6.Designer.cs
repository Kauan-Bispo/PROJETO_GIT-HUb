namespace PROJETO_GIT_HUB
{
    partial class FrmCadastroPedido
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btBuscar = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 199);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "NOME";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(14, 59);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(132, 23);
            btBuscar.TabIndex = 11;
            btBuscar.Text = "BUSCAR CLIENTE";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Brinquedos", "Lápis", "Caneta", "Borracha", "Tinta" });
            comboBox1.Location = new Point(272, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(252, 149);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 14;
            button1.Text = "ADICIONAR PEDIDO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(432, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(307, 212);
            dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 214);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 16;
            label1.Text = "TOTAL:";
            // 
            // button2
            // 
            button2.Location = new Point(7, 309);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 17;
            button2.Text = "SALVAR PEDIDO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(504, 246);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 154);
            listBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 24);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 19;
            label6.Text = "CÓDIGO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 21;
            // 
            // FrmCadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(btBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Name = "FrmCadastroPedido";
            Text = "Cadastro De Pedido";
            Load += FrmCadastroPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btBuscar;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}