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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        //Insert
        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            try
            {
               
                string str = "insert into products values(@id,@name,@price,@quantity)";
                SqlCommand cmd = new SqlCommand(str,con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@price", textBox3.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records inserted succesfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            string str = "update products set Name=@name,Price=@price,Quantity=@quantity where Id=@id";
            try
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@price", textBox3.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records updated successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection( strcon);
            try
            {
                con.Open();
                string str = "delete from products where Id=@id or Name=@name";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        //Search
        private void button4_Click(object sender, EventArgs e)
        {
            string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(strcon);
            try
            {
                con.Open();
                string str = ("select * from products where Id=@id");
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Name"].ToString();
                    textBox3.Text = dr["Price"].ToString();
                    textBox4.Text = dr["Quantity"].ToString();
                }
                dr.Close();
                con.Close();
                if(flag==0)
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
