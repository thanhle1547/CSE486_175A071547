using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sales_App
{
    public partial class AccountForm : Form
    {
        #region UI
        // Windows Form Rounded Corners
        // https://www.youtube.com/watch?v=LE3y5a0G4JA&list=PL-Hz3r18ypmjCbdlIBlO9_nROQHrwbdOo&index=4&t=0s
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // Drop Shadow On A Borderless WinForm
        // https://stackoverflow.com/a/16495142
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // Make a borderless form movable?
        // https://stackoverflow.com/a/1592899
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        public AccountForm()
        {
            InitializeComponent();
            while(true)
                try
                {
                    this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9));
                    break;
                }
                catch (Exception e)
                {

                }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {

        }

        #region Đổi tên
        private void Btn_Huy_Ten_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Td_Ten_Click(object sender, EventArgs e)
        {

        }

        private void CkB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Đổi mật khẩu
        private void Btn_Huy_MK_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Td_MK_Click(object sender, EventArgs e)
        {

        }

        private void LollipopCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
