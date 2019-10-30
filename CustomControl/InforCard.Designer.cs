namespace CustomControl
{
    partial class InforCard
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.lb_TG = new CustomControl.Transparent_Label();
            this.lb_SoVe = new CustomControl.Transparent_Label();
            this.lb_PhongSo = new CustomControl.Transparent_Label();
            this.lb_Ghe = new CustomControl.Transparent_Label();
            this.lb_MaVe = new CustomControl.Transparent_Label();
            this.lb_TenPhim = new CustomControl.Transparent_Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialDivider1.Location = new System.Drawing.Point(588, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 179);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Black;
            this.Picture.BackgroundImage = global::CustomControl.Properties.Resources.rsz_it_chapter_two__vietnamese_poster;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.ImageLocation = "";
            this.Picture.Location = new System.Drawing.Point(-2, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(123, 179);
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // lb_TG
            // 
            this.lb_TG.AutoSize = true;
            this.lb_TG.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_TG.ForeColor = System.Drawing.Color.White;
            this.lb_TG.Location = new System.Drawing.Point(140, 137);
            this.lb_TG.Name = "lb_TG";
            this.lb_TG.Size = new System.Drawing.Size(98, 25);
            this.lb_TG.TabIndex = 4;
            this.lb_TG.Text = "Thời gian: ";
            // 
            // lb_SoVe
            // 
            this.lb_SoVe.AutoSize = true;
            this.lb_SoVe.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_SoVe.ForeColor = System.Drawing.Color.White;
            this.lb_SoVe.Location = new System.Drawing.Point(140, 100);
            this.lb_SoVe.Name = "lb_SoVe";
            this.lb_SoVe.Size = new System.Drawing.Size(46, 25);
            this.lb_SoVe.TabIndex = 4;
            this.lb_SoVe.Text = "2 vé";
            // 
            // lb_PhongSo
            // 
            this.lb_PhongSo.AutoSize = true;
            this.lb_PhongSo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_PhongSo.ForeColor = System.Drawing.Color.White;
            this.lb_PhongSo.Location = new System.Drawing.Point(230, 100);
            this.lb_PhongSo.Name = "lb_PhongSo";
            this.lb_PhongSo.Size = new System.Drawing.Size(105, 25);
            this.lb_PhongSo.TabIndex = 4;
            this.lb_PhongSo.Text = "Phòng số 2";
            // 
            // lb_Ghe
            // 
            this.lb_Ghe.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lb_Ghe.ForeColor = System.Drawing.Color.White;
            this.lb_Ghe.Location = new System.Drawing.Point(364, 100);
            this.lb_Ghe.Name = "lb_Ghe";
            this.lb_Ghe.Size = new System.Drawing.Size(199, 25);
            this.lb_Ghe.TabIndex = 4;
            this.lb_Ghe.Text = "Ghế: ";
            // 
            // lb_MaVe
            // 
            this.lb_MaVe.AutoSize = true;
            this.lb_MaVe.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lb_MaVe.ForeColor = System.Drawing.Color.White;
            this.lb_MaVe.Location = new System.Drawing.Point(140, 63);
            this.lb_MaVe.Name = "lb_MaVe";
            this.lb_MaVe.Size = new System.Drawing.Size(75, 25);
            this.lb_MaVe.TabIndex = 4;
            this.lb_MaVe.Text = "Mã vé: ";
            // 
            // lb_TenPhim
            // 
            this.lb_TenPhim.AutoSize = true;
            this.lb_TenPhim.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_TenPhim.ForeColor = System.Drawing.Color.White;
            this.lb_TenPhim.Location = new System.Drawing.Point(138, 13);
            this.lb_TenPhim.Name = "lb_TenPhim";
            this.lb_TenPhim.Size = new System.Drawing.Size(37, 37);
            this.lb_TenPhim.TabIndex = 4;
            this.lb_TenPhim.Text = "It";
            // 
            // InforCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.lb_TG);
            this.Controls.Add(this.lb_SoVe);
            this.Controls.Add(this.lb_PhongSo);
            this.Controls.Add(this.lb_Ghe);
            this.Controls.Add(this.lb_MaVe);
            this.Controls.Add(this.lb_TenPhim);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Picture);
            this.Name = "InforCard";
            this.Size = new System.Drawing.Size(598, 179);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Transparent_Label lb_TenPhim;
        private Transparent_Label lb_MaVe;
        private Transparent_Label lb_Ghe;
        private Transparent_Label lb_PhongSo;
        private Transparent_Label lb_SoVe;
        private Transparent_Label lb_TG;
    }
}
