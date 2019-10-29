namespace Book_Tickets_App
{
    partial class PickingSeat
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
            this.label10 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new CustomControl.Round_Button();
            this.btn_ThanhToan = new CustomControl.Round_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(407, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Chọn ghế";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuayLai.BorderColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.ButtonImage = null;
            this.btn_QuayLai.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btn_QuayLai.ForeColor = System.Drawing.Color.White;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(33, 11);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.OnHoverButtonColor = System.Drawing.Color.White;
            this.btn_QuayLai.OnHoverTextColor = System.Drawing.Color.Fuchsia;
            this.btn_QuayLai.Size = new System.Drawing.Size(111, 40);
            this.btn_QuayLai.TabIndex = 5;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextColor = System.Drawing.Color.Transparent;
            this.btn_QuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.ButtonImage = null;
            this.btn_ThanhToan.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(725, 11);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_ThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Size = new System.Drawing.Size(152, 40);
            this.btn_ThanhToan.TabIndex = 5;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextColor = System.Drawing.Color.Transparent;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_QuayLai);
            this.panel1.Controls.Add(this.btn_ThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 62);
            this.panel1.TabIndex = 6;
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 62);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(200, 100, 200, 100);
            this.container.Size = new System.Drawing.Size(907, 408);
            this.container.TabIndex = 7;
            // 
            // PickingSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Name = "PickingSeat";
            this.Size = new System.Drawing.Size(907, 470);
            this.Load += new System.EventHandler(this.PickingSeat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private CustomControl.Round_Button btn_ThanhToan;
        private CustomControl.Round_Button btn_QuayLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
    }
}
