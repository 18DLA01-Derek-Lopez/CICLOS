namespace Guia1_24_Marzo_13_DerekLopez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;
                //Agregar los datos en el DataGridView
                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ejercicio1 = new Form2();
            ejercicio1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Problema2 problem2 = new Problema2();
            problem2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Problema3 problem3 = new Problema3();
            problem3.Show();
        }
    }
}
