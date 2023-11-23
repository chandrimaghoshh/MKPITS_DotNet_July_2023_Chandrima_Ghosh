using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_collection_Insert_Remove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity:  " + ar.Capacity);
            MessageBox.Show("Count: " + ar.Count);

            StringBuilder sb = new StringBuilder();
            foreach (object obj in ar)
            {
                sb.Append("Student Name : " + obj.ToString() + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Insert(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ar.Remove(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ar.RemoveAt(Convert.ToInt32(textBox2.Text));
            textBox2.Clear();
            textBox2.Focus();
        }
    }
}
