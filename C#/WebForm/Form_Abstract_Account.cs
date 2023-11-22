using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_abstract_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;

            if (tt == "saving")
            {
                act = new Saving();
            }
            else if(tt=="current")
            {
                act= new Current();
            }
            label4.Text = act.deposit(actno, amt);
            label5.Text = act.showbalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;

            if (tt == "saving")
            {
                act = new Saving();
            }
            else if (tt == "current")
            {
                act = new Current();
            }
            label4.Text = act.withdrawal(actno, amt);
            label5.Text = act.showbalance();
        }
    }
}
