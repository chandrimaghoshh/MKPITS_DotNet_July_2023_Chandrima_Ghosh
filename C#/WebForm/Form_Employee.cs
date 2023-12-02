using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            int empno = Convert.ToInt32(textBox1.Text);
            int salary = Convert.ToInt32(textBox2.Text);
            string desig = textBox3.Text;

            emp.display(empno,salary,desig);

            label4.Text = "Hra = " + emp.hra;
            label5.Text = "Bonus = " + emp.bonus;
            label6.Text = "total sal " + emp.totalsal;
        }
    }
}
