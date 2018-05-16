using MainProgram.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class PhongDAO
    {
        private PhongDAO() { }

        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongDAO();
                }
                return instance;
            }

            private set { instance = value; }
        }

        public List<Phong> GetListRoom()
        {
            List<Phong> listRoom = new List<Phong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Phong");
            foreach (DataRow item in data.Rows)
            {
                Phong food = new Phong(item);
                listRoom.Add(food);
            }

            return listRoom;
        }

        public List<Phong> GetListRoomEmpty()
        {
            List<Phong> listRoom = new List<Phong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong WHERE tinhtrang=N'Trống'");
            foreach (DataRow item in data.Rows)
            {
                Phong food = new Phong(item);
                listRoom.Add(food);
            }

            return listRoom;
        }
        public List<Phong> GetListRoomNoEmpty()
        {
            List<Phong> listRoom = new List<Phong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phong WHERE tinhtrang=N'Có người'");
            foreach (DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                listRoom.Add(p);
            }

            return listRoom;
        }

        public void AddRoom(string maphong, int dientich, string loaiphong, string tinhtrang, int giaphong, string dodac)
        {
            string query = "EXEC dbo.AddRoom @maphong , @dientich , @loaiphong , @tinhtrang , @giaphong , @dodac ";
           
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maphong, dientich, loaiphong, tinhtrang, giaphong, dodac });

        }

        public void UpdateRoom(string maphong, int dientich, string loaiphong, string tinhtrang, int giaphong, string dodac)
        {
            string query = "EXEC dbo.UpdateRoom @maphong , @dientich , @loaiphong , @tinhtrang , @giaphong , @dodac ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maphong, dientich, loaiphong, tinhtrang, giaphong, dodac });
        }
        public void DeletePhong(string maphong)
        {
            string query = "EXEC dbo.deletePhong @maphong ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maphong });

        }

        public DataTable Search(string str)
        {
            
            DataTable data = DataProvider.Instance.ExecuteQuery($"EXEC TimKiemPhong @str=N'{str}'");

            return data;
        }

        public void UpdateBill(string maphong)
        {
            string query = $"UPDATE dbo.Phong SET tinhtrang =N'Trống' WHERE maphong='{maphong}' ";

            DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
