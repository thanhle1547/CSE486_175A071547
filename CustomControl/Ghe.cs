using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_App
{
    public partial class Ghe : Label
    {
        public Ghe()
        {
            this.AutoSize = false;
            //this.Height = 52;
            //this.Width = 52;
            this.Size = new Size(52, 52);
            this.BackColor = Color.White;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (this.BackColor == Color.Fuchsia || this.BackColor == Color.White)
                this.BackColor = Color.Gainsboro;
        }
    }
}
