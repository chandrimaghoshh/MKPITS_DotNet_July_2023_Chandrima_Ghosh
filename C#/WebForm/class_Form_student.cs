using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();

            stud.name = textBox1.Text;
            stud.roll_no = Convert.ToInt32(textBox2.Text);
            stud.marks[0] = Convert.ToInt32(textBox3.Text);
            stud.marks[1] = Convert.ToInt32(textBox4.Text);
            stud.marks[2] = Convert.ToInt32(textBox5.Text);

            StringBuilder sb = new StringBuilder();
            stud.getdata(stud.name, stud.roll_no, stud.marks);
            sb.Append("Student Name : " + stud.name+ " \n");
            sb.Append("Student Roll No. : " + stud.roll_no + "\n");
            sb.Append("Total Marks : " + stud.total + "\n");
            sb.Append("Average : " + stud.avg + "\n");

            label4.Text = sb.ToString();

        }

    }
}
