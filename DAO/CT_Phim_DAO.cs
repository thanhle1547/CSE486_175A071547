using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    // https://stackoverflow.com/a/519536
    // A singleton allows access to a single created instance - that instance (or rather, a reference to that instance) can be passed as a parameter to other methods, and treated as a normal object.
    // A static class allows only static methods.
    public class CT_Phim_DAO
    {
        private static CT_Phim_DAO ins;
        //DataTable dt;

        public static CT_Phim_DAO Ins { get { if (ins == null) ins = new CT_Phim_DAO(); return ins; } private set => ins = value; }

        public IEnumerable<ChiTietPhim> GetMovies(bool comingsoon)
        {
            if (comingsoon)
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter()
                {
                    ParameterName = "@comingSoon",
                    SqlDbType = SqlDbType.Bit,
                    SqlValue = 1
                };
                return DataProvider.Ins.ExecProc<ChiTietPhim>("Get_Movies", parameter); //.ToList();
            }
            return DataProvider.Ins.ExecProc<ChiTietPhim>("Get_Movies"); //.ToList(); // view_ChiTietPhim
        }

        public ChiTietPhim GetMovie_Details(int id, bool comingsoon)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            if (comingsoon)
                return DataProvider.Ins.ExecProc<ChiTietPhim>("Get_MovieInfors", param).First();
            return DataProvider.Ins.ExecProc<ChiTietPhim>("Get_MovieInfors", param).First();// Exec view_ChiTietPhim
        }

        public DataTable GetMovies_Details (bool comingsoon)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter { 
                ParameterName = "@comingSoon", DbType = DbType.Boolean, Value = comingsoon };
            parameters[1] = new SqlParameter { ParameterName = "@all", DbType = DbType.Boolean, Value = 1 };
            if (comingsoon)
                return DataProvider.Ins.ExecProc("Get_Movies", parameters);
            return DataProvider.Ins.ExecProc("Get_Movies", parameters);
        }

        public DataTable GetAllMovies_Details()
        {
            return DataProvider.Ins.ExecQuery("Select * From v_DuLieu_Phim");
        }

        public DataSet GetAllDetails()
        {
            DataSet data = new DataSet();
            using(DataTable dt = DataProvider.Ins.ExecQuery("Select * From DinhDang"))
            {
                dt.TableName = "DinhDang";
                data.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select * From NgonNgu"))
            {
                dt.TableName = "NgonNgu";
                data.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select * From DienVien"))
            {
                dt.TableName = "DienVien";
                data.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select * From DaoDien"))
            {
                dt.TableName = "DaoDien";
                data.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select * From TheLoai"))
            {
                dt.TableName = "TheLoai";
                data.Tables.Add(dt);
            }
            using (DataTable dt = DataProvider.Ins.ExecQuery("Select * From NhaSanXuat"))
            {
                dt.TableName = "NhaSanXuat";
                data.Tables.Add(dt);
            }
            return data;
        }

        public DataTable GetMovieDL (int IDPhim) // Định dạng - Ngôn ngữ Phim
        {
            return DataProvider.Ins.ExecProc("Get_PhimDN", new SqlParameter() { 
                ParameterName = "@IDPhim",
                SqlDbType = SqlDbType.Int,
                SqlValue = IDPhim
            });
        }

        public void InsertMovie(ChiTietPhim phim)
        {
            // https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/configuring-parameters-and-parameter-data-types
            SqlParameter[] parameters = new SqlParameter[13];
            parameters[0] = new SqlParameter("@IDPhim", SqlDbType.Int);
            parameters[1] = new SqlParameter("@TenPhim", SqlDbType.NVarChar);
            parameters[2] = new SqlParameter("@Poster", SqlDbType.Image);
            parameters[3] = new SqlParameter("@ThoiLuong", SqlDbType.TinyInt);
            parameters[4] = new SqlParameter("@KhoiChieu", SqlDbType.Date);
            parameters[5] = new SqlParameter("@Rated", SqlDbType.Char, 3);
            parameters[6] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            parameters[7] = new SqlParameter("@ID_NSX", SqlDbType.Int);
            
            parameters[8] = new SqlParameter("@IDs_DienVien", SqlDbType.NVarChar, 20);
            parameters[9] = new SqlParameter("@IDs_DaoDien", SqlDbType.NVarChar, 20);
            parameters[10] = new SqlParameter("@IDs_NgonNgu", SqlDbType.NVarChar, 20);
            parameters[11] = new SqlParameter("@IDs_DinhDang", SqlDbType.NVarChar, 20);
            parameters[12] = new SqlParameter("@IDs_TheLoai", SqlDbType.NVarChar, 20);
            DataProvider.Ins.AddParams(ref parameters, new object[]
            {
                phim.IDPhim, phim.TenPhim, 
                phim.Poster == null ? (object)DBNull.Value : phim.Poster, 
                phim.ThoiLuong,
                phim.KhoiChieu, phim.Rated, phim.MoTa, 
                phim.TenNSX == "" ? null : phim.TenNSX,
                phim.DienVien, phim.DaoDien, phim.NgonNgu, phim.DinhDang, phim.TheLoai
            });

            DataProvider.Ins.ExecProc("isrt_Movie", parameters);
        }
        
        public void UpdateMovie(ChiTietPhim phim, List<string> diff)
        {
            string query = "Update Phim Set "
                + (diff.Contains("TenPhim") ? "TenPhim = " + phim.TenPhim : "")
                + (diff.Contains("Poster") ? "Poster = " + phim.Poster : "")
                + (diff.Contains("KhoiChieu") ? "KhoiChieu = " + phim.KhoiChieu : "")
                + (diff.Contains("Rated") ? "Rated = " + phim.Rated : "")
                + (diff.Contains("MoTa") ? "MoTa = " + phim.MoTa : "")
                + (diff.Contains("TenPhim") ? "TenPhim = " + phim.TenPhim : "")
                + (diff.Contains("TenNSX") ? "TenNSX = " + phim.TenNSX : "")
                + " Where IDPhim = " + phim.IDPhim;
            if (query.ToCharArray().Count(x => x == '=') > 1)
                DataProvider.Ins.ExecQuery(query);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IDPhim",SqlDbType.Int));
            if (diff.Contains("DienVien"))
                parameters.Add(new SqlParameter("@IDs_DienVien", SqlDbType.NVarChar, 20));
            if (diff.Contains("DaoDien"))
                parameters.Add(new SqlParameter("@IDs_DaoDien", SqlDbType.NVarChar, 20));
            if (diff.Contains("NgonNgu"))
            {
                parameters.Add(new SqlParameter("@IDs_NgonNgu", SqlDbType.NVarChar, 20));
                parameters.Add(new SqlParameter("@IDs_DinhDang", SqlDbType.NVarChar, 20));
            }
            if (diff.Contains("TheLoai"))
                parameters.Add(new SqlParameter("@IDs_TheLoai", SqlDbType.NVarChar, 20));
            if (parameters.Count() != 1)
                DataProvider.Ins.ExecProc("update_Movie", parameters.ToArray());
        }

        public void DeleteMovie(int id)
        {
            try
            {
                DataProvider.Ins.ExecProc("del_Movie",
                    new SqlParameter { ParameterName = "IDPhim", SqlDbType = SqlDbType.Int, Value = id });
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public DataTable InsertNewDetails(string[] newDetails, string tblName, string colName, string colId)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            var values = "(" + String.Join(", " , newDetails.Select(x => "N'" + x + "'") ) + ")";
            return DataProvider.Ins.ExecQuery(
                "Insert into " + tblName + "(" + colName + ")"
                + " OUTPUT inserted." + colId 
                + " Values " + values);
        }

        public int GetLastIDPhim ()
        {
            return (int)DataProvider.Ins.ExecScalar("Select Max(IDPhim) From Phim") + 1;
        }
    }
}
