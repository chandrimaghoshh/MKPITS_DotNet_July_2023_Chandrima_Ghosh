using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Bank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int amt = Convert.ToInt32(TextBox2.Text);
            int bal = 1000;
            int deposit=0;
            int withdrawal=0;
            if(RadioButton1.Checked)
            {
                deposit = bal + amt;
            }
            if(RadioButton2.Checked)
            {
                withdrawal = bal - amt;
            }
            sb.Append("Account No. : " + TextBox1.Text + "<br>");
            sb.Append("Amount : " + TextBox2.Text + "<br>");
            sb.Append("Deposited amount are : " + deposit.ToString() + "<br>");
            sb.Append("Withdrawal amount are : " + withdrawal.ToString() + "<br>");
            Label1.Text = sb.ToString();

        }
    }
}