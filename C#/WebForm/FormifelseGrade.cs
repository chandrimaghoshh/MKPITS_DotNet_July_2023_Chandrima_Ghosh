using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phy, chem, bio;
            int total;
            float per;
            string grade = null;

            phy = Convert.ToInt32(textBox1.Text);
            chem = Convert.ToInt32(textBox2.Text);
            bio = Convert.ToInt32(textBox3.Text);

            total = phy + chem + bio;

            per = (total / 300.0f) * 100.0f;

            if (per >= 75)
                grade = "Distinction";
            else if (per >= 60 && per < 75)
                grade = "First";
            else if (per >= 40 && per < 60)
                grade = "Second";
            else
                grade = "Fail";

            label4.Text = "Total Marks = " + total;
            label5.Text = "Percentage = "+per + "%";
            label6.Text = "Grade = " + grade;

        }
    }
}
