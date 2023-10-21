using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseDayNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayno = Convert.ToInt32(textBox1.Text);

            if (dayno == 1)
                label2.Text = "Monday";

            else if (dayno == 2)
                label2.Text = "Tuesday";

            else if (dayno == 3)
                label2.Text = "Wednesday";

            else if (dayno == 4)
                label2.Text = "Thursday";

            else if (dayno == 5)
                label2.Text = "Friday";

            else if (dayno == 6)
                label2.Text = "Saturday";

            else if (dayno == 7)
                label2.Text = "Sunday";

            else
                label2.Text = "Invalid dayno";

            
        }
    }
}
