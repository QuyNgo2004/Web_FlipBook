using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_KhachHang
    {
        //Khai báo biến tĩnh.
        private static BUS_KhachHang instance;
        private DAL_KhachHang dal_kh = new DAL_KhachHang();

        public static BUS_KhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_KhachHang();
                }
                return instance;
            }
        }

        //Lấy danh sách khách hàng.
        public void XemDSKhachHang(DataGridView dgvDSKH)
        {
            // Gán DataSource cho DataGridView
            dgvDSKH.DataSource = dal_kh.XemDSKhachHang();
        }

        /// <summary>
        /// Thêm khách hàng.
        /// </summary>
        /// <param name="etKhachHang"></param>
        public void ThemKhachHang(ET_KhachHang etKhachHang)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_kh.ThemKhachHang(etKhachHang) == true)
            {
                //Khi thêm thành công sẽ hiển thị thông báo này
                MessageBox.Show("Hoàn tất thêm dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Khi thêm không thành công sẽ hiển thị thông báo này
                MessageBox.Show("Dữ liệu đã có trong hệ thống !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa khách hàng.
        /// </summary>
        /// <param name="dgvDSKH"></param>
        public void XoaKhachHang(DataGridView dgvDSKH)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_kh.XoaKhachHang(dgvDSKH.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                // Hiện lên thông báo khi xóa thành công
                MessageBox.Show("Hoàn tất xóa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiện lên thông báo khi xóa không thành công
                MessageBox.Show("Dữ liệu đang được đối chiếu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sửa khách hàng.
        /// </summary>
        /// <param name="etKhachHang"></param>
        public void SuaKhachHang(ET_KhachHang etKhachHang)
        {
            dal_kh.SuaKhachHang(etKhachHang);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Tạo tự động mã phiếu khám bệnh.
        public string TaoMaKhachHangTuDong()
        {
            return dal_kh.TaoMaKhachHangTuDong();
        }
    }
}
