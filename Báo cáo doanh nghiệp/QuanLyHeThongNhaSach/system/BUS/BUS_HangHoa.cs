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
    public class BUS_HangHoa
    {
        //Khai báo biến tĩnh.
        private static BUS_HangHoa instance;
        private DAL_HangHoa dal_hh = new DAL_HangHoa();

        public static BUS_HangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_HangHoa();
                }
                return instance;
            }
        }

        //Lấy danh sách loại hàng.
        public void XemDSHH(DataGridView dgvDSHH)
        {
            // Gán DataSource cho DataGridView
            dgvDSHH.DataSource = dal_hh.XemDSHangHoa();
        }

        /// <summary>
        /// Thêm hàng hóa.
        /// </summary>
        public void ThemHangHoa(ET_HangHoa etHH)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_hh.ThemHangHoa(etHH) == true)
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
        /// Xóa hàng hóa.
        /// </summary>
        public void XoaHangHoa(DataGridView dgvDSKH)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_hh.XoaHangHoa(dgvDSKH.CurrentRow.Cells[0].Value.ToString()) == true)
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
        /// Sửa hàng hóa.
        /// </summary>
        public void SuaHangHoa(ET_HangHoa etHH)
        {
            dal_hh.SuaHangHoa(etHH);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Tạo tự động mã.
        public string TaoMaHangTuDong()
        {
            return dal_hh.TaoMaHangHoaTuDong();
        }
    }
}
