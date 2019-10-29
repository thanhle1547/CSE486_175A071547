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

namespace CustomControl
{
    public partial class Rounded_RichTextBox : UserControl
    {
        public Rounded_RichTextBox()
        {
            InitializeComponent();
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
                rtBx.BackColor = value;
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

        int top;
        int left;
        int right;
        int bottom;

        private void Rounded_RichTextBox_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            int CornerRadius = 18;

            Pen DrawPen = new Pen(BorderColor);
            GraphicsPath gfxPath_mod = new GraphicsPath();

            top = 0;
            left = 0;
            right = Width;
            bottom = Height;

            gfxPath_mod.AddArc(left, top, CornerRadius, CornerRadius, 180, 90);
            gfxPath_mod.AddArc(right - CornerRadius, top, CornerRadius, CornerRadius, 270, 90);
            gfxPath_mod.AddArc(right - CornerRadius, bottom - CornerRadius,
                CornerRadius, CornerRadius, 0, 90);
            gfxPath_mod.AddArc(left, bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);

            gfxPath_mod.CloseAllFigures();

            e.Graphics.DrawPath(DrawPen, gfxPath_mod);

            int inside = 1;

            Pen newPen = new Pen(BorderColor, BorderSize);
            GraphicsPath gfxPath = new GraphicsPath();
            gfxPath.AddArc(left + inside + 1, top + inside, CornerRadius, CornerRadius, 180, 100);

            gfxPath.AddArc(right - CornerRadius - inside - 2,
                top + inside, CornerRadius, CornerRadius, 270, 90);
            gfxPath.AddArc(right - CornerRadius - inside - 2,
                bottom - CornerRadius - inside - 1, CornerRadius, CornerRadius, 0, 90);

            gfxPath.AddArc(left + inside + 1,
            bottom - CornerRadius - inside, CornerRadius, CornerRadius, 95, 95);
            e.Graphics.DrawPath(newPen, gfxPath);

            this.Region = new System.Drawing.Region(gfxPath_mod);
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
