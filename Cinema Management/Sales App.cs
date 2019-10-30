using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;
using CustomControl;
using System.IO;
using System.Reflection;

namespace Sales_App
{
    public partial class SalesForm : Form
    {
        ChiTietPhim chiTiet = new ChiTietPhim();
        LichChieuPhim lich = new LichChieuPhim();
        Lazy<SoDoPhong1> s1;
        Lazy<SoDoPhong2> s2;
        string GheThuong;
        string GheVIP;
        int tongTienThuong;
        int tongTienVIP;
        int rowIndex = 0;

        public SalesForm()
        {
            InitializeComponent();
            //menu_Account.Text = Properties.Settings.Default.NhanVien.Hoten;

            tP_ChonGhe.Hide();
            tP_LichChieu.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies(ref flp_DsPhim, "GetMovies", false);

            // Hiển thị các bộ phim - lv_DsPhim
        }

        #region Windows Methods
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // https://stackoverflow.com/questions/3501151/maximize-a-window-programmatically-and-prevent-the-user-from-changing-the-window
        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ?
                                    FormWindowState.Normal : FormWindowState.Maximized;
        }

        // C1
        // https://laptrinhvb.net/bai-viet/chuyen-de-csharp/---Csharp----Di-chuyen-form-khong-can-thanh-title-bar/e4bd0fe8d3df74f1.html
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Thả chuột, bắt bởi sự kiện mouse down
                header.Capture = false;

