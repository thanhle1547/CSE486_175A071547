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

namespace Manage_App
{
    public partial class Manage : Form
    {
        int menuWidth = 275;
        int menuAcc_H = 159;
        bool isCollapsed = true;
        bool isSubmColl = true;
        Timer Menu_timer;
        Timer SubMenu_timer;
        public Manage()
        {
            InitializeComponent();
            //MoviesList f = new MoviesList();
            //Customer f = new Customer();
            Statistic f = new Statistic();
            container.Controls.Add(f);

            //SubMenu_timer = new Timer();
            //SubMenu_timer.Tick += SubMenu_timer_Tick;
            //SubMenu_timer.Interval = 30;
        }

        #region Menu Animation
        // https://www.youtube.com/watch?v=MLxmaYhu-d4
        private void Menu_timer_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                p_menu.Width += 10;
                if (p_menu.Width >= menuWidth)
                {
                    Menu_timer.Stop();
                    p_menu.Width = menuWidth;
                    isCollapsed = false;
                    Menu_timer.Dispose();
// https://social.msdn.microsoft.com/Forums/en-US/689b820c-e59b-473e-9af5-b9d862c05fb2/difference-between-invalidate-and-refresh?forum=netfxcompact
                    this.Refresh(); // forces an immediate redraw of the control (and its children)
                    // this.Invalidate(); // basically instruct the OS to redraw the contol. This does not happen immediatly
                }
            }
            else
            {
                p_menu.Width -= 10;
                if (p_menu.Width <= 70)
                {
                    Menu_timer.Stop();
                    p_menu.Width = 70;
                    Menu_timer.Dispose();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void SubMenu_timer_Tick(object sender, EventArgs e)
        {
            if (isSubmColl)
            {
                p_MenuAcc.Height += 48;
                if (p_MenuAcc.Height >= menuAcc_H)
                {
                    SubMenu_timer.Stop();
                    p_MenuAcc.Height = menuAcc_H;
                    isSubmColl = false;
                    SubMenu_timer.Dispose();
                    this.Refresh();
                }
            }
            else
            {
                p_MenuAcc.Height -= 48;
                if (p_MenuAcc.Height <= 10)
                {
                    SubMenu_timer.Stop();
                    p_MenuAcc.Height = 10;
                    isSubmColl = true;
                    SubMenu_timer.Dispose();
                    this.Refresh();
                }
            }
        }

        private void btn_Memu_Click(object sender, EventArgs e)
        {
            Menu_timer = new Timer();
            Menu_timer.Interval = 10;
            Menu_timer.Tick += new EventHandler(Menu_timer_Tick);
            Menu_timer.Start();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            SubMenu_timer = new Timer();
            SubMenu_timer.Interval = 20;
            SubMenu_timer.Tick += new EventHandler(SubMenu_timer_Tick);
            SubMenu_timer.Start();
            //MessageBox.Show(p_MenuAcc.Size.Height.ToString());
        }
        #endregion

        #region Menu
        // https://laptrinhvb.net/bai-viet/chuyen-de-csharp/---Csharp----Tu-dong-load-user-control-vao-form-(Master-layout--Csharp-)/f9f898376d51841a.html

        private void btn_DsKH_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Customer.Ins))
                container.Controls.Add(Customer.Ins);
            Customer.Ins.BringToFront();
        }

        private void btn_LichChieu_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Schedule.Ins))
                container.Controls.Add(Schedule.Ins);
            Schedule.Ins.BringToFront();
        }

        private void btn_DsNV_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Personnel.Ins))
                container.Controls.Add(Personnel.Ins);
            Personnel.Ins.BringToFront();
        }

        private void btn_DsPhim_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(MoviesList.Ins))
                container.Controls.Add(MoviesList.Ins);
            MoviesList.Ins.BringToFront();
        }

        private void btn_TkNV_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(AccPersonnel.Ins))
                container.Controls.Add(AccPersonnel.Ins);
            AccPersonnel.Ins.BringToFront();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Statistic.Ins))
                container.Controls.Add(Statistic.Ins);
            Statistic.Ins.BringToFront();
        }
        #endregion

        #region SubMenu Tài khoản
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChangeAcc_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
