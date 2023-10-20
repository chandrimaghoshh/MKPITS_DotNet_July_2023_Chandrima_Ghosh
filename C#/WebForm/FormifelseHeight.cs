using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseHeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cm = Convert.ToInt32(textBox1.Text);

            if (cm < 135)
                label2.Text = "Height is Dwarf";
            else if (cm >= 145 && cm < 155)
                label2.Text = "Height is Average";
            else if (cm >= 160 && cm < 175)
                label2.Text = "Height is Tall";
            else
                label2.Text = "Height is Abnormal";
        }
    }
}
