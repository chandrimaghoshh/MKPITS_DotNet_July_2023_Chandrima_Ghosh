using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addition
{
    public partial class Marksheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int m1 = Convert.ToInt32(TextBox1.Text);
            int m2 = Convert.ToInt32(TextBox2.Text);
            int m3 = Convert.ToInt32(TextBox3.Text);
            int total;
            float per;
            string grade;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            total = m1+m2+m3;
            per = total * 100.0f / 300.0f;
            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "First";
            }
            else if (per >= 45 && per < 60)
            {
                grade = "Second";
            }
            else if (per >= 30 && per < 45)
            {
                grade = "Third";
            }
            else
            {
                grade = "Fail";
            }
            sb.Append("Total Marks = "+total);
            sb.Append("<br>");
            sb.Append("Percentage = " + per + "%");
            sb.Append("<br>");
            sb.Append("Grade = " + grade);
           
            Label1.Text = sb.ToString();
        }
    }
}