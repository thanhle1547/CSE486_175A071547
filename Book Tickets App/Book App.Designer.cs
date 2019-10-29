namespace Book_Tickets_App
{
    partial class BookForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p_Navigation = new System.Windows.Forms.Panel();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tP_NowPlaying = new System.Windows.Forms.TabPage();
            this.flp_DsPhim = new System.Windows.Forms.FlowLayoutPanel();
            this.tP_ComingSoon = new System.Windows.Forms.TabPage();
            this.flp_dsPhimSC = new System.Windows.Forms.FlowLayoutPanel();
            this.tP_MyTickets = new System.Windows.Forms.TabPage();
            this.flp_VeDaDat = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Setting = new CustomControl.Round_Button();
            this.btn_Account = new CustomControl.Round_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_Navigation.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tP_NowPlaying.SuspendLayout();
            this.tP_ComingSoon.SuspendLayout();
            this.tP_MyTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Navigation
            // 
            this.p_Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.p_Navigation.Controls.Add(this.TabSelector);
            this.p_Navigation.Controls.Add(this.label1);
            this.p_Navigation.Controls.Add(this.btn_Setting);
            this.p_Navigation.Controls.Add(this.btn_Account);
            this.p_Navigation.Controls.Add(this.pictureBox1);
            this.p_Navigation.Location = new System.Drawing.Point(0, 0);
            this.p_Navigation.Name = "p_Navigation";
            this.p_Navigation.Size = new System.Drawing.Size(823, 105);
            this.p_Navigation.TabIndex = 1;
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(228, 58);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(366, 47);
            this.TabSelector.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tP_NowPlaying);
            this.TabControl.Controls.Add(this.tP_ComingSoon);
            this.TabControl.Controls.Add(this.tP_MyTickets);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(0, 105);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(823, 391);
            this.TabControl.TabIndex = 2;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tP_NowPlaying
            // 
            this.tP_NowPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tP_NowPlaying.Controls.Add(this.flp_DsPhim);
            this.tP_NowPlaying.Location = new System.Drawing.Point(4, 22);
            this.tP_NowPlaying.Margin = new System.Windows.Forms.Padding(0);
            this.tP_NowPlaying.Name = "tP_NowPlaying";
            this.tP_NowPlaying.Padding = new System.Windows.Forms.Padding(3);
            this.tP_NowPlaying.Size = new System.Drawing.Size(815, 365);
            this.tP_NowPlaying.TabIndex = 0;
            this.tP_NowPlaying.Text = "Đang chiếu";
            // 
            // flp_DsPhim
            // 
            this.flp_DsPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_DsPhim.AutoScroll = true;
            this.flp_DsPhim.BackColor = System.Drawing.Color.Transparent;
            this.flp_DsPhim.Location = new System.Drawing.Point(0, 0);
            this.flp_DsPhim.Name = "flp_DsPhim";
            this.flp_DsPhim.Size = new System.Drawing.Size(815, 365);
            this.flp_DsPhim.TabIndex = 1;
            // 
            // tP_ComingSoon
            // 
            this.tP_ComingSoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tP_ComingSoon.Controls.Add(this.flp_dsPhimSC);
            this.tP_ComingSoon.Location = new System.Drawing.Point(4, 22);
            this.tP_ComingSoon.Name = "tP_ComingSoon";
            this.tP_ComingSoon.Size = new System.Drawing.Size(815, 365);
            this.tP_ComingSoon.TabIndex = 2;
            this.tP_ComingSoon.Text = "Sắp chiếu";
            // 
            // flp_dsPhimSC
            // 
            this.flp_dsPhimSC.AutoScroll = true;
            this.flp_dsPhimSC.BackColor = System.Drawing.Color.Transparent;
            this.flp_dsPhimSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_dsPhimSC.Location = new System.Drawing.Point(0, 0);
            this.flp_dsPhimSC.Name = "flp_dsPhimSC";
            this.flp_dsPhimSC.Size = new System.Drawing.Size(815, 365);
            this.flp_dsPhimSC.TabIndex = 2;
            // 
            // tP_MyTickets
            // 
            this.tP_MyTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tP_MyTickets.Controls.Add(this.flp_VeDaDat);
            this.tP_MyTickets.Location = new System.Drawing.Point(4, 22);
            this.tP_MyTickets.Name = "tP_MyTickets";
            this.tP_MyTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tP_MyTickets.Size = new System.Drawing.Size(815, 365);
            this.tP_MyTickets.TabIndex = 1;
            this.tP_MyTickets.Text = "Vé của tôi";
            // 
            // flp_VeDaDat
            // 
            this.flp_VeDaDat.AutoScroll = true;
            this.flp_VeDaDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_VeDaDat.Location = new System.Drawing.Point(3, 3);
            this.flp_VeDaDat.Name = "flp_VeDaDat";
            this.flp_VeDaDat.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.flp_VeDaDat.Size = new System.Drawing.Size(809, 359);
            this.flp_VeDaDat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(404, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "CINEMA";
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Setting.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Setting.ButtonImage = null;
            this.btn_Setting.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Image = global::Book_Tickets_App.Properties.Resources.icons8_tune_Material_Outlined_24_CCCCCC;
            this.btn_Setting.Location = new System.Drawing.Point(719, 10);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Setting.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Setting.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_Setting.Size = new System.Drawing.Size(43, 43);
            this.btn_Setting.TabIndex = 2;
            this.btn_Setting.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btn_Setting, "Cài đặt");
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Visible = false;
            // 
            // btn_Account
            // 
            this.btn_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Account.BackColor = System.Drawing.Color.Transparent;
            this.btn_Account.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Account.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Account.ButtonImage = null;
            this.btn_Account.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Image = global::Book_Tickets_App.Properties.Resources.icons8_male_user_Windows_10_24_CCCCCC;
            this.btn_Account.Location = new System.Drawing.Point(768, 10);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Account.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btn_Account.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_Account.Size = new System.Drawing.Size(43, 43);
            this.btn_Account.TabIndex = 2;
            this.btn_Account.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btn_Account, "Tài khoản");
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Visible = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Book_Tickets_App.Properties.Resources.icons8_cinema_Pastel_Glyph_100_red;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(327, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 495);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.p_Navigation);
            this.MinimumSize = new System.Drawing.Size(839, 534);
            this.Name = "BookForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.SizeChanged += new System.EventHandler(this.BookForm_SizeChanged);
            this.p_Navigation.ResumeLayout(false);
            this.p_Navigation.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tP_NowPlaying.ResumeLayout(false);
            this.tP_ComingSoon.ResumeLayout(false);
            this.tP_MyTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Navigation;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tP_NowPlaying;
        private System.Windows.Forms.TabPage tP_MyTickets;
        private System.Windows.Forms.TabPage tP_ComingSoon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_DsPhim;
        private CustomControl.Round_Button btn_Account;
        private CustomControl.Round_Button btn_Setting;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flp_dsPhimSC;
        private System.Windows.Forms.FlowLayoutPanel flp_VeDaDat;
    }
}

