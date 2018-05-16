using MainProgram.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.DAO
{
    class AccountLogin
    {
        private AccountLogin() { }
        private static AccountLogin instance;

        internal static AccountLogin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountLogin();
                }
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public bool Login(string userName, string passWord)
        {
            //test sqp in
            string query = string.Format("checkLogin @username , @password");
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return data.Rows.Count > 0;
        }

    }
}
