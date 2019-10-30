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

namespace Manage_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // C# - Adding a Simple Drop Shadow in Borderless WinForm
        // https://www.youtube.com/watch?v=UoYD_6VgazE
        private const int FORM_Shadow = 0x00020000; // 0x00020000

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= FORM_Shadow;
                return cp;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txB_UserName.Text) || String.IsNullOrWhiteSpace(txB_Pass.Text))
                return;
            try
            {
                NhanVien nv = AccountNV_BUS.Ins.Login(txB_UserName.Text, txB_Pass.Text);
                if (nv.ChucVu == "Saler")
                {
                    MessageBox.Show("Bạn không có quyền!");
                    return;
                }

                if (nv.ID.ToString() != "")
                {
                    Properties.Settings.Default.NhanVien = nv;
                    Manage form = new Manage();
                    this.Hide();
                    form.Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Lỗi đăng nhập");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ckB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txB_Pass.UseSystemPasswordChar = ckB_ShowPass.Checked;
        }
    }
}
