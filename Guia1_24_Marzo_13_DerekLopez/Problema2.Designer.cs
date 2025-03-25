namespace Guia1_24_Marzo_13_DerekLopez
{
    partial class Problema2
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
            Vector1 = new DataGridViewTextBoxColumn();
            Vector2 = new DataGridViewTextBoxColumn();
            TotalSuma = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Vector1, Vector2, TotalSuma });
            dataGridView1.Location = new Point(158, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(680, 300);
            dataGridView1.TabIndex = 0;
            // 
            // Vector1
            // 
            Vector1.HeaderText = "vector1";
            Vector1.MinimumWidth = 10;
            Vector1.Name = "Vector1";
            Vector1.Width = 200;
            // 
            // Vector2
            // 
            Vector2.HeaderText = "vector2";
            Vector2.MinimumWidth = 10;
            Vector2.Name = "Vector2";
            Vector2.Width = 200;
            // 
            // TotalSuma
            // 
            TotalSuma.HeaderText = "totalsuma";
            TotalSuma.MinimumWidth = 10;
            TotalSuma.Name = "TotalSuma";
            TotalSuma.Width = 200;
            // 
            // button1
            // 
            button1.Location = new Point(403, 179);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 94);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 2;
            label1.Text = "Vectores";
            // 
            // Problema2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 686);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Problema2";
            Text = "Problema2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Vector1;
        private DataGridViewTextBoxColumn Vector2;
        private DataGridViewTextBoxColumn TotalSuma;
        private Button button1;
        private Label label1;
    }
}