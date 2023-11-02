using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Emp_HighSal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].id = Convert.ToInt32(textBox1.Text);
                emp[cnt].name = textBox2.Text;
                emp[cnt].salary = Convert.ToDouble(textBox3.Text);
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("Details of 3 employees accepted");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Details : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                sb.Append("--------------------------------------\n");
                sb.Append("Employee ID : " + emp[i].id + "\n");
                sb.Append("Employee Name : " + emp[i].name + "\n");
                sb.Append("Employee Salary : " + emp[i].salary + "\n");
                sb.AppendLine("------------------------------------");
            }
            label4.Text = sb.ToString();

            double high = emp[0].salary;
            int foundat = 0;

            for(int i = 0;i < 3;i++)
            {
                    if (high < emp[i].salary)
                    {
                        high = emp[i].salary;
                        foundat = i;
                    }
            }
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Employee With Highest Salary : \n");
            sb1.Append("Employee ID : " + emp[foundat].id + "\n");
            sb1.Append("Employee Name : " + emp[foundat].name + "\n");
            sb1.Append("Employee Salary : " + emp[foundat].salary + "\n");

            label5.Text = sb1.ToString();
        }
        
    }
}
