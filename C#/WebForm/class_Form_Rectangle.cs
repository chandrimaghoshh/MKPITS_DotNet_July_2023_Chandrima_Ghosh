using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Form_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            area a = new area();

            a.length=Convert.ToInt32(textBox1.Text);
            a.breadth=Convert.ToInt32(textBox2.Text);

            a.rec = a.length * a.breadth;

            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Rectangle = " + a.rec);

            label3.Text = sb.ToString();    

        }
    }
}
