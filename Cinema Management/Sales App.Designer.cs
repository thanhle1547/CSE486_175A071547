namespace Sales_App
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("It", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Ad Astra", 1);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lb_NhanVien = new System.Windows.Forms.Label();
            this.imgList_Phim = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_dsDatVe = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlgVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txB_TenPhim = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new Sales_App.Round_Button();
            this.num_SlgVe = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_PhongSo = new System.Windows.Forms.Label();
            this.btn_ChonGhe = new System.Windows.Forms.Button();
            this.txB_ChonGhe = new System.Windows.Forms.TextBox();
            this.txB_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txB_TienKhachTra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txB_TienDu = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new Sales_App.Round_Button();
            this.btn_Huy = new Sales_App.Round_Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Nhan = new System.Windows.Forms.Label();
            this.cB_NgonNgu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cB_DinhDang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_SoGheT = new System.Windows.Forms.Label();
            this.lb_SoGheV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDatVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SlgVe)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Snow;
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.btn_Minimize);
            this.header.Controls.Add(this.btn_Maximize);
            this.header.Controls.Add(this.btn_Close);
            this.header.Controls.Add(this.lb_NhanVien);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(958, 35);
            this.header.TabIndex = 0;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sales_App.Properties.Resources.icons8_movie_Cute_Clipart_512;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.Location = new System.Drawing.Point(829, -2);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(43, 31);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Maximize.Location = new System.Drawing.Point(872, -1);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(43, 30);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(915, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_Close.Size = new System.Drawing.Size(43, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // lb_NhanVien
            // 
            this.lb_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_NhanVien.AutoSize = true;
            this.lb_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhanVien.Location = new System.Drawing.Point(689, 7);
            this.lb_NhanVien.Name = "lb_NhanVien";
            this.lb_NhanVien.Size = new System.Drawing.Size(105, 21);
            this.lb_NhanVien.TabIndex = 0;
            this.lb_NhanVien.Text = "Tên nhân viên";
            this.lb_NhanVien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lb_NhanVien.Click += new System.EventHandler(this.Lb_NhanVien_Click);
            // 
            // imgList_Phim
            // 
            this.imgList_Phim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Phim.ImageStream")));
            this.imgList_Phim.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Phim.Images.SetKeyName(0, "rsz_it_chapter_two-_vietnamese_poster.jpg");
            this.imgList_Phim.Images.SetKeyName(1, "Ad Astra.jpg");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imgList_Phim;
            this.listView1.Location = new System.Drawing.Point(8, 23);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(932, 486);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 564);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    Danh sách phim    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "    Đặt vé    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txB_TienDu);
            this.splitContainer1.Panel1.Controls.Add(this.txB_TienKhachTra);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_dsDatVe);
            this.splitContainer1.Panel1.Controls.Add(this.txB_TongTien);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ThanhToan);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Huy);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer1.Panel2.Controls.Add(this.cB_DinhDang);
            this.splitContainer1.Panel2.Controls.Add(this.cB_NgonNgu);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ChonGhe);
            this.splitContainer1.Panel2.Controls.Add(this.txB_ChonGhe);
            this.splitContainer1.Panel2.Controls.Add(this.txB_TenPhim);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel2.Controls.Add(this.num_SlgVe);
            this.splitContainer1.Panel2.Controls.Add(this.lb_Nhan);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lb_PhongSo);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.lb_SoGheV);
            this.splitContainer1.Panel2.Controls.Add(this.lb_SoGheT);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(950, 528);
            this.splitContainer1.SplitterDistance = 588;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgv_dsDatVe
            // 
            this.dgv_dsDatVe.AllowUserToAddRows = false;
            this.dgv_dsDatVe.AllowUserToOrderColumns = true;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_dsDatVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_dsDatVe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dsDatVe.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_dsDatVe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dsDatVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsDatVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_dsDatVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsDatVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.SlgVe,
            this.ThoiGian});
            this.dgv_dsDatVe.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_dsDatVe.Location = new System.Drawing.Point(11, 12);
            this.dgv_dsDatVe.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_dsDatVe.Name = "dgv_dsDatVe";
            this.dgv_dsDatVe.RowHeadersWidth = 30;
            this.dgv_dsDatVe.Size = new System.Drawing.Size(574, 331);
            this.dgv_dsDatVe.TabIndex = 0;
            // 
            // TenPhim
            // 
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TenPhim.DefaultCellStyle = dataGridViewCellStyle23;
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Width = 300;
            // 
            // SlgVe
            // 
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SlgVe.DefaultCellStyle = dataGridViewCellStyle24;
            this.SlgVe.HeaderText = "Số lượng vé";
            this.SlgVe.Name = "SlgVe";
            // 
            // ThoiGian
            // 
            this.ThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGian.HeaderText = "Thời gian chiếu";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // txB_TenPhim
            // 
            this.txB_TenPhim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_TenPhim.BackColor = System.Drawing.Color.Snow;
            this.txB_TenPhim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_TenPhim.Location = new System.Drawing.Point(23, 159);
            this.txB_TenPhim.Name = "txB_TenPhim";
            this.txB_TenPhim.ReadOnly = true;
            this.txB_TenPhim.Size = new System.Drawing.Size(306, 33);
            this.txB_TenPhim.TabIndex = 11;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_Xoa.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.ButtonColor = System.Drawing.Color.Linen;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.Location = new System.Drawing.Point(236, 36);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.OnHoverButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Xoa.Size = new System.Drawing.Size(93, 37);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.Black;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // num_SlgVe
            // 
            this.num_SlgVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_SlgVe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_SlgVe.Location = new System.Drawing.Point(229, 330);
            this.num_SlgVe.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_SlgVe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_SlgVe.Name = "num_SlgVe";
            this.num_SlgVe.Size = new System.Drawing.Size(86, 33);
            this.num_SlgVe.TabIndex = 2;
            this.num_SlgVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_SlgVe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // lb_PhongSo
            // 
            this.lb_PhongSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_PhongSo.AutoSize = true;
            this.lb_PhongSo.Location = new System.Drawing.Point(248, 431);
            this.lb_PhongSo.Name = "lb_PhongSo";
            this.lb_PhongSo.Size = new System.Drawing.Size(47, 20);
            this.lb_PhongSo.TabIndex = 0;
            this.lb_PhongSo.Text = "Nhãn";
            // 
            // btn_ChonGhe
            // 
            this.btn_ChonGhe.Location = new System.Drawing.Point(23, 475);
            this.btn_ChonGhe.Name = "btn_ChonGhe";
            this.btn_ChonGhe.Size = new System.Drawing.Size(105, 35);
            this.btn_ChonGhe.TabIndex = 12;
            this.btn_ChonGhe.Text = "Chọn ghế";
            this.btn_ChonGhe.UseVisualStyleBackColor = true;
            // 
            // txB_ChonGhe
            // 
            this.txB_ChonGhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_ChonGhe.BackColor = System.Drawing.Color.Snow;
            this.txB_ChonGhe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_ChonGhe.Location = new System.Drawing.Point(188, 475);
            this.txB_ChonGhe.Name = "txB_ChonGhe";
            this.txB_ChonGhe.ReadOnly = true;
            this.txB_ChonGhe.Size = new System.Drawing.Size(141, 33);
            this.txB_ChonGhe.TabIndex = 11;
            // 
            // txB_TongTien
            // 
            this.txB_TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_TongTien.BackColor = System.Drawing.SystemColors.Control;
            this.txB_TongTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_TongTien.Location = new System.Drawing.Point(150, 370);
            this.txB_TongTien.Name = "txB_TongTien";
            this.txB_TongTien.ReadOnly = true;
            this.txB_TongTien.Size = new System.Drawing.Size(151, 33);
            this.txB_TongTien.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách trả";
            // 
            // txB_TienKhachTra
            // 
            this.txB_TienKhachTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_TienKhachTra.BackColor = System.Drawing.Color.Snow;
            this.txB_TienKhachTra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_TienKhachTra.Location = new System.Drawing.Point(150, 428);
            this.txB_TienKhachTra.Name = "txB_TienKhachTra";
            this.txB_TienKhachTra.Size = new System.Drawing.Size(151, 33);
            this.txB_TienKhachTra.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dư";
            // 
            // txB_TienDu
            // 
            this.txB_TienDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_TienDu.BackColor = System.Drawing.SystemColors.Control;
            this.txB_TienDu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txB_TienDu.Location = new System.Drawing.Point(150, 481);
            this.txB_TienDu.Name = "txB_TienDu";
            this.txB_TienDu.ReadOnly = true;
            this.txB_TienDu.Size = new System.Drawing.Size(151, 33);
            this.txB_TienDu.TabIndex = 11;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.BackColor1 = System.Drawing.Color.White;
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ThanhToan.ButtonColor = System.Drawing.SystemColors.Window;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ThanhToan.Location = new System.Drawing.Point(374, 396);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.OnHoverBorderColor = System.Drawing.Color.Fuchsia;
            this.btn_ThanhToan.OnHoverButtonColor = System.Drawing.Color.Fuchsia;
            this.btn_ThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Size = new System.Drawing.Size(164, 44);
            this.btn_ThanhToan.TabIndex = 10;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextColor = System.Drawing.Color.Black;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.BackColor1 = System.Drawing.Color.White;
            this.btn_Huy.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Huy.ButtonColor = System.Drawing.SystemColors.Window;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Huy.Location = new System.Drawing.Point(410, 464);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.OnHoverBorderColor = System.Drawing.Color.Crimson;
            this.btn_Huy.OnHoverButtonColor = System.Drawing.Color.Crimson;
            this.btn_Huy.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Huy.Size = new System.Drawing.Size(93, 36);
            this.btn_Huy.TabIndex = 10;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.Black;
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 3);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nhãn";
            // 
            // lb_Nhan
            // 
            this.lb_Nhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nhan.AutoSize = true;
            this.lb_Nhan.Location = new System.Drawing.Point(248, 387);
            this.lb_Nhan.Name = "lb_Nhan";
            this.lb_Nhan.Size = new System.Drawing.Size(47, 20);
            this.lb_Nhan.TabIndex = 0;
            this.lb_Nhan.Text = "Nhãn";
            // 
            // cB_NgonNgu
            // 
            this.cB_NgonNgu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_NgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_NgonNgu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_NgonNgu.FormattingEnabled = true;
            this.cB_NgonNgu.Location = new System.Drawing.Point(188, 273);
            this.cB_NgonNgu.Name = "cB_NgonNgu";
            this.cB_NgonNgu.Size = new System.Drawing.Size(127, 33);
            this.cB_NgonNgu.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngôn ngữ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Định dạng";
            // 
            // cB_DinhDang
            // 
            this.cB_DinhDang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_DinhDang.BackColor = System.Drawing.SystemColors.Window;
            this.cB_DinhDang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_DinhDang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_DinhDang.FormattingEnabled = true;
            this.cB_DinhDang.Location = new System.Drawing.Point(188, 216);
            this.cB_DinhDang.Name = "cB_DinhDang";
            this.cB_DinhDang.Size = new System.Drawing.Size(127, 33);
            this.cB_DinhDang.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ghế thường:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ghế VIP:";
            // 
            // lb_SoGheT
            // 
            this.lb_SoGheT.AutoSize = true;
            this.lb_SoGheT.Location = new System.Drawing.Point(143, 44);
            this.lb_SoGheT.Name = "lb_SoGheT";
            this.lb_SoGheT.Size = new System.Drawing.Size(20, 20);
            this.lb_SoGheT.TabIndex = 0;
            this.lb_SoGheT.Text = "N";
            // 
            // lb_SoGheV
            // 
            this.lb_SoGheV.AutoSize = true;
            this.lb_SoGheV.Location = new System.Drawing.Point(143, 76);
            this.lb_SoGheV.Name = "lb_SoGheV";
            this.lb_SoGheV.Size = new System.Drawing.Size(20, 20);
            this.lb_SoGheV.TabIndex = 0;
            this.lb_SoGheV.Text = "N";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số ghế trống";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(917, 548);
            this.Name = "SalesForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsDatVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_SlgVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lb_NhanVien;
        private System.Windows.Forms.ImageList imgList_Phim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_dsDatVe;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlgVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_SlgVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Round_Button btn_Xoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txB_TenPhim;
        private System.Windows.Forms.TextBox txB_TienDu;
        private System.Windows.Forms.TextBox txB_TienKhachTra;
        private System.Windows.Forms.TextBox txB_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ChonGhe;
        private System.Windows.Forms.TextBox txB_ChonGhe;
        private Round_Button btn_ThanhToan;
        private Round_Button btn_Huy;
        private System.Windows.Forms.Label lb_PhongSo;
        private System.Windows.Forms.Label lb_Nhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cB_DinhDang;
        private System.Windows.Forms.ComboBox cB_NgonNgu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_SoGheV;
        private System.Windows.Forms.Label lb_SoGheT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}

