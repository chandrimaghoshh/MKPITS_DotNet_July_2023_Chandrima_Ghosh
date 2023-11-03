using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankCustomer b = new BankCustomer();

            b.name = textBox1.Text;
            b.act_no = Convert.ToDouble(textBox2.Text);
            b.amt = Convert.ToInt32(textBox3.Text);


            b.getdata(b.name, b.act_no, b.amt, b.balance);

            StringBuilder sb = new StringBuilder();

            sb.Append("Final balance after deposit : " + b.deposit + "\n");

            label4.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankCustomer b = new BankCustomer();

            b.name = textBox1.Text;
            b.act_no = Convert.ToDouble(textBox2.Text);
            b.amt = Convert.ToInt32(textBox3.Text);
            

            b.getdata(b.name,b.act_no,b.amt, b.balance);

            StringBuilder sb = new StringBuilder();

            sb.Append("Final balance after withdrawal : " + b.withdrawal + "\n");

            label5.Text = sb.ToString();
        }
    }
}
