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
using System.Globalization;

namespace MainProgram.Forms
{
    public partial class DangKyKhach : Form
    {
        public DangKyKhach()
        {
            InitializeComponent();
            
        }

        private void ckbAccept_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAccept.Checked == true)
            {
                btnSignup.Enabled = true;
            }
        }

        private void DangKyKhach_Load(object sender, EventArgs e)
        {

            DataTable data = new DataTable();
            List<Phong> listRoom = new List<Phong>();
            listRoom = PhongDAO.Instance.GetListRoomEmpty();
            foreach (var item in listRoom)
            {
                cmbMaphong.Items.Add(item.Maphong);
            }


        }

        private void cmbMaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Phong> listRoom = new List<Phong>();
                listRoom = PhongDAO.Instance.GetListRoomEmpty();
                string maphong = cmbMaphong.SelectedItem.ToString();

                foreach (var item in listRoom)
                {
                    if (item.Maphong.Equals(maphong))
                    {
                        txtDientich.Text = item.Dientich.ToString();
                        txtLoai.Text = item.Loai;
                        txtTinhtrang.Text = item.Tinhtrang;
                        txtGia.Text = item.Gia.ToString();
                        txtDodac.Text = item.Dodac;
                    }
                }
            }
            catch
            {

            }
        }

        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            try
            {
                #region Khach


                string makhach = txtMakhach.Text;
                string hoten = txtHoten.Text;
                int namsinh = int.Parse(txtNamsinh.Text);

                int gioitinh = 0;
                RadioButton rdb = null;
                foreach (RadioButton item in grbGioitinh.Controls)
                {
                    if (item != null)
                    {
                        if (item.Checked)
                        {
                            rdb = item;
                            break;
                        }
                    }
                }
                if (rdb.Text.Equals("Nam"))
                {
                    gioitinh = 1;
                }
                else
                {
                    gioitinh = 0;
                }
                string cmnd = txtCMND.Text;
                string quequan = txtQuequan.Text;
                string sdt = txtSDT.Text;
                #endregion
                
                #region dangkyphong

                string maphong = cmbMaphong.SelectedItem.ToString();
                string dientich = txtDientich.Text;
                string loai = txtLoai.Text;
                string tinhtrang = txtTinhtrang.Text;
                string gia = txtGia.Text;
                string dodac = txtDodac.Text;
                int mahdp = int.Parse(txtMahd.Text);
                int songuoi = int.Parse(txtSonguoi.Text);

             
                string ngaythue = dateTimePicker1.Value.ToShortDateString();

              
                string ngaytra = dateTimePicker2.Value.ToShortDateString();

                int datcoc =int.Parse(txtDatcoc.Text) ;
                string htthanhtoan = cmbHTtt.SelectedItem.ToString();
                #endregion
                // xử lý input truyền vào   
              
                KhachDAO.Instance.AddCustomer(makhach, hoten, namsinh, gioitinh, cmnd, quequan, sdt);
                

                DKyPhongDAO.Instance.AddDangKyPhong(mahdp, makhach, maphong, songuoi, ngaythue, ngaytra, datcoc, htthanhtoan);


                MessageBox.Show("Đăng ký thành công");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đăng ký lỗi! "+ex.Message);
            }
        }
    }
}
