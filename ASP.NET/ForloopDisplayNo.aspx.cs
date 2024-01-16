using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addition
{
    public partial class ForloopDisplayNo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int i = 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            
            for(i=1;i<=num;i++)
            {
                sb.Append(i + "<br>");
            }
            Label1.Text = sb.ToString();
        }
    }
}