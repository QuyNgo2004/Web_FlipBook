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
    public class BUS_LoaiHangHoa
    {
        //Khai báo biến tĩnh.
        private static BUS_LoaiHangHoa instance;
        private DAL_LoaiHangHoa dal_lhh = new DAL_LoaiHangHoa();

        public static BUS_LoaiHangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_LoaiHangHoa();
                }
                return instance;
            }
        }

        //Lấy danh sách loại hàng.
        public void XemDSloaiHH(DataGridView dgvDSLHH)
        {
            // Gán DataSource cho DataGridView
            dgvDSLHH.DataSource = dal_lhh.XemDSLoaiHangHoa();
        }

        public IQueryable LoadDSloaiHH()
        {
             return dal_lhh.XemDSLoaiHangHoa();
        }

        /// <summary>
        /// Thêm loại hàng.
        /// </summary>
        public void ThemLoaiHang(ET_LoaiHangHoa etLHH)
        {
            //Kiểm tra mã trùng không không trùng thì trả về true và thực hiện thêm
            if (dal_lhh.ThemLoaiHangHoa(etLHH) == true)
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
        /// Xóa loại hàng.
        /// </summary>
        public void XoaLoaiHang(DataGridView dgvDSKH)
        {
            // Xóa là lấy dữ liệu ô đầu tiên của dòng đang được chọn trong DataGridView để xóa dữ liệu
            if (dal_lhh.XoaLoaiHangHoa(dgvDSKH.CurrentRow.Cells[0].Value.ToString()) == true)
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
        /// Sửa loại hàng.
        /// </summary>
        public void SuaLoaiHang(ET_LoaiHangHoa etLHH)
        {
            dal_lhh.SuaLoaiHangHoa(etLHH);
            MessageBox.Show("Hoàn tất sửa dữ liệu !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Tạo tự động mã .
        public string TaoMaLoaiHangTuDong()
        {
            return dal_lhh.TaoMaLoaiHangTuDong();
        }
    }
}
