using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            float circle, circ;

            r = Convert.ToInt32(textBox1.Text);

            circle = 3.14f * r * r;
            circ = 2 * 3.14f * r;

            label2.Text = "Area of circle : " + circle;
            label3.Text = "Area of Circumference : " + circ;
            
        }
    }
}
