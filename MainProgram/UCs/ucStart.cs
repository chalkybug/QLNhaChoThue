using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainProgram.Forms;

namespace MainProgram.UCs
{
    public partial class ucStart : UserControl
    {
        public ucStart()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            DangKyKhach frmSignup = new DangKyKhach();
            frmSignup.ShowDialog();
        }
    }
}
