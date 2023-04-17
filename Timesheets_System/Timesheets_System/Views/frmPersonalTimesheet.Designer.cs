namespace Timesheets_System.Views
{
    partial class frmPersonalTimesheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonalTimesheet));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.DGV_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_WorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_TeamName = new System.Windows.Forms.Label();
            this.lb_DepartmentName = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.lb_Position = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Year = new System.Windows.Forms.ComboBox();
            this.dgv_TimekeepingDetails = new System.Windows.Forms.DataGridView();
            this.cbb_Month = new System.Windows.Forms.ComboBox();
            this.pn_Title = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimekeepingDetails)).BeginInit();
            this.pn_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(178)))), ((int)(((byte)(232)))));
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 662);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(711, 10);
            this.Panel1.TabIndex = 31;
            // 
            // DGV_Date
            // 
            this.DGV_Date.DataPropertyName = "Date";
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            dataGridViewCellStyle13.NullValue = null;
            this.DGV_Date.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_Date.HeaderText = "Ngày";
            this.DGV_Date.MinimumWidth = 6;
            this.DGV_Date.Name = "DGV_Date";
            this.DGV_Date.ReadOnly = true;
            this.DGV_Date.Width = 120;
            // 
            // DGV_DayOfWeek
            // 
            this.DGV_DayOfWeek.HeaderText = "Thứ";
            this.DGV_DayOfWeek.MinimumWidth = 6;
            this.DGV_DayOfWeek.Name = "DGV_DayOfWeek";
            this.DGV_DayOfWeek.ReadOnly = true;
            this.DGV_DayOfWeek.Width = 125;
            // 
            // DGV_Checkin
            // 
            this.DGV_Checkin.DataPropertyName = "Checkin";
            dataGridViewCellStyle14.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridViewCellStyle14.NullValue = null;
            this.DGV_Checkin.DefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_Checkin.HeaderText = "Checkin";
            this.DGV_Checkin.MinimumWidth = 6;
            this.DGV_Checkin.Name = "DGV_Checkin";
            this.DGV_Checkin.ReadOnly = true;
            this.DGV_Checkin.Width = 150;
            // 
            // DGV_Checkout
            // 
            this.DGV_Checkout.DataPropertyName = "Checkout";
            dataGridViewCellStyle15.Format = "dd/MM/yyyy HH:mm:ss";
            this.DGV_Checkout.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_Checkout.HeaderText = "Checkout";
            this.DGV_Checkout.MinimumWidth = 6;
            this.DGV_Checkout.Name = "DGV_Checkout";
            this.DGV_Checkout.ReadOnly = true;
            this.DGV_Checkout.Width = 150;
            // 
            // DGV_WorkingHours
            // 
            this.DGV_WorkingHours.DataPropertyName = "WorkingHours";
            this.DGV_WorkingHours.HeaderText = "Số giờ làm việc";
            this.DGV_WorkingHours.MinimumWidth = 6;
            this.DGV_WorkingHours.Name = "DGV_WorkingHours";
            this.DGV_WorkingHours.ReadOnly = true;
            this.DGV_WorkingHours.Width = 115;
            // 
            // lb_TeamName
            // 
            this.lb_TeamName.AutoSize = true;
            this.lb_TeamName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TeamName.Location = new System.Drawing.Point(467, 61);
            this.lb_TeamName.Name = "lb_TeamName";
            this.lb_TeamName.Size = new System.Drawing.Size(0, 15);
            this.lb_TeamName.TabIndex = 11;
            // 
            // lb_DepartmentName
            // 
            this.lb_DepartmentName.AutoSize = true;
            this.lb_DepartmentName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DepartmentName.Location = new System.Drawing.Point(467, 28);
            this.lb_DepartmentName.Name = "lb_DepartmentName";
            this.lb_DepartmentName.Size = new System.Drawing.Size(0, 15);
            this.lb_DepartmentName.TabIndex = 11;
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Show.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btn_Show.FlatAppearance.BorderSize = 0;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(307, 164);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(88, 24);
            this.btn_Show.TabIndex = 27;
            this.btn_Show.Text = "Xem";
            this.btn_Show.UseVisualStyleBackColor = false;
            // 
            // lb_Position
            // 
            this.lb_Position.AutoSize = true;
            this.lb_Position.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Position.Location = new System.Drawing.Point(77, 61);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(0, 15);
            this.lb_Position.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(172, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tháng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ và tên";
            // 
            // lb_FullName
            // 
            this.lb_FullName.AutoSize = true;
            this.lb_FullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FullName.Location = new System.Drawing.Point(77, 28);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(0, 15);
            this.lb_FullName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhóm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_FullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_Position);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_TeamName);
            this.groupBox1.Controls.Add(this.lb_DepartmentName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 98);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Chức vụ";
            // 
            // cbb_Year
            // 
            this.cbb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Year.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Year.FormattingEnabled = true;
            this.cbb_Year.Location = new System.Drawing.Point(32, 166);
            this.cbb_Year.Name = "cbb_Year";
            this.cbb_Year.Size = new System.Drawing.Size(100, 23);
            this.cbb_Year.TabIndex = 28;
            // 
            // dgv_TimekeepingDetails
            // 
            this.dgv_TimekeepingDetails.AllowUserToAddRows = false;
            this.dgv_TimekeepingDetails.AllowUserToDeleteRows = false;
            this.dgv_TimekeepingDetails.AllowUserToResizeColumns = false;
            this.dgv_TimekeepingDetails.AllowUserToResizeRows = false;
            this.dgv_TimekeepingDetails.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_TimekeepingDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TimekeepingDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_TimekeepingDetails.ColumnHeadersHeight = 30;
            this.dgv_TimekeepingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TimekeepingDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Date,
            this.DGV_DayOfWeek,
            this.DGV_Checkin,
            this.DGV_Checkout,
            this.DGV_WorkingHours});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TimekeepingDetails.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_TimekeepingDetails.EnableHeadersVisualStyles = false;
            this.dgv_TimekeepingDetails.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_TimekeepingDetails.Location = new System.Drawing.Point(32, 208);
            this.dgv_TimekeepingDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TimekeepingDetails.Name = "dgv_TimekeepingDetails";
            this.dgv_TimekeepingDetails.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TimekeepingDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_TimekeepingDetails.RowHeadersVisible = false;
            this.dgv_TimekeepingDetails.RowHeadersWidth = 51;
            this.dgv_TimekeepingDetails.RowTemplate.Height = 24;
            this.dgv_TimekeepingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_TimekeepingDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TimekeepingDetails.Size = new System.Drawing.Size(652, 437);
            this.dgv_TimekeepingDetails.TabIndex = 24;
            // 
            // cbb_Month
            // 
            this.cbb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Month.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Month.FormattingEnabled = true;
            this.cbb_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_Month.Location = new System.Drawing.Point(175, 166);
            this.cbb_Month.Name = "cbb_Month";
            this.cbb_Month.Size = new System.Drawing.Size(94, 23);
            this.cbb_Month.TabIndex = 29;
            // 
            // pn_Title
            // 
            this.pn_Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_Title.Controls.Add(this.PictureBox2);
            this.pn_Title.Controls.Add(this.label2);
            this.pn_Title.Controls.Add(this.PictureBox1);
            this.pn_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Title.Location = new System.Drawing.Point(0, 0);
            this.pn_Title.Name = "pn_Title";
            this.pn_Title.Size = new System.Drawing.Size(711, 32);
            this.pn_Title.TabIndex = 34;
            this.pn_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Title_MouseDown);
            this.pn_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_Title_MouseMove);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(2, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bảng chấm công cá nhân";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(682, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(28, 28);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmPersonalTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 672);
            this.Controls.Add(this.pn_Title);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_Year);
            this.Controls.Add(this.dgv_TimekeepingDetails);
            this.Controls.Add(this.cbb_Month);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonalTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimesheetsPersonal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimekeepingDetails)).EndInit();
            this.pn_Title.ResumeLayout(false);
            this.pn_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_DayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_WorkingHours;
        private System.Windows.Forms.Label lb_TeamName;
        private System.Windows.Forms.Label lb_DepartmentName;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_Year;
        private System.Windows.Forms.DataGridView dgv_TimekeepingDetails;
        private System.Windows.Forms.ComboBox cbb_Month;
        internal System.Windows.Forms.Panel pn_Title;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}