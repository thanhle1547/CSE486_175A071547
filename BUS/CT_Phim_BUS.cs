using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BUS
{
    public class CT_Phim_BUS
    {
        private static CT_Phim_BUS ins;
        DataTable dt;

        public static CT_Phim_BUS Ins { get { if (ins == null) ins = new CT_Phim_BUS(); return ins; } private set => ins = value; }

        /*public List<ChiTietPhim> GetMovies()
        {
            // System.StackOverflowException HResult = 0x800703E9 
            // Message = Exception of type 'System.StackOverflowException' was thrown.
            return GetMovies().ToList();
        }*/

        public DataTable GetMoviesDetails(bool comingsoon)
        {
            return CT_Phim_DAO.Ins.GetMovies_Details(comingsoon);
        }

        private string GetID_Details (DataTable source, string tblName, string colID, string colName, string data)
        {
            if (data == null)
                return "";
            List<int> l = new List<int>();
            var d = source.AsEnumerable();
            IEnumerable<string> i = data.Split(',').Select(x => x.Trim()).AsEnumerable();

            var dn = d.Select<DataRow, string>(x => x.Field<string>(colName)).ToArray();

            // tìm n~ tên ko có trong cột
            // https://stackoverflow.com/a/3944816
            string[] rsl = i
                .Where<string>(s => !dn.Any(s2 => String.Equals(s2, s, StringComparison.OrdinalIgnoreCase) ) ).ToArray();

            if (rsl.Length != 0)
                l = CT_Phim_DAO.Ins.InsertNewDetails(rsl.ToArray(), tblName, colName, colID)
                    .AsEnumerable().Select<DataRow, int>(x => x.Field<int>(colID)).ToList();

            // lấy id của n~ tên có trg cột
            // https://stackoverflow.com/a/2916648
            l.AddRange( from DataRow row in source.Rows
                where i.Any(s2 => String.Equals(s2, row.Field<string>(colName), StringComparison.OrdinalIgnoreCase))
                select Convert.ToInt32(row[colID])
                );
            return String.Join(", ", l.ToArray());
        }

        private void CheckAndUpdate(ref ChiTietPhim chiTiet, ref DataSet data, List<string> properties = null)
        {
            if (properties == null)
            {
                chiTiet.DienVien =
                  GetID_Details(data.Tables["DienVien"], "DienVien", "IDDienVien", "TenDienVien", chiTiet.DienVien);
                chiTiet.DaoDien =
                    GetID_Details(data.Tables["DaoDien"], "DaoDien", "IDDaoDien", "TenDaoDien", chiTiet.DaoDien);
                chiTiet.TheLoai =
                    GetID_Details(data.Tables["TheLoai"], "TheLoai", "IDTheLoai", "TenTheLoai", chiTiet.TheLoai);
                chiTiet.TenNSX =
                    GetID_Details(data.Tables["NhaSanXuat"], "NhaSanXuat", "ID_NSX", "TenNSX", chiTiet.TenNSX);
                return;
            }

            if (properties.Contains("DienVien"))
                chiTiet.DienVien =
        GetID_Details(data.Tables["DienVien"], "DienVien", "IDDienVien", "TenDienVien", chiTiet.DienVien);
            if (properties.Contains("DaoDien"))
                chiTiet.DaoDien =
        GetID_Details(data.Tables["DaoDien"], "DaoDien", "IDDaoDien", "TenDaoDien", chiTiet.DaoDien);
            if (properties.Contains("TheLoai"))
                chiTiet.TheLoai =
        GetID_Details(data.Tables["TheLoai"], "TheLoai", "IDTheLoai", "TenTheLoai", chiTiet.TheLoai);
            if (properties.Contains("NhaSanXuat"))
                chiTiet.TenNSX =
        GetID_Details(data.Tables["NhaSanXuat"], "NhaSanXuat", "ID_NSX", "TenNSX", chiTiet.TenNSX);

        }

        public List<string> GetDifferences(ChiTietPhim cu, ChiTietPhim moi)
        {
            // https://stackoverflow.com/a/2502468
            List<string> property = new List<string>();
            foreach (PropertyInfo info in cu.GetType().GetProperties())
            {
                object value1 = info.GetValue(cu, null);
                object value2 = info.GetValue(moi, null);
                if (!value1.Equals(value2))
                    property.Add(info.Name);
            }
            return property;
        }

        public void InsertMovie(ChiTietPhim phim, ref DataSet data)
        {
            CheckAndUpdate(ref phim, ref data);
            CT_Phim_DAO.Ins.InsertMovie(phim);
        }

        public void UpdateMovie(ChiTietPhim chiTietCu, ChiTietPhim chiTietMoi, ref DataSet data)
        {
            List<string> diff = GetDifferences(chiTietCu, chiTietMoi);
            CheckAndUpdate(ref chiTietMoi, ref data, diff);
            CT_Phim_DAO.Ins.UpdateMovie(chiTietMoi, diff);
        }
    }
}
