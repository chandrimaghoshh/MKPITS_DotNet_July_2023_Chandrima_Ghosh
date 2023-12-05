using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter name");
                MessageBox.Show("Enter age");
            }
            else
            {
               
            }

            if(numericUpDown1.Value<=18)
            {
                MessageBox.Show("Please enter age greater than 18");
            }
            else
            {
                sb.Append("Name : " + textBox1.Text + "\n");
                sb.Append("Age : " + numericUpDown1.Value.ToString());
            }
            label3.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }
    }
}
