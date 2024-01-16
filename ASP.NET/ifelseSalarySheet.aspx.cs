using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace addition
{
    public partial class ifelseSalarySheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int salary=Convert.ToInt32(TextBox2.Text);
            string designation = TextBox3.Text;
            float hra=0;
            float da = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if (designation=="manager")
            {
                 hra = 0.45f * salary;
                 da = 0.35f * salary;
            }
            else if(designation=="peon")
            {
                 hra = 0.25f * salary;
                 da = 0.15f * salary;
            }
            else
            {
                Response.Write("Invaild Designation");
            }
            float total_salary = salary + hra + da;
            sb.Append("Total Salary = " + total_salary);
            sb.Append("<br>");
            sb.Append("Hra = " + hra);
            sb.Append("<br>");
            sb.Append("Da = " + da);

            Label1.Text = sb.ToString();

        }
    }
}