using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_NV
    {
        /*private static Account_NV ins;
        private int id;
        private string username;
        private string password;
        private string hoten;
        private string ngaySinh;
        private string queQuan;
        private string soCMT;
        private string gioiTinh;
        private string chucVu;

        private Account_NV() { }

        public static Account_NV Ins { get { if (ins == null) ins = new Account_NV(); return ins; } private set => ins = value; }
        public int Id { get => id; set => id = value; }
        public string UserName { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoCMT { get => soCMT; set => soCMT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }*/

        public Account_NV() { }

        public Account_NV(int id, string username, string pass, string idChucVu)
        {
            ID = id;
            UserName = username;
            Password = pass;
            IDChucVu = idChucVu;
        }

        public Account_NV (DataRow row)
        {
            ID = (int)row["IDNhanVien"];
            UserName = row["TenDangNhap"].ToString();
            Password = row["MatKhau"].ToString();
            IDChucVu = row["IDChucVu"].ToString();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IDChucVu { get; set; }
    }
}
