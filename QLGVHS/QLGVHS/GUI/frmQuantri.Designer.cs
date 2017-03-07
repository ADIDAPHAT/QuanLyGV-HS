namespace QLGVHS.GUI
{
    partial class frmQuantri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuantri));
            this.mnsAcc = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnsAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsAcc
            // 
            this.mnsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnDel});
            this.mnsAcc.Location = new System.Drawing.Point(0, 0);
            this.mnsAcc.Name = "mnsAcc";
            this.mnsAcc.Size = new System.Drawing.Size(653, 87);
            this.mnsAcc.TabIndex = 1;
            this.mnsAcc.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 83);
            this.btnAdd.Text = "Thêm tài khoản";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 83);
            this.btnUpdate.Text = "Thay đổi thông tin";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(91, 83);
            this.btnDel.Text = "Xóa tài khoản";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvAcc
            // 
            this.dgvAcc.AllowUserToAddRows = false;
            this.dgvAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.MaGV,
            this.Ho,
            this.Ten,
            this.TenQuyen});
            this.dgvAcc.Location = new System.Drawing.Point(0, 100);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.ReadOnly = true;
            this.dgvAcc.Size = new System.Drawing.Size(648, 223);
            this.dgvAcc.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "MaGV";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            this.MaGV.Visible = false;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // TenHS
            // 
            this.Ten.DataPropertyName = "TenHS";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "TenHS";
            this.Ten.ReadOnly = true;
            // 
            // TenQuyen
            // 
            this.TenQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenQuyen.DataPropertyName = "TenQuyen";
            this.TenQuyen.HeaderText = "Quyền";
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.ReadOnly = true;
            // 
            // frmQuantri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 330);
            this.Controls.Add(this.dgvAcc);
            this.Controls.Add(this.mnsAcc);
            this.Name = "frmQuantri";
            this.Text = "frmQuantri";
            this.mnsAcc.ResumeLayout(false);
            this.mnsAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAcc;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
    }
}