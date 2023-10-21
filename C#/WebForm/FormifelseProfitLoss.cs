using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseProfitLoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total_amt = 0;
            int sp = Convert.ToInt32(textBox1.Text);
            int cp = Convert.ToInt32(textBox2.Text);

            if (sp > cp)
            {
                 total_amt = sp - cp;
                label3.Text = "you get profit of : "+total_amt;
            }
            else if (cp > sp)
            {
                 total_amt = cp - sp;
                label3.Text = "you get loss of : "+total_amt;
            }
            else
            {
                label3.Text = "you get no profit no loss";
                
            }
          
          
        }
    }
}
