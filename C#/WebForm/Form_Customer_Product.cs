using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Customer__product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Our Shop");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if(textBox1.Text=="" && textBox2.Text=="" && textBox3.Text=="")
            {
                MessageBox.Show("Enter Details first");
            }
            else
            {
                sb.Append("Customer Name : " + textBox1.Text + "\n");
                sb.Append("Mobile No. : " + maskedTextBox1.Text + "\n");
                sb.Append("Product catogory : " + comboBox1.Text + "\n");
                sb.Append("Product Item : " + comboBox2.Text + "\n");
                sb.Append("Product Rate : " + textBox2.Text + "\n");
                sb.Append("Product Quantity : " + textBox3.Text + "\n");

                int rate = Convert.ToInt32(textBox2.Text);
                int quantity= Convert.ToInt32(textBox3.Text);
                int total = rate * quantity;
                sb.Append("Total = " + total + "\n");
            }

            label8.Text=sb.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label8.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text)
            {
                case "Electronics":
                    comboBox2.Items.Add("Laptop");
                    comboBox2.Items.Add("Tv");
                    comboBox2.Items.Add("Microwave");
                    comboBox2.Items.Add("Fridge");
                    comboBox2.Items.Add("Washing Machine");
                    comboBox2.Items.Add("Ac");
                    break;
                case "Furniture":
                    comboBox2.Items.Add("Chair");
                    comboBox2.Items.Add("Sofa");
                    comboBox2.Items.Add("Bed");
                    comboBox2.Items.Add("Sofa-cum bed");
                    comboBox2.Items.Add("Tabel");
                    comboBox2.Items.Add("Cupboard");
                    break;
                case "Household":
                    comboBox2.Items.Add("Curtains");
                    comboBox2.Items.Add("Utensils");
                    comboBox2.Items.Add("Bedsheet");
                    comboBox2.Items.Add("Flower vase");
                    comboBox2.Items.Add("Mat");
                    break;
                case "Sports":
                    comboBox2.Items.Add("Cricket products");
                    comboBox2.Items.Add("Football products");
                    comboBox2.Items.Add("Voleyball products");
                    comboBox2.Items.Add("Basketball products");
                    comboBox2.Items.Add("Badminton products");
                    break;
            }
            
        }
    }
}
