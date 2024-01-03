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

namespace User_Details1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strs = "server=chester\\SQLEXPRESS;integrated security=true;database=Userinfo";
            SqlConnection con = new SqlConnection(strs);
            try
            {
                con.Open();
                string str = "insert into userdetails values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(str, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record inserted Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            string strs = "server = chester\\SQLEXPRESS;integrated security=true;database=Userinfo;";
            SqlConnection con = new SqlConnection(strs);
            try
            {
                con.Open();
                string str = "update userdetails set password=' " + textBox2.Text + "'where username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(str, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record Updated Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            string strs = "server=chester\\SQLEXPRESS;integrated security=true;database=Userinfo;";
            SqlConnection con = new SqlConnection(strs);
            try
            {
                con.Open();
                string str = "delete from userdetails where username = '" + textBox1.Text + "' or password='" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(str, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record inserted Successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        //Search
        private void button4_Click(object sender, EventArgs e)
        {
            string strs = "server=chester\\SQLEXPRESS;integrated security=true;database=Userinfo";
            SqlConnection con = new SqlConnection(strs);
            try
            {
                con.Open();
                string str = "select * from userdetails where username = '" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(str, con);
                SqlDataReader dr;
                int flag = 0;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label3.Text = "Record not found";
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
