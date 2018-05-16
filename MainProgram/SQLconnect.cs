using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    class SQLconnect
    {
        public static SqlConnection con;
        public SQLconnect()
        {
            //try
            //{
                con = getConnection();
            //    if (con.State != ConnectionState.Open)
            //    {
            //        con.Open();
            //    }
            //}
            //catch (Exception)
            //{

            //}
        }
        public static SqlConnection getConnection()
        {
            string connectstr = @"Data Source=DESKTOP-ODF6BBO\MINHNGOC;Initial Catalog=QLNCT;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectstr);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                //throw;
            }

            return connection;
        }

        //Hàm thực hiện lệnh truy vấn SELECT-FROM-WHERE 
        public DataSet getDataSet(string cmdstr, CommandType cmdtype)
        {
            DataSet ds = new DataSet();

            SqlDataAdapter adapt = new SqlDataAdapter();
            if (con.State == ConnectionState.Closed) con.Open();

            try
            {
                SqlCommand command = new SqlCommand(cmdstr, con);
                command.CommandType = cmdtype;

                adapt.SelectCommand = command;
                adapt.Fill(ds);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                //throw;
            }
            return ds;
        }

        //Hàm thực hiện các lệnh INSERT, DELETE, UPDATE
        public int ExeNoneQuery(string strcode)
        {
            //Số lượng bản ghi thực hiện được khi thực thi câu lệnh
            int resultt = 0;
            if (strcode != "")
            {
                //Mở kết nối trước khi sử dụng đối tượng SqlCommand
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand command = new SqlCommand(strcode, con);
                command.CommandType = CommandType.Text;
                //Số bản ghi thực hiện được
                resultt = command.ExecuteNonQuery();

                //Đóng kết nối
                if (con.State == ConnectionState.Open) con.Close();
            }
            return resultt;
        }

        //Hàm thực thi các câu lệnh trả về 1 giá trị
        public string ExeScalarQuery(string strcode)
        {
            string result = "";
            //Mở kết nối
            if (con.State == ConnectionState.Closed) con.Open();

            SqlCommand command = new SqlCommand(strcode, con);
            command.CommandType = CommandType.Text;
            result = command.ExecuteScalar().ToString();

            //Đóng kết nối
            if (con.State == ConnectionState.Open) con.Close();

            return result;
        }
        public object ExecScalaQuery(string strcode)
        {
            object res = new object();

            //Mở kết nối
            if (con.State == ConnectionState.Closed) con.Open();

            SqlCommand command = new SqlCommand(strcode, con);
            command.CommandType = CommandType.Text;
            res = command.ExecuteScalar();

            //Đóng kết nối
            if (con.State == ConnectionState.Open) con.Close();

            return res;
        }
    }
}
