namespace CustomControl
{
    partial class SmallRound_TextCard
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
            this.lb_ThoiGian = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lb_GheTrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.AutoSize = true;
            this.lb_ThoiGian.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThoiGian.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_ThoiGian.Location = new System.Drawing.Point(44, 11);
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Size = new System.Drawing.Size(62, 30);
            this.lb_ThoiGian.TabIndex = 0;
            this.lb_ThoiGian.Text = "09:15";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(22, 54);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(107, 1);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lb_GheTrong
            // 
            this.lb_GheTrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GheTrong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lb_GheTrong.Location = new System.Drawing.Point(0, 58);
            this.lb_GheTrong.Margin = new System.Windows.Forms.Padding(0);
            this.lb_GheTrong.Name = "lb_GheTrong";
            this.lb_GheTrong.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lb_GheTrong.Size = new System.Drawing.Size(150, 25);
            this.lb_GheTrong.TabIndex = 0;
            this.lb_GheTrong.Text = "90 ghế trống";
            this.lb_GheTrong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SmallRound_TextCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lb_GheTrong);
            this.Controls.Add(this.lb_ThoiGian);
            this.Name = "SmallRound_TextCard";
            this.Size = new System.Drawing.Size(150, 86);
            this.Load += new System.EventHandler(this.SmallRound_TextCard_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SmallRound_TextCard_MouseClick);
            this.MouseEnter += new System.EventHandler(this.SmallRound_TextCard_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SmallRound_TextCard_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThoiGian;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label lb_GheTrong;
    }
}
