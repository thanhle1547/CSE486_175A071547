namespace Manage_App
{
    partial class Customer
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
            this.cB_DoTuoi = new System.Windows.Forms.ComboBox();
            this.cB_GioiTinh = new System.Windows.Forms.ComboBox();
            this.flatButton1 = new Manage_App.FlatButton();
            this.btn_Filter = new Manage_App.FlatButton();
            this.btn_Refresh = new CustomControl.Round_Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.p_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // p_Control
            // 
            this.p_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.p_Control.Controls.Add(this.label3);
            this.p_Control.Controls.Add(this.label2);
            this.p_Control.Controls.Add(this.cB_DoTuoi);
            this.p_Control.Controls.Add(this.cB_GioiTinh);
            this.p_Control.Controls.Add(this.flatButton1);
            this.p_Control.Controls.Add(this.btn_Filter);
            this.p_Control.Controls.Add(this.btn_Refresh);
            this.p_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Control.Location = new System.Drawing.Point(0, 0);
            this.p_Control.MaximumSize = new System.Drawing.Size(0, 117);
            this.p_Control.MinimumSize = new System.Drawing.Size(0, 55);
            this.p_Control.Name = "p_Control";
            this.p_Control.Size = new System.Drawing.Size(869, 55);
            this.p_Control.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(221, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Độ tuổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giới tính";
            // 
            // cB_DoTuoi
            // 
            this.cB_DoTuoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_DoTuoi.FormattingEnabled = true;
            this.cB_DoTuoi.Location = new System.Drawing.Point(291, 70);
            this.cB_DoTuoi.Name = "cB_DoTuoi";
            this.cB_DoTuoi.Size = new System.Drawing.Size(83, 29);
            this.cB_DoTuoi.TabIndex = 4;
            // 
            // cB_GioiTinh
            // 
            this.cB_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_GioiTinh.FormattingEnabled = true;
            this.cB_GioiTinh.Location = new System.Drawing.Point(98, 70);
            this.cB_GioiTinh.Name = "cB_GioiTinh";
            this.cB_GioiTinh.Size = new System.Drawing.Size(83, 29);
            this.cB_GioiTinh.TabIndex = 4;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flatButton1.ButtonColor = System.Drawing.Color.Transparent;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flatButton1.Location = new System.Drawing.Point(415, 66);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.flatButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.flatButton1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.flatButton1.Size = new System.Drawing.Size(73, 35);
            this.flatButton1.TabIndex = 2;
            this.flatButton1.Text = "  Lọc";
            this.flatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.flatButton1.TextColor = System.Drawing.Color.White;
            this.flatButton1.UseVisualStyleBackColor = false;
            this.flatButton1.Visible = false;
            this.flatButton1.Click += new System.EventHandler(this.btn_Filter_Click);
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
            this.btn_Filter.Visible = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.ButtonImage = null;
            this.btn_Refresh.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Image = global::Manage_App.Properties.Resources.icons8_refresh_iOS_Glyph_20;
            this.btn_Refresh.Location = new System.Drawing.Point(3416, 8);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btn_Refresh.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Size = new System.Drawing.Size(39, 39);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btn_Refresh, "Tải lại");
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_HoTen,
            this.col_NgaySinh,
            this.col_GioiTinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhachHang.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 55);
            this.dgv_KhachHang.MultiSelect = false;
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(869, 478);
            this.dgv_KhachHang.TabIndex = 1;
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.DataPropertyName = "IDKhachHang";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Width = 50;
            // 
            // col_HoTen
            // 
            this.col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_HoTen.DataPropertyName = "HoTen";
            this.col_HoTen.HeaderText = "Họ tên";
            this.col_HoTen.Name = "col_HoTen";
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày sinh";
            this.col_NgaySinh.Name = "col_NgaySinh";
            this.col_NgaySinh.Width = 96;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_KhachHang);
            this.Controls.Add(this.p_Control);
            this.MinimumSize = new System.Drawing.Size(757, 533);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(869, 533);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.p_Control.ResumeLayout(false);
            this.p_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_Control;
        private CustomControl.Round_Button btn_Refresh;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private FlatButton btn_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_GioiTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_DoTuoi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private FlatButton flatButton1;
    }
}
