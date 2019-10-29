using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Booking_DAO
    {
        private static Booking_DAO ins;

        public static Booking_DAO Ins { get { if (ins == null) ins = new Booking_DAO(); return ins; } private set => ins = value; }

        public void BookingClient(BookingClient b, string MaGheThuong, string MaGheVIP, int TongTien)
        {
            if (MaGheThuong != null || MaGheThuong != "")
            {
                var date = DateTime.Now;

                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("@ID", System.Data.SqlDbType.VarChar, 6);
                parameters[1] = new SqlParameter("@IDKhachHang", System.Data.SqlDbType.VarChar, 9);
                parameters[2] = new SqlParameter("@ID_LichChieu", System.Data.SqlDbType.Int);
                parameters[3] = new SqlParameter("@TG_MuaVe", System.Data.SqlDbType.SmallDateTime);
                parameters[4] = new SqlParameter("@SoLuongVe", System.Data.SqlDbType.TinyInt);
                parameters[5] = new SqlParameter("@MaGheNgoi", System.Data.SqlDbType.VarChar);
                parameters[6] = new SqlParameter("@GheVIP", System.Data.SqlDbType.Bit);
                parameters[7] = new SqlParameter("@TongTien", System.Data.SqlDbType.Real);
                DataProvider.Ins.AddParams(ref parameters, new object[] {
                (b.ID_LichChieu.ToString()
                    + b.IDKhachHang.Substring(0, 2).ToString()
                    + date.Millisecond.ToString()),
                b.IDKhachHang, b.ID_LichChieu.ToString(), date.ToString(),
                MaGheThuong.Split(',').Count(), MaGheThuong, 0, TongTien
            });
                DataProvider.Ins.ExecQuery(
"Insert into Booking_Client Values (@ID, @IDKhachHang, @ID_LichChieu, @TG_MuaVe, @SoLuongVe, @MaGheNgoi, @GheVIP, @TongTien )", parameters
    );
            }
            if (MaGheThuong != null || MaGheVIP != "")
            {
                var date = DateTime.Now;
                SqlParameter[] parameters = new SqlParameter[8];
                parameters[0] = new SqlParameter("@ID", System.Data.SqlDbType.VarChar, 6);
                parameters[1] = new SqlParameter("@IDKhachHang", System.Data.SqlDbType.VarChar, 9);
                parameters[2] = new SqlParameter("@ID_LichChieu", System.Data.SqlDbType.Int);
                parameters[3] = new SqlParameter("@TG_MuaVe", System.Data.SqlDbType.SmallDateTime);
                parameters[4] = new SqlParameter("@SoLuongVe", System.Data.SqlDbType.TinyInt);
                parameters[5] = new SqlParameter("@MaGheNgoi", System.Data.SqlDbType.VarChar);
                parameters[6] = new SqlParameter("@GheVIP", System.Data.SqlDbType.Bit);
                parameters[7] = new SqlParameter("@TongTien", System.Data.SqlDbType.Real);
                DataProvider.Ins.AddParams(ref parameters, new object[] {
                (b.ID_LichChieu.ToString()
                    + b.IDKhachHang.Substring(0, 2).ToString()
                    + date.Millisecond.ToString()),
                b.IDKhachHang, b.ID_LichChieu.ToString(), date.ToString(),
                MaGheVIP.Split(',').Count(), MaGheVIP, 1, TongTien
            });
                DataProvider.Ins.ExecQuery(
"Insert into Booking_Client Values (@ID, @IDKhachHang, @ID_LichChieu, @TG_MuaVe, @SoLuongVe, @MaGheNgoi, @GheVIP, @TongTien )", parameters
    );
            }
        }

        public string GetTongTien(int ID_LichChieu, string TenDinhDang)
        {
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter()
            {
                ParameterName = "@ID_LichChieu",
                SqlDbType = System.Data.SqlDbType.Int,
                SqlValue = ID_LichChieu
            };
            p[1] = new SqlParameter()
            {
                ParameterName = "@TenDinhDang",
                SqlDbType = System.Data.SqlDbType.VarChar,
                Size = 5,
                SqlValue = TenDinhDang
            };
            return DataProvider.Ins.ExecScalar("Get_DonGia", p, System.Data.CommandType.StoredProcedure).ToString();
        }
    }
}
