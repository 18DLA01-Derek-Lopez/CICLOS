namespace Guia1_24_Marzo_13_DerekLopez
{
    partial class Problema3
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
            label1 = new Label();
            button1 = new Button();
            Matriz1 = new DataGridViewTextBoxColumn();
            Matriz2 = new DataGridViewTextBoxColumn();
            TotalMulti = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Matriz1, Matriz2, TotalMulti });
            dataGridView1.Location = new Point(210, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(685, 445);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 55);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 1;
            label1.Text = "Matrices";
            // 
            // button1
            // 
            button1.Location = new Point(463, 166);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Matriz1
            // 
            Matriz1.HeaderText = "matriz1";
            Matriz1.MinimumWidth = 10;
            Matriz1.Name = "Matriz1";
            Matriz1.Width = 200;
            // 
            // Matriz2
            // 
            Matriz2.HeaderText = "matriz2";
            Matriz2.MinimumWidth = 10;
            Matriz2.Name = "Matriz2";
            Matriz2.Width = 200;
            // 
            // TotalMulti
            // 
            TotalMulti.HeaderText = "totalmulti";
            TotalMulti.MinimumWidth = 10;
            TotalMulti.Name = "TotalMulti";
            TotalMulti.Width = 200;
            // 
            // Problema3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 766);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Problema3";
            Text = "Problema3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn Matriz1;
        private DataGridViewTextBoxColumn Matriz2;
        private DataGridViewTextBoxColumn TotalMulti;
    }
}