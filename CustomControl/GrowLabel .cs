﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomControl
{
    // https://social.msdn.microsoft.com/Forums/windows/en-US/97c18a1d-729e-4a68-8223-0fcc9ab9012b/automatically-wrap-text-in-label?forum=winforms
    public partial class GrowLabel : Label
    {
        private bool mGrowing;
        public GrowLabel()
        {
            InitializeComponent();
            this.AutoSize = false;
        }
        private void resizeLabel()
        {
            if (mGrowing) return;
            try
            {
                mGrowing = true;
                Size sz = new Size(this.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.Height = sz.Height;
            }
            finally
            {
                mGrowing = false;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            resizeLabel();
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            resizeLabel();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            resizeLabel();
        }
    }
}
