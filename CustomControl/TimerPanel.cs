using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class TimerPanel : Timer
    {
        int number;
        int ctrlMaxS;
        int ctrlMinS;
        bool isCollapsed;
        int interval;
        // Ko thể truyền Panel.Height -> bỏ xysize

        public TimerPanel() { }
        public TimerPanel(int number, int ctrlMaxS, int ctrlMinS, bool isCollapsed, int interval)
        {
            this.number = number;
            this.ctrlMaxS = ctrlMaxS;
            this.ctrlMinS = ctrlMinS;
            this.isCollapsed = isCollapsed;
            Interval = interval;
        }

        public bool IsCollapsed { get => isCollapsed; set => isCollapsed = value; }
        public int _Interval { get => interval; set => interval = value; }
        public int CtrlMaxS { get => ctrlMaxS; set => ctrlMaxS = value; }
        public int CtrlMinS { get => ctrlMinS; set => ctrlMinS = value; }
        public int Number { get => number; set => number = value; }
    }
}
