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
    public partial class FifthFunctionality : Form
    {
        public FifthFunctionality()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = int.Parse(textBox1.Text);
                int a = 0, b = 1, c = 0;
                for (int i = 2; i < sayi; i++)
                {
                    c = a + b;
                    label1.Text = string.Format("{0}", c);
                    a = b;
                    b = c;
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Lütfen bir sayı giriniz.", ex.Message);
            }
           
        }
    }
}
