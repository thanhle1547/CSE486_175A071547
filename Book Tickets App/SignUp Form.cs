using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace Book_Tickets_App
{
    public partial class SignUp_Form : Form
    {
        KhachHang kh = new KhachHang();
        Account_KH a;
        bool isChanged;
        public SignUp_Form()
        {
            InitializeComponent();
            txB_UserName.Focus();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                a = new Account_KH()
                {
                    UserName = txB_UserName.Text,
                    Password = txB_Pass.Text
                };
                kh.Hoten = String.IsNullOrWhiteSpace(txB_HoTen.Text) ? "" : txB_HoTen.Text;
                kh.GioiTinh = rbtn_Nam.Checked ? "Nam" : rbtn_Nu.Checked ? "Nữ" : "";
                if (!isChanged)
                    kh.NgaySinh = dtp_NgaySinh.Value.ToString("yyyy-MM-dd");

                Properties.Settings.Default.UserId =
                    AccountKH_DAO.Ins.SignUp(a, kh);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message); // Lỗi kết nối tới Server. Vui lòng thử lại!\n
            }
        }

        private void dtp_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            kh.NgaySinh = dtp_NgaySinh.Value.ToString("yyyy-MM-dd");
            isChanged = true;
        }

        private void txB_PassAgaint_Validated(object sender, EventArgs e)
        {
            if (txB_Pass.Text != txB_PassAgaint.Text)
            {
                btn_SignUp.Enabled = false;
                MessageBox.Show("Mật khẩu không chính xác!");
            }
            btn_SignUp.Enabled = true;
        }
    }
}
