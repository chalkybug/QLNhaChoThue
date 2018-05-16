using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class Phong            //Đối tượng class biểu diễn cho thực thể Phòng
    {
        private string maphong;       //Mã phòng
        private int dientich;         //Diện tích phòng
        private string loai;          //Loại phòng
        private string tinhtrang;     //Tình trạng
        private int gia;              //Giá phòng
        private string dodac;         //Đồ đạc có sẵn


        public Phong(string maphong, int dientich, string loai, string tinhtrang, int gia, string dodac)
        {
            this.maphong = maphong;
            this.dientich = dientich;
            this.loai = loai;
            this.tinhtrang = tinhtrang;
            this.gia = gia;
            this.dodac = dodac;
        }

        public Phong(DataRow row)
        {
            this.maphong = row["MaPhong"].ToString();
            this.dientich = (int)row["DienTich"];
            this.loai = row["loaiphong"].ToString();
            this.tinhtrang = row["TinhTrang"].ToString();
            this.gia = (int)row["GiaPhong"];
            this.dodac = row["DoDac"].ToString();


        }
        public Phong()
        {
            maphong = "";
            dientich = 0;
            loai = "";
            tinhtrang = "";
            gia = 0;
            dodac = "";
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
        public int Dientich
        {
            get
            {
                return dientich;
            }
            set
            {
                dientich = value;
            }
        }
        public string Loai
        {
            get
            {
                return loai;
            }
            set
            {
                loai = value;
            }
        }
        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }
            set
            {
                tinhtrang = value;
            }
        }
        public int Gia
        {
            get
            {
                return gia;
            }
            set
            {
                gia = value;
            }
        }
        public string Dodac
        {
            get
            {
                return dodac;
            }
            set
            {
                dodac = value;
            }
        }
    }
}
