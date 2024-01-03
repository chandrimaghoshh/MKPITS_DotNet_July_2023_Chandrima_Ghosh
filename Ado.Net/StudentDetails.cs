using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Insert
        private void Button1_Click(object sender, EventArgs e)
        {
            //Insert
            StudentClass s = new StudentClass();
            string g = null;
            if(radiobutton1.Checked)
            {
                g = "Male";
            }
            if(radiobutton2.Checked)
            {
                g = "Female";
            }

            string h = null;
            if(checkbox1.Checked)
            {
                h = "Travelling";
            }
            if(checkbox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " , " + "Cooking";
                }
                else
                {
                    h = "Cooking";
                }    
            }

            string result = s.InsertStudent(Convert.ToInt32(rno.Text),name.Text, g, h, combobox1.Text, DateTimePicker1.Value.ToShortDateString());
            Label8.Text= result;
            cleartext();
        }
        public void cleartext()
        {
            rno.Clear();
            name.Clear();
            radiobutton1.Checked = false;
            radiobutton2.Checked = false;
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            combobox1.Text = " ";
            DateTimePicker1.Value = DateTime.Now;


        }
        //Update
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string g = null;
            if(radiobutton1.Checked)
            {
                g = "Male";
            }
            if(radiobutton2.Checked)
            {
                g = "Female";
            }

            string h = null;
            if(checkbox1.Checked)
            {
                h = "Travelling";
            }
            if(checkbox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " , " + "Cooking";
                }
                else
                {
                    h = "Cooking";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(rno.Text), name.Text, g, h, combobox1.Text, DateTimePicker1.Value.ToShortDateString());
            Label8.Text = result;
            cleartext();

        }
        //Delete
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string result = s.DeleteStudent(Convert.ToInt32(rno.Text), name.Text);
            Label8.Text = result;
            cleartext();
        }
        //Search
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            List<StudentSearch> li = new List<StudentSearch>();
            StudentClass s = new StudentClass();
            li = s.SearchStudent(Convert.ToInt32(rno.Text));
            name.Text = li[0].Name;
            string g = li[0].Gender;
            if(g=="Male")
            {
                radiobutton1.Checked = true;
            }
            else if(g=="Female")
            {
                radiobutton2.Checked = true;
            }

            string h = li[0].Hobby;
            if(h=="Travelling")
            {
                checkbox1.Checked = true;
            }
            if(h=="Cooking")
            {
                checkbox2.Checked = true;
            }
            combobox1.Text = li[0].City;
            DateTimePicker1.Text = li[0].DOB;

        }
    }
}
