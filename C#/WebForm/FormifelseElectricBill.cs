using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ifelseElectricBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBox1.Text);
            int id = Convert.ToInt32(textBox2.Text);
            float unit = Convert.ToSingle(textBox3.Text);
            float charge, bill, total, surcharge = 0;

           
            if (unit <= 200)
                charge = 1.20f;
            else if (unit >= 200 && unit <= 400)
                charge = 1.50f;
            else if (unit >= 400 && unit <= 600)
                charge = 1.80f;
            else
                charge = 2.00f;

            total = unit * charge;
            label7.Text = "Amount Charges @Rs. 2.00 per unit : " + total;

            if (total > 400)
                surcharge = total * 0.15f;
            label8.Text = "Surcharge : " + surcharge;

            bill = total + surcharge;
            label9.Text = "Net Amount Paid By the Customer : " + bill;

            label4.Text = "Customer Name : " + name;
            label5.Text = "Customer ID : " + id;
            label6.Text = "Unit Consumed : " + unit;
        }
    }
}
