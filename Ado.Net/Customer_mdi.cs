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

namespace MdiForm_UserDetails
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        //insert
        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string str = "insert into customer values(@id,@name,@mobile,@address,@email)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records Inserted successfully");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string str = "update customer set Name=@name,Mobile_No=@mobile,Address=@address,Email=@email where Id=@id";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox4.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string str = "delete from customer where Id=@id or Name=@name";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //search
        private void button4_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string str = ("select * from customer where Id=@id");
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Name"].ToString();
                    textBox3.Text = dr["Mobile_No"].ToString();
                    richTextBox1.Text = dr["Address"].ToString();
                    textBox4.Text = dr["Email"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
