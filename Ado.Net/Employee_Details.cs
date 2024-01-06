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

namespace Employee_Details
{
    public partial class Form1 : Form
    {
        public string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
        public Form1()
        {
            InitializeComponent();
        }
        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string g = null;
            if(radioButton1.Checked)
            {
                g = "Male";
            }
            if(radioButton2.Checked)
            {
                g = "Female";
            }
            
            try
            {
                con.Open();
                string str = "insert into employees values(@id,@name,@address,@gender,@city)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@gender", g);
                cmd.Parameters.AddWithValue("@city", comboBox1.GetItemText(comboBox1.SelectedItem));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }

            try
            {
                con.Open();
                string str = "update employees set Name=@name,Address=@address,Gender=@gender,City=@city where Id=@id";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@gender", g);
                cmd.Parameters.AddWithValue("@city", comboBox1.GetItemText(comboBox1.SelectedItem));
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }

            try
            {
                con.Open();
                string str = "delete from employees where Id=@id or Name=@name";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //Search
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "select * from employees where Id=@id";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            SqlDataReader dr;
            int flag = 0;
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                flag = 1;
                textBox1.Text = dr["Id"].ToString();
            }
            dr.Close();
            con.Close();
            if(flag==0)
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}
