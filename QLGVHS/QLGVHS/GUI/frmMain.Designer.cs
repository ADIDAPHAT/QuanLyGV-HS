namespace QLGVHS.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHi = new System.Windows.Forms.Label();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnTkb = new System.Windows.Forms.Button();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.btnHocsinh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListteacher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchtecher = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegisterteach = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblHi);
            this.panel1.Controls.Add(this.btnHuongdan);
            this.panel1.Controls.Add(this.btnTkb);
            this.panel1.Controls.Add(this.btnGiaovien);
            this.panel1.Controls.Add(this.btnHocsinh);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 429);
            this.panel1.TabIndex = 1;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(190)))), ((int)(((byte)(233)))));
            this.lblHi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.Red;
            this.lblHi.Location = new System.Drawing.Point(12, 342);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(168, 19);
            this.lblHi.TabIndex = 5;
            this.lblHi.Text = "Đăng nhập với tư cách: ";
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongdan.Image")));
            this.btnHuongdan.Location = new System.Drawing.Point(365, 185);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(109, 90);
            this.btnHuongdan.TabIndex = 4;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongdan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongdan.UseVisualStyleBackColor = true;
            this.btnHuongdan.Click += new System.EventHandler(this.btnHuongdan_Click);
            // 
            // btnTkb
            // 
            this.btnTkb.Image = ((System.Drawing.Image)(resources.GetObject("btnTkb.Image")));
            this.btnTkb.Location = new System.Drawing.Point(365, 79);
            this.btnTkb.Name = "btnTkb";
            this.btnTkb.Size = new System.Drawing.Size(109, 87);
            this.btnTkb.TabIndex = 3;
            this.btnTkb.Text = "Thời khóa biểu";
            this.btnTkb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTkb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTkb.UseVisualStyleBackColor = true;
            this.btnTkb.Click += new System.EventHandler(this.btnTkb_Click);
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.Image")));
            this.btnGiaovien.Location = new System.Drawing.Point(121, 185);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Size = new System.Drawing.Size(109, 90);
            this.btnGiaovien.TabIndex = 2;
            this.btnGiaovien.Text = "Quản lý giáo viên";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaovien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGiaovien.UseVisualStyleBackColor = true;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // btnHocsinh
            // 
            this.btnHocsinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnHocsinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHocsinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocsinh.Image")));
            this.btnHocsinh.Location = new System.Drawing.Point(121, 79);
            this.btnHocsinh.Name = "btnHocsinh";
            this.btnHocsinh.Size = new System.Drawing.Size(109, 87);
            this.btnHocsinh.TabIndex = 1;
            this.btnHocsinh.Text = "Quản lý học sinh";
            this.btnHocsinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocsinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHocsinh.UseVisualStyleBackColor = true;
            this.btnHocsinh.Click += new System.EventHandler(this.btnHocsinh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStudent,
            this.btnTeacher,
            this.btnRegisterteach,
            this.btnAccount,
            this.btnF1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStudent
            // 
            this.btnStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListstudent,
            this.btnSearchstudent});
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(66, 20);
            this.btnStudent.Text = "Học sinh";
            // 
            // btnListstudent
            // 
            this.btnListstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnListstudent.Image")));
            this.btnListstudent.Name = "btnListstudent";
            this.btnListstudent.Size = new System.Drawing.Size(172, 22);
            this.btnListstudent.Text = "Xem danh sách";
            this.btnListstudent.Click += new System.EventHandler(this.btnListstudent_Click);
            // 
            // btnSearchstudent
            // 
            this.btnSearchstudent.Name = "btnSearchstudent";
            this.btnSearchstudent.Size = new System.Drawing.Size(172, 22);
            this.btnSearchstudent.Text = "Tìm kiếm học sinh";
            // 
            // btnTeacher
            // 
            this.btnTeacher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListteacher,
            this.btnSearchtecher});
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(68, 20);
            this.btnTeacher.Text = "Giáo viên";
            // 
            // btnListteacher
            // 
            this.btnListteacher.Image = ((System.Drawing.Image)(resources.GetObject("btnListteacher.Image")));
            this.btnListteacher.Name = "btnListteacher";
            this.btnListteacher.Size = new System.Drawing.Size(180, 22);
            this.btnListteacher.Text = "Danh sách giáo viên";
            this.btnListteacher.Click += new System.EventHandler(this.btnListteacher_Click);
            // 
            // btnSearchtecher
            // 
            this.btnSearchtecher.Name = "btnSearchtecher";
            this.btnSearchtecher.Size = new System.Drawing.Size(180, 22);
            this.btnSearchtecher.Text = "Tìm kiếm giáo viên";
            // 
            // btnRegisterteach
            // 
            this.btnRegisterteach.Name = "btnRegisterteach";
            this.btnRegisterteach.Size = new System.Drawing.Size(117, 20);
            this.btnRegisterteach.Text = "Đăng ký giảng dạy";
            this.btnRegisterteach.Click += new System.EventHandler(this.btnRegisterteach_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout,
            this.btnAcc});
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(70, 20);
            this.btnAccount.Text = "Tài khoản";
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(167, 22);
            this.btnLogout.Text = "Đăng xuát";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(167, 22);
            this.btnAcc.Text = "Quản lý tài khoản";
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnF1
            // 
            this.btnF1.Name = "btnF1";
            this.btnF1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnF1.Size = new System.Drawing.Size(79, 20);
            this.btnF1.Text = "Hướng dẫn";
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 429);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnTkb;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Button btnHocsinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnStudent;
        private System.Windows.Forms.ToolStripMenuItem btnListstudent;
        private System.Windows.Forms.ToolStripMenuItem btnSearchstudent;
        private System.Windows.Forms.ToolStripMenuItem btnTeacher;
        private System.Windows.Forms.ToolStripMenuItem btnListteacher;
        private System.Windows.Forms.ToolStripMenuItem btnSearchtecher;
        private System.Windows.Forms.ToolStripMenuItem btnRegisterteach;
        private System.Windows.Forms.ToolStripMenuItem btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnAcc;
        private System.Windows.Forms.ToolStripMenuItem btnF1;
    }
}