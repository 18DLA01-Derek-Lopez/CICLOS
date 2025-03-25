namespace Guia1_24_Marzo_13_DerekLopez
{
    partial class Form2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(752, 207);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 0;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 207);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 215);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 3;
            label1.Text = "Digite un valor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numero, Multi, Total });
            dataGridView1.Location = new Point(193, 346);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(566, 361);
            dataGridView1.TabIndex = 4;
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
            button2.Location = new Point(834, 501);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 5;
            button2.Text = "Ejercicio2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 74);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 6;
            label2.Text = "Ciclo While";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 960);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn Total;
        private Button button2;
        private Label label2;
    }
}