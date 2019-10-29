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
    // https://github.com/SaLaaRHuSyN/AddTextUsingButtons/blob/master/RoundButtonDemo/Button_WOC.cs

    public partial class Round_Button : Button
    {
        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        //private int _borderThickness = 6;
        //private int _borderThicknessByTwo = 3;
        private float _borderThickness = (float)3.3; // 3.6
        private float _borderThicknessByTwo = (float)1.4; //1.5

        private Color _BackColor = Color.Transparent;
        //private Image _imgOnMouse;
        //private ContentAlignment _imgOnMouseAlign;
        private Image _ButtonImage;
        private ContentAlignment _ButtonImageAlign = ContentAlignment.MiddleLeft;


        public Round_Button()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };

            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);

            //Border
            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            //Inner part. Button itself
            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
                Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            //Button Text
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);

            // Button Img
            //if (Image != null)
            //g.DrawImage(ImgOnMouse, 
            //    ( Convert.ToInt32(ImgOnMouseAlign.ToString()) / 2) + 2 ,
            //    ( Convert.ToInt32(ImgOnMouseAlign.ToString()) / 2) + 2 );\
            //if (Image != null)
            //    g.DrawImage(Image,
            //        ((int)(ImageAlign.GetTypeCode()) / 2) + 6,
            //        ((int)(ImageAlign.GetTypeCode()) / 2) + 6);
            /*if (Image != null)
                g.DrawImage(Image,
                    ((int)(ImageAlign.GetTypeCode()) / 2) + 6,
                    ((int)(ImageAlign.GetTypeCode()) / 2) + 6); // chưa biết con số phụ thuộc*/

            /*TopLeft = 1,
            TopCenter = 2,
            TopRight = 4,
            MiddleLeft = 16,
            MiddleCenter = 32,
            MiddleRight = 64,
            BottomLeft = 256,
            BottomCenter = 512,
            BottomRight = 1024*/

            /*if (ButtonImage != null)
            {
                // https://www.doogal.co.uk/transparent.php

                float top = 8; // 0
                switch (ButtonImageAlign)
                {
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.MiddleRight:
                        top = (Height - ButtonImage.Height) / 2;
                        break;
                    case ContentAlignment.BottomLeft:
                    case ContentAlignment.BottomCenter:
                    case ContentAlignment.BottomRight:
                        top = Height - ButtonImage.Height;
                        break;
                }

                float left = 8; // -1
                switch (ButtonImageAlign)
                {
                    case ContentAlignment.TopLeft:
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.BottomLeft:
                        if (RightToLeft == RightToLeft.Yes)
                            left = Width - ButtonImage.Width;
                        else
                            left = 8; // -1
                        break;
                    case ContentAlignment.TopCenter:
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.BottomCenter:
                        left = (Width - ButtonImage.Width) / 2;
                        break;
                    case ContentAlignment.TopRight:
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.BottomRight:
                        if (RightToLeft == RightToLeft.Yes)
                            left = 8; // -1
                        else
                            left = Width - ButtonImage.Width;
                        break;
                }


                g.DrawImage(ButtonImage, top, left);*/


            /*// https://icodebroker.tistory.com/3975
            if (ButtonImage != null)
            {
                Rectangle rectangle = new Rectangle(11, 11, ButtonImage.Width, ButtonImage.Height);
                switch (ButtonImageAlign)
                {

                    case ContentAlignment.TopCenter:
                        rectangle = new Rectangle(Width / 2 - ButtonImage.Width / 2, 11, ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.TopRight:
                        rectangle = new Rectangle(Width - 11 - ButtonImage.Width, 11, ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.MiddleLeft:
                        rectangle = new Rectangle(11, Height / 2 - ButtonImage.Height / 2, ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.MiddleCenter:
                        rectangle = new Rectangle(Width / 2 - ButtonImage.Width / 2, Height / 2 - ButtonImage.Height / 2,
                            ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.MiddleRight:
                        rectangle = new Rectangle(Width - 11 - ButtonImage.Width, Height / 2 - ButtonImage.Height / 2,
                            ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.BottomLeft:
                        rectangle = new Rectangle(11, Height - 11 - ButtonImage.Height, ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.BottomCenter:
                        rectangle = new Rectangle(Width / 2 - ButtonImage.Width / 2, Height - 11 - ButtonImage.Height,
                            ButtonImage.Width, ButtonImage.Height);
                        break;
                    case ContentAlignment.BottomRight:
                        rectangle = new Rectangle(Width - 11 - ButtonImage.Width, Height - 11 - ButtonImage.Height,
                            ButtonImage.Width, ButtonImage.Height);
                        break;
                }
                g.DrawImage(ButtonImage, rectangle); 
            }*/

            /*
                O   -->     x ~ left
                |
                y ~ top
            */
            // https://icodebroker.tistory.com/3975
            if (ButtonImage != null)
            {
                float top = 10f; //8
                float left = 10f; // 8
                switch (ButtonImageAlign)
                {
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.MiddleRight:
                        top = Height / 2 - ButtonImage.Height / 2;
                        break;
                    case ContentAlignment.BottomLeft:
                    case ContentAlignment.BottomCenter:
                    case ContentAlignment.BottomRight:
                        top = Height - top - ButtonImage.Height;
                        break;
                }
                switch (ButtonImageAlign)
                {
                    //case ContentAlignment.TopLeft:
                    //case ContentAlignment.MiddleLeft:
                    //case ContentAlignment.BottomLeft:
                        //if (RightToLeft == RightToLeft.Yes)
                        //    left = left;
                        //break;
                    case ContentAlignment.TopCenter:
                    case ContentAlignment.MiddleCenter:
                    case ContentAlignment.BottomCenter:
                        if (RightToLeft != RightToLeft.Yes)
                            left = Width / 2 - ButtonImage.Width / 2;
                        break;
                    case ContentAlignment.TopRight:
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.BottomRight:
                        if (RightToLeft != RightToLeft.Yes)
                            left = Width - left - ButtonImage.Width;
                        break;
                }
                //g.DrawImage(ButtonImage, top, left);
                g.DrawImage(ButtonImage, new Rectangle((int)left, (int)top, ButtonImage.Width, ButtonImage.Height) );
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Invalidate();
        }

        /*protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseHover(e);
            this.BackColor = Color.Transparent;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = _BackColor;
        }*/

        protected override void OnMouseHover(EventArgs e)
        {
            this.BackColor = _BackColor;
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }

        public Image ButtonImage { get => _ButtonImage; set { _ButtonImage = value; Invalidate(); } }
        public ContentAlignment ButtonImageAlign { get => _ButtonImageAlign; set { _ButtonImageAlign = value; Invalidate(); } }

        //public Image ImgOnMouse { get => _imgOnMouse; set => _imgOnMouse = value; }
        //public ContentAlignment ImgOnMouseAlign { get => _imgOnMouseAlign; set => _imgOnMouseAlign = value; }
    }
}
