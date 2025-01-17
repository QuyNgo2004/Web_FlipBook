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
    public partial class NhaPhanPhoi : Form
    {
        BUS_BatLoi batLoi = new BUS_BatLoi();
        BUS_NhaPhanPhoi npp = BUS_NhaPhanPhoi.Instance;
        public NhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void NhaPhanPhoi_Load(object sender, EventArgs e)
        {
            try
            {
                BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
                txtMaNPP.Text = npp.AutoMa_NhaPhanPhoi();
                txtMaNPP.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load Form" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void them()
        {
            
            BUS_NhaPhanPhoi.Instance.themNhaPhanPhoi(ThongTin());
            txtMaNPP.Text = npp.AutoMa_NhaPhanPhoi();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            mstSDT.Clear();
            txtEmail.Clear();            
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void xoa()
        {
            BUS_NhaPhanPhoi.Instance.xoaNhaPhanPhoi(txtMaNPP.Text);
            txtMaNPP.Text = npp.AutoMa_NhaPhanPhoi();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            mstSDT.Clear();
            txtEmail.Clear();            
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void sua()
        {
            
            BUS_NhaPhanPhoi.Instance.suaNhaPhanPhoi(ThongTin());
            txtMaNPP.Text = npp.AutoMa_NhaPhanPhoi();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            mstSDT.Clear();
            txtEmail.Clear();            
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckThongTin() == true)
                {
                    if (npp.KiemTraMaNhaPhanPhoi(txtMaNPP.Text) == true)
                    {
                        DialogResult dar = MessageBox.Show("Bạn có muốn thêm", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dar == DialogResult.Yes)
                        {
                            them();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhà phân phối thêm vào bị trùng Mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Thêm không thành công! \n" + "Message: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
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
                        BUS_NhaPhanPhoi.Instance.hienThiNhaPhanPhoi(dgvDSNPP);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sửa không thành công! \n" + "Message: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNPP.Text = npp.AutoMa_NhaPhanPhoi();
            txtTenNPP.Clear();
            txtDiaChi.Clear();
            mstSDT.Clear();
            txtEmail.Clear();            
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private ET_NhaPhanPhoi ThongTin()
        {
            ET_NhaPhanPhoi nhaPhanPhoi = null;
            try
            {
                nhaPhanPhoi = new ET_NhaPhanPhoi
                {
                    MaNPP = txtMaNPP.Text,
                    TenNPP = txtTenNPP.Text,
                    DiaChiNPP = txtDiaChi.Text,
                    SdtNPP = mstSDT.Text,
                    EmailNPP = txtEmail.Text,                    
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex.Message, "Thông báo");
            }
            return nhaPhanPhoi;
        }
        private bool CheckThongTin()
        {
            bool flag = false;
            if (batLoi.KT_Null(txtTenNPP.Text) || batLoi.KT_SoKiTuCoTheLuu(txtTenNPP.Text, 50) == false || batLoi.KT_ChuoiKiTu(txtTenNPP.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập tên nhà phân phối!\n (Ex: An Huy)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_Null(txtDiaChi.Text) || batLoi.KT_SoKiTuCoTheLuu(txtDiaChi.Text, 150) == false)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_SoKiTu(mstSDT.Text, 10) == false || batLoi.KT_ChuoiSoDT(mstSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại chi nhánh có 10 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (batLoi.KT_Email(txtEmail.Text) == false || batLoi.KT_SoKiTuCoTheLuu(txtEmail.Text, 50) == false)
            {
                MessageBox.Show("Vui lòng nhập email nhà phân phối đúng format!\n (Ex: abc123@gmail.com)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private void dgvDSNPP_Click(object sender, EventArgs e)
        {
            int dong = dgvDSNPP.CurrentCell.RowIndex;
            txtMaNPP.Text = dgvDSNPP.Rows[dong].Cells[0].Value.ToString();
            txtTenNPP.Text = dgvDSNPP.Rows[dong].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDSNPP.Rows[dong].Cells[2].Value.ToString();
            mstSDT.Text = dgvDSNPP.Rows[dong].Cells[3].Value.ToString();
            txtEmail.Text = dgvDSNPP.Rows[dong].Cells[4].Value.ToString();            
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}
