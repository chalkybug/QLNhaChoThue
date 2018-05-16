using MainProgram.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram.Forms
{
    public partial class Login : Form
    {
        public static bool isSuccess = false;

        //Để test phần login
      
        public Login()
        {
            InitializeComponent();
        }

        public void KiemtraLogin()
        {
            if (AccountLogin.Instance.Login(txtUsername.Text,txtPassword.Text))
            {
                isSuccess = true;
                this.Close();
            }
            else
            {
                isSuccess = false;
                lblErrLogin.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KiemtraLogin();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && e.Modifiers == Keys.None)
            {
                KiemtraLogin();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
            {
                KiemtraLogin();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
