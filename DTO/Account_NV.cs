﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account_NV
    {
        /*private int id;
        private string username;
        private string password;
        private string hoten;
        private string ngaySinh;
        private string queQuan;
        private string soCMT;
        private string gioiTinh;*/

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoCMT { get => soCMT; set => soCMT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}