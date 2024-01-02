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
            string cons = "server=chester\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(cons);
            try
            {
                con.Open();
                string cons = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";

                SqlCommand command = new SqlCommand(cons, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }

        private void button5_Click(object sender, EventArgs e)
        {
            string cons = "server = chester\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(cons);
            try
            {
                con.Open();
                MessageBox.Show("Connection Successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.getConnection();
            if (con != null)
            {
                MessageBox.Show("successfully connected");
                con.Close();
            }
            else
            {
                MessageBox.Show("could not connect to sqlserver");
            }

        }
    }
}
