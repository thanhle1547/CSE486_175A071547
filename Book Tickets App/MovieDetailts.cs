using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using BUS;
using CustomControl;

namespace Book_Tickets_App
{
    public partial class MovieDetailts : UserControl
    {
        ChiTietPhim chiTiet = new ChiTietPhim();
        LichChieuPhim lich;

        public MovieDetailts()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //this.Load += MovieDetailts_Load;

            lb_TenPhim.Text = Properties.Settings.Default.ChiTietPhim.TenPhim;
            lb_ThoiLuong.Text = Properties.Settings.Default.ChiTietPhim.ThoiLuong.ToString() + " phút";
            lb_XepLoai.Text = Properties.Settings.Default.ChiTietPhim.Rated;

            /*lb_TenPhim.DataBindings.Add("Text", lich, "TenPhim", false, DataSourceUpdateMode.Never);
            lb_ThoiLuong.DataBindings.Add("Text", lich, "TenPhim", false, DataSourceUpdateMode.Never);
            lb_XepLoai.DataBindings.Add("Text", lich, "TenPhim", false, DataSourceUpdateMode.Never);*/

            picB_Poster.DataBindings.Add("BackgroundImage", 
                Properties.Settings.Default.ChiTietPhim, "Poster", true, DataSourceUpdateMode.Never);
            Load_MovieDetailts(CT_Phim_DAO.Ins.GetMovie_Details(Properties.Settings.Default.ChiTietPhim.IDPhim, false));
        }

        // Form constructor vs Form_Load
        // https://stackoverflow.com/questions/2623808/form-constructor-vs-form-load
        private void MovieDetailts_Load(object sender, EventArgs e)
        {
            Load_Schedule();
        }

        private void Load_Schedule()
        {
            //MessageBox.Show(dateTimePicker.Value.ToString("yyyy-MM-dd"));

            var lich = LC_PhimDAO.Ins.GetScheduleDate(
                    Properties.Settings.Default.ChiTietPhim.IDPhim,
                    dateTimePicker.Value.ToString("yyyy-MM-dd"));

            /*// https://stackoverflow.com/a/2245460
            // https://stackoverflow.com/a/7325306
            foreach (var p in lich.GroupBy(d => new { d.DinhDang, d.NgonNgu })
                        .Select(l => new {
                            DN = l.Key.DinhDang + " - " + l.Key.NgonNgu,
                            ThongTin = l.ToList()
                        }))
            {
                ScheduleCard card = new ScheduleCard();
                //card.Title = string.Join(" - ", p.DinhDang, p.NgonNgu);
                card.Title = p.DN;
                foreach (var l in p.ThongTin)
                    card.AddCard(l.ThoiGian, l.SoGheTrong, l, new EventHandler<EventArgs>(CardClicked));

                flp_Lich.Controls.Add(card);
            }*/

            var g = lich.ToLookup(l => l.DN, t => t);
            foreach (var item in g)
            {
                ScheduleCard card = new ScheduleCard();
                //card.Title = string.Join(" - ", p.DinhDang, p.NgonNgu);
                card.Title = item.Key;
                foreach (LichChieuPhim l in item)
                    card.AddCard(l, new EventHandler<EventArgs>(CardClicked));

                flp_Lich.Controls.Add(card);
            }
        }

        private void Load_MovieDetailts(ChiTietPhim infor) //(object sender, EventArgs e)
        {
            /*chiTiet.DaoDien = infor.DaoDien;
            chiTiet.DienVien = infor.DienVien;
            chiTiet.TheLoai = infor.TheLoai;
            chiTiet.KhoiChieu = infor.KhoiChieu;
            chiTiet.NgonNgu = infor.NgonNgu;
            chiTiet.MoTa = infor.MoTa;
            chiTiet.DinhDang = infor.DinhDang;
            MessageBox.Show(infor.KhoiChieu);*/

            lb_DaoDien.Text = Properties.Settings.Default.ChiTietPhim.DaoDien = infor.DaoDien;
            lb_DienVien.Text = Properties.Settings.Default.ChiTietPhim.DaoDien = infor.DienVien;
            lb_TheLoai.Text = Properties.Settings.Default.ChiTietPhim.DaoDien = infor.TheLoai;
            lb_KhoiChieu.Text = Convert.ToDateTime(infor.KhoiChieu).ToString("dd-MM-yyyy");
            lb_NgonNgu.Text = Properties.Settings.Default.ChiTietPhim.DaoDien = infor.NgonNgu;
            lb_MoTa.Text = infor.MoTa;
            lb_DinhDang.Text = Properties.Settings.Default.ChiTietPhim.DaoDien =  infor.DinhDang;
        }

        /*private void Show()
        {
            //lb_TenPhim.Text = chiTiet.TenPhim;
            lb_DaoDien.Text = chiTiet.DaoDien;
            lb_DienVien.Text = chiTiet.DienVien;
            lb_TheLoai.Text = chiTiet.TheLoai;
            lb_KhoiChieu.Text = chiTiet.KhoiChieu;
            //lb_ThoiLuong.Text = chiTiet.ThoiLuong.ToString();
            lb_NgonNgu.Text = chiTiet.NgonNgu;
            //lb_XepLoai.Text = chiTiet.Rated;
            lb_MoTa.Text = chiTiet.MoTa;
        }*/

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LichChieuPhim = lich;
            PickingSeat form = new PickingSeat();
                this.Parent.Controls.Add(form);
                form.BringToFront();
            //header.Visible = false;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
            //this.Parent.Dispose();
        }

        private void CardClicked(object sender, EventArgs e)
        {
            //MessageBox.Show(((SmallRound_TextCard)sender).IsSelected.ToString());
            btn_DatVe.Visible = true;
            ((SmallRound_TextCard)sender).IsSelected = false;
            lich = (LichChieuPhim)((SmallRound_TextCard)sender).Tag;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            flp_Lich.Controls.Clear();
            Load_Schedule();
        }

        private void flp_Lich_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is SmallRound_TextCard)
            {
                foreach (SmallRound_TextCard c in flp_Lich.Controls)
                    c.BackColor = Color.White;
                ((SmallRound_TextCard)sender).BackColor = Color.WhiteSmoke; 
            }
        }

        public string TenPhim { get => lb_TenPhim.Text; set => lb_TenPhim.Text = value; }
        public string DaoDien { get => lb_DaoDien.Text; set => lb_DaoDien.Text = value; }
        public string DienVien { get => lb_DienVien.Text; set => lb_DienVien.Text = value; }
        public string TheLoai { get => lb_TheLoai.Text; set => lb_TheLoai.Text = value; }
        public string KhoiChieu { get => lb_KhoiChieu.Text; set => lb_KhoiChieu.Text = value; }
        public string ThoiLuong { get => lb_ThoiLuong.Text; set => lb_ThoiLuong.Text = value; }
        public string NgonNgu { get => lb_NgonNgu.Text; set => lb_NgonNgu.Text = value; }
        public string XepLoai { get => lb_XepLoai.Text; set => lb_XepLoai.Text = value; }
        public string MoTa { get => lb_MoTa.Text; set => lb_MoTa.Text = value; }
        public string DinhDang { get => lb_DinhDang.Text; set => lb_DinhDang.Text = value; }

        /*private string TenPhim { get; set; }
        private string DaoDien { get; set; }
        private string DienVien { get; set; }
        private string TheLoai { get; set; }
        private string KhoiChieu { get; set; }
        private string ThoiLuong { get; set; }
        private string NgonNgu { get; set; }
        private string XepLoai { get; set; }
        private string MoTa { get; set; }
        private string DinhDang { get; set; }*/
    }
}
