using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_RegistrationForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch (comboBox1.Text)
            {
                case "India":

                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Nagpur");
                    break;
                case "Usa":
                    comboBox2.Items.Add("Newyork");
                    comboBox2.Items.Add("California");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Username : " + textBox1.Text + "\n");
            sb.Append("Password : " + textBox2.Text + "\n");

            //gender
            if(radioButton1.Checked)
            {
                sb.Append("Gender : " + radioButton1.Text + "\n");
            }
            else if(radioButton2.Checked)
            {
                sb.Append("Gender : " + radioButton2.Text + "\n");
            }

            //courses
            if(checkBox1.Checked)
            {
                sb.Append("Courses : " + checkBox1.Text + "\n");
            }
            else if(checkBox2.Checked)
            {
                sb.Append("Course : " + " " + checkBox2.Text + "\n");
            }
            sb.Append("Country :" + comboBox1.Text + "\n");

            sb.Append("City : " + comboBox2.Text + "\n");

            label7.Text = sb.ToString();
        }
    }
}
