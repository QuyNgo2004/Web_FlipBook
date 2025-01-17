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
    public partial class frmChiNhanh : Form
    {
        private BUS_BatLoi batLoi = new BUS_BatLoi();
        private BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            try
            {
                BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                txtMa.Text = cn.AutoMa_ChiNhanh();
                txtMa.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi Load Form" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void them()
        {
            BUS_ChiNhanh.Instance.themChiNhanh(ThongTin());
            txtMa.Text = cn.AutoMa_ChiNhanh();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();           
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void xoa()
        {
            BUS_ChiNhanh.Instance.xoaChiNhanh(txtMa.Text);
            txtMa.Text = cn.AutoMa_ChiNhanh();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();           
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void sua()
        {

            BUS_ChiNhanh.Instance.suaChiNhanh(ThongTin());
            txtMa.Text = cn.AutoMa_ChiNhanh();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();            
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckThongTin() == true)
                {
                    if (cn.KiemTraMaChiNhanh(txtMa.Text) == true)
                    {
                        DialogResult dar = MessageBox.Show("Bạn có muốn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dar == DialogResult.Yes)
                        {
                            them();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chi nhánh thêm vào bị trùng Mã","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvChiNhanh.CurrentCell.RowIndex;
                txtMa.Text = dgvChiNhanh.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvChiNhanh.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvChiNhanh.Rows[dong].Cells[2].Value.ToString();
                mtbSDT.Text = dgvChiNhanh.Rows[dong].Cells[3].Value.ToString();
                txtEmail.Text = dgvChiNhanh.Rows[dong].Cells[4].Value.ToString();
                txtGhiChu.Text = dgvChiNhanh.Rows[dong].Cells[5].Value.ToString();
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dar = MessageBox.Show("Bạn có muốn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dar == DialogResult.Yes)
                {
                    xoa();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckThongTin() == true)
                {
                    DialogResult dar = MessageBox.Show("Bạn có muốn sửa", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dar == DialogResult.Yes)
                    {
                        sua();
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        BUS_ChiNhanh.Instance.hienThiChiNhanh(dgvChiNhanh);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void lamMoi()
        {
            txtMa.Text = cn.AutoMa_ChiNhanh();
            txtTen.Clear();
            txtDiaChi.Clear();
            mtbSDT.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();           
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dar = MessageBox.Show("Bạn có muốn làm mới", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dar == DialogResult.Yes)
                {
                    lamMoi();
                    MessageBox.Show("Làm mới thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load Form" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ET_ChiNhanh ThongTin()
        {
            ET_ChiNhanh chiNhanh = null;
            try
            {
                chiNhanh = new ET_ChiNhanh
                {
                    MaCN = txtMa.Text,
                    TenCN = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDienThoai = mtbSDT.Text,
                    Email = txtEmail.Text,
                    GhiChu = txtGhiChu.Text,
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex.Message, "Thông báo");
            }
            return chiNhanh;
        }

        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_Null(txtTen.Text) || batLoi.KT_SoKiTuCoTheLuu(txtTen.Text,50) == false || batLoi.KT_ChuoiKiTu(txtTen.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập tên chi nhánh! \n (Ex: Hoang Long)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_Null(txtDiaChi.Text) || batLoi.KT_SoKiTuCoTheLuu(txtDiaChi.Text, 150) == false)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_SoKiTu(mtbSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(mtbSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại chi nhánh có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_Email(txtEmail.Text) == false || batLoi.KT_SoKiTuCoTheLuu(txtEmail.Text, 50) == false)
            {
                MessageBox.Show("Vui lòng nhập email chi nhánh đúng format!\n (Ex: abc123@gmail.com)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
}
