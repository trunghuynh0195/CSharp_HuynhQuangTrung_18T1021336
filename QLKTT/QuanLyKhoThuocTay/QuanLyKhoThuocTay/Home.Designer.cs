
namespace QuanLyKhoThuocTay
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaithuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelHome = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu,
            this.mnuDanhmuc});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuClose});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(112, 22);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Enabled = false;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(112, 22);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(112, 22);
            this.mnuClose.Text = "Close";
            // 
            // mnuDanhmuc
            // 
            this.mnuDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuoc,
            this.mnuLoaithuoc});
            this.mnuDanhmuc.Enabled = false;
            this.mnuDanhmuc.Name = "mnuDanhmuc";
            this.mnuDanhmuc.Size = new System.Drawing.Size(92, 20);
            this.mnuDanhmuc.Text = "QL Danh Mục";
            // 
            // mnuThuoc
            // 
            this.mnuThuoc.Name = "mnuThuoc";
            this.mnuThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuThuoc.Text = "QL Thuốc";
            this.mnuThuoc.Click += new System.EventHandler(this.mnuThuoc_Click);
            // 
            // mnuLoaithuoc
            // 
            this.mnuLoaithuoc.Name = "mnuLoaithuoc";
            this.mnuLoaithuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuLoaithuoc.Text = "QL Loại thuốc";
            this.mnuLoaithuoc.Click += new System.EventHandler(this.mnuLoaithuoc_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(1, 27);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1091, 530);
            this.panelHome.TabIndex = 2;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(1092, 553);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Thuốc";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.MenuStrip menuStrip1;
       // private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
      //  private System.Windows.Forms.ToolStripMenuItem qlDanhMucMenuItem;
      //  private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
      //  private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
      //  private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
       // private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      //  private System.Windows.Forms.Panel panelHome;
       // private System.Windows.Forms.ToolStripMenuItem qLThuocToolStripMenuItem;
//private System.Windows.Forms.ToolStripMenuItem qLNhaCungCapToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaithuoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panelHome;
    }
}

