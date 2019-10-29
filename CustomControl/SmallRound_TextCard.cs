using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class SmallRound_TextCard : UserControl
    {
        private int cornerRadius = 15;
        //public delegate void EventHandler(object sender, MouseEventArgs e);
        public event EventHandler<EventArgs> WasClicked;

        public SmallRound_TextCard()
        {
            InitializeComponent();
        }

        private void SmallRound_TextCard_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                control.MouseClick += SmallRound_TextCard_MouseClick;
        }

        private void SmallRound_TextCard_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
                WasClicked(this, EventArgs.Empty);
            // Select this UC on click.
            IsSelected = true;
        }

        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                if (value < 0) throw new ArgumentException("Value must > 0");
                cornerRadius = value;
                Refresh();
            }
        }

        public bool IsSelected { get; set; }
        public string ThoiGian { get => lb_ThoiGian.Text; set => lb_ThoiGian.Text = value; }
        public string GheTrong { get => lb_GheTrong.Text; set => lb_GheTrong.Text = value; }

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
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 12, 12)); //play with these values till you are happy
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 12, 12)); //play with these values till you are happy
        }

        private void SmallRound_TextCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void SmallRound_TextCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
