
namespace QuanLyKhoThuocTay
{
    partial class QLThuoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.txtNoisx = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hansd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtLoaithuoc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbLoaithuoc = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgaysx = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHansd = new System.Windows.Forms.DateTimePicker();
            this.txtTenthuoccu = new System.Windows.Forms.TextBox();
            this.txtMathuoc = new System.Windows.Forms.TextBox();
            this.btnDatlai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hạn Sử Dụng";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Location = new System.Drawing.Point(912, 145);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(82, 17);
            this.textbox.TabIndex = 6;
            this.textbox.Text = "Đơn Vị Tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên NCC";
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(251, 185);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 50);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(137, 21);
            this.txtTenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenthuoc.Multiline = true;
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(261, 36);
            this.txtTenthuoc.TabIndex = 19;
            // 
            // txtNoisx
            // 
            this.txtNoisx.Location = new System.Drawing.Point(593, 21);
            this.txtNoisx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoisx.Multiline = true;
            this.txtNoisx.Name = "txtNoisx";
            this.txtNoisx.Size = new System.Drawing.Size(261, 36);
            this.txtNoisx.TabIndex = 20;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(137, 134);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNCC.Multiline = true;
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(261, 36);
            this.txtNCC.TabIndex = 20;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1037, 26);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(261, 36);
            this.txtSoluong.TabIndex = 23;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(436, 185);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 50);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 185);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 50);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(624, 185);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(149, 50);
            this.btnIn.TabIndex = 26;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathuoc,
            this.stt,
            this.tenthuoc,
            this.loaithuoc,
            this.noisx,
            this.ngaysx,
            this.hansd,
            this.ncc,
            this.soluong,
            this.dongia,
            this.donvitinh});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 459);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // mathuoc
            // 
            this.mathuoc.DataPropertyName = "mathuoc";
            this.mathuoc.HeaderText = "Mã thuốc";
            this.mathuoc.MinimumWidth = 6;
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Visible = false;
            this.mathuoc.Width = 125;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "sothutu";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // tenthuoc
            // 
            this.tenthuoc.DataPropertyName = "tenthuoc";
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 6;
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Width = 150;
            // 
            // loaithuoc
            // 
            this.loaithuoc.DataPropertyName = "tenloaithuoc";
            this.loaithuoc.HeaderText = "Loại thuốc";
            this.loaithuoc.MinimumWidth = 6;
            this.loaithuoc.Name = "loaithuoc";
            this.loaithuoc.Width = 125;
            // 
            // noisx
            // 
            this.noisx.DataPropertyName = "noisanxuat";
            this.noisx.HeaderText = "Nơi SX";
            this.noisx.MinimumWidth = 6;
            this.noisx.Name = "noisx";
            this.noisx.Width = 125;
            // 
            // ngaysx
            // 
            this.ngaysx.DataPropertyName = "ngaysanxuat";
            this.ngaysx.HeaderText = "Ngày SX";
            this.ngaysx.MinimumWidth = 6;
            this.ngaysx.Name = "ngaysx";
            this.ngaysx.Width = 125;
            // 
            // hansd
            // 
            this.hansd.DataPropertyName = "hansudung";
            this.hansd.HeaderText = "Hạn sử dụng";
            this.hansd.MinimumWidth = 6;
            this.hansd.Name = "hansd";
            this.hansd.Width = 125;
            // 
            // ncc
            // 
            this.ncc.DataPropertyName = "nhacungcap";
            this.ncc.HeaderText = "Nhà CC";
            this.ncc.MinimumWidth = 6;
            this.ncc.Name = "ncc";
            this.ncc.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.MinimumWidth = 6;
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 125;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(1099, 198);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(339, 36);
            this.txtTim.TabIndex = 23;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(1037, 79);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDongia.Multiline = true;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(261, 36);
            this.txtDongia.TabIndex = 23;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(1037, 130);
            this.txtDonvitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonvitinh.Multiline = true;
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(261, 36);
            this.txtDonvitinh.TabIndex = 23;
            // 
            // txtLoaithuoc
            // 
            this.txtLoaithuoc.AutoSize = true;
            this.txtLoaithuoc.Location = new System.Drawing.Point(43, 82);
            this.txtLoaithuoc.Name = "txtLoaithuoc";
            this.txtLoaithuoc.Size = new System.Drawing.Size(74, 17);
            this.txtLoaithuoc.TabIndex = 7;
            this.txtLoaithuoc.Text = "Loại thuốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nơi SX";
            // 
            // cbbLoaithuoc
            // 
            this.cbbLoaithuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaithuoc.FormattingEnabled = true;
            this.cbbLoaithuoc.Location = new System.Drawing.Point(137, 76);
            this.cbbLoaithuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaithuoc.Name = "cbbLoaithuoc";
            this.cbbLoaithuoc.Size = new System.Drawing.Size(261, 26);
            this.cbbLoaithuoc.TabIndex = 28;
            // 
            // dateTimePickerNgaysx
            // 
            this.dateTimePickerNgaysx.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaysx.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaysx.Location = new System.Drawing.Point(589, 82);
            this.dateTimePickerNgaysx.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNgaysx.Name = "dateTimePickerNgaysx";
            this.dateTimePickerNgaysx.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerNgaysx.TabIndex = 29;
            // 
            // dateTimePickerHansd
            // 
            this.dateTimePickerHansd.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerHansd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHansd.Location = new System.Drawing.Point(589, 134);
            this.dateTimePickerHansd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHansd.Name = "dateTimePickerHansd";
            this.dateTimePickerHansd.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerHansd.TabIndex = 29;
            // 
            // txtTenthuoccu
            // 
            this.txtTenthuoccu.Location = new System.Drawing.Point(137, 4);
            this.txtTenthuoccu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenthuoccu.Multiline = true;
            this.txtTenthuoccu.Name = "txtTenthuoccu";
            this.txtTenthuoccu.Size = new System.Drawing.Size(261, 36);
            this.txtTenthuoccu.TabIndex = 19;
            this.txtTenthuoccu.Visible = false;
            // 
            // txtMathuoc
            // 
            this.txtMathuoc.Location = new System.Drawing.Point(589, 4);
            this.txtMathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMathuoc.Multiline = true;
            this.txtMathuoc.Name = "txtMathuoc";
            this.txtMathuoc.Size = new System.Drawing.Size(261, 36);
            this.txtMathuoc.TabIndex = 19;
            this.txtMathuoc.Visible = false;
            // 
            // btnDatlai
            // 
            this.btnDatlai.Location = new System.Drawing.Point(815, 185);
            this.btnDatlai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.Size = new System.Drawing.Size(149, 50);
            this.btnDatlai.TabIndex = 26;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.UseVisualStyleBackColor = true;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
            // 
            // QLThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 714);
            this.Controls.Add(this.dateTimePickerHansd);
            this.Controls.Add(this.dateTimePickerNgaysx);
            this.Controls.Add(this.cbbLoaithuoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDatlai);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtDonvitinh);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtNoisx);
            this.Controls.Add(this.txtMathuoc);
            this.Controls.Add(this.txtTenthuoccu);
            this.Controls.Add(this.txtTenthuoc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLoaithuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLThuoc";
            this.Text = "QLThuoc";
            this.Activated += new System.EventHandler(this.QLThuoc_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.TextBox txtNoisx;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.Label txtLoaithuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbLoaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysx;
        private System.Windows.Forms.DataGridViewTextBoxColumn hansd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaysx;
        private System.Windows.Forms.DateTimePicker dateTimePickerHansd;
        private System.Windows.Forms.TextBox txtTenthuoccu;
        private System.Windows.Forms.TextBox txtMathuoc;
        private System.Windows.Forms.Button btnDatlai;
    }
}