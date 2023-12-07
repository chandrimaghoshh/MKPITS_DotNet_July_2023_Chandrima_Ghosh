using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("DoB : " + maskedTextBox2.Text + "\n");
            sb.Append("Nationality : " + textBox2.Text + "\n");
            sb.Append("City : " + textBox3.Text + "\n");
            sb.Append("Address : " + richTextBox1.Text + "\n");
            sb.Append("Mother Tongue : " + textBox4.Text + "\n");
            sb.Append("Qualification : " + textBox5.Text + "\n");
            sb.Append("Email : "+textBox6.Text+ "\n");

            label10.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name : " + textBox7.Text + "\n");
            sb.Append("last Name : " + textBox8.Text + "\n");
            sb.Append("Father Name : " + textBox9.Text + "\n");
            sb.Append("Mother Name : " + textBox10.Text + "\n");
            sb.Append("Father Occupation : " + textBox11.Text + "\n");
            sb.Append("Mother Occupation : " + textBox12.Text + "\n");
            sb.Append("DOB : " + maskedTextBox3.Text + "\n");
            sb.Append("Qualification: " + textBox13.Text + "\n");
            if (radioButton1.Checked)
            {
                sb.Append("Gender : " + radioButton1.Text+ "\n");
            }
            else if (radioButton2.Checked)
            {
                sb.Append("Gender : " + radioButton2.Text + "\n");
            }
            else
            {
                sb.Append("Gender : " + radioButton3.Text + "\n");
            }
            sb.Append("Address : " + richTextBox2.Text + "\n");

            label22.Text = sb.ToString();
        }
    }
}