                // Tạo và gửi một message WM_NCLBUTTONDOWN
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message m = Message.Create(this.Handle // lấy cửa sổ bao quanh control
                                           , WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref m);
            }
        }

        // Cho phép ứng dụng thu nhỏ được khi click vào icon dưới taskbar
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        // C2
        // https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable

        #endregion

        #region Menu Tài khoản
        private void Mi_Account_Click(object sender, EventArgs e)
        {
            using (AccountForm form = new AccountForm())
                form.ShowDialog();
        }

        private void Mi_ChangeAcc_Click(object sender, EventArgs e)
        {
            using (LoginForm form = new LoginForm())
                form.ShowDialog();
        }

        private void Mi_SignOut_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Account_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White;
        }

        private void Menu_Account_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black;
        }

        private void menu_Account_DropDownOpened(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Black;
        }

        private void menu_Account_DropDownClosed(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.White;
        }
        #endregion

        #region Tab Lấy vé
        private void Btn_LayMaVe_Click(object sender, EventArgs e)
        {
            dgv_dlVe.DataSource = Booking_DAO.Ins.GetBooking(txB_MaVe.Text);
        }
        #endregion

        #region Tab Chọn ghế
        private void Btn_HuyGhe_Click(object sender, EventArgs e)
        {
            Btn_Huy_Click(sender, e);
            tabControl1.SelectedIndex = 0;
        }

        private void Btn_XacNhanGhe_Click(object sender, EventArgs e)
        {
            if (s1.IsValueCreated && s1.Value.SoGheDaChon > 0 && s1.Value.SoGheDaChon < 6)
            {
                GheThuong = String.Join(",", s1.Value.GheThuong.ToArray());
                GheVIP = String.Join(",", s1.Value.GheVIP.ToArray());
            }
            else if (s2.IsValueCreated && s2.Value.SoGheDaChon > 0 && s2.Value.SoGheDaChon < 6)
            {
                GheThuong = String.Join(",", s2.Value.GheThuong.ToArray());
                GheVIP = String.Join(",", s2.Value.GheVIP.ToArray());
            }
            else
            {
                MessageBox.Show("Chỉ được chọn tối đa 5 vé");
                return;
            }

            txB_ChonGhe.Text = String.Join(",", GheThuong, GheVIP);
            num_SlgVe.Value = 
                (String.IsNullOrWhiteSpace(GheThuong) ? 0 : GheThuong.Split(',').Length )
                + (String.IsNullOrWhiteSpace(GheVIP) ? 0 : GheVIP.Split(',').Length);
            //MessageBox.Show(GheThuong.Split(',').Length + " - " + GheVIP.Split(',').Length);

            lb_PhongSo.Text = lich.TenPhong;
            lb_Nhan.Text = chiTiet.Rated;

            txB_Dn.Text = lich.DN;

            tabControl1.SelectedIndex = 1;

            /*if (GheThuong.Length != 0)
            {
                dgv_dsDatVe.SelectedRows[0].Cells["col_SlgVe"].Value = GheThuong.Length;
                dgv_dsDatVe.SelectedRows[0].Cells["col_VeVIP"].Value = "không";
            }
            if (GheVIP.Length != 0)
            {
                dgv_dsDatVe.SelectedRows[0].Cells["col_SlgVe"].Value = GheVIP.Length;
                dgv_dsDatVe.SelectedRows[0].Cells["col_VeVIP"].Value = "có";
            }*/
        }
        #endregion

        #region Tab Bán vé
        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            dgv_dsDatVe.Rows.RemoveAt(dgv_dsDatVe.SelectedRows[0].Index);
        }

        private void btn_TinhTongTien_Click(object sender, EventArgs e)
        {
            tongTienThuong = Convert.ToInt32(Booking_DAO.Ins.GetTongTien(
                    lich.ID_LichChieu,
                    lich.DN.Split('-')[0].Trim()
                ));
            tongTienVIP = tongTienThuong + 5000;

            txB_TongTien.Text = ((tongTienThuong + tongTienVIP) * Convert.ToInt32(num_SlgVe.Text)).ToString();
        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {
            Booking_DAO.Ins.BookingPOS(new BookingClient()
            {
                ID_LichChieu = lich.ID_LichChieu
            },
                GheThuong,
                GheVIP,
                tongTienThuong,
                tongTienVIP
            );

            Btn_Huy_Click(sender, e);
        }

        private void Btn_Huy_Click(object sender, EventArgs e)
        {
            // Xóa hết dl trong dataGridView 'dgv_dsDatVe'
            // Quay lại tab 'Danh sách phim'
            dgv_dsDatVe.Rows.Clear();
            num_SlgVe.Value = 1;
            s1 = null;
            s2 = null;
            flp_Lich.Controls.Clear();
            flp_DsPhim.Controls.Clear();
            GheThuong = "";
            GheVIP = "";
        }

        private void Btn_ChonGhe_Click(object sender, EventArgs e)
        {
            tP_ChonGhe.Show();
            tabControl1.SelectedIndex = 3;
        }

        private void btn_ChooseTime_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            var lich = LC_PhimDAO.Ins.GetScheduleDate(
                    chiTiet.IDPhim,
                    dateTimePicker.Value.ToString("yyyy-MM-dd")
                    );

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

        private void CardClicked(object sender, EventArgs e)
        {
            chiTiet = ((ImageCard)sender).Tag as ChiTietPhim;
            ((ImageCard)sender).IsSelected = false;

            dgv_dsDatVe.Rows.Add(chiTiet.TenPhim);
            tabControl1.SelectedIndex = 1;
            txB_TenPhim.Text = chiTiet.TenPhim;
        }

        private void CardTimeClicked(object sender, EventArgs e)
        {
            ((SmallRound_TextCard)sender).IsSelected = false;
            lich = (LichChieuPhim)((SmallRound_TextCard)sender).Tag;
        }

        private void ShowRoom(string TenPhong)
        {
            switch (TenPhong)
            {
                case "1":
                    s1 = new Lazy<SoDoPhong1>(() => new SoDoPhong1(LC_PhimDAO.Ins.GetRoomSeat(lich.ID_LichChieu).Split(',')));
                    p_ChonGhe.Controls.Add(s1.Value);
                    s1.Value.Dock = DockStyle.None;
                    //s1.Value.Left = (this.ClientSize.Width - s1.Value.Width) / 2;
                    //s1.Value.Top = (this.ClientSize.Height - s1.Value.Height) / 2;
                    break;
                case "2":
                    s2 = new Lazy<SoDoPhong2>(() => new SoDoPhong2(LC_PhimDAO.Ins.GetRoomSeat(lich.ID_LichChieu).Split(',')));
                    p_ChonGhe.Controls.Add(s2.Value);
                    s2.Value.Dock = DockStyle.None;
                    //s2.Value.Left = (this.ClientSize.Width - s2.Value.Width) / 2;
                    //s2.Value.Top = (this.ClientSize.Height - s2.Value.Height) / 2;
                    break;
            }
        }
        #endregion

        private void LoadMovies(ref FlowLayoutPanel panel, string method, bool comingsoon)
        {
            //list = CT_Phim_BUS.Ins.GetMovies();

            // https://stackoverflow.com/questions/204468/invoking-a-method-using-reflection-on-a-singleton-object
            MethodInfo methodInfo = CT_Phim_DAO.Ins.GetType().GetMethod(method);
            foreach (var item in methodInfo.Invoke(CT_Phim_DAO.Ins, new object[] { comingsoon }) as IEnumerable<ChiTietPhim>)
            {
                ImageCard c = new ImageCard();
                c.Tag = item;
                c.TitleText = item.TenPhim;
                c.Minutes = item.ThoiLuong.ToString() + " phút";
                c.RatedText = item.Rated;
                MemoryStream m = new MemoryStream(item.Poster);
                c.CardImage = Image.FromStream(m);
                c.Margin = new Padding(30);
                c.WasClicked += CardClicked;
                panel.Controls.Add(c);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    var lich = LC_PhimDAO.Ins.GetScheduleDate(
                    chiTiet.IDPhim,
                    dateTimePicker.Value.ToString("yyyy-MM-dd"));

                    var g = lich.ToLookup(l => l.DN, t => t);
                    foreach (var item in g)
                    {
                        ScheduleCard card = new ScheduleCard();
                        card.Title = item.Key;
                        foreach (LichChieuPhim l in item)
                            card.AddCard(l, new EventHandler<EventArgs>(CardTimeClicked));

                        flp_Lich.Controls.Add(card);
                    }
                    break;
                case 3:
                    ShowRoom(this.lich.TenPhong);
                    break;
            }
        }

        private void btn_XacNhanLich_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //dgv_dsDatVe.Rows[dgv_dsDatVe.SelectedRows[0].Index].Cells["col_ThoiGian"].Value = lich.ThoiGianChieu;
            txB_Time.Text = lich.ThoiGianChieu;
        }

        private void dgv_dsDatVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // https://www.codeproject.com/Questions/290036/how-to-bind-textbox-with-datagridview
            //txB_Time.DataBindings.Add("Text", dgv_dsDatVe[1, e.RowIndex], "Value", false);

            dgv_dsDatVe.Rows[e.RowIndex].Cells[4].Value = txB_Time.Text;
            dgv_dsDatVe.Rows[e.RowIndex].Cells[2].Value = txB_ChonGhe.Text;
            dgv_dsDatVe.Rows[e.RowIndex].Cells[1].Value = num_SlgVe.Value;

            rowIndex = e.RowIndex;
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            dgv_dlVe.Rows[rowIndex].Selected = true;
            dgv_dsDatVe_CellClick(sender, e as DataGridViewCellEventArgs);
        }

        private void txB_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            txB_TienDu.Text = (Convert.ToInt32(txB_TienKhachTra.Text) - Convert.ToInt32(txB_TongTien.Text)).ToString();
        }
    }
}
