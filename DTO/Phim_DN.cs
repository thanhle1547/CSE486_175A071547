using System.Data;

namespace DTO
{
    // Phim Định dạng Ngôn ngữ
    public class Phim_DN
    {
        public Phim_DN() {}

        public Phim_DN(int id_PDN, string dinhDang, string ngonNgu)
        {
            ID_PDN = id_PDN;
            DinhDang = dinhDang;
            NgonNgu = ngonNgu;
        }

        public Phim_DN(DataRow row)
        {
            ID_PDN = (int)row["ID_PDN"];
            DinhDang = row["DinhDang"].ToString();
            NgonNgu = row["NgonNgu"].ToString();
        }

        public int ID_PDN { get; set; }
        public string DinhDang { get; set; }
        public string NgonNgu { get; set; }
    }
}
