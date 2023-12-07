using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_menustrip_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn=openFileDialog1.FileName;
                MessageBox.Show(fn);
                if(fn.EndsWith("rtf"))
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Cannot open this file");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                MessageBox.Show(fn);
                if (fn.EndsWith("rtf"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("This file cannot be save");
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont=fontDialog1.Font;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor=colorDialog1.Color;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Width = hScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Height = vScrollBar1.Value;
        }
    }
}
