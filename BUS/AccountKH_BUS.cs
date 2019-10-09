using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS // Business Logic Layer
{
    public class AccountKH_BUS
    {
        private static AccountKH_BUS ins;
        private Account_KH kh;
        private AccountKH_DAO dao;

        private AccountKH_BUS () { }

        public bool Login(string username, string password)
        {
            try
            {
                if (AccountKH_DAO.Ins.Login(ref username, ref password))
                    return true;
                return false;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public static AccountKH_BUS Ins { get { if (ins == null) ins = new AccountKH_BUS(); return ins; } set => ins = value; }
    }
}
