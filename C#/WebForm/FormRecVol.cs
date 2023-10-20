using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recVol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox1.Text);
            int breadth = Convert.ToInt32(textBox2.Text);

            int area = length * breadth;

            label4.Text = "Area of Rectangle = " + area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox4.Text);
            int breadth = Convert.ToInt32(textBox5.Text);
            float height = Convert.ToSingle(textBox3.Text);

            float area1 = length * breadth * height;

            label5.Text = "Volume of Area = " + area1;
        }
    }
}
