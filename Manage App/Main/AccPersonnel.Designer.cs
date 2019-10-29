namespace Manage_App
{
    partial class AccPersonnel
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
            this.p_Control = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_DoTuoi = new System.Windows.Forms.ComboBox();
            this.cB_GioiTinh = new System.Windows.Forms.ComboBox();
            this.cB_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_Filter = new Manage_App.FlatButton();
            this.round_Button1 = new CustomControl.Round_Button();
            this.btn_Edit = new CustomControl.Round_Button();
            this.btn_Delete = new CustomControl.Round_Button();
            this.btn_Refresh = new CustomControl.Round_Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_Phim = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_KhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Rated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.p_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Control
            // 
            this.p_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.p_Control.Controls.Add(this.label3);
            this.p_Control.Controls.Add(this.label2);
            this.p_Control.Controls.Add(this.label1);
            this.p_Control.Controls.Add(this.cB_DoTuoi);
            this.p_Control.Controls.Add(this.cB_GioiTinh);
            this.p_Control.Controls.Add(this.cB_ChucVu);
            this.p_Control.Controls.Add(this.btn_Filter);
            this.p_Control.Controls.Add(this.round_Button1);
            this.p_Control.Controls.Add(this.btn_Edit);
            this.p_Control.Controls.Add(this.btn_Delete);
            this.p_Control.Controls.Add(this.btn_Refresh);
            this.p_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Control.Location = new System.Drawing.Point(0, 0);
            this.p_Control.Name = "p_Control";
            this.p_Control.Size = new System.Drawing.Size(869, 55);
            this.p_Control.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(497, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Độ tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(281, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chức vụ";
            // 
            // cB_DoTuoi
            // 
            this.cB_DoTuoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_DoTuoi.FormattingEnabled = true;
            this.cB_DoTuoi.Location = new System.Drawing.Point(587, 73);
            this.cB_DoTuoi.Name = "cB_DoTuoi";
            this.cB_DoTuoi.Size = new System.Drawing.Size(83, 29);
            this.cB_DoTuoi.TabIndex = 4;
            // 
            // cB_GioiTinh
            // 
            this.cB_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_GioiTinh.FormattingEnabled = true;
            this.cB_GioiTinh.Location = new System.Drawing.Point(371, 73);
            this.cB_GioiTinh.Name = "cB_GioiTinh";
            this.cB_GioiTinh.Size = new System.Drawing.Size(83, 29);
            this.cB_GioiTinh.TabIndex = 4;
            // 
            // cB_ChucVu
            // 
            this.cB_ChucVu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_ChucVu.FormattingEnabled = true;
            this.cB_ChucVu.Location = new System.Drawing.Point(108, 73);
            this.cB_ChucVu.Name = "cB_ChucVu";
            this.cB_ChucVu.Size = new System.Drawing.Size(127, 29);
            this.cB_ChucVu.TabIndex = 4;
            // 
            // btn_Filter
            // 
            this.btn_Filter.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Filter.Image = global::Manage_App.Properties.Resources.icons8_filter_iOS_Filled_20_95A5A6;
            this.btn_Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.Location = new System.Drawing.Point(22, 10);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Filter.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Filter.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_Filter.Size = new System.Drawing.Size(87, 35);
            this.btn_Filter.TabIndex = 2;
            this.btn_Filter.Text = "  Lọc";
            this.btn_Filter.TextColor = System.Drawing.Color.White;
            this.btn_Filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // round_Button1
            // 
            this.round_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.round_Button1.BorderColor = System.Drawing.Color.Transparent;
            this.round_Button1.ButtonColor = System.Drawing.Color.Transparent;
            this.round_Button1.FlatAppearance.BorderSize = 0;
            this.round_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.round_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.round_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.round_Button1.Image = global::Manage_App.Properties.Resources.icons8_plus_math_20;
            this.round_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.round_Button1.Location = new System.Drawing.Point(530, 8);
            this.round_Button1.Name = "round_Button1";
            this.round_Button1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.round_Button1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.round_Button1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.round_Button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.round_Button1.Size = new System.Drawing.Size(87, 39);
            this.round_Button1.TabIndex = 1;
            this.round_Button1.Text = "     Thêm";
            this.round_Button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.round_Button1.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Edit.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Edit.Image = global::Manage_App.Properties.Resources.icons8_edit_iOS_20;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(623, 8);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Edit.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Edit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Edit.Size = new System.Drawing.Size(87, 39);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "     Sửa";
            this.btn_Edit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.Image = global::Manage_App.Properties.Resources.icons8_delete_20;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(716, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Delete.Size = new System.Drawing.Size(87, 39);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "     Xóa";
            this.btn_Delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Image = global::Manage_App.Properties.Resources.icons8_refresh_iOS_Glyph_20;
            this.btn_Refresh.Location = new System.Drawing.Point(809, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Refresh.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Size = new System.Drawing.Size(39, 39);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btn_Refresh, "Tải lại");
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // dgv_Phim
            // 
            this.dgv_Phim.AllowUserToAddRows = false;
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
            this.col_MoTa});
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
            this.dgv_Phim.Name = "dgv_Phim";
            this.dgv_Phim.Size = new System.Drawing.Size(869, 478);
            this.dgv_Phim.TabIndex = 1;
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 50;
            // 
            // col_NSX
            // 
            this.col_NSX.HeaderText = "Nhà sản xuất";
            this.col_NSX.Name = "col_NSX";
            // 
            // col_TenPhim
            // 
            this.col_TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenPhim.HeaderText = "Tên Phim";
            this.col_TenPhim.Name = "col_TenPhim";
            // 
            // col_Poster
            // 
            this.col_Poster.HeaderText = "Poster";
            this.col_Poster.Name = "col_Poster";
            // 
            // col_ThoiLuong
            // 
            this.col_ThoiLuong.HeaderText = "Thời Lượng";
            this.col_ThoiLuong.Name = "col_ThoiLuong";
            // 
            // col_KhoiChieu
            // 
            this.col_KhoiChieu.HeaderText = "Khởi Chiếu";
            this.col_KhoiChieu.Name = "col_KhoiChieu";
            // 
            // col_Rated
            // 
            this.col_Rated.HeaderText = "Rated";
            this.col_Rated.Name = "col_Rated";
            // 
            // col_MoTa
            // 
            this.col_MoTa.HeaderText = "Mô Tả";
            this.col_MoTa.Name = "col_MoTa";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AccPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_Phim);
            this.Controls.Add(this.p_Control);
            this.MinimumSize = new System.Drawing.Size(757, 533);
            this.Name = "AccPersonnel";
            this.Size = new System.Drawing.Size(869, 533);
            this.p_Control.ResumeLayout(false);
            this.p_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Control;
        private CustomControl.Round_Button btn_Delete;
        private CustomControl.Round_Button btn_Refresh;
        private System.Windows.Forms.ToolTip toolTip;
        private CustomControl.Round_Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_Phim;
        private CustomControl.Round_Button round_Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_KhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Rated;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MoTa;
        private FlatButton btn_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_GioiTinh;
        private System.Windows.Forms.ComboBox cB_ChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_DoTuoi;
        private System.Windows.Forms.Timer timer;
    }
}
