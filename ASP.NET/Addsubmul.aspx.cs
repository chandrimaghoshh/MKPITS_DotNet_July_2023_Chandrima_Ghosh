using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Addsubmul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            int add = 0;
            int sub = 0;
            int mul = 0;
            if(CheckBox1.Checked)
            {
                add = n1 + n2;
            }
            if(CheckBox2.Checked)
            {
                sub = n1 - n2;
            }
            if(CheckBox3.Checked)
            {
                mul = n1 * n2;
            }
            sb.Append("Addition : " + add.ToString() + "<br>");
            sb.Append("Subtractition : " + sub.ToString() + "<br>");
            sb.Append("Multiplication : " + mul.ToString() + "<br>");
            Label1.Text = sb.ToString();
        }
    }
}