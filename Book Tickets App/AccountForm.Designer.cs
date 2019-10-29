namespace Book_Tickets_App
{
    partial class AccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_ChangeAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::Book_Tickets_App.Properties.Resources.icons8_delete_25_white;
            this.btn_Close.Location = new System.Drawing.Point(200, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 43);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
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
            this.btn_DangXuat.Image = global::Book_Tickets_App.Properties.Resources.icons8_export_iOS_22;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(18, 192);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btn_DangXuat.Size = new System.Drawing.Size(219, 48);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "      Đăng xuất";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btn_TaiKhoan.Image = global::Book_Tickets_App.Properties.Resources.icons8_male_user_Windows_10_24;
            this.btn_TaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(18, 80);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_TaiKhoan.Size = new System.Drawing.Size(219, 48);
            this.btn_TaiKhoan.TabIndex = 3;
            this.btn_TaiKhoan.Text = "      Tài khoản";
            this.btn_TaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btn_ChangeAcc.Image = global::Book_Tickets_App.Properties.Resources.icons8_change_user_Windows_10_24;
            this.btn_ChangeAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangeAcc.Location = new System.Drawing.Point(18, 136);
            this.btn_ChangeAcc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChangeAcc.Name = "btn_ChangeAcc";
            this.btn_ChangeAcc.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btn_ChangeAcc.Size = new System.Drawing.Size(219, 48);
            this.btn_ChangeAcc.TabIndex = 4;
            this.btn_ChangeAcc.Text = "      Thay đổi tài khoản";
            this.btn_ChangeAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChangeAcc.UseVisualStyleBackColor = false;
            this.btn_ChangeAcc.Click += new System.EventHandler(this.btn_ChangeAcc_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(255, 269);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_TaiKhoan);
            this.Controls.Add(this.btn_ChangeAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TaiKhoan;
        private System.Windows.Forms.Button btn_ChangeAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
    }
}