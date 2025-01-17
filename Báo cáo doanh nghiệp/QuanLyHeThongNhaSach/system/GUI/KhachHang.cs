using BUS;
using ET;
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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private Menu mainForm;

        public KhachHang(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
            txtMaKH.Text = BUS_KhachHang.Instance.TaoMaKhachHangTuDong();
        }

        private void dgvDSKH_Click(object sender, EventArgs e)
        {
            int a = dgvDSKH.CurrentCell.RowIndex;

            txtMaKH.Text = dgvDSKH.Rows[a].Cells[0].Value?.ToString() ?? "";

            txtTenKH.Text = dgvDSKH.Rows[a].Cells[1].Value?.ToString() ?? "";

            if (DateTime.TryParse(dgvDSKH.Rows[a].Cells[2].Value?.ToString(), out DateTime birthDate))
            {
                if (birthDate < dtpNgaySinh.MinDate || birthDate > dtpNgaySinh.MaxDate)
                {
                    dtpNgaySinh.Value = DateTime.Today; // Set to current date or any valid date
                }
                else
                {
                    dtpNgaySinh.Value = birthDate; // Only set this if within valid range
                }
            }
            else
            {
                dtpNgaySinh.Value = DateTime.Today; // or any default value if parsing fails
            }

            string gender = dgvDSKH.Rows[a].Cells[3].Value?.ToString();
            radNam.Checked = (gender == radNam.Text);
            radNu.Checked = (gender == radNu.Text);

            txtDiaChi.Text = dgvDSKH.Rows[a].Cells[4].Value?.ToString() ?? "";
            mtbSDT.Text = dgvDSKH.Rows[a].Cells[5].Value?.ToString() ?? "";
            txtEmail.Text = dgvDSKH.Rows[a].Cells[6].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maKH)
        {
            if (maKH.Equals(dgvDSKH.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtDiaChi.Text.Length == 0 || mtbSDT.Text.Length == 0 || txtEmail.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        public string layGioiTinh()
        {
            string gtinh = string.Empty;
            if (radNam.Checked == true)
            {
                gtinh = radNam.Text;
            }
            else
            {
                gtinh = radNu.Text;
            }
            return gtinh;
        }

        /// <summary>
        /// Thanh công cụ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_KhachHang.Instance.ThemKhachHang(new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, dtpNgaySinh.Value, layGioiTinh(), txtDiaChi.Text, mtbSDT.Text, txtEmail.Text));
                    BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào trừ email !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_KhachHang.Instance.XoaKhachHang(dgvDSKH);
                    BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaKH.Text) == true)
                        {
                            BUS_KhachHang.Instance.SuaKhachHang(new ET_KhachHang(txtMaKH.Text, txtTenKH.Text, dtpNgaySinh.Value, layGioiTinh(), txtDiaChi.Text, mtbSDT.Text, txtEmail.Text));
                            BUS_KhachHang.Instance.XemDSKhachHang(dgvDSKH);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã khách hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.Text = dgvDSKH.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = BUS_KhachHang.Instance.TaoMaKhachHangTuDong();
            txtTenKH.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            radNu.Checked = false;
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Bắt lỗi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt hay chữ số !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtTenKH.Text.Trim().Length == 0 && !char.IsLetter(e.KeyChar))
            {
                // Nếu chưa có ký tự chữ nào
                e.Handled = true;
                MessageBox.Show("Tên khách hàng phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKH.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập tên khách hàng quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Không thể chọn ngày sinh lớn hơn ngày hiện tại !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgaySinh.Value = DateTime.Now;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '/' && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt trừ '/' và '-',',' !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar != '\b' && txtDiaChi.Text.Trim().Length == 0 && !char.IsLetterOrDigit(e.KeyChar))
            {
                // Nếu chưa có ký tự chữ nào
                e.Handled = true;
                MessageBox.Show("Địa chỉ phải chứa ít nhất một ký tự chữ !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập địa chỉ quá 50 ký tự !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtbSDT_Validating(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem có khoảng trắng hay không
            if (mtbSDT.Text.Contains(" "))
            {
                MessageBox.Show("Số điện thoại không được chứa khoảng trắng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;  // Dừng sự kiện và giữ focus tại MaskedTextBox
                return; // Thoát khỏi phương thức
            }
            // Kiểm tra độ dài số điện thoại
            if (mtbSDT.Text.Length != 10)  // 10 số cho số điện thoại
            {
                MessageBox.Show("Bạn phải nhập đủ 10 chữ số cho số điện thoại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                e.Cancel = true;  // Dừng sự kiện và giữ focus tại MaskedTextBox
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra ký tự hợp lệ
            if ((!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.') ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsUpper(e.KeyChar)) // Ngăn ký tự in hoa
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập kí tự đặc biệt, khoảng trắng và chữ in hoa!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra độ dài của email
            else if (txtEmail.Text.Length > 49 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Không thể nhập email quá 50 ký tự!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
