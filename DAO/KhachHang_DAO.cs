using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHang_DAO
    {
        private static KhachHang_DAO ins;


        private KhachHang_DAO() { }

        public static KhachHang_DAO Ins { get { if (ins == null) ins = new KhachHang_DAO(); return ins; } private set => ins = value; }

        public DataTable GetCustomer ()
        {
            return DataProvider.Ins.ExecQuery("Select * From v_dl_KhachHang");
        }
    }
}
