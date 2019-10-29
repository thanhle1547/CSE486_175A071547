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
    // https://www.codeguru.com/csharp/.net/net_general/creating-a-.net-transparent-panel.html
    public partial class Transparent_Panel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;

        public Transparent_Panel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 50;

        [DefaultValue(50)]
        public int Opacity
        {
            get => this.opacity;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cpar = base.CreateParams;
                cpar.ExStyle = cpar.ExStyle | WS_EX_TRANSPARENT;
                return cpar;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }
}
