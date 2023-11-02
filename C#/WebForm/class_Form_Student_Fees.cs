using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Student_Fees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stud = new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                stud[cnt].roll_no = Convert.ToInt32(textBox1.Text);
                stud[cnt].name = textBox2.Text;
                stud[cnt].fees = Convert.ToInt32(textBox3.Text);
                stud[cnt].date = textBox4.Text;
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if (cnt == 10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("details of 3 students accepted");
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Students Details : " + "\n");
            for (int i = 0; i < 10; i++)
            {
                sb.Append("---------------------------------------\n");
                sb.Append("Student Roll No. : " + stud[i].roll_no + "\n");
                sb.Append("Student Name : " + stud[i].name + "\n");
                sb.Append("Student Fees : " + stud[i].fees + "\n");
                sb.Append("Date of Addmission : " + stud[i].date + "\n");
                sb.Append("---------------------------------------------");
            }
            richTextBox1.Text = sb.ToString();

            double high = stud[0].fees;
            int foundat = 0;

            for(int i=0; i<10; i++)
            {
                if(high < stud[i].fees)
                {
                    high = stud[i].fees;
                    foundat = i;
                }
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Highest Fees Student : "+ "\n");

            sb1.Append("Student Roll No. : " + stud[foundat].roll_no + "\n");
            sb1.Append("Student Name : " + stud[foundat].name + "\n");
            sb1.Append("Student Fees : " + stud[foundat].fees + "\n");
            sb1.Append("Date of Addmission : " + stud[foundat].date + "\n");

            label6.Text = sb1.ToString();
        }
    }
}


