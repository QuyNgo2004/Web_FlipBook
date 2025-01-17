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
    public partial class CaTruc : Form
    {
        private BUS_BatLoi error = new BUS_BatLoi();
        private BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        private BUS_CaTruc ct = BUS_CaTruc.Instance;
        private int maCaTruc;
        public CaTruc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQLCT_Click(object sender, EventArgs e)
        {
            
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new QuanLyCaTruc());
            this.Close();
        }

        private void CaTruc_Load(object sender, EventArgs e)
        {
            cboChiNhanh.DataSource = cn.Load_ChiNhanh();
            cboChiNhanh.DisplayMember = "TenCN";
            cboChiNhanh.ValueMember = "MaCN";
            ct.hienThiCaTruc(dgvCaTruc, cboChiNhanh.SelectedValue.ToString());
            Load_CT();
        }
        private void Load_CT()
        {
            ct.hienThiCaTruc(dgvCaTruc, cboChiNhanh.SelectedValue.ToString());
            dgvCaTruc.Columns["Mã"].Visible = false;
            btnThem.Focus();
            txtTenCT.Text = null;
            txtGioBD.Text = "0";
            txtPhutBD.Text = "0";
            txtGioKT.Text = "0";
            txtPhutKT.Text = "0";
            txtGhiChu.Text = null;
        }
        private ET_CaTruc DL_CaTruc()
        {
            TimeSpan tsBD = new TimeSpan(int.Parse(txtGioBD.Text), int.Parse(txtPhutBD.Text),0);
            TimeSpan tsKT = new TimeSpan(int.Parse(txtGioKT.Text), int.Parse(txtPhutKT.Text), 0);
            ET_CaTruc ct = new ET_CaTruc
            {
                MaCT = maCaTruc,
                TenCT = txtTenCT.Text,
                MaCN = cboChiNhanh.SelectedValue.ToString(),
                GioBD = tsBD,
                GioKT = tsKT,
                GhiChu = txtGhiChu.Text,
            };
            return ct;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm ca làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ET_CaTruc catruc = DL_CaTruc();
                    if (catruc.GioBD <= catruc.GioKT) {
                        ct.themCaTruc(catruc);
                        Load_CT();
                    }
                    else
                    {
                        MessageBox.Show("Giờ bắt đầu nhỏ hơn giờ kết thúc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            

        }

        private void dgvCaTruc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = dgvCaTruc.CurrentCell.RowIndex;
                maCaTruc = int.Parse(dgvCaTruc.Rows[dong].Cells[0].Value.ToString());
                txtTenCT.Text = dgvCaTruc.Rows[dong].Cells[1].Value.ToString();
                TimeSpan tsBD = TimeSpan.Parse(dgvCaTruc.Rows[dong].Cells[3].Value.ToString());
                txtGioBD.Text = tsBD.Hours.ToString();
                txtPhutBD.Text = tsBD.Minutes.ToString();
                TimeSpan tsKT = TimeSpan.Parse(dgvCaTruc.Rows[dong].Cells[4].Value.ToString());
                txtGioKT.Text = tsKT.Hours.ToString();
                txtPhutKT.Text = tsKT.Minutes.ToString();
                txtGhiChu.Text = dgvCaTruc.Rows[dong].Cells[5].Value.ToString();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi khi chọn dòng dữ liệu" + ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ca làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ct.xoaCaTruc(maCaTruc);
                    Load_CT();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn sửa ca làm không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ct.suaCaTruc(DL_CaTruc());
                    Load_CT();
                }
                catch (Exception ex) {
                    MessageBox.Show("Không thể sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTenCT_Validated(object sender, EventArgs e)
        {
            if (error.KT_SoKiTuCoTheLuu(txtTenCT.Text, 30) == false)
            {
                MessageBox.Show("Tên ca trực vượt quá số kí tự \n(Kí tự giới hạn 45)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtGhiChu_Validated(object sender, EventArgs e)
        {
            if (error.KT_SoKiTuCoTheLuu(txtGhiChu.Text, 150) == false)
            {
                MessageBox.Show("Tên ca trực vượt quá số kí tự \n(Kí tự giới hạn 45)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct.hienThiCaTruc(dgvCaTruc, cboChiNhanh.SelectedValue.ToString());
            Load_CT();
        }

        private void txtGioBD_Validated(object sender, EventArgs e)
        {
            if (txtGioBD.Text == string.Empty)
            {
                txtGioBD.Text = "0";
            }
            else if (error.KT_ChuoiSo(txtGioBD.Text) == false)
            {
                MessageBox.Show("Sai format (Vui lòng nhập số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(error.KT_SoLonBe(int.Parse(txtGioBD.Text), 24) == false) {
                MessageBox.Show("Giờ lớn 0 và nhỏ hơn 24","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
             
        }

        private void txtGioBD_Click(object sender, EventArgs e)
        {
            txtGioBD.Text = string.Empty;
        }

        private void txtPhutBD_Click(object sender, EventArgs e)
        {
            txtPhutBD.Text = string.Empty;
        }

        private void txtGioKT_Click(object sender, EventArgs e)
        {
            txtGioKT.Text = string.Empty;
        }

        private void txtPhutKT_Click(object sender, EventArgs e)
        {
            txtPhutKT.Text = string.Empty;
        }

        private void txtPhutBD_Validated(object sender, EventArgs e)
        {
            if (txtPhutBD.Text == string.Empty)
            {
                txtPhutBD.Text = "0";
            }
            else if (error.KT_ChuoiSo(txtPhutBD.Text) == false)
            {
                MessageBox.Show("Sai format (Vui lòng nhập số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_SoLonBe(int.Parse(txtPhutBD.Text), 59) == false)
            {
                MessageBox.Show("Giờ lớn 0 và nhỏ hơn 24", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGioKT_Validated(object sender, EventArgs e)
        {
            if (txtGioKT.Text == string.Empty)
            {
                txtGioKT.Text = "0";
            }
            else if (error.KT_ChuoiSo(txtGioKT.Text) == false)
            {
                MessageBox.Show("Sai format (Vui lòng nhập số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_SoLonBe(int.Parse(txtGioKT.Text), 24) == false)
            {
                MessageBox.Show("Giờ lớn 0 và nhỏ hơn 24", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhutKT_Validated(object sender, EventArgs e)
        {
            if (txtPhutKT.Text == string.Empty)
            {
                txtPhutKT.Text = "0";
            }
            else if (error.KT_ChuoiSo(txtPhutKT.Text) == false)
            {
                MessageBox.Show("Sai format (Vui lòng nhập số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error.KT_SoLonBe(int.Parse(txtPhutKT.Text), 59) == false)
            {
                MessageBox.Show("Giờ lớn 0 và nhỏ hơn 24", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                Load_CT();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
