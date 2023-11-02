using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Library[] book = new Library[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new Library();
            book[1] = new Library();
            book[2] = new Library();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt < 3)
            {
                book[cnt].title = textBox1.Text;
                book[cnt].author = textBox2.Text;

                if(checkBox1.Checked)
                {
                    book[cnt].isavailable = true;
                }
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                if(cnt == 3)
                {
                    textBox1.Enabled= false;
                    textBox2.Enabled= false;
                    button1.Enabled= false;
                    button2.Enabled= true;

                    MessageBox.Show("details of 3 books accepted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book Details : " + "\n");
            for(int i=0; i<3; i++)
            {
                if (book[i].isavailable == true)
                {
                    sb.Append("Book Title : " + book[i].title + "\n");
                    sb.Append("Book Author Name : " + book[i].author + "\n");

                    sb.Append("------------------------------\n");
                }
            }
            label3.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Not Available Books : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isavailable == false)
                {
                    sb1.Append("Book Title : " + book[i].title + "\n");
                    sb1.Append("Book Author Name : " + book[i].author + "\n");

                    sb1.Append("------------------------------\n");
                }
            }
            label4.Text = sb1.ToString();
        }
    }
}
