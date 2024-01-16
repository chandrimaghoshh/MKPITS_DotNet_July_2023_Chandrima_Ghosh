using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addition
{
    public partial class Circle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float radius = Convert.ToSingle(TextBox1.Text);
            float circle = 3.14f * radius * radius;
            float circ = 2 * 3.14f * radius;
            Label1.Text="Area of Circle = "+circle.ToString();
            Label3.Text="Area of Circumference = "+circ.ToString();
        }
    }
}