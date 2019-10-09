using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO // Data Access Layer
{
    public class AccountKH_DAO
    {
        private static AccountKH_DAO ins;

        private AccountKH_DAO()
        {

        }

        public static AccountKH_DAO Ins { get { if (ins == null) ins = new AccountKH_DAO(); return ins; } private set => ins = value; }

        public bool Login (ref string username, ref string password)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@", SqlDbType.VarChar, 20);
            //param[0].Value = username;
            param[1] = new SqlParameter("@", SqlDbType.VarChar, 10);
            //param[1].Value = password;
            DataProvider.Ins.AddParams(ref param, username, password);
            DataTable result;

            try
            {
                result = DataProvider.Ins.ExecQuery("Login", param);
            }
            catch (Exception e) when (e is SqlException)
            {
                throw (e);
            }
            /* Để cho server
            if (result.Rows[0].Field<string>("TenDangNhap") == username
                    && result.Rows[0].Field<string>("MatKhau") == password)*/
            if (result.Columns.Contains("HoTen"))
            {
                NhanVien
                return true;
            }
            return false;
        }

        // Lấy dl từ view
        public DataTable GetUserInfor (string username)
        {
            DataTable dt = DataProvider.Ins.ExecQuery("Select * from v_ Where TenDangNhap = @user");

            return dt;
        }
    }
}