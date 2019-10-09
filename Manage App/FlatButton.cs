using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_App
{
    public partial class FlatButton : Button
    {
        private Color _buttonColor = Color.Transparent;
        private Color _onHoverButtonColor = Color.FromArgb(33, 0, 0, 0);
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        private Color _BackColor = Color.Transparent;

        public FlatButton()
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

    }
}
