namespace Guia1_24_Marzo_13_DerekLopez
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Multi = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Numero, Multi, Total });
            dataGridView1.Location = new Point(241, 290);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(566, 361);
            dataGridView1.TabIndex = 8;
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
            // button1
            // 
            button1.Location = new Point(711, 188);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 7;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 188);
            textBox1.Margin = new Padding(6, 6, 6, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 39);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 203);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 5;
            label1.Text = "Digite un valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 79);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 9;
            label2.Text = "Ciclo Do While";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 734);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Multi;
        private DataGridViewTextBoxColumn Total;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}