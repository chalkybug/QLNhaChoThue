using MainProgram.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class DKyPhongDAO
    {
        private DKyPhongDAO() { }
        private static DKyPhongDAO instance;
        public static DKyPhongDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new DKyPhongDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }


        public List<DKyPhong> GetListRoom()
        {
            List<DKyPhong> listRoom = new List<DKyPhong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DangKyPhong");
            foreach (DataRow item in data.Rows)
            {
                DKyPhong dkphong = new DKyPhong(item);
                listRoom.Add(dkphong);
            }

            return listRoom;
        }

        public void AddDangKyPhong(int mahdp, string makhach,string maphong, int songuoi, string ngaythue, string ngaytra , int datcoc , string htthanhtoan)
        {
            string query = "EXEC dbo.SelectRoomForCustomer @mahp , @makhach , @maphong , @songuoi , @ngaythue , @ngaytra ,  @datcoc ,  @htthanhtoan ";
            
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdp, makhach, maphong, songuoi, ngaythue, ngaytra, datcoc, htthanhtoan });

        }

        public void UpdateDangKyPhong(int mahdp, string makhach, string maphong, int songuoi, string ngaythue, string ngaytra, int datcoc, string htthanhtoan)
        {
            string query = "EXEC dbo.UpdateDangKyKhach @mahp , @makhach , @maphong , @songuoi , @ngaythue , @ngaytra ,  @datcoc ,  @htthanhtoan ";
           
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdp, makhach, maphong, songuoi, ngaythue, ngaytra, datcoc, htthanhtoan });

        }
        public void DeleteDangKyPhong(int mahdp)
        {
            string query = "EXEC dbo.deleteDangKyPhong @mahdp ";
           
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdp });

        }

        public List<DKyPhong> Search(string str)
        {

            List<DKyPhong> listRoom = new List<DKyPhong>();
            DataTable data = DataProvider.Instance.ExecuteQuery($"EXEC TimKiemdkp N'{str}'");
            foreach (DataRow item in data.Rows)
            {
                DKyPhong dkphong = new DKyPhong(item);
                listRoom.Add(dkphong);
            }

            return listRoom;
           
        }

    }
}
