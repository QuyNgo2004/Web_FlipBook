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
    public partial class LoaiHangHoa : Form
    {
        public LoaiHangHoa()
        {
            InitializeComponent();
            this.Dock = DockStyle.None;
        }

        private Menu mainForm;

        public LoaiHangHoa(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LoaiHangHoa_Load(object sender, EventArgs e)
        {
            BUS_LoaiHangHoa.Instance.XemDSloaiHH(dgvLoaiHangHoa);
            txtMaLH.Text = BUS_LoaiHangHoa.Instance.TaoMaLoaiHangTuDong();
        }

        private void dgvLoaiHangHoa_Click(object sender, EventArgs e)
        {
            int a = dgvLoaiHangHoa.CurrentCell.RowIndex;

            txtMaLH.Text = dgvLoaiHangHoa.Rows[a].Cells[0].Value?.ToString() ?? "";
            txtTenLHH.Text = dgvLoaiHangHoa.Rows[a].Cells[1].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvLoaiHangHoa.Rows[a].Cells[2].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maLHH)
        {
            if (maLHH.Equals(dgvLoaiHangHoa.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtTenLHH.Text.Length == 0 || txtGhiChu.Text.Length == 0)
            {
                return false;
            }
            return true;
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
                    BUS_LoaiHangHoa.Instance.ThemLoaiHang(new ET_LoaiHangHoa(txtMaLH.Text,txtTenLHH.Text, txtGhiChu.Text));
                    BUS_LoaiHangHoa.Instance.XemDSloaiHH(dgvLoaiHangHoa);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_LoaiHangHoa.Instance.XoaLoaiHang(dgvLoaiHangHoa);
                    BUS_LoaiHangHoa.Instance.XemDSloaiHH(dgvLoaiHangHoa);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaLH.Text) == true)
                        {
                            BUS_LoaiHangHoa.Instance.SuaLoaiHang(new ET_LoaiHangHoa(txtMaLH.Text, txtTenLHH.Text, txtGhiChu.Text));
                            BUS_LoaiHangHoa.Instance.XemDSloaiHH(dgvLoaiHangHoa);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã loại hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaLH.Text = dgvLoaiHangHoa.CurrentRow.Cells[0].Value.ToString();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLH.Text = BUS_LoaiHangHoa.Instance.TaoMaLoaiHangTuDong();
            txtTenLHH.Clear();
            txtGhiChu.Clear();
        }
    }
}
