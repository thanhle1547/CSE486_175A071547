using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO // Value Object / Data Transfer Object
{
    public class Account_KH
    {
        /*private int id;
        private string username;
        private string password;
        private string hoten;
        private string ngaySinh;
        private string queQuan;
        private string soCMT;
        private string gioiTinh;

        public Account_KH() {}

        public Account_KH(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public int ID { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoCMT { get => soCMT; set => soCMT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }*/
        public Account_KH() { }

        public Account_KH(int id, string username, string pass)
        {
            ID = id;
            UserName = username;
            Password = pass;
        }

        public Account_KH(DataRow row)
        {
            ID = (int)row["IDKhachHang"];
            UserName = row["TenDangNhap"].ToString();
            Password = row["MatKhau"].ToString();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
