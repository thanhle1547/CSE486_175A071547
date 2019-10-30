namespace Manage_App.Function_Form
{
    partial class ScheduleDetails
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cB_DN = new System.Windows.Forms.ComboBox();
            this.cB_Phong = new System.Windows.Forms.ComboBox();
            this.cB_TenPhim = new System.Windows.Forms.ComboBox();
            this.dtp_TG = new System.Windows.Forms.DateTimePicker();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new CustomControl.Round_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Huy = new CustomControl.Round_Button();
            this.btn_Add = new CustomControl.Round_Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cB_DN);
            this.panel3.Controls.Add(this.cB_Phong);
            this.panel3.Controls.Add(this.cB_TenPhim);
            this.panel3.Controls.Add(this.dtp_TG);
            this.panel3.Controls.Add(this.dtp_Ngay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 80, 0, 60);
            this.panel3.Size = new System.Drawing.Size(752, 414);
            this.panel3.TabIndex = 57;
            // 
            // cB_DN
            // 
            this.cB_DN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_DN.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cB_DN.FormattingEnabled = true;
            this.cB_DN.Location = new System.Drawing.Point(116, 197);
            this.cB_DN.Name = "cB_DN";
            this.cB_DN.Size = new System.Drawing.Size(334, 33);
            this.cB_DN.TabIndex = 50;
            // 
            // cB_Phong
            // 
            this.cB_Phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Phong.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cB_Phong.FormattingEnabled = true;
            this.cB_Phong.Location = new System.Drawing.Point(525, 316);
            this.cB_Phong.Name = "cB_Phong";
            this.cB_Phong.Size = new System.Drawing.Size(108, 33);
            this.cB_Phong.TabIndex = 50;
            // 
            // cB_TenPhim
            // 
            this.cB_TenPhim.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cB_TenPhim.FormattingEnabled = true;
            this.cB_TenPhim.Location = new System.Drawing.Point(116, 75);
            this.cB_TenPhim.Name = "cB_TenPhim";
            this.cB_TenPhim.Size = new System.Drawing.Size(517, 33);
            this.cB_TenPhim.TabIndex = 50;
            this.cB_TenPhim.SelectedIndexChanged += new System.EventHandler(this.cB_TenPhim_SelectedIndexChanged);
            // 
            // dtp_TG
            // 
            this.dtp_TG.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtp_TG.CustomFormat = "HH:mm";
            this.dtp_TG.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtp_TG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TG.Location = new System.Drawing.Point(339, 316);
            this.dtp_TG.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_TG.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtp_TG.Name = "dtp_TG";
            this.dtp_TG.ShowUpDown = true;
            this.dtp_TG.Size = new System.Drawing.Size(111, 33);
            this.dtp_TG.TabIndex = 44;
            this.dtp_TG.Value = new System.DateTime(2019, 10, 23, 0, 16, 0, 0);
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtp_Ngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_Ngay.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.dtp_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngay.Location = new System.Drawing.Point(116, 316);
            this.dtp_Ngay.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_Ngay.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(158, 33);
            this.dtp_Ngay.TabIndex = 44;
            this.dtp_Ngay.Value = new System.DateTime(2019, 10, 23, 0, 16, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Định dạng - Ngôn ngữ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 62);
            this.panel1.TabIndex = 56;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Update.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Update.ButtonImage = null;
            this.btn_Update.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(594, 11);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Update.OnHoverButtonColor = System.Drawing.Color.White;
            this.btn_Update.OnHoverTextColor = System.Drawing.Color.Fuchsia;
            this.btn_Update.Size = new System.Drawing.Size(112, 40);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.TextColor = System.Drawing.Color.Transparent;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lịch chiếu phim";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Huy.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Huy.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Huy.ButtonImage = null;
            this.btn_Huy.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Huy.Location = new System.Drawing.Point(35, 11);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Huy.OnHoverButtonColor = System.Drawing.Color.White;
            this.btn_Huy.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Size = new System.Drawing.Size(101, 40);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextColor = System.Drawing.Color.Transparent;
            this.btn_Huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Add.ButtonImage = null;
            this.btn_Add.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(594, 11);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverButtonColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.Fuchsia;
            this.btn_Add.Size = new System.Drawing.Size(112, 40);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.Transparent;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Huy;
            this.ClientSize = new System.Drawing.Size(752, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Details";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.Round_Button btn_Update;
        private System.Windows.Forms.Label label1;
        private CustomControl.Round_Button btn_Huy;
        private CustomControl.Round_Button btn_Add;
        private System.Windows.Forms.DateTimePicker dtp_TG;
        private System.Windows.Forms.ComboBox cB_Phong;
        private System.Windows.Forms.ComboBox cB_TenPhim;
        private System.Windows.Forms.ComboBox cB_DN;
        private System.Windows.Forms.Label label7;
    }
}