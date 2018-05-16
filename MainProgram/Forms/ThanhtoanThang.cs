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
    public partial class ThanhtoanThang : Form
    {
        List<DKyPhong> list = DKyPhongDAO.Instance.GetListRoom();
        public ThanhtoanThang()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {

            foreach (var item in list)
            {
                comboBox1.Items.Add(item.Maphong);
            }
            cmbThangtt.Items.Add("1 tháng");
            cmbThangtt.Items.Add("3 tháng");
            cmbThangtt.Items.Add("6 tháng");
            cmbThangtt.Items.Add("12 tháng");
            cmbThangtt.Items.Add("24 tháng");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timePayment = dateTimePicker1.Value.ToShortDateString();
            string maphong = comboBox1.SelectedItem.ToString();
            float giaphong = float.Parse(txtGiaphong.Text);

            DateTime timefrom = dateTimePicker2.Value;
            DateTime timeto = dateTimePicker2.Value;
            string month = cmbThangtt.SelectedItem.ToString();
            if (month == "1 tháng")
            {
                timeto = timeto.AddMonths(1);
            }
            else if (month == "3 tháng")
            {
                timeto = timeto.AddMonths(3);
            }
            else if (month == "6 tháng")
            {
                timeto = timeto.AddMonths(6);
            }
            else if (month == "12 tháng")
            {
                timeto = timeto.AddYears(1);
            }
            else if (month == "24 tháng")
            {
                timeto = timeto.AddYears(2);
            }

            BillDAO.Instance.Add(timePayment, timefrom.ToShortDateString(), timeto.ToShortDateString(), giaphong, txtMakhach.Text, maphong);
            PhongDAO.Instance.UpdateBill(maphong);

            DKyPhong dkphong = DKyPhongDAO.Instance.Search(maphong).Where(x => x.Maphong == maphong).FirstOrDefault();
            DKyPhongDAO.Instance.DeleteDangKyPhong(int.Parse(dkphong.Mahdp));
            MessageBox.Show("Thanh toán phòng thành công");

        }

        private void ThanhtoanThang_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maphong = comboBox1.SelectedItem.ToString();
            foreach (var dkphong in list)
            {
                if (dkphong.Maphong == maphong)
                {
                    txtMakhach.Text = dkphong.Makhach;

                    foreach (var phong in PhongDAO.Instance.GetListRoom())
                    {
                        if (dkphong.Maphong == phong.Maphong)
                        {
                            txtGiaphong.Text = phong.Gia.ToString();
                        }

                    }
                    foreach (var khach in KhachDAO.Instance.GetListCustomer())
                    {
                        if (dkphong.Makhach == khach.Makhach)
                        {
                            txtTenkhach.Text = khach.Hoten;
                        }
                    }
                }
            }

        }
    }
}
