using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationForm
{
    public partial class Course_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(RadioButton4.Checked)
            {
                cat = category.Student;
            }
            

        }
        public enum category { Student, IT_Professional }
        category cat;
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Full Name : " + TextBox1.Text + "<br>");
            string g = null;
            if(RadioButton1.Checked)
            {
                g = RadioButton1.Text;
            }
            if(RadioButton2.Checked)
            {
                g = RadioButton2.Text;
            }
            if(RadioButton3.Checked)
            {
                g= RadioButton3.Text;
            }
            sb.Append("Gender : " + g + "<br>");
            string c = null;
            if(RadioButton4.Checked)
            {
                c = RadioButton4.Text;
            }
            if(RadioButton5.Checked)
            {
                c = RadioButton5.Text;
            }
            sb.Append("Category : " + c + "<br>");
            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("City : " + DropDownList3.Text + "<br>");
            sb.Append("Payment Date : " + TextBox2.Text + "<br>");
            sb.Append("Total Amount : " + TextBox3.Text + "<br>");
            sb.Append("Fees Paid : " + TextBox4.Text + "<br>");
            sb.Append("Balance Amount : " + TextBox5.Text + "<br>");
            Label1.Text = sb.ToString();


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch(c)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Punjab");
                    break;
                case "USA":
                    DropDownList2.Items.Add("La");
                    DropDownList2.Items.Add("Ny");
                    break;
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList2.Text;
            DropDownList3.Items.Clear();
            switch(c)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Mumbai");
                    break;
                case "Punjab":
                    DropDownList3.Items.Add("Amritsar");
                    DropDownList3.Items.Add("Chandigarh");
                    break;
                case "La":
                    DropDownList3.Items.Add("California");
                    DropDownList3.Items.Add("White House");
                    break;
                case "Ny":
                    DropDownList3.Items.Add("Pauls");
                    DropDownList3.Items.Add("Shine");
                    break;
            }
        }
        double fp = 0;
        double bamt = 0;
        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
           if(RadioButton4.Checked)
            {
                cat = category.Student;
                TextBox3.Text = "1000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";
            }
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton5.Checked)
            {
                cat = category.IT_Professional;
                TextBox3.Text = "3000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
            if (cat.ToString() == "Student")
            {

                float ta = Convert.ToSingle(TextBox3.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(TextBox4.Text);

                if (amt < fp)
                {
                    Response.Write("minimum amount to be paid is 50 per");
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
                
            }
            else if (cat.ToString() == "IT_Professional")
            {

                float ta = Convert.ToSingle(TextBox3.Text);
                fp = ta * 0.8f;
                float amt = Convert.ToSingle(TextBox4.Text);

                if (amt < fp)
                {
                    Response.Write("minimum amount to be paid is 80 per");
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
            }
            
        }
    }
}