using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class LC_PhimDAO
    {
        private static LC_PhimDAO ins;

        public static LC_PhimDAO Ins { get { if (ins == null) ins = new LC_PhimDAO(); return ins; } private set => ins = value; }

        public IEnumerable<LichChieuPhim> GetScheduleDate(int id, string ngay) // DataSet
        {
            SqlParameter[] param = new SqlParameter[2]; 
            param[0] = new SqlParameter() {
                ParameterName = "@IDPhim",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = id,
            };
            param[1] = new SqlParameter() {
                ParameterName = "@Ngay",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = ngay
            };

            return DataProvider.Ins.ExecProc<LichChieuPhim>("Get_LichChieu_Ngay", param);
        }

        public DataTable GetScheduleRoom(int? id = 0, string tenPhong = "(none)")
        {
            List<SqlParameter> param = new List<SqlParameter>();
            if (id != 0)
                param.Add( new SqlParameter()
                {
                    ParameterName = "@IDPhim",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = id
                });
            if (tenPhong != "(none)")
                param.Add( new SqlParameter()
                {
                    ParameterName = "@TenPhong",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 5,
                    Value = tenPhong
                });

            return DataProvider.Ins.ExecProc("Get_LichChieu_Phong", param.ToArray());
        }

        public DataSet GetMoviesRoom()
        {
            DataSet dataSet = new DataSet();

            using (DataTable dt = DataProvider.Ins.ExecQuery("Select IDPhim, TenPhim From v_DuLieu_Phim"))
            {
                dt.TableName = "Phim";
                dataSet.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select IDPhong, TenPhong From PhongChieuPhim"))
            {
                dt.TableName = "Phong";
                dataSet.Tables.Add(dt);
            }
            return dataSet;
        }

        public string GetRoomSeat(int ID_LichChieu)
        {
            SqlParameter param = new SqlParameter()
            {
                ParameterName = "@ID_LichChieu",
                SqlDbType = SqlDbType.Int,
                Value = ID_LichChieu
            };
            return DataProvider.Ins.ExecScalar("Select dbo.Get_MaGhe(@ID_LichChieu)", param).ToString();
        }

        public void InsertSchedule(LichChieuPhim l)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter() { ParameterName = "@ID_PDN", SqlDbType = SqlDbType.Int, SqlValue = l.ID_PDN };
            param[1] = new SqlParameter() { ParameterName = "@IDPhong", 
                SqlDbType = SqlDbType.TinyInt, SqlValue = l.TenPhong };
            param[2] = new SqlParameter()
            {
                ParameterName = "@ThoiGianChieu",
                SqlDbType = SqlDbType.SmallDateTime,
                SqlValue = l.ThoiGianChieu
            };
            DataProvider.Ins.ExecQuery("Insert into LichChieuPhim (ID_PDN, IDPhong, ThoiGianChieu) " +
                "Values (@ID_PDN, @IDPhong, @ThoiGianChieu)", param);
        }

        public void UpdateSchedule(LichChieuPhim l)
        {
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter() { ParameterName = "@ID_PDN", SqlDbType = SqlDbType.Int, SqlValue = l.ID_PDN };
            param[1] = new SqlParameter()
            {
                ParameterName = "@IDPhong",
                SqlDbType = SqlDbType.TinyInt,
                SqlValue = l.TenPhong
            };
            param[2] = new SqlParameter()
            {
                ParameterName = "@ThoiGianChieu",
                SqlDbType = SqlDbType.SmallDateTime,
                SqlValue = l.ThoiGianChieu
            };
            param[3] = new SqlParameter()
            {
                ParameterName = "@ID_LichChieu",
                SqlDbType = SqlDbType.Int,
                SqlValue = l.ID_LichChieu
            };
            DataProvider.Ins.ExecQuery("Update LichChieuPhim " +
                "Set ID_PDN = @ID_PDN, IDPhong = @IDPhong, ThoiGianChieu = @ThoiGianChieu " +
                " Where ID_LichChieu = @ID_LichChieu", param);
        }

        public void DeleteSchedule(int ID_LichChieu)
        {
            DataProvider.Ins.ExecQuery("Delete From LichChieuPhim Where ID_LichChieu = @ID_LichChieu", 
                new SqlParameter() { ParameterName = "@ID_LichChieu", SqlDbType = SqlDbType.Int, SqlValue = ID_LichChieu});
        }
    }
}
