using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dictionary_ProductsOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Ordercollection> orders=new Dictionary<int,Ordercollection>();

        Ordercollection ord = null;

        private void button1_Click(object sender, EventArgs e)
        {
            ord = new Ordercollection(Convert.ToInt32(textBox1.Text), textBox2.Text,
                                        Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

            orders.Add(Convert.ToInt32(textBox1.Text),ord);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<int, Ordercollection> kvp in orders)
            {
                int amount = kvp.Value.orderquantity * kvp.Value.orderRate;
                total = total + amount;

                sb.Append("Order ID : " + kvp.Key + "\n" + "Item Name : " + kvp.Value.orderName + "\n" + "Rate : " + kvp.Value.orderRate + "\n" + "Quantity : " + kvp.Value.orderquantity + "\n"
                                +"\n"+"Total Amount : "+amount+"\n");
                sb.Append("---------------------------------------------------------------"+"\n");
            }
            label5.Text = sb.ToString();

        }
    }
}
