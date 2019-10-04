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
    public partial class FirstFunctionality : Form
    {
        public FirstFunctionality()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            double N1 = double.Parse(txtNumber1.Text);
            double N2 = double.Parse(txtNumber2.Text);
            double N3 = double.Parse(txtNumber3.Text);
            double result = (N1 + N2) * N3;
            txtResult.Text = result.ToString();
          
        }

      
    }
}
