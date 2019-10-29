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

namespace CustomControl
{
    public partial class ScheduleCard : UserControl
    {
        public ScheduleCard()
        {
            InitializeComponent();
        }

        public void AddCard (LichChieuPhim phim, EventHandler<EventArgs> _event)
        {
            SmallRound_TextCard card = new SmallRound_TextCard();
            card.ThoiGian = DateTime.Parse(phim.ThoiGianChieu).ToString("HH:mm");
            card.GheTrong = phim.SoGheTrong + " ghế trống";
            card.Tag = phim;
            card.Margin = new Padding(15, 3, 15, 10);
            card.WasClicked += _event;

            flp_ThoiGian.Controls.Add(card);
        }

        public string Title { get => lb_Title.Text; set => lb_Title.Text = value; }
    }
}
