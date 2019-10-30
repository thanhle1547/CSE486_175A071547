using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class AccountNV_BUS
    {
        private static AccountNV_BUS ins;
        private Account_NV nv;
        //private AccountNV_DAO dao;
        private DataTable dt;

        private AccountNV_BUS() { }

        public NhanVien Login(string username, string password)
        {
            try
            {
                dt = AccountNV_DAO.Ins.Login(ref username, ref password);
                NhanVien nv = new NhanVien();
                nv.Hoten = dt.Rows[0].Field<string>("HoTen");
                nv.ID = (int)dt.Rows[0].Field<int>("IDNhanVien");
                nv.ChucVu = dt.Rows[0].Field<string>("ChucVu");

                return nv;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public static AccountNV_BUS Ins { get { if (ins == null) ins = new AccountNV_BUS(); return ins; } set => ins = value; }

        public List<string> GetDifferences(NhanVien cu, NhanVien moi)
        {
            // https://stackoverflow.com/a/2502468
            List<string> property = new List<string>();
            foreach (PropertyInfo info in cu.GetType().GetProperties())
            {
                object value1 = info.GetValue(cu, null);
                object value2 = info.GetValue(moi, null);
                if (!value1.Equals(value2))
                    property.Add(info.Name);
            }
            return property;
        }

        public void UpdatePer(NhanVien cu, NhanVien moi)
        {
            List<string> diff = GetDifferences(cu, moi);
            if (diff.Count() == 0)
                return;
            try
            {
                NhanVien_DAO.Ins.UpdatePer(moi, diff);
            }
            catch (Exception) { throw; }
        }
    }
}
