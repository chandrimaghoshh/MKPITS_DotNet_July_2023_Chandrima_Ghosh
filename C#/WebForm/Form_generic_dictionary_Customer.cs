﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_generic_Dictionary_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Customer> cust = new Dictionary<int, Customer>();
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Customer c2 = new Customer(Convert.ToInt32(textBox3.Text), textBox4.Text);

            cust.Add(c1.customerID, c1);
            cust.Add(c2.customerID, c2);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Customer> kv in cust)
            {
                sb.Append("cust id " + kv.Key + " customer name " + kv.Value.name + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
