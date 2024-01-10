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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud_Opt_Disconnected_Emp
{

    public partial class Form1 : Form
    {
        public string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=Mkpsample";
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from employee",strcon);
            cb=new SqlCommandBuilder(sqlda);
            ds=new DataSet();
            sqlda.Fill(ds, "Emp");
            
        }
        //Select
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Emp"];
        }
        //Create
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Emp"].NewRow();
            dr[0] = gunaTextBox1.Text;
            dr[1] = gunaTextBox2.Text;
            dr[2] = gunaTextBox3.Text;
            dr[3] = Convert.ToInt32(gunaTextBox4.Text);
            dr[4] = gunaTextBox5.Text;
            dr[5] = gunaTextBox6.Text;
            dr[6] = Convert.ToInt32(gunaTextBox7.Text);

            ds.Tables["Emp"].Rows.Add(dr);
            sqlda.Update(ds.Tables["Emp"]);
            MessageBox.Show("Record inserted successfully");
        }
        //Update
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == gunaTextBox1.Text)
                {
                    try
                    {
                        dr[0] = gunaTextBox1.Text;
                        dr[1] = gunaTextBox2.Text;
                        dr[2] = gunaTextBox3.Text;
                        dr[3] = Convert.ToInt32(gunaTextBox4.Text);
                        dr[4] = gunaTextBox5.Text;
                        dr[5] = gunaTextBox6.Text;
                        dr[6] = Convert.ToInt32(gunaTextBox7.Text);
                        sqlda.Update(ds.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                }
            }
        }
        //Delete
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == gunaTextBox1.Text)
                {
                    try
                    {
                        ds.Tables["Emp"].Rows.Remove(dr);
                        sqlda.Update(ds.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gunaTextBox1.Text= dataGridView1[0,e.RowIndex].Value.ToString();
            gunaTextBox2.Text = dataGridView1[1,e.RowIndex].Value.ToString();
            gunaTextBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            gunaTextBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            gunaTextBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            gunaTextBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            gunaTextBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gunaTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            gunaTextBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            gunaTextBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            gunaTextBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            gunaTextBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            gunaTextBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            gunaTextBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gunaTextBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            gunaTextBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            gunaTextBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            gunaTextBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            gunaTextBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            gunaTextBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            gunaTextBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }
    }
}
