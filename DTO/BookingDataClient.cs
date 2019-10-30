using System.Data;

namespace DTO
{
    public class BookingDataClient
    {
        public BookingDataClient()
        {
        }

        public BookingDataClient(string iD, string tenPhong, int soLuongVe, string maGheNgoi, string thoiGianChieu, string tenPhim, float tongTien = 0)
        {
            ID = iD;
            TenPhong = tenPhong;
            SoLuongVe = soLuongVe;
            MaGheNgoi = maGheNgoi;
            ThoiGianChieu = thoiGianChieu;
            TenPhim = tenPhim;
        }

        public BookingDataClient(DataRow row)
        {
            ID = row.Field<string>("ID") ?? "";
            TenPhim = row.Field<string>("TenPhim");
            TenPhong = row.Field<string>("TenPhong");
            SoLuongVe = row.Field<int>("SoLuongVe");
            MaGheNgoi = row.Field<string>("MaGheNgoi");
            ThoiGianChieu = row.Field<string>("ThoiGianChieu");
        }

        public string ID { get; set; }
        public string TenPhim { get; set; }
        public string TenPhong { get; set; }
        public int SoLuongVe { get; set; }
        public string MaGheNgoi { get; set; }
        public string ThoiGianChieu { get; set; }
        //public float TongTien { get; set; }
    }
}
