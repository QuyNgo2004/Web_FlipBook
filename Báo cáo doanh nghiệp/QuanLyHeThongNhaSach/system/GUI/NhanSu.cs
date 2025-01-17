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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class NhanSu : Form
    {
        private BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        private BUS_ChucVu cv = BUS_ChucVu.Instance;
        private BUS_NhanSu ns = BUS_NhanSu.Instance;
        private BUS_BatLoi error = new BUS_BatLoi();
        public NhanSu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Hãy chắc chắn rằng bạn muốn thoát khỏi màn hình này !", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void NhanSu_Load(object sender, EventArgs e)
        {
           
            try
            {
               
                cboChiNhanh.DataSource = cn.Load_ChiNhanh();
                cboChucVu.DataSource = cv.Load_ChucVu();
                cboChiNhanh.DisplayMember = "TenCN";
                cboChiNhanh.ValueMember = "MaCN";
                cboChucVu.ValueMember = "Mã";
                cboChucVu.DisplayMember = "Tên";
                Load_NS();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
               
                    if (MessageBox.Show("Bạn chắc chắn làm mới form này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                            MessageBox.Show("Làm mới thành công!   ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_NS();
                        
                    }
                
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi load form: " + ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Load file nhân sự
        private void Load_NS()
        {
            ns.hienThiNhanSu(dgvDSNhanSu);
            txtMaNS.Text = ns.AutoMa_NhanSu();
            btnThem.Focus();
            txtTenNS.Text = null;
            radNam.Checked = true;
            txtCCCD.Text = null;
            txtSDT.Text = null;
            txtEmail.Text = null;
            txtDiaChiNha.Text = null;
        }
        // Tao đối tượng nhân sự
        private ET_NhanSu Info()
        {
            ET_NhanSu nhanSu = null;
            try
            {
               

                string gioiTinh = null;
                if (radNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                nhanSu = new ET_NhanSu
                {
                    MaNS = txtMaNS.Text,
                    TenNS = txtTenNS.Text,
                    GioiTinh = gioiTinh,
                    CCCD = txtCCCD.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    DiaChi = txtDiaChiNha.Text,
                    MaCN = cboChiNhanh.SelectedValue.ToString(),
                    ChucVu = int.Parse(cboChucVu.SelectedValue.ToString()),
                };
                
            }
            catch (Exception ex) { }
            
            return nhanSu;
        }
        // Kiểm tra null 
        private bool TextBox_Null()
        {
            bool flag = false;
            if (error.KT_Null(txtTenNS.Text) || error.KT_SoKiTuCoTheLuu(txtTenNS.Text,45) == false || error.KT_ChuoiKiTu(txtTenNS.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập tên nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_SoKiTu(txtCCCD.Text, 11) == false || error.KT_ChuoiSo(txtCCCD.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập CCCD nhân sự có 11 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(error.KT_SoKiTu(txtSDT.Text,10) == false || error.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân sự có 11 số bắt đàu là số 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(error.KT_Email(txtEmail.Text) == false || error.KT_SoKiTuCoTheLuu(txtEmail.Text, 40) == false)
            {
                MessageBox.Show("Vui lòng nhập email nhân sự đúng format!\n (Ex: abc123@gmail.com)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(error.KT_Null(txtDiaChiNha.Text) || error.KT_SoKiTuCoTheLuu(txtDiaChiNha.Text, 55) == false)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân sự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                flag = true;
            }
            return flag;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (TextBox_Null() == true)
                {
                    if (ns.KT_TTNS(txtMaNS.Text) == true)
                    {
                        if (MessageBox.Show("Bạn chắc chắn thêm nhân sự này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (ns.themNhanSu(Info()))
                            {
                                MessageBox.Show("Thêm nhân sự thành công!   ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Load_NS();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhân sự thêm vào bị trùng mãNS ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm không thành công! \n" + "Message: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvDSNhanSu_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDSNhanSu.CurrentCell.RowIndex;
                txtMaNS.Text = dgvDSNhanSu.Rows[dong].Cells[0].Value.ToString();
                txtTenNS.Text = dgvDSNhanSu.Rows[dong].Cells[1].Value.ToString();
                if (dgvDSNhanSu.Rows[dong].Cells[2].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtCCCD.Text = dgvDSNhanSu.Rows[dong].Cells[3].Value.ToString();
                txtSDT.Text = dgvDSNhanSu.Rows[dong].Cells[4].Value.ToString();
                txtEmail.Text = dgvDSNhanSu.Rows[dong].Cells[5].Value.ToString();
                txtDiaChiNha.Text = dgvDSNhanSu.Rows[dong].Cells[6].Value.ToString();
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
                if (TextBox_Null() == true)
                {
                    if (MessageBox.Show("Bạn có muốn sửa nhân sự đang chọn không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ns.suaNhanSu(Info());
                        MessageBox.Show("Sửa thành công", "Thông báo");
                        Load_NS();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công! \n" + "Message: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (ns.KT_TTNS(txtMaNS.Text) == false)
                {
                    if (MessageBox.Show("Bạn có muốn xóa nhân sự đang chọn không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ns.xoaNhanSu(Info().MaNS);
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Load_NS();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân sự này? ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công! \n" + "Message: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenNS_Validated(object sender, EventArgs e)
        {
            if (error.KT_SoKiTuCoTheLuu(txtTenNS.Text, 45) == false )
            {
                MessageBox.Show("Tên nhân sự vượt quá số kí tự \n(Kí tự giới hạn 45)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( error.KT_ChuoiKiTu(txtTenNS.Text) == false)
            {
                MessageBox.Show("Tên nhân sự sai format \n(Chỉ có thể nhập kí tự)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCCCD_Validated(object sender, EventArgs e)
        {
            if (error.KT_SoKiTu(txtCCCD.Text, 11) == false)
            {
                MessageBox.Show("CCCD nhân sự phải có 11 số kí tự ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_ChuoiSo(txtCCCD.Text) == false)
            {
                MessageBox.Show("CCCD nhân sự sai format \n(Chỉ có thể nhập số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_Validated(object sender, EventArgs e)
        {
            if (error.KT_SoKiTu(txtSDT.Text, 10) == false)
            {
                MessageBox.Show("Số điện thoại nhân sự phải có 10 số kí tự ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_ChuoiSoDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại nhân sự sai format \n(Chỉ có thể nhập số bắt đàu là 0)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (error.KT_Email(txtEmail.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập email nhân sự đúng format!\n (Ex: abc123@gmail.com)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_SoKiTuCoTheLuu(txtEmail.Text, 40) == false)
            {
                MessageBox.Show("Email nhân sự vượt quá số kí tự \n(Kí tự giới hạn 40)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiaChiNha_Validated(object sender, EventArgs e)
        {
            if(error.KT_SoKiTuCoTheLuu(txtDiaChiNha.Text, 55) == false)
            {
                MessageBox.Show("Email nhân sự vượt quá số kí tự \n(Kí tự giới hạn 55)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        // Mở màn hình quản lý ca trực
        private void btnCaTruc_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new QuanLyCaTruc());
            this.Close();
        }
    }
}
