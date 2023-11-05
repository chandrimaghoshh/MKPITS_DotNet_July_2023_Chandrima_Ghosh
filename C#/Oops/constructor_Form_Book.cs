using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructor_Form_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b1 = new Book();
            b1.bookid = Convert.ToInt32(textBox1.Text);
            b1.title = textBox2.Text;
            b1.author = textBox3.Text;
            b1.price = Convert.ToInt32(textBox4.Text);
            b1.getdata(b1.bookid, b1.title, b1.author, b1.price);

            StringBuilder sb = new StringBuilder();
            sb.Append("Book Id : " + b1.bookid + "\n");
            sb.Append("Book Title : "+ );
            sb.Append("Book Author : ");
            sb.Append("Book Price : ");

            label5.Text = sb.ToString();
        }
    }
}
