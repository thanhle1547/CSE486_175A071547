using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl;

namespace Manage_App
{
    public partial class AccPersonnel : UserControl
    {
        private static AccPersonnel ins;

        // TimerPanel t = new TimerPanel(10, 117, 55, true, 10); // Ko chạy
        int control_H = 117;
        bool isCollapsed = true;

        public AccPersonnel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public static AccPersonnel Ins { get { if (ins == null) ins = new AccPersonnel(); return ins; } private set => ins = value; }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        /*private void PControl_Animate ()
        {
            if (t.IsCollapsed)
            {
                p_Control.Height += t.Number;
                if (p_Control.Height >= t.CtrlMaxS)
                {
                    t.Stop();
                    p_Control.Height = t.CtrlMaxS;
                    t.IsCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                p_Control.Height -= t.Number;
                if (p_Control.Height <= t.CtrlMinS)
                {
                    t.Stop();
                    p_Control.Height = t.CtrlMinS;
                    t.IsCollapsed = true;
                    this.Refresh();
                }
            }
        }*/

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                p_Control.Height += 10;
                if (p_Control.Height >= control_H)
                {
                    timer.Stop();
                    p_Control.Height = control_H;
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                p_Control.Height -= 10;
                if (p_Control.Height <= 55)
                {
                    timer.Stop();
                    p_Control.Height = 55;
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }
    }
}
