using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Text;

namespace Manage_App
{
    public partial class Statistic : UserControl
    {
        //PrivateFontCollection roboto = new PrivateFontCollection();

        // https://stackoverflow.com/questions/15222580/lazy-singleton-in-a-multithreaded-c-sharp-application
        // https://docs.microsoft.com/en-us/dotnet/framework/performance/lazy-initialization?redirectedfrom=MSDN
        // a Lazy<T> object always returns the same object or value that it was initialized with
        // private Lazy<Statistic> ins = new Lazy<Statistic>(() => new Statistic(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
        // ins.Value trả về kiểu static  -> container.Controls.Contains ko dùng đc

        private static Statistic ins;

        public Statistic()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            /*roboto.AddFontFile("Roboto_Regular.ttf");
            card1.TitleFont = new Font(roboto.Families[0], 15);*/
        }

        // public Statistic Ins { get => ins.Value; }
        public static Statistic Ins { get { if (ins == null) ins = new Statistic(); return ins; } private set => ins = value; }
    }
}
