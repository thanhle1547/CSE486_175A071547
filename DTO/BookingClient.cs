using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookingClient
    {
        public BookingClient()
        {
        }

        public BookingClient(string iD, string iDKhachHang, int iD_LichChieu, DateTime tG_MuaVe, int soLuongVe, string maGheNgoi, bool gheVIP, float tongTien)
        {
            ID = iD;
            IDKhachHang = iDKhachHang;
            ID_LichChieu = iD_LichChieu;
            TG_MuaVe = tG_MuaVe;
            SoLuongVe = soLuongVe;
            MaGheNgoi = maGheNgoi;
            GheVIP = gheVIP;
            TongTien = tongTien;
        }

        public string ID { get; set; }
        public string IDKhachHang { get; set; }
        public int ID_LichChieu { get; set; }
        public DateTime TG_MuaVe { get; set; }
        public int SoLuongVe { get; set; }
        public string MaGheNgoi { get; set; }
        public bool GheVIP { get; set; }
        public float TongTien { get; set; }
    }
}
