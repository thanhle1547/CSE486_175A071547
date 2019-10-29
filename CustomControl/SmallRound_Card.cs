using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace CustomControl
{
    public partial class SmallRound_Card : UserControl
    {
        private Color hoverColor = Color.FromArgb(248, 248, 248);
        private Color colorBack = Color.White;
        public event EventHandler<EventArgs> WasClicked;

        // https://www.youtube.com/watch?v=LE3y5a0G4JA
        public SmallRound_Card()
        {
            InitializeComponent();
            //this.BorderStyle = BorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius));
            //picture.Region -> dùng picturebox thay thế
        }

        private void SmallRoundCard_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
                WasClicked(this, EventArgs.Empty);
            // Select this UC on click.
            IsSelected = true;
        }

        private void SmallRound_Card_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = hoverColor;
        }

        private void SmallRound_Card_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = colorBack;
        }

        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value < 0) throw new ArgumentException("Value must > 0");
                radius = value;
                Invalidate();
            }
        }
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

        private void SmallRound_Card_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            //    Color.Black, 3, ButtonBorderStyle.Solid,
            //    Color.Black, 3, ButtonBorderStyle.Solid,
            //    Color.Black, 3, ButtonBorderStyle.Solid,
            //    Color.Black, 3, ButtonBorderStyle.Solid);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Refresh();
        }

        private void picture_Validating(object sender, CancelEventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius));
        }

        /*
        private int cornerRadius = 15;
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                if (value < 0) throw new ArgumentException("Value must > 0");
                cornerRadius = value;
                Refresh();
            }
        }*/

        public bool IsSelected { get; set; }
        public Color HoverColor { get => hoverColor; set => hoverColor = value; }
        public Color ColorBack { get => colorBack; set => colorBack = value; }
        public Image Picture { get => picture.BackgroundImage; set => picture.BackgroundImage = value; }

        //public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
    }
}
