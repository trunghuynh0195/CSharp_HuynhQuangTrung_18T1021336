using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoThuocTay
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            login_logout(mySave.KT);
        }
        public void login_logout(Boolean kt)
        {
            mnuClose.Enabled = mnuLogin.Enabled = !kt;
            mnuLogout.Enabled = mnuDanhmuc.Enabled = kt;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            login_logout(mySave.KT);
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
        }

        private void mnuThuoc_Click(object sender, EventArgs e)
        {
            QLThuoc f = new QLThuoc();
            f.Show();
        }

        private void mnuLoaithuoc_Click(object sender, EventArgs e)
        {
            QLLoaithuoc f = new QLLoaithuoc();
            f.Show();
        }
    }
}
