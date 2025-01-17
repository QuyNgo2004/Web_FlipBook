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
    public partial class HangHoa : Form
    {
        private BUS_LoaiHangHoa lhh = BUS_LoaiHangHoa.Instance;
        private BUS_NhaPhanPhoi npp = BUS_NhaPhanPhoi.Instance;
        public HangHoa()
        {
            InitializeComponent();
        }

        private Menu mainForm;

        public HangHoa(Menu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
            txtMaHH.Text = BUS_HangHoa.Instance.TaoMaHangTuDong();

            try
            {

                cboLoaiHH.DataSource = lhh.LoadDSloaiHH();
                cboNhaPP.DataSource = npp.loadnpp();
                cboLoaiHH.DisplayMember = "tenLHH";
                cboLoaiHH.ValueMember = "maLHH";
                cboNhaPP.ValueMember = "maNPP";
                cboNhaPP.DisplayMember = "tenNPP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvDSHangHoa_Click(object sender, EventArgs e)
        {
            int a = dgvDSHangHoa.CurrentCell.RowIndex;

            txtMaHH.Text = dgvDSHangHoa.Rows[a].Cells[0].Value?.ToString() ?? "";
            txtTenHH.Text = dgvDSHangHoa.Rows[a].Cells[1].Value?.ToString() ?? "";
            cboLoaiHH.Text = dgvDSHangHoa.Rows[a].Cells[2].Value?.ToString() ?? "";
            txtGiaHH.Text = dgvDSHangHoa.Rows[a].Cells[3].Value?.ToString() ?? "";
            txtDonViTinh.Text = dgvDSHangHoa.Rows[a].Cells[4].Value?.ToString() ?? "";
            txtSoLuongTon.Text = dgvDSHangHoa.Rows[a].Cells[5].Value?.ToString() ?? "";
            cboNhaPP.Text = dgvDSHangHoa.Rows[a].Cells[6].Value?.ToString() ?? "";
            txtMoTa.Text = dgvDSHangHoa.Rows[a].Cells[7].Value?.ToString() ?? "";
            txtGhiChu.Text = dgvDSHangHoa.Rows[a].Cells[8].Value?.ToString() ?? "";
            cboTinhTrang.Text = dgvDSHangHoa.Rows[a].Cells[9].Value?.ToString() ?? "";
        }

        public bool KTraMa(string maLHH)
        {
            if (maLHH.Equals(dgvDSHangHoa.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                return true;
            }
            return false;
        }

        public bool KtraBoTrong()
        {
            if (txtMaHH.Text.Length == 0 || txtTenHH.Text.Length == 0 || txtGiaHH.Text.Length == 0 || txtDonViTinh.Text.Length == 0 || txtSoLuongTon.Text.Length == 0 || txtMoTa.Text.Length == 0 || txtGhiChu.Text.Length == 0)
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

        private void btnThemLHH_Click(object sender, EventArgs e)
        {
            //Menu formMenu = (Menu)this.ParentForm;
            //formMenu.openChildForm(new LoaiHangHoa());

            LoaiHangHoa lhh = new LoaiHangHoa();
            lhh.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTroLaiNhapHang_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new NhapHang());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Xác nhận thêm dữ liệu đã nhập ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (KtraBoTrong() == true)
                {
                    BUS_HangHoa.Instance.ThemHangHoa(new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboLoaiHH.SelectedValue.ToString(), int.Parse(txtGiaHH.Text), txtDonViTinh.Text, int.Parse(txtSoLuongTon.Text), cboNhaPP.SelectedValue.ToString(), txtMoTa.Text, txtGhiChu.Text, cboTinhTrang.Text));
                    BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                }
                else
                {
                    MessageBox.Show("Không thể bỏ trống bất kì trường nào !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    BUS_HangHoa.Instance.XoaHangHoa(dgvDSHangHoa);
                    BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHangHoa.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Hãy chắc chắn rằng bạn muốn sửa dữ liệu vừa nhập !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    if (KtraBoTrong() == true)
                    {
                        if (KTraMa(txtMaHH.Text) == true)
                        {
                            BUS_HangHoa.Instance.SuaHangHoa(new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboLoaiHH.Text, int.Parse(txtGiaHH.Text), txtDonViTinh.Text, int.Parse(txtSoLuongTon.Text), cboNhaPP.Text, txtMoTa.Text, txtGhiChu.Text, cboTinhTrang.Text));
                            BUS_HangHoa.Instance.XemDSHH(dgvDSHangHoa);
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa mã loại hàng !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaHH.Text = dgvDSHangHoa.CurrentRow.Cells[0].Value.ToString();
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
    }
}
