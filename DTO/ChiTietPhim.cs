using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace DTO
{
    public class ChiTietPhim
    {
        public ChiTietPhim() {}

        public ChiTietPhim(int iDPhim, string tenNSX, string tenPhim, byte[] poster, int thoiLuong, string khoiChieu, string rated, string moTa, string daoDien, string dienVien, string theLoai, string dinhDang, string ngonNgu)
        {
            IDPhim = iDPhim;
            TenNSX = tenNSX;
            TenPhim = tenPhim;
            Poster = poster;
            ThoiLuong = thoiLuong;
            KhoiChieu = khoiChieu;
            Rated = rated;
            MoTa = moTa;

            DaoDien = daoDien;
            DienVien = dienVien;
            TheLoai = theLoai;
            DinhDang = dinhDang;
            NgonNgu = ngonNgu;
        }

        public ChiTietPhim(DataRow row)
        {
            IDPhim = (int)row["IDPhim"];
            TenNSX = row["TenNSX"].ToString();
            TenPhim = row["TenPhim"].ToString();
            Poster = (Byte[])row["Poster"];
            ThoiLuong = row["ThoiLuong"] is DBNull ? 0 : (int)row["ThoiLuong"];
            KhoiChieu = row["KhoiChieu"].ToString();
            Rated = row["Rated"].ToString();
            MoTa = row["MoTa"].ToString();

            DaoDien = row["DaoDien"].ToString();
            DienVien = row["DienVien"].ToString();
            TheLoai = row["TheLoai"].ToString();
            DinhDang = row["DinhDang"].ToString();
            NgonNgu = row["NgonNgu"].ToString();
        }

        public int IDPhim { get; set; }
        public string TenNSX { get; set; }
        public string TenPhim { get; set; }
        // https://stackoverflow.com/questions/8084590/how-to-load-image-from-sql-server-into-picture-box
        public Byte[] Poster { get; set; }
        public int ThoiLuong { get; set; }
        public string KhoiChieu { get; set; }
        public string Rated { get; set; }
        public string MoTa { get; set; }

        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public string TheLoai { get; set; }
        public string DinhDang { get; set; }
        public string NgonNgu { get; set; }

        
    }
}
