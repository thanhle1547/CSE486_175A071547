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
using CustomControl;
using System.Reflection;

namespace Book_Tickets_App
{
    public partial class PickingSeat : UserControl
    {
        LichChieuPhim phim;
        Lazy<SoDoPhong1> s1;
        Lazy<SoDoPhong2> s2;
        public PickingSeat()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.phim = Properties.Settings.Default.LichChieuPhim;
        }

        private void PickingSeat_Load(object sender, EventArgs e)
        {
            ShowRoom(phim.TenPhong);
        }

        private void ShowRoom(string TenPhong)
        {
            switch (TenPhong)
            {
                case "1":
                    s1 = new Lazy<SoDoPhong1>(() => new SoDoPhong1(LC_PhimDAO.Ins.GetRoomSeat(phim.ID_LichChieu).Split(',')) );
                    container.Controls.Add(s1.Value);
                    //s1.Value.Left = (this.ClientSize.Width - s1.Value.Width) / 2;
                    //s1.Value.Top = (this.ClientSize.Height - s1.Value.Height) / 2;
                    break;
                case "2":
                    s2 = new Lazy<SoDoPhong2>(() => new SoDoPhong2(LC_PhimDAO.Ins.GetRoomSeat(phim.ID_LichChieu).Split(',')));
                    container.Controls.Add(s2.Value);
                    //s2.Value.Left = (this.ClientSize.Width - s2.Value.Width) / 2;
                    //s2.Value.Top = (this.ClientSize.Height - s2.Value.Height) / 2;
                    break;
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Controls.Remove(this);
            //this.Parent.Controls.Find("header", false)[0].Visible = true;
            this.Dispose();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(s1.IsValueCreated.ToString());

            if (s1.IsValueCreated && s1.Value.SoGheDaChon > 0 && s1.Value.SoGheDaChon < 6)
            {
                Properties.Settings.Default.GheThuong = String.Join(",", s1.Value.GheThuong.ToArray());
                Properties.Settings.Default.GheVIP = String.Join(",", s1.Value.GheVIP.ToArray());
            }
            else if (s2.IsValueCreated && s2.Value.SoGheDaChon > 0 && s2.Value.SoGheDaChon < 6)
            {
                Properties.Settings.Default.GheThuong = String.Join(",", s2.Value.GheThuong.ToArray());
                Properties.Settings.Default.GheVIP = String.Join(",", s2.Value.GheVIP.ToArray());
            }
            else
            {
                MessageBox.Show("Chỉ được chọn tối đa 5 vé");
                return;
            }
            Paying_Tickets form = new Paying_Tickets();
                this.Parent.Controls.Add(form);
                form.Show();
                form.BringToFront();
        }
    }
}
