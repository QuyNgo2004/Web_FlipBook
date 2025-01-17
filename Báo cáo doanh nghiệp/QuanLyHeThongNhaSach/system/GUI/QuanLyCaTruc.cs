using BUS;
using DevExpress.Data.Linq.Helpers;
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
    public partial class QuanLyCaTruc : Form
    {
        BUS_ChiNhanh cn = BUS_ChiNhanh.Instance;
        BUS_CaTruc ct =  BUS_CaTruc.Instance;
        BUS_NhanSu ns = BUS_NhanSu.Instance;
        BUS_ChiTietCaTruc ctct = BUS_ChiTietCaTruc.Instance;
        private string MaCTCT;
        public QuanLyCaTruc()
        {
            InitializeComponent();
        }
        public void Load_QLCaTruc()
        {
            try
            {
                txtMaNS.Text = string.Empty;
                txtTenNS.Text = string.Empty;
                ctct.hienThiCTCaTruc(dgvDSCaTruc, int.Parse(cboCaTruc.SelectedValue.ToString()));
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QuanLyCaTruc_Load(object sender, EventArgs e)
        {
            cboCN.DataSource = cn.Load_ChiNhanh();
            cboCN.DisplayMember = "TenCN";
            cboCN.ValueMember = "MaCN";
            cboCN_SelectedIndexChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new CaTruc());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Menu formMenu = (Menu)this.ParentForm;
            formMenu.openChildForm(new NhanSu());
            this.Close();
        }

        private void cboCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (ct.Load_CaTruc(cboCN.SelectedValue.ToString()).Count() > 0)
                {
                    
                    cboCaTruc.DataSource = ct.Load_CaTruc(cboCN.SelectedValue.ToString());
                    cboCaTruc.DisplayMember = "Tên";
                    cboCaTruc.ValueMember = "Mã";
                    ctct.hienThiCTCaTruc(dgvDSCaTruc, int.Parse(cboCaTruc.SelectedValue.ToString()));
                }
                else
                {
                    cboCaTruc.DataSource=null;
                    dgvDSCaTruc.DataSource = null;
                }
                txtMaNS.Text = null;
                txtTenNS.Text = null;
                ns.hienThiNhanSu(dgvNV, cboCN.SelectedValue.ToString());
                //ctct.hienThiCTCaTruc(dgvDSCaTruc,int.Parse(cboCaTruc.SelectedValue.ToString()));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNV.CurrentCell.RowIndex;
                txtMaNS.Text = dgvNV.Rows[dong].Cells[0].Value.ToString();
                txtTenNS.Text = dgvNV.Rows[dong].Cells[1].Value.ToString();
                MaCTCT = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm ca làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNS.Text != string.Empty && txtTenNS.Text != string.Empty && cboCaTruc.SelectedValue.ToString() != null && ctct.TimKiem(int.Parse(cboCaTruc.SelectedValue.ToString()),txtMaNS.Text) == true)
                    {
                        ctct.themCTCaTruc(int.Parse(cboCaTruc.SelectedValue.ToString()), txtMaNS.Text);
                        Load_QLCaTruc();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboCaTruc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctct.hienThiCTCaTruc(dgvDSCaTruc, int.Parse(cboCaTruc.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa ca làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNS.Text != string.Empty && txtTenNS.Text != string.Empty && cboCaTruc.SelectedValue.ToString() != null && ctct.TimKiem(int.Parse(cboCaTruc.SelectedValue.ToString()), txtMaNS.Text) == true)
                    {
                        ctct.suaCTCaTruc(int.Parse(MaCTCT),int.Parse(cboCaTruc.SelectedValue.ToString()), txtMaNS.Text);
                        Load_QLCaTruc();
                    }
                    else
                    {
                        MessageBox.Show("sửa không thành sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDSCaTruc_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvDSCaTruc.CurrentCell.RowIndex;
                txtMaNS.Text = dgvDSCaTruc.Rows[dong].Cells[1].Value.ToString();
                txtTenNS.Text = dgvDSCaTruc.Rows[dong].Cells[2].Value.ToString();
                MaCTCT = dgvDSCaTruc.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ca làm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                   
                        ctct.xoaCTCaTruc(int.Parse(MaCTCT));
                        Load_QLCaTruc();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
