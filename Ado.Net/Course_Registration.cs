using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=chester\\SQLEXPRESS; integrated security=true;database=Course_Regis";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            getNation();
            getState();
            getCity();
            if (radioButton1.Checked)
            {
                textBox2.Text = "1000";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }
        public void getNation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNation", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationId";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getState()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableState where NationId=@nationid", con);
                da.SelectCommand.Parameters.AddWithValue("@nationid", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "TableState");
                comboBox2.DataSource = ds.Tables["TableState"];
                comboBox2.DisplayMember = "StateName";
                comboBox2.ValueMember = "StateId";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getCity()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableCity where StateId=@stateid", con);
                da.SelectCommand.Parameters.AddWithValue("@stateid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "TableCity");
                comboBox3.DataSource = ds.Tables["TableCity"];
                comboBox3.DisplayMember = "CityName";
                comboBox3.ValueMember = "CityId";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        enum category { Student, IT_Professional }
        enum gender { Male, Female, Others }
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Full name can't be blank");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cat = category.Student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.IT_Professional;
                }
                MessageBox.Show("Category : " + cat);
                //for gender
                if (radioButton3.Checked)
                {
                    gen = gender.Male;
                }
                else if (radioButton4.Checked)
                {
                    gen = gender.Female;
                }
                else if (radioButton5.Checked)
                {
                    gen = gender.Others;
                }
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.IT_Professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
        public void calculatefees()
        {
            if (cat.ToString() == "Student")
            {
                textBox2.Text = "1000";

                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "it_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
        }
    }
}
