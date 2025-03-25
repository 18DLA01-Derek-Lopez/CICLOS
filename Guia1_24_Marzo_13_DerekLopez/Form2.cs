using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Guia1_24_Marzo_13_DerekLopez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont2 = 1;
            int num2 = int.Parse(textBox1.Text);
            while (cont2<11)
            {
                int multi;
                multi = num2 * cont2;
                //Agregar los datos en el DataGridView
                dataGridView1.Rows.Add(num2, cont2, multi);
                cont2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ejercicio3 = new Form3();
            ejercicio3.Show();
        }
    }
}
