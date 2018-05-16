using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class Khach          //Đối tượng class biểu diễn cho thực thể Khách
    {
        private string makhach;       //Mã khách
        private string hoten;         //Họ và tên khách
        private int namsinh;          //Năm sinh
        private int gioitinh;        //Giới tính
        private string cmnd;          //Số CMND của khách
        private string quequan;       //Quê quán
        private string sdt;           //Số điện thoại của khách


        public Khach(string makhach, string hoten, int namsinh, int gioitinh, string cmnd, string quequan, string sdt)
        {
            this.makhach = makhach;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.quequan = quequan;
            this.sdt = sdt;
        }

        public Khach(DataRow row)
        {
            this.makhach = row["makhach"].ToString();
            this.hoten = row["hoten"].ToString();
            this.namsinh = int.Parse(row["namsinh"].ToString());
            this.gioitinh = bool.Parse(row["gioitinh"].ToString()) ? 1:0;  
            this.cmnd = row["cmnd"].ToString();
            this.quequan = row["quequan"].ToString();
            this.sdt = row["sdt"].ToString(); ;
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
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public int Namsinh
        {
            get
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
            }
        }
        public int Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
            }
        }
        public string Cmnd
        {
            get
            {
                return cmnd;
            }
            set
            {
                cmnd = value;
            }
        }
        public string Quequan
        {
            get
            {
                return quequan;
            }
            set
            {
                quequan = value;
            }
        }
        public string Sdt
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
    }
}
