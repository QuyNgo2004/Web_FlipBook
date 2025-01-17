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
    public partial class formThanhToan : Form
    {
        public formThanhToan()
        {
            InitializeComponent();
        }

        private void btnLSHoaDon_Click(object sender, EventArgs e)
        {
            Menu form = (Menu)this.ParentForm;
            form.openChildForm(new DanhSachHangDon());
        }
    }
}
