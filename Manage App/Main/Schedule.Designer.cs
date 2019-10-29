namespace Manage_App
{
    partial class Schedule
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
            this.btn_Xem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_PhongChieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_Phim = new System.Windows.Forms.ComboBox();
            this.btn_Add = new CustomControl.Round_Button();
            this.btn_Edit = new CustomControl.Round_Button();
            this.btn_Delete = new CustomControl.Round_Button();
            this.btn_Refresh = new CustomControl.Round_Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_Phim = new System.Windows.Forms.DataGridView();
            this.col_ID_LichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PhongChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThoiGianChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TGKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btn_Xem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cB_PhongChieu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cB_Phim);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 55);
            this.panel1.TabIndex = 0;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Xem.Location = new System.Drawing.Point(516, 13);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(86, 30);
            this.btn_Xem.TabIndex = 6;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(296, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phòng chiếu";
            // 
            // cB_PhongChieu
            // 
            this.cB_PhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PhongChieu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_PhongChieu.FormattingEnabled = true;
            this.cB_PhongChieu.Location = new System.Drawing.Point(402, 13);
            this.cB_PhongChieu.Name = "cB_PhongChieu";
            this.cB_PhongChieu.Size = new System.Drawing.Size(89, 29);
            this.cB_PhongChieu.TabIndex = 4;
            this.toolTip.SetToolTip(this.cB_PhongChieu, "Phim đang chiếu và sắp chiếu");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn phim";
            // 
            // cB_Phim
            // 
            this.cB_Phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Phim.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_Phim.FormattingEnabled = true;
            this.cB_Phim.Location = new System.Drawing.Point(115, 14);
            this.cB_Phim.Name = "cB_Phim";
            this.cB_Phim.Size = new System.Drawing.Size(160, 29);
            this.cB_Phim.TabIndex = 2;
            this.toolTip.SetToolTip(this.cB_Phim, "Phim đang chiếu và sắp chiếu");
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Add.ButtonImage = global::Manage_App.Properties.Resources.icons8_plus_math_20;
            this.btn_Add.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(635, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverButtonColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Add.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_Add.Size = new System.Drawing.Size(87, 39);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "     Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Edit.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Edit.ButtonImage = global::Manage_App.Properties.Resources.icons8_edit_iOS_20;
            this.btn_Edit.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(728, 8);
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
            this.btn_Delete.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(821, 8);
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
            this.btn_Refresh.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Location = new System.Drawing.Point(914, 8);
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
            // dgv_Phim
            // 
            this.dgv_Phim.AllowUserToAddRows = false;
            this.dgv_Phim.AllowUserToDeleteRows = false;
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
            this.col_ID_LichChieu,
            this.col_TenPhim,
            this.col_DN,
            this.col_PhongChieu,
            this.col_ThoiGianChieu,
            this.col_TGKetThuc});
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
            this.dgv_Phim.Size = new System.Drawing.Size(974, 478);
            this.dgv_Phim.TabIndex = 1;
            // 
            // col_ID_LichChieu
            // 
            this.col_ID_LichChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID_LichChieu.DataPropertyName = "ID_LichChieu";
            this.col_ID_LichChieu.HeaderText = "ID_LichChieu";
            this.col_ID_LichChieu.Name = "col_ID_LichChieu";
            this.col_ID_LichChieu.Visible = false;
            // 
            // col_TenPhim
            // 
            this.col_TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_TenPhim.HeaderText = "Tên Phim";
            this.col_TenPhim.Name = "col_TenPhim";
            this.col_TenPhim.Visible = false;
            // 
            // col_DN
            // 
            this.col_DN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DN.DataPropertyName = "DN";
            this.col_DN.HeaderText = "Định dạng - Ngôn Ngữ";
            this.col_DN.Name = "col_DN";
            // 
            // col_PhongChieu
            // 
            this.col_PhongChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_PhongChieu.DataPropertyName = "TenPhong";
            this.col_PhongChieu.HeaderText = "Phòng chiếu";
            this.col_PhongChieu.Name = "col_PhongChieu";
            // 
            // col_ThoiGianChieu
            // 
            this.col_ThoiGianChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ThoiGianChieu.DataPropertyName = "ThoiGianChieu";
            this.col_ThoiGianChieu.HeaderText = "Thời gian chiếu";
            this.col_ThoiGianChieu.Name = "col_ThoiGianChieu";
            // 
            // col_TGKetThuc
            // 
            this.col_TGKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.col_TGKetThuc.HeaderText = "Thời gian kết thúc";
            this.col_TGKetThuc.Name = "col_TGKetThuc";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_Phim);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(757, 533);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(974, 533);
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private CustomControl.Round_Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_Phim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_PhongChieu;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID_LichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PhongChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThoiGianChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TGKetThuc;
    }
}
