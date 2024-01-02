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

namespace User_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class DatabaseConnection
        {
            private static string connectionString = "your_connection_string";

            public static SqlConnection GetConnection()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    return connection;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                    return null;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    
    }
}

