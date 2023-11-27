using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dictionary_Key_Values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> dic = new Dictionary<int, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            dic.Add(Convert.ToInt32(textBox1.Text),textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            MessageBox.Show("Added in dictionary");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            List<int> Keys = new List<int>(dic.Keys);
            foreach(int keys in Keys)
            {
                sb.Append("Keys in dictionary : " + keys + "\n");
            }
            label3.Text= sb.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            List<string> Values = new List<string>(dic.Values);
            foreach (string values in Values)
            {
                sb.Append("Keys in dictionary : " + values + "\n");
            }
            label4.Text = sb.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int,string> kvp in dic)
            {
                sb.Append("Keys : " + kvp.Key + "Value : " + kvp.Value + "\n");
            }
            label4.Text=sb.ToString();
        }
    }
}
