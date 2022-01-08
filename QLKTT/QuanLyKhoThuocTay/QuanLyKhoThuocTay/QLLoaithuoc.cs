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
    public partial class QLLoaithuoc : Form
    {
        public QLLoaithuoc()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            using (khothuoctayEntities db = new khothuoctayEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.view_loaithuoc.ToList<view_loaithuoc>();
                reload();
            }
        }
        public void reload()
        {
            txtTenloaithuoc.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            using (khothuoctayEntities db = new khothuoctayEntities())
            {
                string key = txtTim.Text;
                dataGridView1.AutoGenerateColumns = false;
                if (key != "")
                {
                    dataGridView1.DataSource = db.view_loaithuoc.Where(s => s.tenloaithuoc.Contains(key)).ToList<view_loaithuoc>();
                }
                else
                {
                    load();
                }

            }
        }
        public void thongtinloai()
        {
            int i = dataGridView1.CurrentRow.Index;
            txtTenloaithuoc.Text = txtTenloaicu.Text = dataGridView1[2, i].Value.ToString();
            txtMaloaithuoc.Text = dataGridView1[0, i].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            thongtinloai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(khothuoctayEntities db = new khothuoctayEntities())
            {
                if(txtTenloaithuoc.Text !="")
                {
                    loaithuoc loai = db.loaithuocs.Where(s => s.tenloaithuoc.Equals(txtTenloaithuoc.Text)).FirstOrDefault();
                    if (loai == null)
                    {
                        loaithuoc lt = new loaithuoc();
                        lt.tenloaithuoc = txtTenloaithuoc.Text;
                        db.loaithuocs.Add(lt);
                        db.SaveChanges();
                        MessageBox.Show("Thêm loại thuốc thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Trùng tên loại thuốc!");
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (khothuoctayEntities db = new khothuoctayEntities())
            {
                if (txtTenloaithuoc.Text != "")
                {
                    loaithuoc loai = db.loaithuocs.Where(s => s.tenloaithuoc.Equals(txtTenloaithuoc.Text)).FirstOrDefault();
                    if (!txtTenloaicu.Text.Equals(txtTenloaithuoc.Text) && loai != null)
                    {
                        MessageBox.Show("Trùng tên loại thuốc!");
                        thongtinloai();
                    }
                    else
                    {
                        loaithuoc lt = db.loaithuocs.Where(s => s.tenloaithuoc.Equals(txtTenloaicu.Text)).FirstOrDefault();
                        lt.tenloaithuoc = txtTenloaithuoc.Text;
                        db.SaveChanges();
                        MessageBox.Show("Sửa loại thuốc thành công");
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (khothuoctayEntities db = new khothuoctayEntities())
            {
                try
                {
                    DialogResult xacnhan = MessageBox.Show("Bạn chắc chắn muốn xóa loại thuốc này!", "Thông báo", MessageBoxButtons.YesNo);
                    if (xacnhan == DialogResult.Yes)
                    {
                        int maloaithuoc = int.Parse(txtMaloaithuoc.Text);
                        loaithuoc t = db.loaithuocs.Where(s => s.maloaithuoc == maloaithuoc).FirstOrDefault();
                        db.loaithuocs.Remove(t);
                        db.SaveChanges();
                        MessageBox.Show("Xóa loại thuốc thành công!");
                        load();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi! Không thể xóa loại thuốc này!");
                }
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void QLLoaithuoc_Activated(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ViewReportLoaiThuoc f = new ViewReportLoaiThuoc();
                f.Show();
        }
    }
}
