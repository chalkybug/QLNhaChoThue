using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainProgram.Forms;
using MainProgram.UCs;
using MainProgram.DAO;
using System.Globalization;
using System.Data.SqlClient;

namespace MainProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucStart uc = new ucStart();

            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.ShowDialog();

            if (Login.isSuccess)
            {
                ucAdmin ucadmin1 = new ucAdmin();
                ucadmin1.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(ucadmin1);

                tsbLogin.Text = "Admin";
                tsbLogin.Image = MainProgram.Properties.Resources.icons8_manager_32;
                tsbLogin.Enabled = false;
            }
        }
    }
}
