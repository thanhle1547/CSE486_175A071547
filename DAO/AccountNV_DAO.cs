using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class AccountNV_DAO
    {
        private static AccountNV_DAO ins;
        DataTable dt;

        private AccountNV_DAO() { }

        public static AccountNV_DAO Ins { get { if (ins == null) ins = new AccountNV_DAO(); return ins; } private set => ins = value; }

        public DataTable Login(ref string username, ref string password)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@userName", SqlDbType.VarChar, 20);
            //param[0].Value = username;
            param[1] = new SqlParameter("@passWord", SqlDbType.VarChar, 16);
            //param[1].Value = password;
            DataProvider.Ins.AddParams(ref param, username, password);
            DataTable result;

            try
            {
                result = DataProvider.Ins.ExecProc("ckLogin_NV", param);
            }
            catch (Exception e) when (e is SqlException)
            {
                throw (e);
            }
            return result;
        }

        public DataTable GetPosition ()
        {
            return DataProvider.Ins.ExecQuery("Select * From ChucVu");
        }

        public IEnumerable<NhanVien> GetPerPosition(string chucVu)
        {
            SqlParameter param = new SqlParameter
            {
                ParameterName = "ChucVu",
                DbType = DbType.String,
                Value = chucVu
            };
            return DataProvider.Ins.ExecQuery<NhanVien>("Select * from v_dl_Nhanvien Where", param);
        }
    }
}
