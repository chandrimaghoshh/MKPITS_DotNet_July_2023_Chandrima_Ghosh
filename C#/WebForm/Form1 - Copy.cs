using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration_Form r = new Registration_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_Form a = new Account_Form();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registration_Form r = new Registration_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Account_Form a = new Account_Form();
            a.MdiParent = this;
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin") 
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invaild input");
            }
        }
    }
}
