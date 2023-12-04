using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Calculator_MoreThan_OneDigit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op = null;
        int pn = 0;
        int res = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Number 1
            if(textBox1.Text==" ")
            {
                textBox1.Text = "1";
            }
            else
            {
                if(op != "null")
                {
                    if(textBox1.Text=="+" ||  textBox1.Text=="-" || textBox1.Text=="*" || textBox1.Text=="/")
                    {
                        textBox1.Clear();
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "1";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Number 2
            if(textBox1.Text== " ")
            {
                textBox1.Text = "2";
            }
            else
            {
                if (op != "null")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Addition
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "+";
            op = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Equal To
            switch(op)
            {
                case "+":
                    res = pn + Convert.ToInt32(textBox1.Text);
                    break;
                case "-":
                    res = pn - Convert.ToInt32(textBox1.Text);
                    break;
                case "*":
                    res = pn * Convert.ToInt32(textBox1.Text);
                    break;
                case "/":
                    res = pn / Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Number 3
            if(textBox1.Text==" ")
            {
                textBox1.Text = "3";
            }
            else
            {
                if (op != "null")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Number 4
            if (textBox1.Text == " ")
            {
                textBox1.Text = "4";
            }
            else
            {
                if (op != "4")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Number 5
            if (textBox1.Text == " ")
            {
                textBox1.Text = "5";
            }
            else
            {
                if (op != "5")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Number 6
            if (textBox1.Text == " ")
            {
                textBox1.Text = "6";
            }
            else
            {
                if (op != "6")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Number 7
            if (textBox1.Text == " ")
            {
                textBox1.Text = "7";
            }
            else
            {
                if (op != "7")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Number 8
            if (textBox1.Text == " ")
            {
                textBox1.Text = "8";
            }
            else
            {
                if (op != "8")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Number 9
            if (textBox1.Text == " ")
            {
                textBox1.Text = "9";
            }
            else
            {
                if (op != "9")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Number 0
            if (textBox1.Text == " ")
            {
                textBox1.Text = "0";
            }
            else
            {
                if (op != "0")
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "0";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Clear method
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Substraction
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "-";
            op = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Multiplication
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "*";
            op = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Division
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "/";
            op = "/";
        }
    }
}
