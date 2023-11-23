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

namespace Form_collection_Rollno_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox2.Text), textBox1.Text);
            ar.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Student s in ar)
            {
                sb.Append("rno " + s.rno + " name " + s.name + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
