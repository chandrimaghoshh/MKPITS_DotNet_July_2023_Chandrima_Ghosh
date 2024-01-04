using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForm_UserDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
        string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=Userinfo;";
        SqlConnection con = null;
        SqlCommand command = null;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                string str = "select count(*) from userdetails where Username=@username and Password=@password";
                command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@username", gunaTextBox1.Text);
                command.Parameters.AddWithValue("@password", gunaTextBox2.Text);

                con.Open();
                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if (cnt > 0)
                {
                    gunaLabel3.Text = "login successfull";
                    menuStrip1.Visible = true;
                    panel1.Visible = false;
                    
                }
                else
                {
                    gunaLabel3.Text = "invalid credentail , try again";
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
            menuStrip1.Visible = true;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaTextBox1.Clear();
            gunaTextBox2.Clear();
            gunaTextBox1.Focus();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Hide();
        }
    }
}
