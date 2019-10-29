namespace CustomControl
{
    partial class SmallRound_Card
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
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(136, 64);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Validating += new System.ComponentModel.CancelEventHandler(this.picture_Validating);
            // 
            // SmallRound_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.picture);
            this.DoubleBuffered = true;
            this.Name = "SmallRound_Card";
            this.Size = new System.Drawing.Size(136, 64);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SmallRound_Card_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SmallRoundCard_MouseClick);
            this.MouseEnter += new System.EventHandler(this.SmallRound_Card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SmallRound_Card_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
    }
}
