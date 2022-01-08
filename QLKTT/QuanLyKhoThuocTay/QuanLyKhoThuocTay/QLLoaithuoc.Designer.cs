
namespace QuanLyKhoThuocTay
{
    partial class QLLoaithuoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenloaithuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnDatlai = new System.Windows.Forms.Button();
            this.txtMaloaithuoc = new System.Windows.Forms.TextBox();
            this.txtTenloaicu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaithuoc,
            this.stt,
            this.tenloaithuoc});
            this.dataGridView1.Location = new System.Drawing.Point(727, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 452);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // maloaithuoc
            // 
            this.maloaithuoc.DataPropertyName = "maloaithuoc";
            this.maloaithuoc.HeaderText = "Mã loại thuốc";
            this.maloaithuoc.MinimumWidth = 6;
            this.maloaithuoc.Name = "maloaithuoc";
            this.maloaithuoc.Visible = false;
            this.maloaithuoc.Width = 125;
            // 
            // stt
            // 
            this.stt.DataPropertyName = "sothutu";
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.Width = 125;
            // 
            // tenloaithuoc
            // 
            this.tenloaithuoc.DataPropertyName = "tenloaithuoc";
            this.tenloaithuoc.HeaderText = "Tên loại thuốc";
            this.tenloaithuoc.MinimumWidth = 6;
            this.tenloaithuoc.Name = "tenloaithuoc";
            this.tenloaithuoc.Width = 200;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(383, 262);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(149, 50);
            this.btnIn.TabIndex = 47;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(131, 185);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 50);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(131, 262);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 50);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(383, 185);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 50);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenloaithuoc
            // 
            this.txtTenloaithuoc.Location = new System.Drawing.Point(269, 102);
            this.txtTenloaithuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenloaithuoc.Multiline = true;
            this.txtTenloaithuoc.Name = "txtTenloaithuoc";
            this.txtTenloaithuoc.Size = new System.Drawing.Size(261, 36);
            this.txtTenloaithuoc.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên loại thuốc";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(935, 41);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(261, 36);
            this.txtTim.TabIndex = 36;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnDatlai
            // 
            this.btnDatlai.Location = new System.Drawing.Point(131, 342);
            this.btnDatlai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.Size = new System.Drawing.Size(149, 50);
            this.btnDatlai.TabIndex = 47;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.UseVisualStyleBackColor = true;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
            // 
            // txtMaloaithuoc
            // 
            this.txtMaloaithuoc.Location = new System.Drawing.Point(269, 41);
            this.txtMaloaithuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaloaithuoc.Multiline = true;
            this.txtMaloaithuoc.Name = "txtMaloaithuoc";
            this.txtMaloaithuoc.Size = new System.Drawing.Size(261, 36);
            this.txtMaloaithuoc.TabIndex = 36;
            this.txtMaloaithuoc.Visible = false;
            // 
            // txtTenloaicu
            // 
            this.txtTenloaicu.Location = new System.Drawing.Point(269, -1);
            this.txtTenloaicu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenloaicu.Multiline = true;
            this.txtTenloaicu.Name = "txtTenloaicu";
            this.txtTenloaicu.Size = new System.Drawing.Size(261, 36);
            this.txtTenloaicu.TabIndex = 36;
            this.txtTenloaicu.Visible = false;
            // 
            // QLLoaithuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDatlai);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtTenloaicu);
            this.Controls.Add(this.txtMaloaithuoc);
            this.Controls.Add(this.txtTenloaithuoc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLLoaithuoc";
            this.Text = "QL loại thuốc";
            this.Activated += new System.EventHandler(this.QLLoaithuoc_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenloaithuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnDatlai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaithuoc;
        private System.Windows.Forms.TextBox txtMaloaithuoc;
        private System.Windows.Forms.TextBox txtTenloaicu;
    }
}