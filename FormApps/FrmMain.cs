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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FirstFunctionality_Click(object sender, EventArgs e)
        {
            var frm = new FirstFunctionality();
            frm.MdiParent = this;
            frm.Show();
        }

        private void SecondFunctionality_Click(object sender, EventArgs e)
        {
            var frmSecond = new SecondFunctionality();
            frmSecond.MdiParent = this;
            frmSecond.Show();
        }

        private void ThirdFunctionality_Click(object sender, EventArgs e)
        {
            var frmThird = new ThirdFunctionality();
            frmThird.MdiParent = this;
            frmThird.Show();
        }

        private void FourthFunctionality_Click(object sender, EventArgs e)
        {
            var frmFourth = new FourthFunctionality();
            frmFourth.MdiParent = this;
            frmFourth.Show();

        }

        private void FifthFunctionality_Click(object sender, EventArgs e)
        {
            var frmFifth = new FifthFunctionality();
            frmFifth.MdiParent = this;
            frmFifth.Show();

        }
    }
}
