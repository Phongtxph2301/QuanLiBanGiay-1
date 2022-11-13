namespace C_GUI.Views
{
    partial class FormBanHang
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lsvShowSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lsvShowHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbxKhachHang = new C_GUI.RJControls.RJComboBox();
            this._cbxNhanVien = new C_GUI.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._rjtbxThanhTien = new C_GUI.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton1 = new C_GUI.RJControls.RJButton();
            this._rjbtnXacNhan = new C_GUI.RJControls.RJButton();
            this._rjtbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lsvShowSanPham);
            this.groupBox1.Location = new System.Drawing.Point(385, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(701, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // _lsvShowSanPham
            // 
            this._lsvShowSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this._lsvShowSanPham.FullRowSelect = true;
            this._lsvShowSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this._lsvShowSanPham.Location = new System.Drawing.Point(5, 20);
            this._lsvShowSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvShowSanPham.Name = "_lsvShowSanPham";
            this._lsvShowSanPham.Size = new System.Drawing.Size(696, 170);
            this._lsvShowSanPham.TabIndex = 1;
            this._lsvShowSanPham.UseCompatibleStateImageBehavior = false;
            this._lsvShowSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Giày";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Màu Sắc";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hãng Giày";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nsx";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Size";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Chiều Cao Đế Giày";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giá";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Số Lượng Tồn";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mô Tả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lsvShowHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(385, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(701, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn";
            // 
            // _lsvShowHoaDon
            // 
            this._lsvShowHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this._lsvShowHoaDon.FullRowSelect = true;
            this._lsvShowHoaDon.Location = new System.Drawing.Point(5, 20);
            this._lsvShowHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvShowHoaDon.Name = "_lsvShowHoaDon";
            this._lsvShowHoaDon.Size = new System.Drawing.Size(696, 210);
            this._lsvShowHoaDon.TabIndex = 0;
            this._lsvShowHoaDon.UseCompatibleStateImageBehavior = false;
            this._lsvShowHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Id";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Mã Hóa Đơn";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tên Giày ";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Đơn Giá";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Số Lượng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._cbxKhachHang);
            this.groupBox3.Controls.Add(this._cbxNhanVien);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._rjtbxThanhTien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rjButton1);
            this.groupBox3.Controls.Add(this._rjbtnXacNhan);
            this.groupBox3.Controls.Add(this._rjtbxMaHoaDon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(369, 424);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // _cbxKhachHang
            // 
            this._cbxKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxKhachHang.BorderColor = System.Drawing.Color.Black;
            this._cbxKhachHang.BorderSize = 1;
            this._cbxKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxKhachHang.ForeColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxKhachHang.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.Location = new System.Drawing.Point(145, 115);
            this._cbxKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbxKhachHang.MinimumSize = new System.Drawing.Size(175, 22);
            this._cbxKhachHang.Name = "_cbxKhachHang";
            this._cbxKhachHang.Padding = new System.Windows.Forms.Padding(1);
            this._cbxKhachHang.Size = new System.Drawing.Size(219, 29);
            this._cbxKhachHang.TabIndex = 21;
            this._cbxKhachHang.Texts = "";
            // 
            // _cbxNhanVien
            // 
            this._cbxNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxNhanVien.BorderColor = System.Drawing.Color.Black;
            this._cbxNhanVien.BorderSize = 1;
            this._cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxNhanVien.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.Location = new System.Drawing.Point(145, 186);
            this._cbxNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._cbxNhanVien.MinimumSize = new System.Drawing.Size(175, 22);
            this._cbxNhanVien.Name = "_cbxNhanVien";
            this._cbxNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this._cbxNhanVien.Size = new System.Drawing.Size(219, 29);
            this._cbxNhanVien.TabIndex = 20;
            this._cbxNhanVien.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // _rjtbxThanhTien
            // 
            this._rjtbxThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this._rjtbxThanhTien.BorderColor = System.Drawing.Color.Black;
            this._rjtbxThanhTien.BorderFocusColor = System.Drawing.Color.Red;
            this._rjtbxThanhTien.BorderRadius = 15;
            this._rjtbxThanhTien.BorderSize = 2;
            this._rjtbxThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjtbxThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._rjtbxThanhTien.Location = new System.Drawing.Point(145, 251);
            this._rjtbxThanhTien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rjtbxThanhTien.MaxLength = 20;
            this._rjtbxThanhTien.Multiline = false;
            this._rjtbxThanhTien.Name = "_rjtbxThanhTien";
            this._rjtbxThanhTien.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._rjtbxThanhTien.PasswordChar = false;
            this._rjtbxThanhTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._rjtbxThanhTien.PlaceholderText = "";
            this._rjtbxThanhTien.Size = new System.Drawing.Size(211, 27);
            this._rjtbxThanhTien.TabIndex = 18;
            this._rjtbxThanhTien.Texts = "";
            this._rjtbxThanhTien.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thành Tiền";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Turquoise;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Turquoise;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(17, 334);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(164, 29);
            this.rjButton1.SizeImage = new System.Drawing.Size(20, 20);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "Tạo Hóa Đơn";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // _rjbtnXacNhan
            // 
            this._rjbtnXacNhan.BackColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._rjbtnXacNhan.BorderColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.BorderRadius = 15;
            this._rjbtnXacNhan.BorderSize = 2;
            this._rjbtnXacNhan.FlatAppearance.BorderSize = 0;
            this._rjbtnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._rjbtnXacNhan.ForeColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.Location = new System.Drawing.Point(192, 334);
            this._rjbtnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._rjbtnXacNhan.Name = "_rjbtnXacNhan";
            this._rjbtnXacNhan.Size = new System.Drawing.Size(164, 29);
            this._rjbtnXacNhan.SizeImage = new System.Drawing.Size(20, 20);
            this._rjbtnXacNhan.TabIndex = 15;
            this._rjbtnXacNhan.Text = "Thanh Toán";
            this._rjbtnXacNhan.TextColor = System.Drawing.Color.Black;
            this._rjbtnXacNhan.UseVisualStyleBackColor = false;
            // 
            // _rjtbxMaHoaDon
            // 
            this._rjtbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._rjtbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._rjtbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._rjtbxMaHoaDon.BorderRadius = 15;
            this._rjtbxMaHoaDon.BorderSize = 2;
            this._rjtbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._rjtbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._rjtbxMaHoaDon.Location = new System.Drawing.Point(145, 38);
            this._rjtbxMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._rjtbxMaHoaDon.MaxLength = 20;
            this._rjtbxMaHoaDon.Multiline = false;
            this._rjtbxMaHoaDon.Name = "_rjtbxMaHoaDon";
            this._rjtbxMaHoaDon.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this._rjtbxMaHoaDon.PasswordChar = false;
            this._rjtbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._rjtbxMaHoaDon.PlaceholderText = "";
            this._rjtbxMaHoaDon.Size = new System.Drawing.Size(211, 27);
            this._rjtbxMaHoaDon.TabIndex = 9;
            this._rjtbxMaHoaDon.Texts = "";
            this._rjtbxMaHoaDon.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1096, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(101, 412);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn Chờ";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private RJControls.RJButton _rjbtnXacNhan;
        private RJControls.RJTextBox _rjtbxMaHoaDon;
        private GroupBox groupBox4;
        private ListView _lsvShowSanPham;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private RJControls.RJTextBox _rjtbxThanhTien;
        private Label label4;
        private RJControls.RJButton rjButton1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView _lsvShowHoaDon;
        private RJControls.RJComboBox _cbxKhachHang;
        private RJControls.RJComboBox _cbxNhanVien;
        private Label label3;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
    }
}