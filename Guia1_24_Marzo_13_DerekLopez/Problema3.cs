using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_Marzo_13_DerekLopez
{
    public partial class Problema3 : Form
    {
        public Problema3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Matriz1 = {
                {1,2,3},
                {3,5,8}
            };
            int[,] Matriz2 = {
                {4,5,6},
                {2,4,8}
            };

            for(int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    int multi = Matriz1[j,i] * Matriz2[j,i];
                    dataGridView1.Rows.Add(Matriz1[j, i], Matriz2[j,i], multi);
                }
            }
        }
    }
}
