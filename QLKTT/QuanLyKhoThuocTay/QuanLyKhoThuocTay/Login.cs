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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = "trung";
            string matkhau = "123";
            if (txtTaiKhoan.Text.Equals(taikhoan) && txtMatKhau.Text.Equals(matkhau))
            {
                MessageBox.Show("Đăng nhập thành công!");
                Close();
            }
            else
            {
                txtTaiKhoan.Text = txtMatKhau.Text = "";
                MessageBox.Show("Đăng nhập sai!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
