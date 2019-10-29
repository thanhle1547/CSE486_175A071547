namespace Manage_App
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.p_menu = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.p_MenuAcc = new System.Windows.Forms.Panel();
            this.borderBotom = new MaterialSkin.Controls.MaterialDivider();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_ChangeAcc = new System.Windows.Forms.Button();
            this.btn_LichChieu = new System.Windows.Forms.Button();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_DsKH = new System.Windows.Forms.Button();
            this.btn_DsNV = new System.Windows.Forms.Button();
            this.btn_DsPhim = new System.Windows.Forms.Button();
            this.btn_Memu = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.p_menu.SuspendLayout();
            this.p_MenuAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_menu
            // 
            this.p_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.p_menu.Controls.Add(this.btn_ThongKe);
            this.p_menu.Controls.Add(this.p_MenuAcc);
            this.p_menu.Controls.Add(this.btn_LichChieu);
            this.p_menu.Controls.Add(this.btn_Account);
            this.p_menu.Controls.Add(this.btn_DsKH);
            this.p_menu.Controls.Add(this.btn_DsNV);
            this.p_menu.Controls.Add(this.btn_DsPhim);
            this.p_menu.Controls.Add(this.btn_Memu);
            this.p_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_menu.Location = new System.Drawing.Point(0, 0);
            this.p_menu.Margin = new System.Windows.Forms.Padding(0);
            this.p_menu.Name = "p_menu";
            this.p_menu.Size = new System.Drawing.Size(275, 556);
            this.p_menu.TabIndex = 0;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Image = global::Manage_App.Properties.Resources.icons8_graph_iOS_Filled_24;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 262);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Padding = new System.Windows.Forms.Padding(18, 0, 53, 0);
            this.btn_ThongKe.Size = new System.Drawing.Size(275, 48);
            this.btn_ThongKe.TabIndex = 1;
            this.btn_ThongKe.Text = "      Thống kê";
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_ThongKe, "Thống kê");
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Visible = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // p_MenuAcc
            // 
            this.p_MenuAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.p_MenuAcc.Controls.Add(this.borderBotom);
            this.p_MenuAcc.Controls.Add(this.btn_DangXuat);
            this.p_MenuAcc.Controls.Add(this.btn_TaiKhoan);
            this.p_MenuAcc.Controls.Add(this.btn_ChangeAcc);
            this.p_MenuAcc.Location = new System.Drawing.Point(0, 346);
            this.p_MenuAcc.Name = "p_MenuAcc";
            this.p_MenuAcc.Size = new System.Drawing.Size(275, 159);
            this.p_MenuAcc.TabIndex = 2;
            this.p_MenuAcc.Visible = false;
            // 
            // borderBotom
            // 
            this.borderBotom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderBotom.BackColor = System.Drawing.Color.DimGray;
            this.borderBotom.Depth = 0;
            this.borderBotom.Location = new System.Drawing.Point(-10, 157);
            this.borderBotom.Margin = new System.Windows.Forms.Padding(0);
            this.borderBotom.MouseState = MaterialSkin.MouseState.HOVER;
            this.borderBotom.Name = "borderBotom";
            this.borderBotom.Size = new System.Drawing.Size(294, 3);
            this.borderBotom.TabIndex = 4;
            this.borderBotom.Text = "materialDivider1";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.White;
            this.btn_DangXuat.Image = global::Manage_App.Properties.Resources.icons8_export_iOS_22;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 12);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btn_DangXuat.Size = new System.Drawing.Size(275, 48);
            this.btn_DangXuat.TabIndex = 1;
            this.btn_DangXuat.Text = "      Đăng xuất";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_DangXuat, "Đăng xuất");
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_TaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.Image = global::Manage_App.Properties.Resources.icons8_male_user_Windows_10_24;
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(0, 108);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(275, 48);
            this.btn_TaiKhoan.TabIndex = 1;
            this.btn_TaiKhoan.Text = "      Tài khoản";
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_TaiKhoan, "Tài khoản");
            this.btn_TaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaiKhoan.Click += new System.EventHandler(this.btn_TaiKhoan_Click);
            // 
            // btn_ChangeAcc
            // 
            this.btn_ChangeAcc.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChangeAcc.FlatAppearance.BorderSize = 0;
            this.btn_ChangeAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChangeAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChangeAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeAcc.ForeColor = System.Drawing.Color.White;
            this.btn_ChangeAcc.Image = global::Manage_App.Properties.Resources.icons8_change_user_Windows_10_24;
            this.btn_ChangeAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeAcc.Location = new System.Drawing.Point(0, 60);
            this.btn_ChangeAcc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangeAcc.Name = "btn_ChangeAcc";
            this.btn_ChangeAcc.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_ChangeAcc.Size = new System.Drawing.Size(275, 48);
            this.btn_ChangeAcc.TabIndex = 1;
            this.btn_ChangeAcc.Text = "      Thay đổi tài khoản";
            this.btn_ChangeAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_ChangeAcc, "Thay đổi tài khoản");
            this.btn_ChangeAcc.UseVisualStyleBackColor = false;
            this.btn_ChangeAcc.Click += new System.EventHandler(this.btn_ChangeAcc_Click);
            // 
            // btn_LichChieu
            // 
            this.btn_LichChieu.BackColor = System.Drawing.Color.Transparent;
            this.btn_LichChieu.FlatAppearance.BorderSize = 0;
            this.btn_LichChieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LichChieu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichChieu.ForeColor = System.Drawing.Color.White;
            this.btn_LichChieu.Image = global::Manage_App.Properties.Resources.icons8_schedule_Windows_Metro_24_white;
            this.btn_LichChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichChieu.Location = new System.Drawing.Point(0, 118);
            this.btn_LichChieu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LichChieu.Name = "btn_LichChieu";
            this.btn_LichChieu.Padding = new System.Windows.Forms.Padding(18, 0, 14, 0);
            this.btn_LichChieu.Size = new System.Drawing.Size(275, 48);
            this.btn_LichChieu.TabIndex = 1;
            this.btn_LichChieu.Text = "      Lịch chiếu phim";
            this.btn_LichChieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_LichChieu, "Lịch chiếu phim");
            this.btn_LichChieu.UseVisualStyleBackColor = false;
            this.btn_LichChieu.Click += new System.EventHandler(this.btn_LichChieu_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Account.BackColor = System.Drawing.Color.Transparent;
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Account.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = global::Manage_App.Properties.Resources.icons8_male_user_Windows_10_24;
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(0, 508);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Padding = new System.Windows.Forms.Padding(18, 0, 25, 0);
            this.btn_Account.Size = new System.Drawing.Size(275, 48);
            this.btn_Account.TabIndex = 1;
            this.btn_Account.Text = "      Tài khoản";
            this.btn_Account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Account.UseVisualStyleBackColor = false;
            this.btn_Account.Visible = false;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_DsKH
            // 
            this.btn_DsKH.BackColor = System.Drawing.Color.Transparent;
            this.btn_DsKH.FlatAppearance.BorderSize = 0;
            this.btn_DsKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DsKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsKH.ForeColor = System.Drawing.Color.White;
            this.btn_DsKH.Image = global::Manage_App.Properties.Resources.icons8_people_iOS_Glyph_24_white;
            this.btn_DsKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DsKH.Location = new System.Drawing.Point(0, 214);
            this.btn_DsKH.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DsKH.Name = "btn_DsKH";
            this.btn_DsKH.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_DsKH.Size = new System.Drawing.Size(275, 48);
            this.btn_DsKH.TabIndex = 1;
            this.btn_DsKH.Text = "      Danh sách khách hàng";
            this.btn_DsKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_DsKH, "Danh sách khách hàng");
            this.btn_DsKH.UseVisualStyleBackColor = false;
            this.btn_DsKH.Click += new System.EventHandler(this.btn_DsKH_Click);
            // 
            // btn_DsNV
            // 
            this.btn_DsNV.BackColor = System.Drawing.Color.Transparent;
            this.btn_DsNV.FlatAppearance.BorderSize = 0;
            this.btn_DsNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DsNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsNV.ForeColor = System.Drawing.Color.White;
            this.btn_DsNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_DsNV.Image")));
            this.btn_DsNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DsNV.Location = new System.Drawing.Point(0, 166);
            this.btn_DsNV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DsNV.Name = "btn_DsNV";
            this.btn_DsNV.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_DsNV.Size = new System.Drawing.Size(275, 48);
            this.btn_DsNV.TabIndex = 1;
            this.btn_DsNV.Text = "      Danh sách nhân viên";
            this.btn_DsNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_DsNV, "Danh sách nhân viên");
            this.btn_DsNV.UseVisualStyleBackColor = false;
            this.btn_DsNV.Click += new System.EventHandler(this.btn_DsNV_Click);
            // 
            // btn_DsPhim
            // 
            this.btn_DsPhim.BackColor = System.Drawing.Color.Transparent;
            this.btn_DsPhim.FlatAppearance.BorderSize = 0;
            this.btn_DsPhim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsPhim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DsPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DsPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DsPhim.ForeColor = System.Drawing.Color.White;
            this.btn_DsPhim.Image = global::Manage_App.Properties.Resources.icons8_movie_24;
            this.btn_DsPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DsPhim.Location = new System.Drawing.Point(0, 70);
            this.btn_DsPhim.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DsPhim.Name = "btn_DsPhim";
            this.btn_DsPhim.Padding = new System.Windows.Forms.Padding(18, 0, 12, 0);
            this.btn_DsPhim.Size = new System.Drawing.Size(275, 48);
            this.btn_DsPhim.TabIndex = 1;
            this.btn_DsPhim.Text = "      Danh sách phim";
            this.btn_DsPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btn_DsPhim, "Danh sách phim");
            this.btn_DsPhim.UseVisualStyleBackColor = false;
            this.btn_DsPhim.Click += new System.EventHandler(this.btn_DsPhim_Click);
            // 
            // btn_Memu
            // 
            this.btn_Memu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Memu.FlatAppearance.BorderSize = 0;
            this.btn_Memu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Memu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Memu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Memu.Image = global::Manage_App.Properties.Resources.icons8_menu_24;
            this.btn_Memu.Location = new System.Drawing.Point(13, 12);
            this.btn_Memu.Name = "btn_Memu";
            this.btn_Memu.Size = new System.Drawing.Size(44, 44);
            this.btn_Memu.TabIndex = 0;
            this.btn_Memu.UseVisualStyleBackColor = false;
            this.btn_Memu.Click += new System.EventHandler(this.btn_Memu_Click);
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(275, 0);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(955, 556);
            this.container.TabIndex = 1;
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 556);
            this.Controls.Add(this.container);
            this.Controls.Add(this.p_menu);
            this.MinimumSize = new System.Drawing.Size(1180, 595);
            this.Name = "Manage";
            this.Text = "Cinema Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manage_FormClosing);
            this.p_menu.ResumeLayout(false);
            this.p_MenuAcc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_menu;
        private System.Windows.Forms.Button btn_Memu;
        private System.Windows.Forms.Button btn_LichChieu;
        private System.Windows.Forms.Button btn_DsKH;
        private System.Windows.Forms.Button btn_DsNV;
        private System.Windows.Forms.Button btn_DsPhim;
        private System.Windows.Forms.Button btn_ChangeAcc;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel p_MenuAcc;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.ToolTip toolTip;
        private MaterialSkin.Controls.MaterialDivider borderBotom;
    }
}

