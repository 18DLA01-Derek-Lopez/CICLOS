namespace Guia1_24_Marzo_13_DerekLopez
{
    partial class Form1
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 164);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "Digite un valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 149);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(648, 149);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 2;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numero, Multi, Total });
            dataGridView1.Location = new Point(178, 252);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(566, 361);
            dataGridView1.TabIndex = 3;
            // 
            // Numero
            // 
            Numero.HeaderText = "numero";
            Numero.MinimumWidth = 10;
            Numero.Name = "Numero";
            Numero.Width = 200;
            // 
            // Multi
            // 
            Multi.HeaderText = "Multiplicacion";
            Multi.MinimumWidth = 10;
            Multi.Name = "Multi";
            Multi.Width = 200;
            // 
            // Total
            // 
            Total.HeaderText = "total";
            Total.MinimumWidth = 10;
            Total.Name = "Total";
            Total.Width = 200;
            // 
            // button2
            // 
            button2.Location = new Point(793, 324);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 4;
            button2.Text = "Ejercicio1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(803, 416);
            button3.Name = "button3";
            button3.Size = new Size(129, 79);
            button3.TabIndex = 5;
            button3.Text = "Suma Vectores";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(803, 537);
            button4.Name = "button4";
            button4.Size = new Size(129, 76);
            button4.TabIndex = 6;
            button4.Text = "Multi Matrices";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 721);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Ciclos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn Total;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
