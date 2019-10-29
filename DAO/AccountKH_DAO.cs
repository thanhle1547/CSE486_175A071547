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
        DataTable dt;

        private AccountKH_DAO()
        {

        }

        public static AccountKH_DAO Ins { get { if (ins == null) ins = new AccountKH_DAO(); return ins; } private set => ins = value; }

        public string Login (ref string username, ref string password)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userName", SqlDbType.VarChar, 20);
            //param[0].Value = username;
            param[1] = new SqlParameter("@passWord", SqlDbType.VarChar, 16);
            //param[1].Value = password;
            DataProvider.Ins.AddParams(ref param, username, password);
            string result;

            try
            {
                result = DataProvider.Ins.ExecScalar("ckLogin_KH", param, CommandType.StoredProcedure).ToString();
            }
            catch (Exception e) when (e is SqlException)
            {
                throw (e);
            }
            /* Để cho server
            if (result.Rows[0].Field<string>("TenDangNhap") == username
                    && result.Rows[0].Field<string>("MatKhau") == password)*/
            return result;
        }

        // Lấy dl từ view
        public DataTable GetUserInfor (int id)
        {
            SqlParameter param = new SqlParameter("@IDKhachHang", SqlDbType.Int);
            param.Value = id;
            dt = DataProvider.Ins.ExecQuery("Select * from v_ Where ", param);

            return dt;
        }

        public string SignUp(Account_KH a, KhachHang kh)
        {
            var date = DateTime.Now;
            var id = date.Millisecond.ToString() + date.Second.ToString() + date.Day + date.DayOfWeek;
            try
            {
                SqlParameter[] parameters = new SqlParameter[6];
                parameters[0] = new SqlParameter("@IDKhachHang", SqlDbType.VarChar, 9);
                parameters[1] = new SqlParameter("@userName", SqlDbType.VarChar, 20);
                parameters[2] = new SqlParameter("@passWord", SqlDbType.VarChar, 16);
                parameters[3] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
                parameters[4] = new SqlParameter("@NgaySinh", SqlDbType.Date);
                parameters[5] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 3);
                DataProvider.Ins.AddParams(ref parameters, new object[]
                {
                    id,
                    a.UserName, a.Password, kh.Hoten, kh.NgaySinh, kh.GioiTinh
                });

                DataProvider.Ins.ExecProc("SignUp_KH", parameters);
                return id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}