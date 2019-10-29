namespace Manage_App
{
    partial class MoviesList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_Loc = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_Phim = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Poster = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Rated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DaoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDienVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DinhDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new CustomControl.Round_Button();
            this.btn_Edit = new CustomControl.Round_Button();
            this.btn_Delete = new CustomControl.Round_Button();
            this.btn_Refresh = new CustomControl.Round_Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.cB_Loc);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 55);
            this.panel1.TabIndex = 0;
            // 
            // cB_Loc
            // 
            this.cB_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Loc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_Loc.FormattingEnabled = true;
            this.cB_Loc.Location = new System.Drawing.Point(28, 14);
            this.cB_Loc.Name = "cB_Loc";
            this.cB_Loc.Size = new System.Drawing.Size(219, 29);
            this.cB_Loc.TabIndex = 2;
            this.cB_Loc.SelectedIndexChanged += new System.EventHandler(this.cB_Loc_SelectedIndexChanged);
            // 
            // dgv_Phim
            // 
            this.dgv_Phim.AllowUserToAddRows = false;
            this.dgv_Phim.AllowUserToDeleteRows = false;
            this.dgv_Phim.AllowUserToOrderColumns = true;
            this.dgv_Phim.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Phim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Phim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_NSX,
            this.col_TenPhim,
            this.col_Poster,
            this.col_ThoiLuong,
            this.col_KhoiChieu,
            this.col_Rated,
            this.col_MoTa,
            this.col_DaoDien,
            this.TenDienVien,
            this.col_TheLoai,
            this.col_DinhDang,
            this.col_NgonNgu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Phim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Phim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Phim.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_Phim.Location = new System.Drawing.Point(0, 55);
            this.dgv_Phim.MultiSelect = false;
            this.dgv_Phim.Name = "dgv_Phim";
            this.dgv_Phim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phim.Size = new System.Drawing.Size(869, 478);
            this.dgv_Phim.TabIndex = 1;
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.DataPropertyName = "IDPhim";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 50;
            // 
            // col_NSX
            // 
            this.col_NSX.DataPropertyName = "TenNSX";
            this.col_NSX.HeaderText = "Nhà sản xuất";
            this.col_NSX.Name = "col_NSX";
            // 
            // col_TenPhim
            // 
            this.col_TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_TenPhim.DataPropertyName = "TenPhim";
            this.col_TenPhim.HeaderText = "Tên Phim";
            this.col_TenPhim.Name = "col_TenPhim";
            this.col_TenPhim.Width = 98;
            // 
            // col_Poster
            // 
            this.col_Poster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Poster.DataPropertyName = "Poster";
            this.col_Poster.HeaderText = "Poster";
            this.col_Poster.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_Poster.Name = "col_Poster";
            this.col_Poster.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Poster.Width = 59;
            // 
            // col_ThoiLuong
            // 
            this.col_ThoiLuong.DataPropertyName = "ThoiLuong";
            this.col_ThoiLuong.HeaderText = "Thời lượng";
            this.col_ThoiLuong.Name = "col_ThoiLuong";
            // 
            // col_KhoiChieu
            // 
            this.col_KhoiChieu.DataPropertyName = "KhoiChieu";
            this.col_KhoiChieu.HeaderText = "Khởi chiếu";
            this.col_KhoiChieu.Name = "col_KhoiChieu";
            // 
            // col_Rated
            // 
            this.col_Rated.DataPropertyName = "Rated";
            this.col_Rated.HeaderText = "Rated";
            this.col_Rated.Name = "col_Rated";
            // 
            // col_MoTa
            // 
            this.col_MoTa.DataPropertyName = "MoTa";
            this.col_MoTa.HeaderText = "Mô tả";
            this.col_MoTa.Name = "col_MoTa";
            // 
            // col_DaoDien
            // 
            this.col_DaoDien.DataPropertyName = "DaoDien";
            this.col_DaoDien.HeaderText = "Đạo diễn";
            this.col_DaoDien.Name = "col_DaoDien";
            // 
            // TenDienVien
            // 
            this.TenDienVien.DataPropertyName = "DienVien";
            this.TenDienVien.HeaderText = "Diễn viên";
            this.TenDienVien.Name = "TenDienVien";
            // 
            // col_TheLoai
            // 
            this.col_TheLoai.DataPropertyName = "TheLoai";
            this.col_TheLoai.HeaderText = "Thể loại";
            this.col_TheLoai.Name = "col_TheLoai";
            // 
            // col_DinhDang
            // 
            this.col_DinhDang.DataPropertyName = "DinhDang";
            this.col_DinhDang.HeaderText = "Đinh dạng";
            this.col_DinhDang.Name = "col_DinhDang";
            // 
            // col_NgonNgu
            // 
            this.col_NgonNgu.DataPropertyName = "NgonNgu";
            this.col_NgonNgu.HeaderText = "Ngôn ngữ";
            this.col_NgonNgu.Name = "col_NgonNgu";
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Them.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Them.ButtonImage = global::Manage_App.Properties.Resources.icons8_plus_math_20;
            this.btn_Them.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(530, 8);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Them.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Them.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Them.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Them.Size = new System.Drawing.Size(87, 39);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "     Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Edit.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Edit.ButtonImage = global::Manage_App.Properties.Resources.icons8_edit_iOS_20;
            this.btn_Edit.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(623, 8);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Edit.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Edit.Size = new System.Drawing.Size(87, 39);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "     Sửa";
            this.btn_Edit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Delete.ButtonImage = global::Manage_App.Properties.Resources.icons8_delete_20;
            this.btn_Delete.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(716, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Delete.Size = new System.Drawing.Size(87, 39);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "     Xóa";
            this.btn_Delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.ButtonImage = global::Manage_App.Properties.Resources.icons8_refresh_iOS_Glyph_20;
            this.btn_Refresh.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(809, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Refresh.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Size = new System.Drawing.Size(39, 39);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btn_Refresh, "Tải lại");
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_Phim);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(757, 533);
            this.Name = "MoviesList";
            this.Size = new System.Drawing.Size(869, 533);
            this.Load += new System.EventHandler(this.MoviesList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.Round_Button btn_Delete;
        private CustomControl.Round_Button btn_Refresh;
        private System.Windows.Forms.ToolTip toolTip;
        private CustomControl.Round_Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_Phim;
        private CustomControl.Round_Button btn_Them;
        private System.Windows.Forms.ComboBox cB_Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhim;
        private System.Windows.Forms.DataGridViewImageColumn col_Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Rated;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DaoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDienVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DinhDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgonNgu;
    }
}
