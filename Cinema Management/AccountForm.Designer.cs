namespace Sales_App
{
    partial class AccountForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckB_ShowPass = new LollipopCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Td_Ten = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Huy_Ten = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txB_PassAgain = new LollipopTextBox();
            this.txB_Pass = new LollipopTextBox();
            this.txB_UserName = new LollipopTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lollipopCheckBox1 = new LollipopCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Huy_MK = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_Td_MK = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.lollipopTextBox3 = new LollipopTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lollipopTextBox2 = new LollipopTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lollipopTextBox1 = new LollipopTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên đăng nhập";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 109);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(368, 399);
            this.materialTabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.ckB_ShowPass);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.txB_PassAgain);
            this.tabPage1.Controls.Add(this.txB_Pass);
            this.tabPage1.Controls.Add(this.txB_UserName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đổi tên";
            // 
            // ckB_ShowPass
            // 
            this.ckB_ShowPass.AutoSize = true;
            this.ckB_ShowPass.CheckColor = "#508ef5";
            this.ckB_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckB_ShowPass.Location = new System.Drawing.Point(51, 288);
            this.ckB_ShowPass.Name = "ckB_ShowPass";
            this.ckB_ShowPass.Size = new System.Drawing.Size(114, 20);
            this.ckB_ShowPass.TabIndex = 24;
            this.ckB_ShowPass.Text = "Hiện mật khẩu";
            this.ckB_ShowPass.UseVisualStyleBackColor = true;
            this.ckB_ShowPass.CheckedChanged += new System.EventHandler(this.CkB_ShowPass_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_Td_Ten);
            this.panel2.Controls.Add(this.btn_Huy_Ten);
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 58);
            this.panel2.TabIndex = 23;
            // 
            // btn_Td_Ten
            // 
            this.btn_Td_Ten.AutoSize = true;
            this.btn_Td_Ten.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Td_Ten.Depth = 0;
            this.btn_Td_Ten.Icon = null;
            this.btn_Td_Ten.Location = new System.Drawing.Point(268, 14);
            this.btn_Td_Ten.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Td_Ten.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Td_Ten.Name = "btn_Td_Ten";
            this.btn_Td_Ten.Primary = false;
            this.btn_Td_Ten.Size = new System.Drawing.Size(82, 36);
            this.btn_Td_Ten.TabIndex = 1;
            this.btn_Td_Ten.Text = "Thay đổi";
            this.btn_Td_Ten.UseVisualStyleBackColor = true;
            this.btn_Td_Ten.Click += new System.EventHandler(this.Btn_Td_Ten_Click);
            // 
            // btn_Huy_Ten
            // 
            this.btn_Huy_Ten.AutoSize = true;
            this.btn_Huy_Ten.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Huy_Ten.Depth = 0;
            this.btn_Huy_Ten.Icon = null;
            this.btn_Huy_Ten.Location = new System.Drawing.Point(199, 14);
            this.btn_Huy_Ten.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Huy_Ten.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Huy_Ten.Name = "btn_Huy_Ten";
            this.btn_Huy_Ten.Primary = false;
            this.btn_Huy_Ten.Size = new System.Drawing.Size(48, 36);
            this.btn_Huy_Ten.TabIndex = 1;
            this.btn_Huy_Ten.Text = "Hủy";
            this.btn_Huy_Ten.UseVisualStyleBackColor = true;
            this.btn_Huy_Ten.Click += new System.EventHandler(this.Btn_Huy_Ten_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(356, 1);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txB_PassAgain
            // 
            this.txB_PassAgain.BackColor = System.Drawing.Color.White;
            this.txB_PassAgain.FocusedColor = "#508ef5";
            this.txB_PassAgain.FontColor = "#878383";
            this.txB_PassAgain.IsEnabled = true;
            this.txB_PassAgain.Location = new System.Drawing.Point(57, 244);
            this.txB_PassAgain.MaxLength = 32767;
            this.txB_PassAgain.Multiline = false;
            this.txB_PassAgain.Name = "txB_PassAgain";
            this.txB_PassAgain.ReadOnly = false;
            this.txB_PassAgain.Size = new System.Drawing.Size(250, 24);
            this.txB_PassAgain.TabIndex = 18;
            this.txB_PassAgain.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_PassAgain.UseSystemPasswordChar = true;
            // 
            // txB_Pass
            // 
            this.txB_Pass.BackColor = System.Drawing.Color.White;
            this.txB_Pass.FocusedColor = "#508ef5";
            this.txB_Pass.FontColor = "#878383";
            this.txB_Pass.IsEnabled = true;
            this.txB_Pass.Location = new System.Drawing.Point(55, 159);
            this.txB_Pass.MaxLength = 32767;
            this.txB_Pass.Multiline = false;
            this.txB_Pass.Name = "txB_Pass";
            this.txB_Pass.ReadOnly = false;
            this.txB_Pass.Size = new System.Drawing.Size(250, 24);
            this.txB_Pass.TabIndex = 18;
            this.txB_Pass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_Pass.UseSystemPasswordChar = true;
            // 
            // txB_UserName
            // 
            this.txB_UserName.BackColor = System.Drawing.Color.White;
            this.txB_UserName.FocusedColor = "#508ef5";
            this.txB_UserName.FontColor = "#878383";
            this.txB_UserName.IsEnabled = true;
            this.txB_UserName.Location = new System.Drawing.Point(55, 70);
            this.txB_UserName.MaxLength = 32767;
            this.txB_UserName.Multiline = false;
            this.txB_UserName.Name = "txB_UserName";
            this.txB_UserName.ReadOnly = false;
            this.txB_UserName.Size = new System.Drawing.Size(250, 24);
            this.txB_UserName.TabIndex = 18;
            this.txB_UserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txB_UserName.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(51, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lollipopCheckBox1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.lollipopTextBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lollipopTextBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lollipopTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đổi mật khẩu";
            // 
            // lollipopCheckBox1
            // 
            this.lollipopCheckBox1.AutoSize = true;
            this.lollipopCheckBox1.CheckColor = "#508ef5";
            this.lollipopCheckBox1.Location = new System.Drawing.Point(51, 288);
            this.lollipopCheckBox1.Name = "lollipopCheckBox1";
            this.lollipopCheckBox1.Size = new System.Drawing.Size(114, 20);
            this.lollipopCheckBox1.TabIndex = 26;
            this.lollipopCheckBox1.Text = "Hiện mật khẩu";
            this.lollipopCheckBox1.UseVisualStyleBackColor = true;
            this.lollipopCheckBox1.CheckedChanged += new System.EventHandler(this.LollipopCheckBox1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_Huy_MK);
            this.panel3.Controls.Add(this.btn_Td_MK);
            this.panel3.Controls.Add(this.materialDivider2);
            this.panel3.Location = new System.Drawing.Point(0, 332);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 58);
            this.panel3.TabIndex = 25;
            // 
            // btn_Huy_MK
            // 
            this.btn_Huy_MK.AutoSize = true;
            this.btn_Huy_MK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Huy_MK.Depth = 0;
            this.btn_Huy_MK.Icon = null;
            this.btn_Huy_MK.Location = new System.Drawing.Point(199, 14);
            this.btn_Huy_MK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Huy_MK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Huy_MK.Name = "btn_Huy_MK";
            this.btn_Huy_MK.Primary = false;
            this.btn_Huy_MK.Size = new System.Drawing.Size(48, 36);
            this.btn_Huy_MK.TabIndex = 1;
            this.btn_Huy_MK.Text = "Hủy";
            this.btn_Huy_MK.UseVisualStyleBackColor = true;
            this.btn_Huy_MK.Click += new System.EventHandler(this.Btn_Huy_MK_Click);
            // 
            // btn_Td_MK
            // 
            this.btn_Td_MK.AutoSize = true;
            this.btn_Td_MK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Td_MK.Depth = 0;
            this.btn_Td_MK.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Td_MK.Icon = null;
            this.btn_Td_MK.Location = new System.Drawing.Point(268, 14);
            this.btn_Td_MK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Td_MK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Td_MK.Name = "btn_Td_MK";
            this.btn_Td_MK.Primary = false;
            this.btn_Td_MK.Size = new System.Drawing.Size(82, 36);
            this.btn_Td_MK.TabIndex = 1;
            this.btn_Td_MK.Text = "Thay đổi";
            this.btn_Td_MK.UseVisualStyleBackColor = true;
            this.btn_Td_MK.Click += new System.EventHandler(this.Btn_Td_MK_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(356, 1);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // lollipopTextBox3
            // 
            this.lollipopTextBox3.BackColor = System.Drawing.Color.White;
            this.lollipopTextBox3.FocusedColor = "#508ef5";
            this.lollipopTextBox3.FontColor = "#878383";
            this.lollipopTextBox3.IsEnabled = true;
            this.lollipopTextBox3.Location = new System.Drawing.Point(55, 244);
            this.lollipopTextBox3.MaxLength = 32767;
            this.lollipopTextBox3.Multiline = false;
            this.lollipopTextBox3.Name = "lollipopTextBox3";
            this.lollipopTextBox3.ReadOnly = false;
            this.lollipopTextBox3.Size = new System.Drawing.Size(250, 24);
            this.lollipopTextBox3.TabIndex = 24;
            this.lollipopTextBox3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox3.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(51, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập lại mật khẩu mới";
            // 
            // lollipopTextBox2
            // 
            this.lollipopTextBox2.BackColor = System.Drawing.Color.White;
            this.lollipopTextBox2.FocusedColor = "#508ef5";
            this.lollipopTextBox2.FontColor = "#878383";
            this.lollipopTextBox2.IsEnabled = true;
            this.lollipopTextBox2.Location = new System.Drawing.Point(55, 159);
            this.lollipopTextBox2.MaxLength = 32767;
            this.lollipopTextBox2.Multiline = false;
            this.lollipopTextBox2.Name = "lollipopTextBox2";
            this.lollipopTextBox2.ReadOnly = false;
            this.lollipopTextBox2.Size = new System.Drawing.Size(250, 24);
            this.lollipopTextBox2.TabIndex = 22;
            this.lollipopTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox2.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(51, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(51, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.BackColor = System.Drawing.Color.White;
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#878383";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(55, 70);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(250, 24);
            this.lollipopTextBox1.TabIndex = 19;
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.White;
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(368, 45);
            this.materialTabSelector1.TabIndex = 21;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.materialTabSelector1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 108);
            this.panel1.TabIndex = 22;
            // 
            // title
            // 
            this.title.Controls.Add(this.label3);
            this.title.Controls.Add(this.btn_Close);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(368, 57);
            this.title.TabIndex = 22;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Close.Image = global::Sales_App.Properties.Resources.icons8_delete_25_white;
            this.btn_Close.Location = new System.Drawing.Point(318, 18);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(26, 26);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialFlatButton btn_Td_Ten;
        private MaterialSkin.Controls.MaterialFlatButton btn_Huy_Ten;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private LollipopTextBox txB_PassAgain;
        private LollipopTextBox txB_Pass;
        private LollipopTextBox txB_UserName;
        private System.Windows.Forms.Label label4;
        private LollipopCheckBox ckB_ShowPass;
        private System.Windows.Forms.Label label5;
        private LollipopTextBox lollipopTextBox1;
        private LollipopTextBox lollipopTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton btn_Huy_MK;
        private MaterialSkin.Controls.MaterialFlatButton btn_Td_MK;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private LollipopTextBox lollipopTextBox3;
        private System.Windows.Forms.Label label7;
        private LollipopCheckBox lollipopCheckBox1;
        private System.Windows.Forms.Panel title;
    }
}