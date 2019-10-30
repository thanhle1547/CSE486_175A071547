namespace Manage_App
{
    partial class Personnel
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
            this.label1 = new System.Windows.Forms.Label();
            this.cB_ChucVu = new System.Windows.Forms.ComboBox();
            this.btn_Add = new CustomControl.Round_Button();
            this.btn_Edit = new CustomControl.Round_Button();
            this.btn_Delete = new CustomControl.Round_Button();
            this.btn_Refresh = new CustomControl.Round_Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Que = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cB_ChucVu);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chức vụ";
            // 
            // cB_ChucVu
            // 
            this.cB_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_ChucVu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cB_ChucVu.FormattingEnabled = true;
            this.cB_ChucVu.Location = new System.Drawing.Point(115, 14);
            this.cB_ChucVu.Name = "cB_ChucVu";
            this.cB_ChucVu.Size = new System.Drawing.Size(197, 29);
            this.cB_ChucVu.TabIndex = 2;
            this.cB_ChucVu.SelectedIndexChanged += new System.EventHandler(this.cB_ChucVu_SelectedIndexChanged);
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
            this.btn_Add.Location = new System.Drawing.Point(530, 8);
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
            this.btn_Delete.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
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
            this.btn_Refresh.ButtonImageAlign = System.Drawing.ContentAlignment.TopLeft;
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
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_HoTen,
            this.col_NgaySinh,
            this.col_GioiTinh,
            this.col_Que,
            this.col_SoCMT,
            this.col_ChucVu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Magenta;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 55);
            this.dgv_NhanVien.MultiSelect = false;
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(869, 478);
            this.dgv_NhanVien.TabIndex = 1;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "IDNhanVien";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = false;
            // 
            // col_HoTen
            // 
            this.col_HoTen.DataPropertyName = "HoTen";
            this.col_HoTen.HeaderText = "Họ tên";
            this.col_HoTen.Name = "col_HoTen";
            this.col_HoTen.Width = 333;
            // 
            // col_NgaySinh
            // 
            this.col_NgaySinh.DataPropertyName = "NgaySinh";
            this.col_NgaySinh.HeaderText = "Ngày sinh";
            this.col_NgaySinh.Name = "col_NgaySinh";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_Que
            // 
            this.col_Que.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Que.DataPropertyName = "Que";
            this.col_Que.HeaderText = "Quê quán";
            this.col_Que.Name = "col_Que";
            // 
            // col_SoCMT
            // 
            this.col_SoCMT.DataPropertyName = "SoChungMinhThu";
            this.col_SoCMT.HeaderText = "Số CMT";
            this.col_SoCMT.Name = "col_SoCMT";
            // 
            // col_ChucVu
            // 
            this.col_ChucVu.DataPropertyName = "ChucVu";
            this.col_ChucVu.HeaderText = "Chức vụ";
            this.col_ChucVu.Name = "col_ChucVu";
            // 
            // Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(757, 533);
            this.Name = "Personnel";
            this.Size = new System.Drawing.Size(869, 533);
            this.Load += new System.EventHandler(this.Personnel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.Round_Button btn_Delete;
        private CustomControl.Round_Button btn_Refresh;
        private System.Windows.Forms.ToolTip toolTip;
        private CustomControl.Round_Button btn_Edit;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private CustomControl.Round_Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Que;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChucVu;
    }
}
