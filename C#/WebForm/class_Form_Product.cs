using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            int total=0;
            int quantity = 50;
            p.productName = textBox1.Text;
            p.productPrice = Convert.ToInt32(textBox2.Text);
            p.stockQuantity = Convert.ToInt32(textBox3.Text);

            if (p.stockQuantity > 0 && p.stockQuantity < quantity)
            {
                int remainingQuantity = quantity - p.stockQuantity;
                total = p.productPrice * p.stockQuantity;

                p.getdata(p.productName, p.productPrice, total);

                StringBuilder sb = new StringBuilder();
                sb.Append("Product Name : " + p.productName + "\n");
                sb.Append("Product Price : " + p.productPrice + "\n");
               
                sb.Append("Remaining Quantity : " + remainingQuantity + "\n");
                sb.Append("Total Price : " + total + "\n");

          
                label4.Text = sb.ToString();

            }
            
        }
    }
}
