﻿using System;
using System.Windows.Forms;
using DTO;

namespace CustomControl
{
    public partial class InforCard : UserControl
    {
        public InforCard()
        {
            InitializeComponent();
        }

        public InforCard(BookingDataClient b)
        {
            InitializeComponent();
            lb_TenPhim.Text = b.TenPhim;
            lb_MaVe.Text = "Mã vé: " + b.ID;
            lb_PhongSo.Text = "Phòng số " + b.TenPhong;
            lb_SoVe.Text = b.SoLuongVe + " vé";
            lb_Ghe.Text = "Ghế: " + b.MaGheNgoi;
            lb_TG.Text = "Thời gian: " + b.ThoiGianChieu;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10)); //play with these values till you are happy
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10)); //play with these values till you are happy
        }
    }
}
