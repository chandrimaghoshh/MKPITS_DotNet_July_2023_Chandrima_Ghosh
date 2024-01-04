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

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=Userinfo";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                string qr = "select count(*) from userdetails where Username=@username and Password=@password ";
                command = new SqlCommand(qr, con);
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);

                con.Open();
                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if (cnt > 0)
                    MessageBox.Show("login successfull");
                else
                    MessageBox.Show("invalid credentail , try again");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}

