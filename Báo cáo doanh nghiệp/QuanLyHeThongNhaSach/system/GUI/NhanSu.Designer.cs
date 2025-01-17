namespace GUI
{
    partial class NhanSu
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
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtDiaChiNha = new System.Windows.Forms.TextBox();
            this.lblDiaChiNha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCccdNS = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtTenNS = new System.Windows.Forms.TextBox();
            this.lblTenNS = new System.Windows.Forms.Label();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.lblMaNS = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanSu = new System.Windows.Forms.DataGridView();
            this.pnlNhanSu = new System.Windows.Forms.Panel();
            this.lblDSNhanSu = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCaTruc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanSu)).BeginInit();
            this.pnlNhanSu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cboChucVu.Location = new System.Drawing.Point(131, 307);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(177, 26);
            this.cboChucVu.TabIndex = 23;
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(131, 272);
            this.cboChiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(177, 26);
            this.cboChiNhanh.TabIndex = 22;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(229, 107);
            this.radNu.Margin = new System.Windows.Forms.Padding(2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 22);
            this.radNu.TabIndex = 21;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboChucVu);
            this.groupBox1.Controls.Add(this.cboChiNhanh);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.lblChucVu);
            this.groupBox1.Controls.Add(this.lblChiNhanh);
            this.groupBox1.Controls.Add(this.txtDiaChiNha);
            this.groupBox1.Controls.Add(this.lblDiaChiNha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.lblCccdNS);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.txtTenNS);
            this.groupBox1.Controls.Add(this.lblTenNS);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.lblMaNS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 343);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Sự";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(131, 107);
            this.radNam.Margin = new System.Windows.Forms.Padding(2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 22);
            this.radNam.TabIndex = 20;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(21, 309);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(62, 18);
            this.lblChucVu.TabIndex = 16;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(17, 274);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(74, 18);
            this.lblChiNhanh.TabIndex = 14;
            this.lblChiNhanh.Text = "Chi nhánh";
            // 
            // txtDiaChiNha
            // 
            this.txtDiaChiNha.BackColor = System.Drawing.Color.White;
            this.txtDiaChiNha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChiNha.Location = new System.Drawing.Point(131, 238);
            this.txtDiaChiNha.Name = "txtDiaChiNha";
            this.txtDiaChiNha.Size = new System.Drawing.Size(177, 24);
            this.txtDiaChiNha.TabIndex = 13;
            this.txtDiaChiNha.Validated += new System.EventHandler(this.txtDiaChiNha_Validated);
            // 
            // lblDiaChiNha
            // 
            this.lblDiaChiNha.AutoSize = true;
            this.lblDiaChiNha.Location = new System.Drawing.Point(17, 240);
            this.lblDiaChiNha.Name = "lblDiaChiNha";
            this.lblDiaChiNha.Size = new System.Drawing.Size(81, 18);
            this.lblDiaChiNha.TabIndex = 12;
            this.lblDiaChiNha.Text = "Địa chỉ nhà";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(131, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 24);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 207);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(131, 170);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(177, 24);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.Validated += new System.EventHandler(this.txtSDT_Validated);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(17, 173);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(94, 18);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.Color.White;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Location = new System.Drawing.Point(131, 136);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(177, 24);
            this.txtCCCD.TabIndex = 7;
            this.txtCCCD.Validated += new System.EventHandler(this.txtCCCD_Validated);
            // 
            // lblCccdNS
            // 
            this.lblCccdNS.AutoSize = true;
            this.lblCccdNS.Location = new System.Drawing.Point(17, 140);
            this.lblCccdNS.Name = "lblCccdNS";
            this.lblCccdNS.Size = new System.Drawing.Size(52, 18);
            this.lblCccdNS.TabIndex = 6;
            this.lblCccdNS.Text = "CCCD";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(17, 108);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(62, 18);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtTenNS
            // 
            this.txtTenNS.BackColor = System.Drawing.Color.White;
            this.txtTenNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNS.Location = new System.Drawing.Point(131, 73);
            this.txtTenNS.Name = "txtTenNS";
            this.txtTenNS.Size = new System.Drawing.Size(177, 24);
            this.txtTenNS.TabIndex = 3;
            this.txtTenNS.Validated += new System.EventHandler(this.txtTenNS_Validated);
            // 
            // lblTenNS
            // 
            this.lblTenNS.AutoSize = true;
            this.lblTenNS.Location = new System.Drawing.Point(17, 77);
            this.lblTenNS.Name = "lblTenNS";
            this.lblTenNS.Size = new System.Drawing.Size(89, 18);
            this.lblTenNS.TabIndex = 2;
            this.lblTenNS.Text = "Tên nhân sự";
            // 
            // txtMaNS
            // 
            this.txtMaNS.BackColor = System.Drawing.Color.White;
            this.txtMaNS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNS.Enabled = false;
            this.txtMaNS.Location = new System.Drawing.Point(131, 40);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(177, 24);
            this.txtMaNS.TabIndex = 1;
            // 
            // lblMaNS
            // 
            this.lblMaNS.AutoSize = true;
            this.lblMaNS.Location = new System.Drawing.Point(17, 43);
            this.lblMaNS.Name = "lblMaNS";
            this.lblMaNS.Size = new System.Drawing.Size(85, 18);
            this.lblMaNS.TabIndex = 0;
            this.lblMaNS.Text = "Mã nhân sự";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSNhanSu);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(367, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 515);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhân Sự";
            // 
            // dgvDSNhanSu
            // 
            this.dgvDSNhanSu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDSNhanSu.AllowUserToAddRows = false;
            this.dgvDSNhanSu.AllowUserToDeleteRows = false;
            this.dgvDSNhanSu.AllowUserToResizeColumns = false;
            this.dgvDSNhanSu.AllowUserToResizeRows = false;
            this.dgvDSNhanSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhanSu.Location = new System.Drawing.Point(3, 20);
            this.dgvDSNhanSu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSNhanSu.MultiSelect = false;
            this.dgvDSNhanSu.Name = "dgvDSNhanSu";
            this.dgvDSNhanSu.RowHeadersWidth = 62;
            this.dgvDSNhanSu.RowTemplate.Height = 28;
            this.dgvDSNhanSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDSNhanSu.Size = new System.Drawing.Size(641, 492);
            this.dgvDSNhanSu.TabIndex = 0;
            this.dgvDSNhanSu.Click += new System.EventHandler(this.dgvDSNhanSu_Click);
            // 
            // pnlNhanSu
            // 
            this.pnlNhanSu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlNhanSu.Controls.Add(this.lblDSNhanSu);
            this.pnlNhanSu.Location = new System.Drawing.Point(367, 0);
            this.pnlNhanSu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhanSu.Name = "pnlNhanSu";
            this.pnlNhanSu.Size = new System.Drawing.Size(648, 83);
            this.pnlNhanSu.TabIndex = 30;
            // 
            // lblDSNhanSu
            // 
            this.lblDSNhanSu.AutoSize = true;
            this.lblDSNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSNhanSu.ForeColor = System.Drawing.Color.White;
            this.lblDSNhanSu.Location = new System.Drawing.Point(102, 20);
            this.lblDSNhanSu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSNhanSu.Name = "lblDSNhanSu";
            this.lblDSNhanSu.Size = new System.Drawing.Size(466, 46);
            this.lblDSNhanSu.TabIndex = 7;
            this.lblDSNhanSu.Text = "DANH SÁCH NHÂN SỰ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(46, 79);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(45, 38);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(45, 161);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(262, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(185, 38);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCaTruc);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 248);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Công Cụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(185, 79);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(122, 23);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Tạo Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCaTruc
            // 
            this.btnCaTruc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCaTruc.FlatAppearance.BorderSize = 0;
            this.btnCaTruc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaTruc.ForeColor = System.Drawing.Color.White;
            this.btnCaTruc.Location = new System.Drawing.Point(45, 121);
            this.btnCaTruc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaTruc.Name = "btnCaTruc";
            this.btnCaTruc.Size = new System.Drawing.Size(262, 23);
            this.btnCaTruc.TabIndex = 4;
            this.btnCaTruc.Text = "Quản lý ca trực";
            this.btnCaTruc.UseVisualStyleBackColor = false;
            this.btnCaTruc.Click += new System.EventHandler(this.btnCaTruc_Click);
            // 
            // NhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 705);
            this.Controls.Add(this.pnlNhanSu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhanSu";
            this.Text = "NhanSu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanSu)).EndInit();
            this.pnlNhanSu.ResumeLayout(false);
            this.pnlNhanSu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.TextBox txtDiaChiNha;
        private System.Windows.Forms.Label lblDiaChiNha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCccdNS;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtTenNS;
        private System.Windows.Forms.Label lblTenNS;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label lblMaNS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSNhanSu;
        private System.Windows.Forms.Panel pnlNhanSu;
        private System.Windows.Forms.Label lblDSNhanSu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnCaTruc;
    }
}