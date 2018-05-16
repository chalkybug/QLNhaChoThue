using MainProgram.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class KhachDAO
    {
        private KhachDAO () { }
        private static KhachDAO instance;
        public static KhachDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new KhachDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<Khach> GetListCustomer()
        {
            List<Khach> listCustomer = new List<Khach>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Khach");
            foreach (DataRow item in data.Rows)
            {
                Khach khach = new Khach(item);
                listCustomer.Add(khach);
            }

            return listCustomer;

        }

        public void AddCustomer(string makhach, string hoten, int namsinh, int gioitinh, string cmnd, string quequan, string sdt)
        {
            string query = "EXEC dbo.DangKyKhach @makhach , @hoten , @namsinh ,  @gioitinh ,  @cmnd ,  @quequan , @sdt ";
          
            DataProvider.Instance.ExecuteNonQuery(query, new object [] { makhach,  hoten,  namsinh, gioitinh,  cmnd,  quequan, sdt });

        }

        public void UpdateCustomer(string makhach, string hoten, int namsinh, int gioitinh, string sdt, string quequan, string cmnd)
        {
            string query = "EXECUTE dbo.UpdateCustomer @makhach , @hoten , @namsinh ,  @gioitinh ,  @sdt ,  @quequan ,  @cmnd ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makhach, hoten, namsinh, gioitinh, sdt , quequan, cmnd });
        }

        public void DeleteCutomer(string makhach)
        {
            string query = "EXEC dbo.deleteKhach @makhach ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makhach });

        }
        public DataTable Search(string str)
        {
           
            DataTable data = DataProvider.Instance.ExecuteQuery($"EXEC dbo.TimKiemKhach  @str = N'{str}' ");
          
            return data;

        }


    }
}
