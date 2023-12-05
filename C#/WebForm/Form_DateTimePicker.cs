using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_DateTimePicker
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

            string age = dateTimePicker1.Text;
            sb.Append("Dob = " + age + "\n");

            int year = dateTimePicker1.Value.Year;
            sb.Append("Dob Year = " + year + "\n");

            int cyear = DateTime.Now.Year;
            sb.Append("Current year = " + cyear + "\n");

            int diff = cyear - Convert.ToInt32(year);
            sb.Append("Your Age is = " + diff + "\n");

            label2.Text=sb.ToString();
        }
    }
}
