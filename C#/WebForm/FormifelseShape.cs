using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseShape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cho = Convert.ToInt32(textBox3.Text);
            int radius = Convert.ToInt32(textBox4.Text);
            int length = Convert.ToInt32(textBox1.Text);
            int breadth = Convert.ToInt32(textBox2.Text);
            int num = Convert.ToInt32(textBox5.Text);
            int choice=0,area=0;

            if (choice == '1')
                label4.Text = "Circle";
            area = 3.14f * radius * radius;

            else if (choice == '2')
                label3.Text = "Rectangle";
            area = length * breadth;

            else if (choice == '3')
                label5.Text = "Square";
                area =num * num;


            else
                label3.Text = " invaild";




        }
    }
}
