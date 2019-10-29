namespace CustomControl
{
    partial class ScheduleCard
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.flp_ThoiGian = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(25, 14);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(49, 25);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Title";
            // 
            // flp_ThoiGian
            // 
            this.flp_ThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_ThoiGian.Location = new System.Drawing.Point(3, 61);
            this.flp_ThoiGian.Name = "flp_ThoiGian";
            this.flp_ThoiGian.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.flp_ThoiGian.Size = new System.Drawing.Size(754, 100);
            this.flp_ThoiGian.TabIndex = 1;
            // 
            // ScheduleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flp_ThoiGian);
            this.Controls.Add(this.lb_Title);
            this.Name = "ScheduleCard";
            this.Size = new System.Drawing.Size(760, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.FlowLayoutPanel flp_ThoiGian;
    }
}
