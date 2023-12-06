using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ques
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            if(radioButton2.Checked)
            {
                count++;
            }
            else { }

            if(radioButton4.Checked)
            {
                count++;
            }
            else { }

            if(radioButton8.Checked)
            {
                count++;
            }
            else { }
            sb.Append("Total Score : " + count);
            label2.Text = sb.ToString();
            
        }
    }
}
