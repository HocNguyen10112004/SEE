namespace ABD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diemThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.quanLiToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.doiMatKhauToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.giaoVienToolStripMenuItem1,
            this.diemThiToolStripMenuItem});
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quanLiToolStripMenuItem.Text = "Quản lí";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhVienToolStripMenuItem.Text = "Sinh viên";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.monHocToolStripMenuItem.Text = "Môn học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem1
            // 
            this.giaoVienToolStripMenuItem1.Name = "giaoVienToolStripMenuItem1";
            this.giaoVienToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.giaoVienToolStripMenuItem1.Text = "Giáo viên";
            this.giaoVienToolStripMenuItem1.Click += new System.EventHandler(this.giaoVienToolStripMenuItem1_Click);
            // 
            // diemThiToolStripMenuItem
            // 
            this.diemThiToolStripMenuItem.Name = "diemThiToolStripMenuItem";
            this.diemThiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.diemThiToolStripMenuItem.Text = "Điểm thi";
            this.diemThiToolStripMenuItem.Click += new System.EventHandler(this.diemThiToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 26);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(800, 424);
            this.pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diemThiToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}