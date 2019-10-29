namespace CustomControl
{
    partial class ImageCard
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Panel = new CustomControl.Transparent_Panel();
            this.Rated = new CustomControl.Transparent_Label();
            this.Time = new CustomControl.Transparent_Label();
            this.Title = new CustomControl.Transparent_Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.Black;
            this.Picture.BackgroundImage = global::CustomControl.Properties.Resources.rsz_it_chapter_two__vietnamese_poster;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.Picture.ImageLocation = "";
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(202, 297);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.Controls.Add(this.Rated);
            this.Panel.Controls.Add(this.Time);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 235);
            this.Panel.Name = "Panel";
            this.Panel.Opacity = 60;
            this.Panel.Size = new System.Drawing.Size(202, 62);
            this.Panel.TabIndex = 3;
            // 
            // Rated
            // 
            this.Rated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rated.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rated.ForeColor = System.Drawing.Color.White;
            this.Rated.Location = new System.Drawing.Point(157, 35);
            this.Rated.MinimumSize = new System.Drawing.Size(35, 20);
            this.Rated.Name = "Rated";
            this.Rated.Size = new System.Drawing.Size(35, 20);
            this.Rated.TabIndex = 5;
            this.Rated.Text = "C18";
            this.Rated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(12, 35);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 20);
            this.Time.TabIndex = 5;
            this.Time.Text = "169 phút";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoEllipsis = true;
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(11, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(181, 25);
            this.Title.TabIndex = 4;
            this.Title.Text = "It";
            // 
            // ImageCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Picture);
            this.MinimumSize = new System.Drawing.Size(202, 297);
            this.Name = "ImageCard";
            this.Size = new System.Drawing.Size(202, 297);
            this.Load += new System.EventHandler(this.ImageCard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageCard_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private Transparent_Label Title;
        private Transparent_Panel Panel;
        private Transparent_Label Rated;
        private Transparent_Label Time;
    }
}
