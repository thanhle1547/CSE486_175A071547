using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public KhachHang() { }

        public KhachHang(string id, string hoten, string ngaySinh, string gioiTinh)
        {
            ID = id;
            Hoten = hoten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
        }

        public KhachHang(DataRow row)
        {
            ID = row["IDKhachHang"].ToString();
            Hoten = row["HoTen"].ToString();
            NgaySinh = row["NgaySinh"].ToString();
            GioiTinh = row["GioiTinh"].ToString();
        }

        public string ID { get; set; }
        public string Hoten { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
    }
}
