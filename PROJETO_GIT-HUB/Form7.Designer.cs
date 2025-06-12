namespace PROJETO_GIT_HUB
{
    partial class FrmConsulta
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
            label1 = new Label();
            textBox1 = new TextBox();
            btBuscar = new Button();
            listView1 = new ListView();
            label2 = new Label();
            label3 = new Label();
            listView2 = new ListView();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(182, 34);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(136, 23);
            btBuscar.TabIndex = 2;
            btBuscar.Text = "BUSCAR CLIENTE";
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(368, 65);
            listView1.Name = "listView1";
            listView1.Size = new Size(218, 195);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "PEDIDOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 205);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "ITENS";
            // 
            // listView2
            // 
            listView2.Location = new Point(66, 223);
            listView2.Name = "listView2";
            listView2.Size = new Size(218, 195);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 403);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "TOTAL:";
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(listView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(btBuscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FrmConsulta";
            Text = "Consulta de Pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btBuscar;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private ListView listView2;
        private Label label4;
    }
}