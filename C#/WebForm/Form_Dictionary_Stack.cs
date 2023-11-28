using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dictionary_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> s = new Stack<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string c in s)
            {
                sb.Append(c + " " + "\n");
            }

            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            s.Pop();

            foreach (string c in s)
            {
                sb1.Append(c + " " + "\n");
            }

            label2.Text = sb1.ToString();
        }
    }
}
