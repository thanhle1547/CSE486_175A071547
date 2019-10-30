using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAO;
using CustomControl;
using System.IO;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;

namespace Book_Tickets_App
{
    public partial class BookForm : Form
    {
        ChiTietPhim chiTiet;

        public BookForm()
        {
            InitializeComponent();

            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;

            manager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Pink800,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            // Color.FromArgb(230,0,0,0) not support transparent

            //MovieDetailts f = new MovieDetailts();
            //container.Controls.Add(f);
            //f.BringToFront();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            using (AccountForm f = new AccountForm())
            {
                //f.Parent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(); 
            }
        }

        private void LoadMovies(ref FlowLayoutPanel panel, string method, bool comingsoon)
        {
            //list = CT_Phim_BUS.Ins.GetMovies();

            // https://stackoverflow.com/questions/204468/invoking-a-method-using-reflection-on-a-singleton-object
            MethodInfo methodInfo = CT_Phim_DAO.Ins.GetType().GetMethod(method);
            foreach (var item in methodInfo.Invoke(CT_Phim_DAO.Ins, new object[]{comingsoon}) as IEnumerable<ChiTietPhim>)
            {
                ImageCard c = new ImageCard();
                c.Tag = item;
                c.TitleText = item.TenPhim;
                c.Minutes = item.ThoiLuong.ToString() + " phút";
                c.RatedText = item.Rated;
                // https://stackoverflow.com/a/8084628
                // https://www.youtube.com/watch?v=BqyAAGMfTD8&t=2s
                MemoryStream m = new MemoryStream(item.Poster);
                c.CardImage = Image.FromStream(m);
                c.Margin = new Padding(30);
                // https://stackoverflow.com/questions/12608300/select-usercontrol-from-flowlayoutpanel
                c.WasClicked += CardClicked;
                panel.Controls.Add(c);
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadMovies(ref flp_DsPhim, "GetMovies", false);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((sender as TabControl).SelectedIndex.ToString());
            // https://stackoverflow.com/a/2921776
            switch ((sender as TabControl).SelectedIndex)
            {
                case 1:
                    if (flp_dsPhimSC.Controls.Count == 0)
                        LoadMovies(ref flp_dsPhimSC, "GetMovies", true);
                    break;
                case 2:
                    foreach (var item in
                        Booking_DAO.Ins.GetBookingDataClient(Properties.Settings.Default.UserId))
                    {
                        InforCard card = new InforCard(item);
                        card.Margin = new Padding(50, 50, 50, 0);
                        // https://stackoverflow.com/a/10600215
                        card.Size = new Size(flp_VeDaDat.Width - card.Margin.Horizontal, card.Height);
                        flp_VeDaDat.Controls.Add(card);
                    }
                    break;
            }
        }

        private void CardClicked(object sender, EventArgs e)
        {
            /*Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.BackColor = Color.Transparent;*/
            //MessageBox.Show("Card clicked");
            Properties.Settings.Default.ChiTietPhim = ((ImageCard)sender).Tag as ChiTietPhim;
            
            /*// https://stackoverflow.com/a/16958128
            ImageConverter converter = new ImageConverter();
            Properties.Settings.Default.ChiTietPhim.Poster =
                (byte[])converter.ConvertTo(((ImageCard)sender).BackgroundImage, typeof(byte[]) );*/

            MovieDetailts form = new MovieDetailts();
                this.Controls.Add(form);
                form.Show();
                form.BringToFront();
            ((ImageCard)sender).IsSelected = false;
        }

        private void BookForm_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control card in flp_VeDaDat.Controls)
                card.Size = new Size(flp_VeDaDat.Width - card.Margin.Horizontal, card.Height);
        }

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // https://stackoverflow.com/a/42214518
            Application.Exit();
        }
    }
}
