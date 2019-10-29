using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        private static NhanVien_DAO ins;
        DataTable dt;

        private NhanVien_DAO() { }

        public static NhanVien_DAO Ins { get { if (ins == null) ins = new NhanVien_DAO(); return ins; } private set => ins = value; }

        public DataTable GetPosition()
        {
            return DataProvider.Ins.ExecQuery("Select * From ChucVu");
        }

        public DataTable GetPerPosition(string chucVu) // IEnumerable<NhanVien>
        {
            /*SqlParameter param = new SqlParameter
            {
                ParameterName = "@ChucVu",
                DbType = DbType.String,
                Value = chucVu
            };*/
            return DataProvider.Ins.ExecQuery("Select * from v_dl_Nhanvien Where ChucVu = '" + chucVu + "'");
        }

        public void AddPer(NhanVien n, Account_NV a)
        {
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 20);
            parameters[1] = new SqlParameter("@NgaySinh", SqlDbType.Date);
            parameters[2] = new SqlParameter("@Que", SqlDbType.NVarChar, 20);
            parameters[3] = new SqlParameter("@SoChungMinhThu", SqlDbType.VarChar, 15);
            parameters[4] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar, 3);
            parameters[5] = new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 20);
            parameters[6] = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 10);
            parameters[7] = new SqlParameter("@IDChucVu", SqlDbType.TinyInt);
            DataProvider.Ins.AddParams(ref parameters,
                n.Hoten, n.NgaySinh, n.QueQuan, n.SoCMT, n.GioiTinh,
                a.UserName, a.Password, a.IDChucVu
                );

            DataProvider.Ins.ExecProc("Add_Personnel", parameters);
        }

        public void UpdatePer(NhanVien n, List<string> diff)
        {
            string query = "Update NhanVien Set ";
            List<string> p = new List<string>();
            List<SqlParameter> param = new List<SqlParameter>();

            if (diff.Contains("Hoten"))
            {
                param.Add(new SqlParameter()
                { ParameterName = "@Hoten", SqlDbType = SqlDbType.NVarChar, Size = 30, SqlValue = n.Hoten });
                p.Add(" Hoten = @Hoten ");
            }
            if (diff.Contains("NgaySinh"))
            {
                param.Add(new SqlParameter()
                { ParameterName = "@NgaySinh", SqlDbType = SqlDbType.Date, SqlValue = n.NgaySinh });
                p.Add(" NgaySinh = @NgaySinh ");
            }
            if (diff.Contains("QueQuan"))
            {
                param.Add(new SqlParameter()
                { ParameterName = "@Que", SqlDbType = SqlDbType.NVarChar, Size = 20, SqlValue = n.QueQuan });
                p.Add(" Que = @Que ");
            }
            if (diff.Contains("SoCMT"))
            {
                param.Add(new SqlParameter()
                { ParameterName = "@SoChungMinhThu", SqlDbType = SqlDbType.VarChar, Size = 15, SqlValue = n.SoCMT });
                p.Add(" SoChungMinhThu = @SoChungMinhThu ");
            }
            if (diff.Contains("GioiTinh"))
            {
                param.Add(new SqlParameter()
                { ParameterName = "@GioiTinh", SqlDbType = SqlDbType.NVarChar, Size = 3, SqlValue = n.GioiTinh });
                p.Add(" GioiTinh = @GioiTinh ");
            }
            param.Add(new SqlParameter()
            {
                ParameterName = "@IDNhanVien",
                SqlDbType = SqlDbType.Int,
                SqlValue = n.ID
            });
            query += String.Join(", ", p) + " Where IDNhanVien = @IDNhanVien";

            try
            {
                DataProvider.Ins.ExecQuery(query, param.ToArray() );

                if (diff.Contains("ChucVu"))
                {
                    param.Add(new SqlParameter()
                    { ParameterName = "@ChucVu", SqlDbType = SqlDbType.NVarChar, Size = 30, SqlValue = n.ChucVu });
                    query = "Update Account_NV Set ChucVu = @ChucVu ";

                    DataProvider.Ins.ExecQuery(query, param.ToArray());
                }
            }
            catch (Exception) { throw; }
        }

        public void DeletePer(int IDNhanVien)
        {
            DataProvider.Ins.ExecProc("Del_Personnel", new SqlParameter()
            {
                ParameterName = "@IDNhanVien",
                SqlDbType = SqlDbType.Int,
                SqlValue = IDNhanVien
            });
        }
    }
}
