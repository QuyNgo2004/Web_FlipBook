namespace GUI
{
    partial class Menu
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
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.btnDanhSachNhaPhanPhoi = new System.Windows.Forms.Button();
            this.btnDanhSachKhachHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.pnlNhanSu = new System.Windows.Forms.Panel();
            this.btnDanhSachChiNhanh = new System.Windows.Forms.Button();
            this.btnDanhSachNhanSu = new System.Windows.Forms.Button();
            this.btnNhanSu = new System.Windows.Forms.Button();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.btnCTKhuyenMai = new System.Windows.Forms.Button();
            this.btnThanhToanHoaDon = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuShow = new System.Windows.Forms.Panel();
            this.pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            this.pnlNhanSu.SuspendLayout();
            this.pnlHangHoa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavbar.Controls.Add(this.btnLogout);
            this.pnlNavbar.Controls.Add(this.btnThoat);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(1293, 40);
            this.pnlNavbar.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::GUI.Properties.Resources.images;
            this.btnLogout.Location = new System.Drawing.Point(1206, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(24, 24);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Tomato;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1240, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(27, 24);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlMenu.Controls.Add(this.pnlKhachHang);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Controls.Add(this.pnlNhanSu);
            this.pnlMenu.Controls.Add(this.btnNhanSu);
            this.pnlMenu.Controls.Add(this.pnlHangHoa);
            this.pnlMenu.Controls.Add(this.btnHangHoa);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(241, 594);
            this.pnlMenu.TabIndex = 5;
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.Honeydew;
            this.pnlKhachHang.Controls.Add(this.btnDanhSachNhaPhanPhoi);
            this.pnlKhachHang.Controls.Add(this.btnDanhSachKhachHang);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhachHang.Location = new System.Drawing.Point(0, 446);
            this.pnlKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(241, 67);
            this.pnlKhachHang.TabIndex = 8;
            // 
            // btnDanhSachNhaPhanPhoi
            // 
            this.btnDanhSachNhaPhanPhoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDanhSachNhaPhanPhoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachNhaPhanPhoi.FlatAppearance.BorderSize = 0;
            this.btnDanhSachNhaPhanPhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhaPhanPhoi.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachNhaPhanPhoi.Location = new System.Drawing.Point(0, 36);
            this.btnDanhSachNhaPhanPhoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanhSachNhaPhanPhoi.Name = "btnDanhSachNhaPhanPhoi";
            this.btnDanhSachNhaPhanPhoi.Size = new System.Drawing.Size(241, 31);
            this.btnDanhSachNhaPhanPhoi.TabIndex = 1;
            this.btnDanhSachNhaPhanPhoi.Text = "Danh sách nhà phân phối";
            this.btnDanhSachNhaPhanPhoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachNhaPhanPhoi.UseVisualStyleBackColor = false;
            this.btnDanhSachNhaPhanPhoi.Click += new System.EventHandler(this.btnDanhSachNhaPhanPhoi_Click);
            // 
            // btnDanhSachKhachHang
            // 
            this.btnDanhSachKhachHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.btnDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            this.btnDanhSachKhachHang.Size = new System.Drawing.Size(241, 36);
            this.btnDanhSachKhachHang.TabIndex = 0;
            this.btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            this.btnDanhSachKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachKhachHang.UseVisualStyleBackColor = false;
            this.btnDanhSachKhachHang.Click += new System.EventHandler(this.btnDanhSachKhachHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 412);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(241, 34);
            this.btnKhachHang.TabIndex = 7;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // pnlNhanSu
            // 
            this.pnlNhanSu.BackColor = System.Drawing.Color.Honeydew;
            this.pnlNhanSu.Controls.Add(this.btnDanhSachChiNhanh);
            this.pnlNhanSu.Controls.Add(this.btnDanhSachNhanSu);
            this.pnlNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhanSu.Location = new System.Drawing.Point(0, 340);
            this.pnlNhanSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNhanSu.Name = "pnlNhanSu";
            this.pnlNhanSu.Size = new System.Drawing.Size(241, 72);
            this.pnlNhanSu.TabIndex = 6;
            // 
            // btnDanhSachChiNhanh
            // 
            this.btnDanhSachChiNhanh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDanhSachChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachChiNhanh.FlatAppearance.BorderSize = 0;
            this.btnDanhSachChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachChiNhanh.Location = new System.Drawing.Point(0, 36);
            this.btnDanhSachChiNhanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanhSachChiNhanh.Name = "btnDanhSachChiNhanh";
            this.btnDanhSachChiNhanh.Size = new System.Drawing.Size(241, 36);
            this.btnDanhSachChiNhanh.TabIndex = 4;
            this.btnDanhSachChiNhanh.Text = "Danh sách chi nhánh";
            this.btnDanhSachChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachChiNhanh.UseVisualStyleBackColor = false;
            this.btnDanhSachChiNhanh.Click += new System.EventHandler(this.btnDanhSachChiNhanh_Click);
            // 
            // btnDanhSachNhanSu
            // 
            this.btnDanhSachNhanSu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDanhSachNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachNhanSu.FlatAppearance.BorderSize = 0;
            this.btnDanhSachNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhanSu.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachNhanSu.Location = new System.Drawing.Point(0, 0);
            this.btnDanhSachNhanSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDanhSachNhanSu.Name = "btnDanhSachNhanSu";
            this.btnDanhSachNhanSu.Size = new System.Drawing.Size(241, 36);
            this.btnDanhSachNhanSu.TabIndex = 3;
            this.btnDanhSachNhanSu.Text = "Quản lý nhân sự";
            this.btnDanhSachNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachNhanSu.UseVisualStyleBackColor = false;
            this.btnDanhSachNhanSu.Click += new System.EventHandler(this.btnDanhSachNhanSu_Click);
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanSu.FlatAppearance.BorderSize = 0;
            this.btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanSu.ForeColor = System.Drawing.Color.Transparent;
            this.btnNhanSu.Location = new System.Drawing.Point(0, 306);
            this.btnNhanSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(241, 34);
            this.btnNhanSu.TabIndex = 5;
            this.btnNhanSu.Text = "NHÂN SỰ";
            this.btnNhanSu.UseVisualStyleBackColor = false;
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.BackColor = System.Drawing.Color.Honeydew;
            this.pnlHangHoa.Controls.Add(this.btnCTKhuyenMai);
            this.pnlHangHoa.Controls.Add(this.btnThanhToanHoaDon);
            this.pnlHangHoa.Controls.Add(this.btnNhapHang);
            this.pnlHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHangHoa.Location = new System.Drawing.Point(0, 201);
            this.pnlHangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(241, 105);
            this.pnlHangHoa.TabIndex = 4;
            // 
            // btnCTKhuyenMai
            // 
            this.btnCTKhuyenMai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCTKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCTKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnCTKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnCTKhuyenMai.Location = new System.Drawing.Point(0, 72);
            this.btnCTKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCTKhuyenMai.Name = "btnCTKhuyenMai";
            this.btnCTKhuyenMai.Size = new System.Drawing.Size(241, 36);
            this.btnCTKhuyenMai.TabIndex = 2;
            this.btnCTKhuyenMai.Text = "Chương trình khuyến mãi";
            this.btnCTKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTKhuyenMai.UseVisualStyleBackColor = false;
            this.btnCTKhuyenMai.Click += new System.EventHandler(this.btnCTKhuyenMai_Click);
            // 
            // btnThanhToanHoaDon
            // 
            this.btnThanhToanHoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThanhToanHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToanHoaDon.FlatAppearance.BorderSize = 0;
            this.btnThanhToanHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanHoaDon.Location = new System.Drawing.Point(0, 36);
            this.btnThanhToanHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToanHoaDon.Name = "btnThanhToanHoaDon";
            this.btnThanhToanHoaDon.Size = new System.Drawing.Size(241, 36);
            this.btnThanhToanHoaDon.TabIndex = 4;
            this.btnThanhToanHoaDon.Text = "Thanh toán hóa đơn";
            this.btnThanhToanHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToanHoaDon.UseVisualStyleBackColor = false;
            this.btnThanhToanHoaDon.Click += new System.EventHandler(this.btnThanhToanHoaDon_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 0);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(241, 36);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHangHoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 167);
            this.btnHangHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(241, 34);
            this.btnHangHoa.TabIndex = 1;
            this.btnHangHoa.Text = "HÀNG HÓA";
            this.btnHangHoa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 63);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nguyễn Văn A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(-1, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Xin chào, nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 104);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "AN NAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hệ thống quản lý chuỗi nhà sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenuShow
            // 
            this.pnlMenuShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuShow.Location = new System.Drawing.Point(241, 40);
            this.pnlMenuShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenuShow.Name = "pnlMenuShow";
            this.pnlMenuShow.Size = new System.Drawing.Size(1052, 594);
            this.pnlMenuShow.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 634);
            this.Controls.Add(this.pnlMenuShow);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnlNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlNhanSu.ResumeLayout(false);
            this.pnlHangHoa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Button btnDanhSachNhaPhanPhoi;
        private System.Windows.Forms.Button btnDanhSachKhachHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel pnlNhanSu;
        private System.Windows.Forms.Button btnDanhSachChiNhanh;
        private System.Windows.Forms.Button btnDanhSachNhanSu;
        private System.Windows.Forms.Button btnNhanSu;
        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.Button btnCTKhuyenMai;
        private System.Windows.Forms.Button btnThanhToanHoaDon;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenuShow;
    }
}

