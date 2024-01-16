using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addition
{
    public partial class SwitchSalarySheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            int salary=Convert.ToInt32(TextBox2.Text);
            string designation = TextBox3.Text;
            float hra = 0;
            float da = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            switch(designation)
            {
                case "manager":
                    hra = 0.45f * salary;
                    da = 0.35f * salary;
                    break;
                case "peon":
                    hra = 0.25f * salary;
                    da = 0.15f * salary;
                    break;
                default:
                    Response.Write("Invaild designation");
                    break;
            }
            float totalSalary = salary + hra + da;
            sb.Append("Total Salary = " + totalSalary);
            sb.Append("<br>");
            sb.Append("Hra = " + hra);
            sb.Append("<br>");
            sb.Append("Da = " + da);

            Label1.Text = sb.ToString();
        }
    }
}