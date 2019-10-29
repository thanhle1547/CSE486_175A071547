using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        /*private int id;
        private string hoten;
        private string ngaySinh;
        private string queQuan;
        private string soCMT;
        private string gioiTinh;

        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoCMT { get => soCMT; set => soCMT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public static NhanVien ins;*/

        public NhanVien()
        {
        }

        public NhanVien(int id, string hoten, string ngaySinh, string queQuan, string soCMT, string gioiTinh, string chucVu)
        {
            ID = id;
            Hoten = hoten;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            SoCMT = soCMT;
            GioiTinh = gioiTinh;
            ChucVu = chucVu;
        }

        public NhanVien(DataRow row)
        {
            ID = (int)row["IDNhanVien"];
            Hoten = row["HoTen"].ToString();
            NgaySinh = row["NgaySinh"].ToString();
            QueQuan = row["Que"].ToString();
            SoCMT = row["SoChungMinhThu"].ToString();
            GioiTinh = row["GioiTinh"].ToString();
            ChucVu = row["ChucVu"].ToString();
        }

        // auto-property, ngôn ngữ sẽ tự tạo 1 field private, gettter và setter cho field đó
        public int ID { get; set; }
        public string Hoten { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string SoCMT { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
    }
}
