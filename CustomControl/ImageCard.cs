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
    public partial class ImageCard : UserControl
    {
        /*private Image cardImage;
        private string titleText;
        private string minutes;
        private string ratedText;*/

        public ImageCard()
        {
            InitializeComponent();
        }

        // https://stackoverflow.com/questions/12608300/select-usercontrol-from-flowlayoutpanel
        public event EventHandler<EventArgs> WasClicked;

        public Image CardImage { get => Picture.BackgroundImage; set => Picture.BackgroundImage = value; }
        public string TitleText { get => Title.Text; set => Title.Text = value; }
        public string Minutes { get => Time.Text; set => Time.Text = value; }
        public string RatedText { get => Rated.Text; set => Rated.Text = value; }
        public bool IsSelected { get; set; }

        private void ImageCard_Load(object sender, EventArgs e)
        {
            //this.MouseClick += ImageCard_MouseClick;
            foreach (Control control in Controls)
                control.MouseClick += ImageCard_MouseClick;
        }

        private void ImageCard_MouseClick(object sender, MouseEventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
                WasClicked(this, EventArgs.Empty);
            // Select this UC on click.
            IsSelected = true;
        }
    }
}
