namespace Book_Tickets_App
{
    partial class SignUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.txB_Pass = new LollipopTextBox();
            this.txB_UserName = new LollipopTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SignUp = new CustomControl.Round_Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txB_PassAgaint = new LollipopTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txB_HoTen = new LollipopTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbtn_Nam = new LollipopRadioButton();
            this.rbtn_Nu = new LollipopRadioButton();
            this.SuspendLayout();
            // 
            // txB_Pass
            // 
            this.txB_Pass.FocusedColor = "#508ef5";
            this.txB_Pass.FontColor = "#999999";
            this.txB_Pass.IsEnabled = true;
            this.txB_Pass.Location = new System.Drawing.Point(45, 220);
            this.txB_Pass.MaxLength = 32767;
            this.txB_Pass.Multiline = false;
            this.txB_Pass.Name = "txB_Pass";
            this.txB_Pass.ReadOnly = false;
            this.txB_Pass.Size = new System.Drawing.Size(249, 24);
            this.txB_Pass.TabIndex = 13;
            this.txB_Pass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_Pass.UseSystemPasswordChar = true;
            // 
            // txB_UserName
            // 
            this.txB_UserName.FocusedColor = "#508ef5";
            this.txB_UserName.FontColor = "#999999";
            this.txB_UserName.IsEnabled = true;
            this.txB_UserName.Location = new System.Drawing.Point(45, 137);
            this.txB_UserName.MaxLength = 32767;
            this.txB_UserName.Multiline = false;
            this.txB_UserName.Name = "txB_UserName";
            this.txB_UserName.ReadOnly = false;
            this.txB_UserName.Size = new System.Drawing.Size(249, 24);
            this.txB_UserName.TabIndex = 13;
            this.txB_UserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_UserName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(42, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BorderColor = System.Drawing.Color.Silver;
            this.btn_SignUp.ButtonColor = System.Drawing.Color.White;
            this.btn_SignUp.ButtonImage = null;
            this.btn_SignUp.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignUp.Enabled = false;
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.Location = new System.Drawing.Point(265, 407);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_SignUp.OnHoverButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_SignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SignUp.Size = new System.Drawing.Size(167, 42);
            this.btn_SignUp.TabIndex = 12;
            this.btn_SignUp.Text = "Đăng ký";
            this.btn_SignUp.TextColor = System.Drawing.Color.Black;
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(41, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(42, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txB_PassAgaint
            // 
            this.txB_PassAgaint.FocusedColor = "#508ef5";
            this.txB_PassAgaint.FontColor = "#999999";
            this.txB_PassAgaint.IsEnabled = true;
            this.txB_PassAgaint.Location = new System.Drawing.Point(46, 312);
            this.txB_PassAgaint.MaxLength = 32767;
            this.txB_PassAgaint.Multiline = false;
            this.txB_PassAgaint.Name = "txB_PassAgaint";
            this.txB_PassAgaint.ReadOnly = false;
            this.txB_PassAgaint.Size = new System.Drawing.Size(249, 24);
            this.txB_PassAgaint.TabIndex = 13;
            this.txB_PassAgaint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_PassAgaint.UseSystemPasswordChar = true;
            this.txB_PassAgaint.Validated += new System.EventHandler(this.txB_PassAgaint_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(387, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(388, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(388, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ tên";
            // 
            // txB_HoTen
            // 
            this.txB_HoTen.FocusedColor = "#508ef5";
            this.txB_HoTen.FontColor = "#999999";
            this.txB_HoTen.IsEnabled = true;
            this.txB_HoTen.Location = new System.Drawing.Point(391, 137);
            this.txB_HoTen.MaxLength = 32767;
            this.txB_HoTen.Multiline = false;
            this.txB_HoTen.Name = "txB_HoTen";
            this.txB_HoTen.ReadOnly = false;
            this.txB_HoTen.Size = new System.Drawing.Size(249, 24);
            this.txB_HoTen.TabIndex = 13;
            this.txB_HoTen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_HoTen.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(385, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Thông tin cá nhân";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(391, 216);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 28);
            this.dtp_NgaySinh.TabIndex = 14;
            this.dtp_NgaySinh.ValueChanged += new System.EventHandler(this.dtp_NgaySinh_ValueChanged);
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.CheckColor = "#508ef5";
            this.rbtn_Nam.Checked = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(392, 317);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(52, 19);
            this.rbtn_Nam.TabIndex = 15;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.CheckColor = "#508ef5";
            this.rbtn_Nu.Location = new System.Drawing.Point(489, 317);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(41, 19);
            this.rbtn_Nu.TabIndex = 15;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 468);
            this.Controls.Add(this.rbtn_Nu);
            this.Controls.Add(this.rbtn_Nam);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.txB_PassAgaint);
            this.Controls.Add(this.txB_Pass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txB_HoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txB_UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignUp_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LollipopTextBox txB_Pass;
        private LollipopTextBox txB_UserName;
        private System.Windows.Forms.Label label1;
        private CustomControl.Round_Button btn_SignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private LollipopTextBox txB_PassAgaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private LollipopTextBox txB_HoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private LollipopRadioButton rbtn_Nam;
        private LollipopRadioButton rbtn_Nu;
    }
}