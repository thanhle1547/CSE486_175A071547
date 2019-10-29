namespace Manage_App
{
    partial class Statistic
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.card3 = new CustomControl.Card();
            this.card2 = new CustomControl.Card();
            this.card1 = new CustomControl.Card();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // card3
            // 
            this.card3.AutoSize = true;
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.card3.ContentColor = System.Drawing.SystemColors.ControlText;
            this.card3.ContentFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.card3.ContentText = "";
            this.card3.Location = new System.Drawing.Point(100, 360);
            this.card3.Margin = new System.Windows.Forms.Padding(30);
            this.card3.Name = "card3";
            this.card3.PicBackImgLayout = System.Windows.Forms.ImageLayout.Center;
            this.card3.PictureBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.card3.PictureBackImage = global::Manage_App.Properties.Resources.Man_Laptop_Cinema_Ticket_Bubbles_100;
            this.card3.PictureImage = null;
            this.card3.PictureSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.card3.Size = new System.Drawing.Size(294, 250);
            this.card3.TabIndex = 1;
            this.card3.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(182)))), ((int)(((byte)(121)))));
            this.card3.TitleFont = new System.Drawing.Font("Calibri", 16F);
            this.card3.TitleText = "Thống kê số vé đặt mua qua ứng dụng";
            // 
            // card2
            // 
            this.card2.AutoSize = true;
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.card2.ContentColor = System.Drawing.SystemColors.ControlText;
            this.card2.ContentFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.card2.ContentText = "";
            this.card2.Location = new System.Drawing.Point(454, 50);
            this.card2.Margin = new System.Windows.Forms.Padding(30);
            this.card2.Name = "card2";
            this.card2.PicBackImgLayout = System.Windows.Forms.ImageLayout.Center;
            this.card2.PictureBackColor = System.Drawing.Color.Transparent;
            this.card2.PictureBackImage = global::Manage_App.Properties.Resources.Ticket_Purchase_Color_100;
            this.card2.PictureImage = null;
            this.card2.PictureSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.card2.Size = new System.Drawing.Size(294, 250);
            this.card2.TabIndex = 1;
            this.card2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(182)))), ((int)(((byte)(121)))));
            this.card2.TitleFont = new System.Drawing.Font("Calibri", 16F);
            this.card2.TitleText = "Thống kê số vé bán tại quầy";
            // 
            // card1
            // 
            this.card1.AutoSize = true;
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.card1.ContentColor = System.Drawing.SystemColors.ControlText;
            this.card1.ContentFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.card1.ContentText = "";
            this.card1.Location = new System.Drawing.Point(100, 50);
            this.card1.Margin = new System.Windows.Forms.Padding(30);
            this.card1.Name = "card1";
            this.card1.PicBackImgLayout = System.Windows.Forms.ImageLayout.Center;
            this.card1.PictureBackColor = System.Drawing.Color.Transparent;
            this.card1.PictureBackImage = global::Manage_App.Properties.Resources.icons8_movie_ticket_Cloud_100;
            this.card1.PictureImage = null;
            this.card1.PictureSizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.card1.Size = new System.Drawing.Size(294, 250);
            this.card1.TabIndex = 1;
            this.card1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(182)))), ((int)(((byte)(121)))));
            this.card1.TitleFont = new System.Drawing.Font("Calibri", 16F);
            this.card1.TitleText = "Thống kê lượng vé bán được";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.card1);
            this.flowLayoutPanel1.Controls.Add(this.card2);
            this.flowLayoutPanel1.Controls.Add(this.card3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(70, 20, 70, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(872, 556);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Statistic";
            this.Size = new System.Drawing.Size(872, 556);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.Card card1;
        private CustomControl.Card card2;
        private CustomControl.Card card3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
