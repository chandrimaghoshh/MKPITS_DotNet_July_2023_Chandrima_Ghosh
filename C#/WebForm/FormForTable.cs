using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForTable
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
            int num = Convert.ToInt32(textBox1.Text);
            int res = 0;
            int cnt;

            for(cnt = 1; cnt <= 10; cnt++)
            {
                res = num * cnt;
                sb.Append(num + "*" + cnt + "=" + res + "\n");
            }
            label2.Text =sb.ToString();
        }
    }
}
