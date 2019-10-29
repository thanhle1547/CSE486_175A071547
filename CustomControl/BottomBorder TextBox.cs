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
    // https://social.msdn.microsoft.com/Forums/windows/en-US/3c6e77d6-55af-4bfc-9467-9896d30b680e/rounded-corner-textbox?forum=winformsdesigner
    public partial class BottomBorder_TextBox : TextBox
    {
        private float borderSize = 2;
        private Color borderColor = Color.Black;
        private Color hoverBorderColor = Color.Fuchsia;
        private Color focusBorderColor = Color.Fuchsia;
        private bool _isHovering = false;
        private bool _isFocusing = false;

        public BottomBorder_TextBox()
        {
            this.BorderStyle = BorderStyle.None;
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
            Enter += (sender, e) =>
            {
                _isFocusing = true;
                Invalidate();
            };
            Leave += (sender, e) =>
            {
                _isFocusing = false;
                Invalidate();
            };

            InitializeComponent();
        }

        private int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Pen pen = new Pen(_isHovering ? HoverBorderColor : _isFocusing ? FocusBorderColor : BorderColor, BorderSize); // Brushes.Black, 1.5f
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(pen, new Point(0, this.Size.Height - 1), new Point(this.Size.Width, this.Size.Height - 1));
                }
            }
        }

        [DefaultValue(2)]
        public float BorderSize { get => borderSize; set { borderSize = value; Invalidate(); } }
        public Color BorderColor { get => borderColor; set { borderColor = value; Invalidate(); } }
        public Color HoverBorderColor { get => hoverBorderColor; set => hoverBorderColor = value; }
        public Color FocusBorderColor { get => focusBorderColor; set => focusBorderColor = value; }
    }
}
