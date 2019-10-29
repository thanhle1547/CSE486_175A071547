using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace CustomControl
{
    public partial class Rounded_TextBox : TextBox
    {
        public Rounded_TextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            BorderStyle = BorderStyle.None;
        }

        // https://stackoverflow.com/questions/56519392/how-can-i-draw-a-rounded-rectangle-as-the-border-for-a-rounded-form
        private Color m_InternalBorderColor = Color.FromArgb(128, 128, 128);
        private Color m_BorderColor = Color.DimGray;
        private Color m_HoverBorderColor = Color.Fuchsia;
        private Color m_FocusBorderColor = Color.Fuchsia;
        private Color m_FillColor = Color.White;
        private float m_PenSize = 1f; // 6f;
        private float m_CurveAngle = 5f; // 60.0f;
        internal float m_PenSizeOffset = 0.5f; // 3f;
        private bool _isHovering = false;
        private bool _isFocusing = false;

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(10f)] //60.0f
        public virtual float CurveAngle
        {
            get => this.m_CurveAngle;
            set
            {
                this.m_CurveAngle = Math.Max(Math.Min(value, 180), 15);
                Invalidate();
            }
        }
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(1.0f)] // 6.0f
        public virtual float BorderSize
        {
            get => this.m_PenSize;
            set
            {
                this.m_PenSize = value;
                this.m_PenSizeOffset = value / 2.0f;
                this.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor
        {
            get => this.m_BorderColor;
            set
            {
                this.m_BorderColor = value;
                this.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverBorderColor
        {
            get => m_HoverBorderColor;
            set => m_HoverBorderColor = value;
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FocusBorderColor
        {
            get => m_FocusBorderColor;
            set => m_FocusBorderColor = value;
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color FillColor
        {
            get => this.m_FillColor;
            set
            {
                this.m_FillColor = value;
                this.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Get or Set the Color of the internal border")]
        public virtual Color InternalBorderColor
        {
            get => this.m_InternalBorderColor;
            set
            {
                this.m_InternalBorderColor = value;
                this.Invalidate();
            }
        }


        private GraphicsPath pathRegion = new GraphicsPath(FillMode.Winding);
        private GraphicsPath pathBorder;
        //Point pMousePosition = Point.Empty;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            RoundedCornerRectangle(this.ClientRectangle);
            RectangleF rect = pathRegion.GetBounds();
            float scaleX = 1 - (BorderSize / rect.Width);
            float scaleY = 1 - (BorderSize / rect.Height);
            using (Pen pen = new Pen(_isHovering ? m_HoverBorderColor : _isFocusing ? m_FocusBorderColor : m_BorderColor, BorderSize))
            using (Pen penBorder = new Pen(InternalBorderColor, 2))
            using (Brush brush = new SolidBrush(FillColor))
            using (Matrix mx = new Matrix(scaleX, 0, 0, scaleY, (pen.Width / 2), (pen.Width / 2)))
            {
                e.Graphics.Transform = mx;
                e.Graphics.FillPath(brush, pathRegion);
                e.Graphics.DrawPath(penBorder, pathBorder);
                e.Graphics.DrawPath(pen, pathRegion);
            }
            //SizeF stringSize = e.Graphics.MeasureString(Text, Font);
            //e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
            pathRegion.Dispose();
        }

        private void RoundedCornerRectangle(Rectangle r)
        {
            pathRegion = new GraphicsPath(FillMode.Alternate);
            float innerCurve = this.CurveAngle - this.m_PenSizeOffset;

            pathRegion.StartFigure();
            pathRegion.AddArc(r.X, r.Y, CurveAngle, CurveAngle, 180, 90);
            pathRegion.AddArc(r.Right - CurveAngle, r.Y, CurveAngle, CurveAngle, 270, 90);
            pathRegion.AddArc(r.Right - CurveAngle, r.Bottom - CurveAngle, CurveAngle, CurveAngle, 0, 90);
            pathRegion.AddArc(r.X, r.Bottom - CurveAngle, CurveAngle, CurveAngle, 90, 90);
            pathRegion.CloseFigure();

            pathBorder = new GraphicsPath();
            pathBorder.StartFigure();
            pathBorder.AddArc(r.X + m_PenSizeOffset, r.Y + m_PenSizeOffset, innerCurve, innerCurve, 180, 90);
            pathBorder.AddArc(r.Right - innerCurve - m_PenSizeOffset, r.Y + m_PenSizeOffset, innerCurve, innerCurve, 270, 90);
            pathBorder.AddArc(r.Right - innerCurve - m_PenSizeOffset, r.Bottom - innerCurve - m_PenSizeOffset, innerCurve, innerCurve, 0, 90);
            pathBorder.AddArc(r.X + m_PenSizeOffset, r.Bottom - innerCurve - m_PenSizeOffset, innerCurve, innerCurve, 90, 90);
            pathBorder.CloseFigure();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Invalidate();
        }

        private void Rounded_TextBox_MouseEnter(object sender, EventArgs e)
        {
            _isHovering = true;
            Invalidate();
        }

        private void Rounded_TextBox_MouseLeave(object sender, EventArgs e)
        {
            _isHovering = false;
            Invalidate();
        }

        private void Rounded_TextBox_Enter(object sender, EventArgs e)
        {
            _isFocusing = true;
            Invalidate();
        }

        private void Rounded_TextBox_Leave(object sender, EventArgs e)
        {
            _isFocusing = false;
            Invalidate();
        }
    }
}
