using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Mdi
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Email Id : " + textBox2.Text + "\n");
            sb.Append("Age :" + numericUpDown1.Value + "\n");

            //radiobutton
            if(radioButton1.Checked)
            {
                sb.Append("Gender : " + radioButton1.Text + "\n");
            }
            else if(radioButton2.Checked)
            {
                sb.Append("Gender : " + radioButton2.Text + "\n");
            }
            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("City : " + comboBox2.Text + "\n");

            label7.Text= sb.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch (comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Kolkata");
                    comboBox2.Items.Add("Delhi");
                    comboBox2.Items.Add("Chennai");
                    break;
                case "USA":
                    comboBox2.Items.Add("La");
                    comboBox2.Items.Add("Newyork");
                    comboBox2.Items.Add("Califonia");
                    comboBox2.Items.Add("Atlas");
                    break;
            }
           
        }
    }
}
