using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(btn3.Enabled)
            {
                richTextBox1.SaveFile(@"C:TempProba");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Enabled)
            {
                richTextBox1.LoadFile(@"C:TempProba");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(btn2.Enabled)
            {
                richTextBox1.Clear();
            }
        }
    }
}
