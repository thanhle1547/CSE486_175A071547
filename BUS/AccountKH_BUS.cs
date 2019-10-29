using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS // Business Logic Layer
{
    public class AccountKH_BUS
    {
        private static AccountKH_BUS ins;
        private KhachHang kh;
        private Account_KH acc;
        private AccountKH_DAO dao;
        private DataTable dt;

        private AccountKH_BUS () { }

        public KhachHang Login(string username, string password)
        {
            kh = new KhachHang();
            try
            {
                kh.ID = AccountKH_DAO.Ins.Login(ref username, ref password);
                return kh;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public KhachHang GetInfor(int id)
        {
            kh = new KhachHang();
            try
            {
                dt = AccountKH_DAO.Ins.GetUserInfor(id);
                kh.Hoten = dt.Rows[0].Field<string>("HoTen");
                kh.NgaySinh = dt.Rows[0].Field<string>("NgaySinh");
                kh.GioiTinh = dt.Rows[0].Field<string>("GioiTinh");
                return kh;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public static AccountKH_BUS Ins { get { if (ins == null) ins = new AccountKH_BUS(); return ins; } set => ins = value; }
    }
}
