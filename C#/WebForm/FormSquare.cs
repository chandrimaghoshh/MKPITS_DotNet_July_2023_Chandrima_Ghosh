using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            int num, square;

            num = Convert.ToInt32(textBox1.Text);

            square = num * num;
            label2.Text = "Square :" + square;
        }
    }
}
