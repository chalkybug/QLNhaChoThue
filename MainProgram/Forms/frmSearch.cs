using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainProgram.DAO;

namespace MainProgram.Forms
{
    public partial class frmSearch : Form
    {
        private int tabIndex;
        private DataTable dtb;
        public DataTable Dtb
        {
            get
            {
                return dtb;
            }
        }
        private void setDtb(DataTable d1)
        {
            dtb = d1;
        }
        public frmSearch()
        {
            InitializeComponent();
            loadCombobox();
        }

        private void loadCombobox()
        {
            comboBox1.Items.Add("Khách");
            comboBox1.Items.Add("Phòng");
            comboBox1.Items.Add("Đăng ký phòng");
            comboBox1.Items.Add("Bill");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (comboBox1.SelectedIndex == 0)
            {
                dt = KhachDAO.Instance.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dt = PhongDAO.Instance.Search(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = DKyPhongDAO.Instance.Search(txtSearch.Text);
            }
            else if (comboBox1.SelectedIndex == 3)
            {

            }
            dataGridView1.DataSource = dt;
            // search();
        }

        private void search()
        {
            if (tabIndex == 0)
            {
                DataTable dt = KhachDAO.Instance.Search((string)comboBox1.SelectedItem);
                dataGridView1.DataSource = dt;
            }
            else if (tabIndex == 1)
            {
                // PhongDAO.Instance.Search((string)comboBox1.SelectedItem));
            }
            else if (tabIndex == 2)
            {
                // setDtb(DKyPhongDAO.Instance.Search((string)comboBox1.SelectedItem, textBox1.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
