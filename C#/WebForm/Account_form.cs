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
    public partial class Account_form : Form
    {
        public Account_form()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            int amt = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("Account No : " + textBox1.Text + "\n");
            
            if(radioButton1.Checked )
            {
                bal = bal + amt;
                sb.Append("Amount after deposit = " + bal + "\n");
            }
            else if(radioButton2.Checked )
            {
                bal = bal - amt;
                if(amt>bal)
                {
                    sb.Append("Insufficient balance in your account");
                }
                else
                {
                    sb.Append("Amount after withdrawal = " + bal + "\n");
                }
            }
            label4.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();   
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
