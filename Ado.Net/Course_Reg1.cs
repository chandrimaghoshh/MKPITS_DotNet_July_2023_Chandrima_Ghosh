using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration
{
    public partial class Form1 : Form
    {
        string strcon = "server=chester\\SQLEXPRESS; integrated security=true;database=Course_Regis";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
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
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getState()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
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
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public void getCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
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
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public enum category { Student, IT_Professional }
        public enum gender { Male, Female, Others }
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.", "Invalid Date Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                saveCourseReg(cat, gen);
            }
        }
        public void saveCourseReg(category c, gender g)
        {
            try
            {
                string str = "insert into TableCourseRegDetail values(@categoryid,@fullname,@genderid)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@categoryid", Convert.ToInt32(c));
                cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                cmd.Parameters.AddWithValue("@genderid", Convert.ToInt32(g));
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved");
                con.Close();
                insertRegAddress();
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void insertRegAddress()
        {
            try
            {
                con.Open();
                string str = "select max(CourseRegId) from TableCourseRegDetail";
                SqlCommand cmd1 = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(cmd1.ExecuteScalar());
                string s2 = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
                SqlCommand cmd2 = new SqlCommand(s2, con);
                cmd2.Parameters.AddWithValue("@CourseRegID", mcid);
                cmd2.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                cmd2.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                cmd2.Parameters.AddWithValue("@CityID", comboBox3.SelectedValue);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Stored TableRegAddress");
                con.Close();
                insertFeeDetail();

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void insertFeeDetail()
        {
                con.Open();
                string str = "select max(CourseRegId) from TableCourseRegDetail";
                SqlCommand cmd11 = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

                string s2 = "insert into TableFeeDetail values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
                SqlCommand cmd1 = new SqlCommand(s2, con);
                cmd1.Parameters.AddWithValue("@CourseRegID",mcid);
                cmd1.Parameters.AddWithValue("@TotalAmount",textBox2.Text);
                cmd1.Parameters.AddWithValue("@MinPer",fp);
                cmd1.Parameters.AddWithValue("@PaidAmount",textBox3.Text);
                cmd1.Parameters.AddWithValue("@BalAmount",textBox4.Text);
                cmd1.Parameters.AddWithValue("@PaidDate",dateTimePicker1.Value);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stored TableFeeDetail");
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }
        float fp = 0;
        float bamt = 0;
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
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                     bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "IT_Professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                   bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            getNation();
            getState();
            getCity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
