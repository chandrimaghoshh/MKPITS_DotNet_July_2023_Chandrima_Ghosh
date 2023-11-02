using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Area a = new Area();
            
            a.radius = Convert.ToInt32(textBox1.Text);
            a.getdata(a.radius);

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Circle : " + a.circle + "\n");
            

            label2.Text = sb.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Area a = new Area();

            a.radius = Convert.ToInt32(textBox1.Text);
            a.getdata(a.radius);

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Circumference : " + a.circ + "\n");


            label3.Text = sb.ToString();
        }
    }
}
