using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Form r=new Register_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_form a = new Account_form();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Register_Form r = new Register_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void accountForrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_form a = new Account_form();
            a.MdiParent = this;
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register_Form r = new Register_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Account_form a = new Account_form();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
            registerFormToolStripMenuItem.Enabled = true;
            accountFormToolStripMenuItem.Enabled = true;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = true;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
