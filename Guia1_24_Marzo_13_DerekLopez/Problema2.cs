﻿using System;
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
    public partial class Problema2 : Form
    {
        public Problema2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Vector1 = { 1, 2, 3, 4 };
            int[] Vector2 = { 5, 6, 7, 8 };

            for(int i=0; i<4; i++)
            {
                int suma = Vector1[i] + Vector2[i];
                dataGridView1.Rows.Add(Vector1[i], Vector2[i],suma);
            }
        }
    }
}
