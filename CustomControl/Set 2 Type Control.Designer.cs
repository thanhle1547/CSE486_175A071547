namespace CustomControl
{
    partial class Set_2_Type_Control
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
            this.cB_2 = new System.Windows.Forms.ComboBox();
            this.cB_1 = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new CustomControl.Round_Button();
            this.SuspendLayout();
            // 
            // cB_2
            // 
            this.cB_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_2.FormattingEnabled = true;
            this.cB_2.Location = new System.Drawing.Point(137, 6);
            this.cB_2.Name = "cB_2";
            this.cB_2.Size = new System.Drawing.Size(315, 33);
            this.cB_2.TabIndex = 44;
            // 
            // cB_1
            // 
            this.cB_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_1.FormattingEnabled = true;
            this.cB_1.Location = new System.Drawing.Point(6, 6);
            this.cB_1.Name = "cB_1";
            this.cB_1.Size = new System.Drawing.Size(95, 33);
            this.cB_1.TabIndex = 45;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.ButtonColor = System.Drawing.Color.Transparent;
            this.btn_Delete.ButtonImage = global::CustomControl.Properties.Resources.icons8_delete_25;
            this.btn_Delete.ButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(488, 6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Delete.OnHoverButtonColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Size = new System.Drawing.Size(33, 33);
            this.btn_Delete.TabIndex = 46;
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Set_2_Type_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cB_2);
            this.Controls.Add(this.cB_1);
            this.Name = "Set_2_Type_Control";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(527, 45);
            this.ResumeLayout(false);

        }

        #endregion
        private Round_Button btn_Delete;
        private System.Windows.Forms.ComboBox cB_2;
        private System.Windows.Forms.ComboBox cB_1;
    }
}
