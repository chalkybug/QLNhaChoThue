using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MainProgram.Objects
{
    public class Bill
    {
        //       id INT IDENTITY PRIMARY KEY,
        //timePayment DATE,
        //   price FLOAT,
        //makhach VARCHAR(10) REFERENCES dbo.Khach(makhach),
        //maphong VARCHAR(10) REFERENCES dbo.Phong(maphong)

        public int id { get; set; }
        public string timePayment { get; set; }
        public string timefrom { get; set; }
        public string timeto { get; set; }
        public float price { get; set; }
        public string makhach { get; set; }
        public string maphong { get; set; }

        public Bill(int id, string timePayment, float price, string makhach, string maphong, string timefrom, string timeto)
        {
            this.id = id;
            this.timePayment = timePayment;
            this.price = price;
            this.makhach = makhach;
            this.maphong = maphong;
            this.timefrom = timefrom;
            this.timeto = timeto;
        }
        public Bill(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.timePayment = row["timePayment"].ToString();
            this.timefrom = row["timefrom"].ToString();
            this.timeto = row["timeto"].ToString();
            this.price = float.Parse(row["price"].ToString());
            this.makhach = row["makhach"].ToString();
            this.maphong = row["maphong"].ToString();
        }
        public Bill()
        {

        }

    }
}
