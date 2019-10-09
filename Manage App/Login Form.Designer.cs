﻿namespace Manage_App
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_Remember = new LollipopCheckBox();
            this.ckB_ShowPass = new LollipopCheckBox();
            this.round_Button1 = new CustomControl.Round_Button();
            this.txB_UserName = new LollipopTextBox();
            this.txB_Pass = new LollipopTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manage_App.Properties.Resources.icons8_movie_Cute_Clipart_512;
            this.pictureBox1.Location = new System.Drawing.Point(95, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(78, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đăng nhập";
            // 
            // cB_Remember
            // 
            this.cB_Remember.AutoSize = true;
            this.cB_Remember.CheckColor = "#508ef5";
            this.cB_Remember.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Remember.Location = new System.Drawing.Point(43, 405);
            this.cB_Remember.Name = "cB_Remember";
            this.cB_Remember.Size = new System.Drawing.Size(110, 20);
            this.cB_Remember.TabIndex = 10;
            this.cB_Remember.Text = "Nhớ tài khoản";
            this.cB_Remember.UseVisualStyleBackColor = true;
            // 
            // ckB_ShowPass
            // 
            this.ckB_ShowPass.AutoSize = true;
            this.ckB_ShowPass.CheckColor = "#508ef5";
            this.ckB_ShowPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_ShowPass.Location = new System.Drawing.Point(43, 379);
            this.ckB_ShowPass.Name = "ckB_ShowPass";
            this.ckB_ShowPass.Size = new System.Drawing.Size(114, 20);
            this.ckB_ShowPass.TabIndex = 10;
            this.ckB_ShowPass.Text = "Hiện mật khẩu";
            this.ckB_ShowPass.UseVisualStyleBackColor = true;
            // 
            // round_Button1
            // 
            this.round_Button1.BorderColor = System.Drawing.Color.Silver;
            this.round_Button1.ButtonColor = System.Drawing.Color.White;
            this.round_Button1.FlatAppearance.BorderSize = 0;
            this.round_Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.round_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.round_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_Button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_Button1.Location = new System.Drawing.Point(82, 446);
            this.round_Button1.Name = "round_Button1";
            this.round_Button1.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.round_Button1.OnHoverButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.round_Button1.OnHoverTextColor = System.Drawing.Color.White;
            this.round_Button1.Size = new System.Drawing.Size(167, 42);
            this.round_Button1.TabIndex = 12;
            this.round_Button1.Text = "Đăng nhập";
            this.round_Button1.TextColor = System.Drawing.Color.Black;
            this.round_Button1.UseVisualStyleBackColor = true;
            // 
            // txB_UserName
            // 
            this.txB_UserName.FocusedColor = "#508ef5";
            this.txB_UserName.FontColor = "#999999";
            this.txB_UserName.IsEnabled = true;
            this.txB_UserName.Location = new System.Drawing.Point(42, 259);
            this.txB_UserName.MaxLength = 32767;
            this.txB_UserName.Multiline = false;
            this.txB_UserName.Name = "txB_UserName";
            this.txB_UserName.ReadOnly = false;
            this.txB_UserName.Size = new System.Drawing.Size(249, 24);
            this.txB_UserName.TabIndex = 13;
            this.txB_UserName.Text = "Tên đăng nhập";
            this.txB_UserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_UserName.UseSystemPasswordChar = false;
            // 
            // txB_Pass
            // 
            this.txB_Pass.FocusedColor = "#508ef5";
            this.txB_Pass.FontColor = "#999999";
            this.txB_Pass.IsEnabled = true;
            this.txB_Pass.Location = new System.Drawing.Point(42, 342);
            this.txB_Pass.MaxLength = 32767;
            this.txB_Pass.Multiline = false;
            this.txB_Pass.Name = "txB_Pass";
            this.txB_Pass.ReadOnly = false;
            this.txB_Pass.Size = new System.Drawing.Size(249, 24);
            this.txB_Pass.TabIndex = 13;
            this.txB_Pass.Text = "Mật khẩu";
            this.txB_Pass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_Pass.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txB_Pass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txB_UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.round_Button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ckB_ShowPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cB_Remember);
            this.panel1.Location = new System.Drawing.Point(297, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 509);
            this.panel1.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 533);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private LollipopCheckBox cB_Remember;
        private LollipopCheckBox ckB_ShowPass;
        private CustomControl.Round_Button round_Button1;
        private LollipopTextBox txB_UserName;
        private LollipopTextBox txB_Pass;
        private System.Windows.Forms.Panel panel1;
    }
}