using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApps
{
    public partial class SecondFunctionality : Form
    {
        public SecondFunctionality()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            for( int i = 1; i <= 200; i++)
            {

                if (i % 15 == 0 && i > 100)
                {
                    richTextBox1.Text += "zagzig";
                    richTextBox1.Text += " ";
                }
                else if (i % 15 == 0)
                {
                    richTextBox1.Text += "zigzag";
                    richTextBox1.Text += " ";

                } else if (i % 3 == 0)
                {
                    richTextBox1.Text += "zig";
                    richTextBox1.Text += " ";

                } else if(i % 5 == 0)
                {
                    richTextBox1.Text += "zag";
                    richTextBox1.Text += " ";
                }
                else
                {
                    richTextBox1.Text += i.ToString();
                    richTextBox1.Text += " ";

                }


            }
        }
    }
}
