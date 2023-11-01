using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Person_Shortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person2 p = new Person2();

            p.Name = textBox1.Text;
            p.Age = Convert.ToInt32(textBox2.Text);
            p.Address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + p.Name+ "\n");
            sb.Append("Age : " + p.Age + "\n");
            sb.Append("Address : " + p.Address + "\n");

            label4.Text = sb.ToString();


        }
    }
}
