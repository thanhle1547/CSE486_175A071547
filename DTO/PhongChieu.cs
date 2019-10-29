using System.Data;

namespace DTO
{
    public class PhongChieu
    {
        public PhongChieu()
        {
        }

        public PhongChieu(DataRow row)
        {
            IDPhong = row.Field<int>("IDPhong");
            TenPhong = row.Field<string>("TenPhong");
        }

        public int IDPhong { get; set; }
        public string TenPhong { get; set; }
    }
}