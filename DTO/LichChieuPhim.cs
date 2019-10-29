using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuPhim
    {
        public LichChieuPhim() {}

        public LichChieuPhim(DataRow row) 
        {
            ID_LichChieu = row.Field<int>("ID_LichChieu");
            ID_PDN = row.Field<int>("ID_PDN");
            DN = row.Field<string>("DN");
            TenPhong = row.Field<string>("TenPhong");
            ThoiGianChieu = row.Field<string>("ThoiGianChieu");
            ThoiGianKetThuc = row.Field<string>("ThoiGianKetThuc");
            SoGheTrong = row.Field<int>("SoGheTrong");
        }

        public int ID_LichChieu { get; set; }
        public int ID_PDN { get; set; }
        //public string TenPhim { get; set; }
        public string DN { get; set; }
        public string TenPhong { get; set; }
        public string ThoiGianChieu { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public int SoGheTrong { get; set; }
    }
}
