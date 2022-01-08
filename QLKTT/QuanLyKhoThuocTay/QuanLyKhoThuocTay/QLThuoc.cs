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
    public partial class QLThuoc : Form
    {
        public QLThuoc()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            using(khothuoctayEntities db = new khothuoctayEntities())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.view_thuoc.ToList<view_thuoc>();
                cbbLoaithuoc.ValueMember = "maloaithuoc";
                cbbLoaithuoc.DisplayMember = "tenloaithuoc";
                cbbLoaithuoc.DataSource = db.loaithuocs.ToList<loaithuoc>();
                reload();
            }
        }
        private void QLThuoc_Activated(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            thongtinthuoc();
        }
        public void thongtinthuoc()
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMathuoc.Text = dataGridView1[0, i].Value.ToString();
            txtTenthuoc.Text = txtTenthuoccu.Text = dataGridView1[2, i].Value.ToString();
            cbbLoaithuoc.Text = dataGridView1[3, i].Value.ToString();
            txtNoisx.Text = dataGridView1[4, i].Value.ToString();
            dateTimePickerNgaysx.Value = DateTime.Parse(dataGridView1[5, i].Value.ToString());
            dateTimePickerHansd.Value = DateTime.Parse(dataGridView1[6, i].Value.ToString());
            txtNCC.Text = dataGridView1[7, i].Value.ToString();
            txtSoluong.Text = dataGridView1[8, i].Value.ToString();
            txtDongia.Text = dataGridView1[9, i].Value.ToString();
            txtDonvitinh.Text = dataGridView1[10, i].Value.ToString();
            btnSua.Enabled = btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            using(khothuoctayEntities db = new khothuoctayEntities())
            {
                string key = txtTim.Text;
                dataGridView1.AutoGenerateColumns = false;
                if (key!="")
                {
                    dataGridView1.DataSource = db.view_thuoc.Where(s => s.tenthuoc.Contains(key) || s.tenloaithuoc.Contains(key) || s.noisanxuat.Contains(key) || s.nhacungcap.Contains(key)).ToList<view_thuoc>();
                }
                else
                {
                    load();
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(khothuoctayEntities db = new khothuoctayEntities())
            {
                if (txtTenthuoc.Text!=""&&txtNCC.Text!=""&&txtNoisx.Text!=""&&txtSoluong.Text!=""&&txtDongia.Text!=""&&textbox.Text!="")
                {
                    try
                    {
                        string tenthuoc = txtTenthuoc.Text;
                        int maloaithuoc = int.Parse(cbbLoaithuoc.SelectedValue.ToString());
                        string nhacungcap = txtNCC.Text;
                        string noisanxuat = txtNoisx.Text;
                        DateTime ngaysanxuat = DateTime.Parse(dateTimePickerNgaysx.Text);
                        DateTime hansudung = DateTime.Parse(dateTimePickerHansd.Text);
                        int soluong, dongia;
                        soluong = int.Parse(txtSoluong.Text);
                        dongia = int.Parse(txtDongia.Text);
                        string donvitinh = txtDonvitinh.Text;

                        thuoc t = db.thuocs.Where(s => s.tenthuoc.Equals(tenthuoc)).FirstOrDefault();
                        if (t == null)
                        {
                            thuoc thuoc = new thuoc();
                            thuoc.tenthuoc = tenthuoc;
                            thuoc.maloaithuoc = maloaithuoc;
                            thuoc.nhacungcap = nhacungcap;
                            thuoc.noisanxuat = noisanxuat;
                            thuoc.ngaysanxuat = ngaysanxuat;
                            thuoc.hansudung = hansudung;
                            thuoc.soluong = soluong;
                            thuoc.dongia = dongia;
                            thuoc.donvitinh = donvitinh;
                            db.thuocs.Add(thuoc);
                            db.SaveChanges();
                            MessageBox.Show("Thêm thuốc thành công!", "Thông báo");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Trùng tên thuốc!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi nhập dữ liệu");
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
                if (txtTenthuoc.Text != "" && txtNCC.Text != "" && txtNoisx.Text != "" && txtSoluong.Text != "" && txtDongia.Text != "" && textbox.Text != "")
                {
                    try
                    {
                        int mathuoc = int.Parse(txtMathuoc.Text);
                        string tenthuoc = txtTenthuoc.Text;
                        int maloaithuoc = int.Parse(cbbLoaithuoc.SelectedValue.ToString());
                        string nhacungcap = txtNCC.Text;
                        string noisanxuat = txtNoisx.Text;
                        DateTime ngaysanxuat = DateTime.Parse(dateTimePickerNgaysx.Text);
                        DateTime hansudung = DateTime.Parse(dateTimePickerHansd.Text);
                        int soluong, dongia;
                        soluong = int.Parse(txtSoluong.Text);
                        dongia = int.Parse(txtDongia.Text);
                        string donvitinh = txtDonvitinh.Text;
                        string tenthuoccu = txtTenthuoccu.Text;
                        thuoc t = db.thuocs.Where(s => s.tenthuoc.Equals(tenthuoc)).FirstOrDefault();
                        // tên thuốc cũ trùng tên thuốc mới => không kiểm tra trùng tên
                        // tên thuốc cũ khác tên thuốc mới => kiểm tra ? trùng -> thông báo: cập nhật
                        if (!tenthuoccu.Equals(tenthuoc) && t != null)
                        {
                            MessageBox.Show("Trùng tên thuốc!");
                            thongtinthuoc();
                        }
                        else
                        {
                            thuoc thuoc = db.thuocs.Where(s => s.mathuoc==mathuoc).FirstOrDefault();
                            thuoc.tenthuoc = tenthuoc;
                            thuoc.maloaithuoc = maloaithuoc;
                            thuoc.nhacungcap = nhacungcap;
                            thuoc.noisanxuat = noisanxuat;
                            thuoc.ngaysanxuat = ngaysanxuat;
                            thuoc.hansudung = hansudung;
                            thuoc.soluong = soluong;
                            thuoc.dongia = dongia;
                            thuoc.donvitinh = donvitinh;
                            db.SaveChanges();
                            MessageBox.Show("Sửa thuốc thành công!", "Thông báo");
                            load();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi nhập dữ liệu");
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
            using(khothuoctayEntities db = new khothuoctayEntities())
            {
                DialogResult xacnhan = MessageBox.Show("Bạn chắc chắn muốn xóa thuốc này!", "Thông báo", MessageBoxButtons.YesNo);
                if (xacnhan == DialogResult.Yes)
                {
                    int mathuoc = int.Parse(txtMathuoc.Text);
                    thuoc t = db.thuocs.Where(s => s.mathuoc == mathuoc).FirstOrDefault();
                    db.thuocs.Remove(t);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thuốc thành công!");
                    load();
                }
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            reload();
        }
        public void reload()
        {
            txtTenthuoc.Text = txtNCC.Text = txtNoisx.Text = txtSoluong.Text = txtDongia.Text = txtDonvitinh.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ViewReportThuoc f = new ViewReportThuoc();
            f.Show();
        }
    }
}
