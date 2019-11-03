using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl;
using DTO;
using DAO;

namespace Book_Tickets_App
{
    public partial class Paying_Tickets : UserControl
    {
        //LichChieuPhim l;
        int tongTienThuong;
        int tongTienVIP;

        public Paying_Tickets()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            //l = Properties.Settings.Default.LichChieuPhim;

            picB_Poster.DataBindings.Add("BackgroundImage", Properties.Settings.Default.ChiTietPhim, 
                "Poster", true, DataSourceUpdateMode.Never);
            lb_TenPhim.Text = Properties.Settings.Default.ChiTietPhim.TenPhim;
            lb_DN.Text = Properties.Settings.Default.LichChieuPhim.DN;
            lb_ThoiGian.Text = Properties.Settings.Default.LichChieuPhim.ThoiGianChieu;
            lb_PhongSo.Text = Properties.Settings.Default.LichChieuPhim.TenPhong;
            lb_SoVe.Text =
                ( (String.IsNullOrEmpty(Properties.Settings.Default.GheThuong) ?
                    0 : Properties.Settings.Default.GheThuong.Split(',').Length )
                + (String.IsNullOrEmpty(Properties.Settings.Default.GheVIP) ?
                    0 : Properties.Settings.Default.GheVIP.Split(',').Length) )
                .ToString();
            lb_ViTriGhe.Text = 
                (String.IsNullOrEmpty(Properties.Settings.Default.GheThuong) ? "" : (Properties.Settings.Default.GheThuong + ","))
                + Properties.Settings.Default.GheVIP;
            lb_Rated.Text = Properties.Settings.Default.ChiTietPhim.Rated;

            /*foreach (SmallRound_Card item in flp_ptThanhToan.Controls)
            {
                item.Click += new EventHandler(card_MouseClick);
                //MessageBox.Show(item.Name);
            }*/
        }

        private void Paying_Tickets_Load(object sender, EventArgs e)
        {
            tongTienThuong = Convert.ToInt32(Booking_DAO.Ins.GetTongTien(
                Properties.Settings.Default.LichChieuPhim.ID_LichChieu,
                Properties.Settings.Default.LichChieuPhim.DN.Split('-')[0].Trim()
                ));
            tongTienVIP = tongTienThuong + 5000;
            lb_TongTien.Text =  ( (tongTienThuong + tongTienVIP) * Convert.ToInt32(lb_SoVe.Text) ).ToString() + " ₫";
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            Booking_DAO.Ins.BookingClient(new BookingClient() { 
                IDKhachHang = Properties.Settings.Default.UserId,
                ID_LichChieu = Properties.Settings.Default.LichChieuPhim.ID_LichChieu
                },
                Properties.Settings.Default.GheThuong,
                Properties.Settings.Default.GheVIP,
                tongTienThuong,
                tongTienVIP
            );
            MessageBox.Show("Giao dịch thành công");
            MessageBox.Show("Mô phỏng đến đây là kết thúc!");

            this.Parent.Controls.RemoveAt(0);
            //this.Parent.Controls.RemoveAt(1);
            //this.Parent.Controls.RemoveAt(2);
            this.Dispose();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void Card_Clicked(object sender, EventArgs e)
        {
            btn_XacNhan.Visible = true;
            foreach (SmallRound_Card item in flp_ptThanhToan.Controls)
            {
                item.BackColor = Color.FromArgb(248, 248, 248);
            }
            ((SmallRound_Card)sender).BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}
