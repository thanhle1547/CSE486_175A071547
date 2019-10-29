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
            this.transparent_Label5 = new CustomControl.Transparent_Label();
            this.transparent_Label6 = new CustomControl.Transparent_Label();
            this.transparent_Label4 = new CustomControl.Transparent_Label();
            this.transparent_Label3 = new CustomControl.Transparent_Label();
            this.transparent_Label2 = new CustomControl.Transparent_Label();
            this.transparent_Label1 = new CustomControl.Transparent_Label();
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
            // transparent_Label5
            // 
            this.transparent_Label5.AutoSize = true;
            this.transparent_Label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.transparent_Label5.ForeColor = System.Drawing.Color.White;
            this.transparent_Label5.Location = new System.Drawing.Point(140, 137);
            this.transparent_Label5.Name = "transparent_Label5";
            this.transparent_Label5.Size = new System.Drawing.Size(98, 25);
            this.transparent_Label5.TabIndex = 4;
            this.transparent_Label5.Text = "Thời gian: ";
            // 
            // transparent_Label6
            // 
            this.transparent_Label6.AutoSize = true;
            this.transparent_Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.transparent_Label6.ForeColor = System.Drawing.Color.White;
            this.transparent_Label6.Location = new System.Drawing.Point(140, 100);
            this.transparent_Label6.Name = "transparent_Label6";
            this.transparent_Label6.Size = new System.Drawing.Size(46, 25);
            this.transparent_Label6.TabIndex = 4;
            this.transparent_Label6.Text = "2 vé";
            // 
            // transparent_Label4
            // 
            this.transparent_Label4.AutoSize = true;
            this.transparent_Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.transparent_Label4.ForeColor = System.Drawing.Color.White;
            this.transparent_Label4.Location = new System.Drawing.Point(259, 100);
            this.transparent_Label4.Name = "transparent_Label4";
            this.transparent_Label4.Size = new System.Drawing.Size(105, 25);
            this.transparent_Label4.TabIndex = 4;
            this.transparent_Label4.Text = "Phòng số 2";
            // 
            // transparent_Label3
            // 
            this.transparent_Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.transparent_Label3.ForeColor = System.Drawing.Color.White;
            this.transparent_Label3.Location = new System.Drawing.Point(405, 100);
            this.transparent_Label3.Name = "transparent_Label3";
            this.transparent_Label3.Size = new System.Drawing.Size(167, 25);
            this.transparent_Label3.TabIndex = 4;
            this.transparent_Label3.Text = "Ghế: ";
            // 
            // transparent_Label2
            // 
            this.transparent_Label2.AutoSize = true;
            this.transparent_Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.transparent_Label2.ForeColor = System.Drawing.Color.White;
            this.transparent_Label2.Location = new System.Drawing.Point(140, 63);
            this.transparent_Label2.Name = "transparent_Label2";
            this.transparent_Label2.Size = new System.Drawing.Size(75, 25);
            this.transparent_Label2.TabIndex = 4;
            this.transparent_Label2.Text = "Mã vé: ";
            // 
            // transparent_Label1
            // 
            this.transparent_Label1.AutoSize = true;
            this.transparent_Label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.transparent_Label1.ForeColor = System.Drawing.Color.White;
            this.transparent_Label1.Location = new System.Drawing.Point(138, 13);
            this.transparent_Label1.Name = "transparent_Label1";
            this.transparent_Label1.Size = new System.Drawing.Size(37, 37);
            this.transparent_Label1.TabIndex = 4;
            this.transparent_Label1.Text = "It";
            // 
            // InforCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.transparent_Label5);
            this.Controls.Add(this.transparent_Label6);
            this.Controls.Add(this.transparent_Label4);
            this.Controls.Add(this.transparent_Label3);
            this.Controls.Add(this.transparent_Label2);
            this.Controls.Add(this.transparent_Label1);
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
        private Transparent_Label transparent_Label1;
        private Transparent_Label transparent_Label2;
        private Transparent_Label transparent_Label3;
        private Transparent_Label transparent_Label4;
        private Transparent_Label transparent_Label6;
        private Transparent_Label transparent_Label5;
    }
}
