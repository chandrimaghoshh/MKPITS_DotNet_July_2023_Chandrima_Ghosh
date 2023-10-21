using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);

            if (num == 1)
                label2.Text = "January";

            else if (num == 2)
                label2.Text = "February";

            else if (num == 3)
                label2.Text = "March";

            else if (num == 4)
                label2.Text = "April";

            else if (num == 5)
                label2.Text = "May";

            else if (num == 6)
                label2.Text = "June";

            else if (num == 7)
                label2.Text = "July";

            else if (num == 8)
                label2.Text = "August";

            else if (num == 9)
                label2.Text = "September";

            else if (num == 10)
                label2.Text = "October";

            else if (num == 11)
                label2.Text = "November";

            else if (num == 12)
                label2.Text = "Deccember";

            else
                label2.Text = "Invalid month no.";

        }
    }
}
