using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phy = Convert.ToInt32(textBox1.Text);
            int chem = Convert.ToInt32(textBox2.Text);
            int bio = Convert.ToInt32(textBox3.Text);
          

            if (phy >= 65)
                label4.Text = "The candidate is eligible for admission";

            else if(chem >= 50)
                label4.Text = "The candidate is eligible for admission";

            else if(bio >= 65)
                label4.Text = "The candidate is eligible for admission";

            else
                label4.Text = "The candidate is  not eligible for admission";

        }
    }
}
