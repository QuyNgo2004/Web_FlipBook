using BUS;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// bỏ màn hình con vào panel.
        /// </summary>
        /// <param name="childForm"></param>

        public void openChildForm(Form childForm)
        {

            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlMenuShow.Controls.Add(childForm);
                pnlMenuShow.Tag = childForm;
                // Code để thêm và hiển thị form con
                this.pnlMenuShow.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                // Ghi lại hoặc hiển thị lỗi
                Console.WriteLine("Error opening child form: " + ex.Message);
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        /// <summary>
        /// button thoát.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi chương trình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// button logout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi tài khoảng hay không ?", "ĐĂNG XUẤT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        /// <summary>
        /// button nhập hàng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhapHang nhaphang;
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (nhaphang == null || nhaphang.IsDisposed)
            {
                openChildForm(new NhapHang());
            }
            else
            {
                nhaphang.BringToFront();
            }
        }

        /// <summary>
        /// button danh sách nhân sự.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhanSu nhansu;
        private void btnDanhSachNhanSu_Click(object sender, EventArgs e)
        {
            if (nhansu == null || nhansu.IsDisposed)
            {
                openChildForm(new NhanSu());
            }
            else
            {
                nhansu.BringToFront();
            }
        }

        /// <summary>
        /// button chương trình khuyến mãi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private KhuyenMai khuyenmai;
        private void btnCTKhuyenMai_Click(object sender, EventArgs e)
        {
            if (khuyenmai == null || khuyenmai.IsDisposed)
            {
                openChildForm(new KhuyenMai());
            }
            else
            {
                khuyenmai.BringToFront();
            }
        }

        /// <summary>
        /// button nhà phân phối.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private NhaPhanPhoi npp;
        private void btnDanhSachNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            if (npp == null || npp.IsDisposed)
            {
                openChildForm(new NhaPhanPhoi());
            }
            else
            {
                npp.BringToFront();
            }
        }
        /// <summary>
        /// button Khách Hàng.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private KhachHang kh;
        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
            {
                openChildForm(new KhachHang());
            }
            else
            {
                kh.BringToFront();
            }
        }
        private frmChiNhanh chiNhanh;
        private void btnDanhSachChiNhanh_Click(object sender, EventArgs e)
        {
            if (chiNhanh == null || chiNhanh.IsDisposed)
            {
                openChildForm(new frmChiNhanh());
            }
            else
            {
                kh.BringToFront();
            }
            //pnlMenuShow.Controls.Clear();
            //UCChiNhanh chiNhanh = new UCChiNhanh();
            //pnlMenuShow.Tag = chiNhanh;
            //chiNhanh.Dock = DockStyle.Fill;
            //this.pnlMenuShow.Controls.Add(chiNhanh);
        }
        private formThanhToan thanhToan;
        private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            if (thanhToan == null || thanhToan.IsDisposed)
            {
                openChildForm(new formThanhToan());
            }
            else
            {
                kh.BringToFront();
            }
            //pnlMenuShow.Controls.Clear();
            //ThanhToan thanhToan = new ThanhToan();
            //pnlMenuShow.Tag = thanhToan;
            //thanhToan.Dock = DockStyle.Fill;
            //pnlMenuShow.Controls.Add(thanhToan);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
