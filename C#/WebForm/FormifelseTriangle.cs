﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c =  Convert.ToInt32(textBox3.Text);

            if (a == b && b == c)
                label4.Text = "Triangle is Eqvilateral";
            else if (a == b || b == c || b == c)
                label4.Text = "Triangle is Isosceles";
            else
                label4.Text = "Triangle is Scalane";
        }
    }
}
