using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Collection_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);
            ar.Add(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Employee emp in ar)
            {
                sb.Append("Employee Id : " + emp.empname + "\n" + " Employee Name : " + "\n" + emp.empname + "Employee Salary : " + emp.salary + "\n" + "Employee Desig : " + emp.designation + "\n");
            }
            label5.Text = sb.ToString();
        }
        
    }
}
