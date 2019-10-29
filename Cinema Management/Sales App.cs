﻿using System;
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

namespace Sales_App
{
    public partial class SalesForm : Form
    {
        public SalesForm(/*string hoTenNv*/)
        {
            InitializeComponent();
            //menu_Account.Text = hoTenNv;

            tP_ChonGhe.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

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

        }
        #endregion

        #region Tab Chọn ghế
        private void Btn_HuyGhe_Click(object sender, EventArgs e)
        {

        }

        private void Btn_XacNhanGhe_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tab Bán vé
        private void Btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Huy_Click(object sender, EventArgs e)
        {
            // Xóa hết dl trong dataGridView 'dgv_dsDatVe'
            // Quay lại tab 'Danh sách phim'
            dgv_dsDatVe.Rows.Clear();
            num_SlgVe.Value = 1;
        }

        private void Btn_ChonGhe_Click(object sender, EventArgs e)
        {
            tP_ChonGhe.Show();
        }
        #endregion

    }
}
