namespace CustomControl
{
    partial class Card
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
                // https://www.youtube.com/watch?v=1cSK7NMNRLg&t=417s
                if (Picture.Image != null || Picture.BackgroundImage != null)
                    Picture.Dispose();
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Content = new CustomControl.GrowLabel();
            this.Title = new CustomControl.GrowLabel();
            this.borderPicture = new MaterialSkin.Controls.MaterialDivider();
            this.borderBotom = new MaterialSkin.Controls.MaterialDivider();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.Content);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Controls.Add(this.borderPicture);
            this.Panel.Controls.Add(this.borderBotom);
            this.Panel.Controls.Add(this.Picture);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(294, 250);
            this.Panel.TabIndex = 3;
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Content.Location = new System.Drawing.Point(12, 219);
            this.Content.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(272, 16);
            this.Content.TabIndex = 6;
            this.Content.Text = "Content";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Calibri", 16F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(182)))), ((int)(((byte)(121)))));
            this.Title.Location = new System.Drawing.Point(10, 179);
            this.Title.Margin = new System.Windows.Forms.Padding(10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(274, 27);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title";
            // 
            // borderPicture
            // 
            this.borderPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderPicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borderPicture.Depth = 0;
            this.borderPicture.Location = new System.Drawing.Point(0, 170);
            this.borderPicture.Margin = new System.Windows.Forms.Padding(0);
            this.borderPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.borderPicture.Name = "borderPicture";
            this.borderPicture.Size = new System.Drawing.Size(294, 1);
            this.borderPicture.TabIndex = 4;
            this.borderPicture.Text = "materialDivider1";
            // 
            // borderBotom
            // 
            this.borderBotom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderBotom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.borderBotom.Depth = 0;
            this.borderBotom.Location = new System.Drawing.Point(0, 247);
            this.borderBotom.Margin = new System.Windows.Forms.Padding(0);
            this.borderBotom.MouseState = MaterialSkin.MouseState.HOVER;
            this.borderBotom.Name = "borderBotom";
            this.borderBotom.Size = new System.Drawing.Size(294, 3);
            this.borderBotom.TabIndex = 3;
            this.borderBotom.Text = "materialDivider1";
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture.BackColor = System.Drawing.SystemColors.Control;
            this.Picture.Location = new System.Drawing.Point(1, 1);
            this.Picture.Margin = new System.Windows.Forms.Padding(0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(292, 169);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(294, 250);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Panel Panel;
        private MaterialSkin.Controls.MaterialDivider borderBotom;
        private MaterialSkin.Controls.MaterialDivider borderPicture;
        private GrowLabel Title;
        private GrowLabel Content;
    }
}
