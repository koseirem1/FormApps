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
    public partial class ThirdFunctionality : Form
    {
        public ThirdFunctionality()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            try
            {
                sayi = int.Parse(txtSayi.Text);
                if (sayi > 0 && sayi <= 15)
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        for (int a = 1; a <= sayi; a++)
                        {
                            int z = i * a;
                            label1.Text += string.Format("{0,-10}", z);

                        }
                                label1.Text += string.Format("\r\n");
                    }
                       

                }

                
                else
                {
                    MessageBox.Show("Lütfen 1 ile 15 arası bir sayı giriniz.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", ex.Message);
            }
       
         
        }

     
    }
}
