using MainProgram.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
   public class BillDAO
    {
        private BillDAO() { }
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<Bill> GetList()
        {
            List<Bill> listCustomer = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill");
            foreach (DataRow item in data.Rows)
            {
                Bill khach = new Bill(item);
                listCustomer.Add(khach);
            }

            return listCustomer;

        }

        public void Add(string timePayment,string timefrom, string timeto, float price, string makhach, string maphong)
        {
            string query = $"INSERT dbo.Bill VALUES  ( {price} ,  '{makhach}' ,  '{maphong}' , '{timePayment}' ,'{timefrom} ', '{timeto}' )";

            DataProvider.Instance.ExecuteNonQuery(query);


        }

        public void Update(int id, string timePayment, string timefrom, string timeto, float price, string makhach, string maphong)
        {
            string query = $" UPDATE dbo.Bill SET timePayment ='{timePayment}',timefrom='{timefrom}' ,timefrom='{timeto}',price= {price},makhach ='{makhach}', maphong = '{maphong}' WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void Delete(string id)
        {
            string query = $"DELETE  dbo.Bill where id={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

        }

    }
}
