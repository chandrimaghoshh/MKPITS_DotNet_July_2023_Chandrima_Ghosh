using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseOpeartors1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(textBox1.Text);

            int num1 = Convert.ToInt32(textBox2.Text);
            int num2 = Convert.ToInt32(textBox3.Text);
            int ans;

            if (choice == 1)

                label1.Text = "";
            

            else if (choice == 2)
                label2.Text = "Addition ";
                ans = num1 + num2;


        }
    }
}
