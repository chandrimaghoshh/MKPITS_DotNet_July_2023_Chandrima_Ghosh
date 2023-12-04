using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CheckButton_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int salary = Convert.ToInt32(textBox2.Text);
            string desig = Console.ReadLine();
            float bonus = 0.0f;

            StringBuilder sb = new StringBuilder();
            //combobox
            if (comboBox1.Text == "manager")
            {
                bonus = salary * 0.45f;
            }
            else if (comboBox1.Text == "clerk")
            {
                bonus = salary * 0.25f;
            }
            else if(comboBox1.Text == "peon")
            {
                bonus = salary * 0.15f;
            }
            label3.Text=sb.ToString();

            //checkbox
            float total_sal = salary + bonus;
            if (checkBox1.Checked == checkBox2.Checked)
            {
                sb.Append("Bonus = " + bonus + "\n");
                sb.Append("Total Salary = " + total_sal + "\n");
            }
            else if (checkBox1.Checked)
            {
               sb.Append( "Bonus = " + bonus);
            }
            else if (checkBox2.Checked)
            {
                sb.Append("Total Salary = " + total_sal);
            }
            
            label3.Text = sb.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

