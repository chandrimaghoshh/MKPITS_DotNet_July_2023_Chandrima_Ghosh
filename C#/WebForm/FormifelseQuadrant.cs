using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseQuadrant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            if (x > 0 && y > 0)
                label3.Text = "Lies on First quadrant";
            else if (x < 0 && y > 0)
                label3.Text = "Lies on Second quadrant";
            else if (x < 0 && y < 0)
                label3.Text = "Lies on Third quadrant";
            else if (x > 0 && y < 0)
                label3.Text = "Lies on Fourth quadrant";
        }
    }
}
