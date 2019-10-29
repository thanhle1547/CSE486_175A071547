namespace CustomControl
{
    partial class Rounded_RichTextBox
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
            this.rtBx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtBx
            // 
            this.rtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtBx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBx.Location = new System.Drawing.Point(3, 3);
            this.rtBx.Name = "rtBx";
            this.rtBx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtBx.Size = new System.Drawing.Size(364, 301);
            this.rtBx.TabIndex = 0;
            this.rtBx.Text = "";
            // 
            // Rounded_RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rtBx);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Rounded_RichTextBox";
            this.Size = new System.Drawing.Size(370, 307);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Rounded_RichTextBox_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBx;
    }
}
