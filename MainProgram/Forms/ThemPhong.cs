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
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string maphong = txtMaphong.Text;
            int dientich = int.Parse(txtDienTich.Text);
            string loaiPhong = txtLoaiPhong.Text;
            string tinhtrang = txtTinhTrang.Text;
            int gia = int.Parse(txtGia.Text);
            string dodac = txtDodac.Text;
            try
            {
                PhongDAO.Instance.AddRoom(maphong, dientich, loaiPhong, tinhtrang, gia, dodac);

                MessageBox.Show("Thêm phòng thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm phòng thất bại!");
            }
        }
    }
}
