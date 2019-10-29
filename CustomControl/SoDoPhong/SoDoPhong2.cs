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
    public partial class SoDoPhong2 : UserControl
    {
        //private static SoDoPhong2 ins;
        private List<string> gheThuong = new List<string>();
        private List<string> gheVIP = new List<string>();

        public SoDoPhong2()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public SoDoPhong2(string[] s)
        {
            InitializeComponent();

            foreach (Ghe i in container.Controls)
            {
                if (s.Contains(i.Text))
                    i.BackColor = Color.Gainsboro;
                i.Click += GheClicked;
            }
        }

        private void GheClicked(object sender, EventArgs e)
        {
            if (((Ghe)sender).Enabled == false)
                return;
            switch (((Ghe)sender).BackColor.Name)
            {
                case "Fuchsia":
                    ((Ghe)sender).BackColor = Color.Maroon;
                    ((Ghe)sender).ForeColor = Color.White;
                    GheVIP.Add(((Ghe)sender).Text);
                    break;
                case "White":
                    ((Ghe)sender).BackColor = Color.Red;
                    ((Ghe)sender).ForeColor = Color.White;
                    GheThuong.Add(((Ghe)sender).Text);
                    break;
                case "Maroon":
                    ((Ghe)sender).BackColor = Color.Fuchsia;
                    ((Ghe)sender).ForeColor = Color.White;
                    GheVIP.Remove(((Ghe)sender).Text);
                    break;
                case "Red":
                    ((Ghe)sender).BackColor = Color.White;
                    ((Ghe)sender).ForeColor = Color.FromArgb(64, 64, 64);
                    GheThuong.Remove(((Ghe)sender).Text);
                    break;
            }
        }

        //public static SoDoPhong2 Ins { get { if (ins == null) ins = new SoDoPhong2(); return ins; } set => ins = value; }

        public List<string> GheThuong { get => gheThuong; set => gheThuong = value; }
        public List<string> GheVIP { get => gheVIP; set => gheVIP = value; }
        public int SoGheDaChon { get =>
                (GheThuong == null ? 0 : GheThuong.Count())
                + (GheVIP == null ? 0 : GheVIP.Count()); private set => SoGheDaChon = value; }
    }
}
