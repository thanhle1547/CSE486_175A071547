using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LC_PhimBUS
    {
        private static LC_PhimBUS ins;

        public static LC_PhimBUS Ins { get { if (ins == null) ins = new LC_PhimBUS(); return ins; } private set => ins = value; }

        /*public IEnumerable<LichChieuPhim> GetSchedule(int id, string ngay)
        {
            DataSet data = LC_PhimDAO.Ins.GetScheduleDate(id, ngay);

            // https://yinyangit.wordpress.com/2011/08/20/linq-su-dung-inner-join-csharp/
            *//*var list = data.Tables[0].AsEnumerable()
                    .Join(data.Tables[1].AsEnumerable(),
                        o => o.Field<int>("ID_LichChieu"),
                        i => i.Field<int>("ID_LichChieu"),
                        // những cột hiện ra với đk nối = nhau ở trên
                        (o, i) => new
                        {
                            ID_LichChieu = o.Field<int>("ID_LichChieu"),
                            ThoiGian = o.Field<string>("ThoiGianChieu"),
                            DinhDang = o.Field<string>("TenDinhDang"),
                            NgonNgu = o.Field<string>("NgonNgu"),
                            TenPhong = o.Field<string>("TenPhong"),
                            SoLuongVe = i.Field<int>("SoLuongVe"),
                            MaGhe = i.Field<string>("MaGhe")
                        })
                    // https://stackoverflow.com/a/29074275
                    .GroupBy(key => new Phim_DN() //key selector
                    {
                        ID_PDN = key.ID_PDN,
                        DinhDang = key.DinhDang,
                        NgonNgu = key.NgonNgu,
                    }, result => new LichChieuPhim() { // result selector
                        TenPhong = result.TenPhong,
                        ThoiGian = result.ThoiGian 
                    })*//*.Select(n => new {
                        ID_PDN = n.Key.ID_PDN,
                        DinhDang = n.Key.DinhDang,
                        NgonNgu = n.Key.NgonNgu,
                        ThongTin = n.ToList()
                    })*//*.ToList();
*/
                        /*var l = from lcp in data.Tables[0].AsEnumerable()
                                join ghe in data.Tables[1].AsEnumerable()
                                    on lcp.Field<int>("ID_LichChieu") equals ghe.Field<int>("ID_LichChieu")
                                select new LichChieuPhim()
                                {
                                    ID_LichChieu = lcp.Field<int>("ID_LichChieu"),
                                    ThoiGian = lcp.Field<string>("ThoiGianChieu"),
                                    DinhDang = lcp.Field<string>("TenDinhDang"),
                                    NgonNgu = lcp.Field<string>("NgonNgu"),
                                    TenPhong = lcp.Field<string>("TenPhong"),
                                    SoGheTrong = ghe.Field<int>("SoLuongVe")
                                };*//* into g
                                select new
                                {
                                    ID_LichChieu = g.Key.ID_LichChieu,
                                    DinhDang = g.Key.DinhDang,
                                    NgonNgu = g.Key.NgonNgu,
                                    ThongTin = g.ToList()
                                };*//*
                        var l = data.Tables[0].AsEnumerable().Join(
                                    data.Tables[1].AsEnumerable(),
                                    lcp => lcp.Field<int>("ID_LichChieu"),
                                    ghe => ghe.Field<int>("ID_LichChieu"),
                                (lcp, ghe) => new LichChieuPhim()
                                {
                                    ID_LichChieu = lcp.Field<int>("ID_LichChieu"),
                                    ThoiGian = lcp.Field<string>("ThoiGianChieu"),
                                    DinhDang = lcp.Field<string>("TenDinhDang"),
                                    NgonNgu = lcp.Field<string>("NgonNgu"),
                                    TenPhong = lcp.Field<string>("TenPhong"),
                                    SoGheTrong = ghe.Field<int>("SoLuongVe")
                                }); // ???? 0 đc
                        return l;
                    }*/
    }
}
