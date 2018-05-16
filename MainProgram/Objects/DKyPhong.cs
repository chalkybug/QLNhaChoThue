using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class DKyPhong           //Đối tượng class biểu diễn cho bảng quan hệ Đăng ký phòng
    {
        private string mahdp;           //Mã hợp đồng thuê phòng
        private string makhach;         //Mã khách đăng ký
        private string maphong;         //Mã phòng
        private int songuoi;            //Số người ở
        private string ngaythue;        //Ngày thuê phòng
        private string ngaytra;         //Ngày trả phòng
        private int datcoc;             //Tiền đặt cọc
        private string htthanhtoan;     //Hình thức thanh toán

        public DKyPhong(string mahdp, string makhach, string maphong, int songuoi,string  ngaythue, string ngaytra,int datcoc,string htthanhtoan)
        {
            this.mahdp = mahdp;
            this.makhach = makhach;
            this.maphong = maphong;
            this.songuoi = songuoi;
            this.ngaythue = ngaythue;
            this.ngaytra = ngaytra;
            this.datcoc = datcoc;
            this.htthanhtoan = htthanhtoan;
        }

        public DKyPhong(DataRow row)
        {

            this.mahdp = row["mahdp"].ToString();
            this.makhach = row["makhach"].ToString();
            this.maphong = row["maphong"].ToString();
            this.songuoi = (int)row["songuoi"];
            this.ngaythue = row["ngaythue"].ToString();
            this.ngaytra = row["ngaytra"].ToString();
            this.datcoc = (int)row["datcoc"];
            this.htthanhtoan = row["htthanhtoan"].ToString();
        }

        public string Mahdp
        {
            get
            {
                return mahdp;
            }
            set
            {
                mahdp = value;
            }
        }
        public string Makhach
        {
            get
            {
                return makhach;
            }
            set
            {
                makhach = value;
            }
        }
        public string Maphong
        {
            get
            {
                return maphong;
            }
            set
            {
                maphong = value;
            }
        }
        public int Songuoi
        {
            get
            {
                return songuoi;
            }
            set
            {
                songuoi = value;
            }
        }
        public string Ngaythue
        {
            get
            {
                return ngaythue;
            }
            set
            {
                ngaythue = value;
            }
        }
        public string Ngaytra
        {
            get
            {
                return ngaytra;
            }
            set
            {
                ngaytra = value;
            }
        }
        public int Datcoc
        {
            get
            {
                return datcoc;
            }
            set
            {
                datcoc = value;
            }
        }
        public string Htthanhtoan
        {
            get
            {
                return htthanhtoan;
            }
            set
            {
                htthanhtoan = value;
            }
        }
    }
}
