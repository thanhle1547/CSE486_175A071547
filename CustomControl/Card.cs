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
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
            //Title.Font = new Font("Roboto", 13, FontStyle.Bold);
            Panel.Paint += drawBorder;
        }

        private void drawBorder(object sender, PaintEventArgs e) // dropShadow
        {
            /*Panel panel = (Panel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }*/

            // https://stackoverflow.com/a/20997144
            //e.Graphics.DrawRectangle(new Pen(BorderColor), new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1));

            // https://vicky4147.wordpress.com/2007/03/04/how-to-draw-a-custom-border-around-a-form-or-control/
            ControlPaint.DrawBorder(e.Graphics, this.Panel.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        public Color BorderColor { get => borderBotom.BackColor; set => borderBotom.BackColor = value; }

        public Image PictureImage { get => Picture.Image; set => Picture.Image = value; }
        public PictureBoxSizeMode PictureSizeMode { get => Picture.SizeMode; set => Picture.SizeMode = value; }
        public Color PictureBackColor { get => Picture.BackColor; set => Picture.BackColor = value; }
        public Image PictureBackImage { get => Picture.BackgroundImage; set => Picture.BackgroundImage = value; }
        public ImageLayout PicBackImgLayout { get => Picture.BackgroundImageLayout; set => Picture.BackgroundImageLayout = value; }

        public string TitleText { get => Title.Text; set => Title.Text = value; }
        public Color TitleColor { get => Title.ForeColor; set => Title.ForeColor = value; }
        public Font TitleFont { get => Title.Font; set => Title.Font = value; }

        public string ContentText { get => Content.Text; set => Content.Text = value; }
        public Color ContentColor { get => Content.ForeColor; set => Content.ForeColor = value; }
        public Font ContentFont { get => Content.Font; set => Content.Font = value; }
    }
}
