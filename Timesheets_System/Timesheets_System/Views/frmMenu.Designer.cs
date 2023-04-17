namespace Timesheets_System.Views
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.tsmi_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPersonalTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Personnel = new System.Windows.Forms.ToolStripMenuItem();
            this.frmEmployeeList = new System.Windows.Forms.ToolStripMenuItem();
            this.frmTimesheets = new System.Windows.Forms.ToolStripMenuItem();
            this.frmRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_System = new System.Windows.Forms.ToolStripMenuItem();
            this.frmPermissionGrant = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChangPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.ms_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.AutoSize = false;
            this.ms_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ms_Menu.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Personal,
            this.tsmi_Personnel,
            this.tsmi_Report,
            this.tsmi_System});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.ms_Menu.Size = new System.Drawing.Size(961, 32);
            this.ms_Menu.TabIndex = 32;
            this.ms_Menu.Text = "menuStrip1";
            this.ms_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ms_Menu_MouseDown);
            this.ms_Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ms_Menu_MouseMove);
            // 
            // tsmi_Personal
            // 
            this.tsmi_Personal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmPersonalInfo,
            this.frmPersonalTimesheet});
            this.tsmi_Personal.Name = "tsmi_Personal";
            this.tsmi_Personal.Size = new System.Drawing.Size(67, 28);
            this.tsmi_Personal.Text = "Cá nhân";
            // 
            // frmPersonalInfo
            // 
            this.frmPersonalInfo.Name = "frmPersonalInfo";
            this.frmPersonalInfo.Size = new System.Drawing.Size(184, 22);
            this.frmPersonalInfo.Text = "Thông tin cá nhân";
            // 
            // frmPersonalTimesheet
            // 
            this.frmPersonalTimesheet.Name = "frmPersonalTimesheet";
            this.frmPersonalTimesheet.Size = new System.Drawing.Size(184, 22);
            this.frmPersonalTimesheet.Text = "Bảng công cá nhân";
            this.frmPersonalTimesheet.Click += new System.EventHandler(this.frmPersonalTimesheet_Click);
            // 
            // tsmi_Personnel
            // 
            this.tsmi_Personnel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmEmployeeList,
            this.frmTimesheets,
            this.frmRequest});
            this.tsmi_Personnel.Name = "tsmi_Personnel";
            this.tsmi_Personnel.Size = new System.Drawing.Size(66, 28);
            this.tsmi_Personnel.Text = "Nhân sự";
            // 
            // frmEmployeeList
            // 
            this.frmEmployeeList.Name = "frmEmployeeList";
            this.frmEmployeeList.Size = new System.Drawing.Size(194, 22);
            this.frmEmployeeList.Text = "Danh sách nhân viên";
            // 
            // frmTimesheets
            // 
            this.frmTimesheets.Name = "frmTimesheets";
            this.frmTimesheets.Size = new System.Drawing.Size(194, 22);
            this.frmTimesheets.Text = "Bảng công";
            this.frmTimesheets.Click += new System.EventHandler(this.frmTimesheets_Click);
            // 
            // frmRequest
            // 
            this.frmRequest.Name = "frmRequest";
            this.frmRequest.Size = new System.Drawing.Size(194, 22);
            this.frmRequest.Text = "Yêu cầu";
            // 
            // tsmi_Report
            // 
            this.tsmi_Report.Enabled = false;
            this.tsmi_Report.Name = "tsmi_Report";
            this.tsmi_Report.Size = new System.Drawing.Size(65, 28);
            this.tsmi_Report.Text = "Báo cáo";
            // 
            // tsmi_System
            // 
            this.tsmi_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmPermissionGrant,
            this.frmChangPassword,
            this.tsmi_Logout});
            this.tsmi_System.Name = "tsmi_System";
            this.tsmi_System.Size = new System.Drawing.Size(72, 28);
            this.tsmi_System.Text = "Hệ thống";
            // 
            // frmPermissionGrant
            // 
            this.frmPermissionGrant.Name = "frmPermissionGrant";
            this.frmPermissionGrant.Size = new System.Drawing.Size(180, 22);
            this.frmPermissionGrant.Text = "Phân quyền";
            // 
            // frmChangPassword
            // 
            this.frmChangPassword.Name = "frmChangPassword";
            this.frmChangPassword.Size = new System.Drawing.Size(180, 22);
            this.frmChangPassword.Text = "Đổi mật khẩu";
            // 
            // tsmi_Logout
            // 
            this.tsmi_Logout.Name = "tsmi_Logout";
            this.tsmi_Logout.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Logout.Text = "Đăng xuất";
            this.tsmi_Logout.Click += new System.EventHandler(this.tsmi_Logout_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(929, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(28, 28);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackgroundImage = global::Timesheets_System.Properties.Resources.GolineBackground;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel2.Controls.Add(this.lbl_Username);
            this.Panel2.Location = new System.Drawing.Point(0, 32);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(961, 478);
            this.Panel2.TabIndex = 34;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_Username.Location = new System.Drawing.Point(11, 450);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(65, 17);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "LOGGED: ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 507);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Personal;
        private System.Windows.Forms.ToolStripMenuItem frmPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem frmPersonalTimesheet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Personnel;
        private System.Windows.Forms.ToolStripMenuItem frmEmployeeList;
        private System.Windows.Forms.ToolStripMenuItem frmTimesheets;
        internal System.Windows.Forms.ToolStripMenuItem frmRequest;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Report;
        private System.Windows.Forms.ToolStripMenuItem tsmi_System;
        private System.Windows.Forms.ToolStripMenuItem frmPermissionGrant;
        internal System.Windows.Forms.ToolStripMenuItem frmChangPassword;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Logout;
    }
}