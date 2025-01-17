using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiHangHoa : DAL_Data
    {
        //Khai báo biến tĩnh.
        private static DAL_LoaiHangHoa instance;

        public static DAL_LoaiHangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_LoaiHangHoa();
                }
                return instance;
            }
        }

        //Tạo một đối tượng 'dbNhaSach' từ lớp QLNhaSachDataContext.

        //Xem danh sách khách hàng.
        public IQueryable XemDSLoaiHangHoa()
        {
            IQueryable loaihh = from lhh in dbNhaSach.LoaiHangHoas
                                   select lhh;
            return loaihh;
        }

        /// <summary>
        /// Thêm loại hàng hóa.
        /// </summary>
        /// <param name="etKhachHang"></param>
        /// <returns></returns>
        public bool ThemLoaiHangHoa(ET_LoaiHangHoa etLoaiHH)
        {
            //Kiểm tra xem có trùng mã loại hàng hay không, nếu trùng trả về false.
            if (dbNhaSach.LoaiHangHoas.Any(lhh => lhh.maLHH == etLoaiHH.MaLHH))
            {
                //Nếu tồn tại, trả về false để báo hiệu việc thêm không thành công do trùng lặp.
                return false;
            }
            else
            {
                try
                {
                    //Tạo một đối tượng mới của loại hàng hóa.
                    LoaiHangHoa lhh = new LoaiHangHoa
                    {
                        maLHH = etLoaiHH.MaLHH,
                        tenLHH = etLoaiHH.TenHH,
                        ghiChu = etLoaiHH.GhiChu,
                    };
                    //Thêm loại hàng vào cơ sở dữ liệu
                    dbNhaSach.LoaiHangHoas.InsertOnSubmit(lhh);
                }
                finally
                {
                    // Lưu các thay đổi vào cơ sở dữ liệu
                    dbNhaSach.SubmitChanges();
                }
                // Trả về true để báo hiệu việc thêm mới thành công
                return true;
            }
        }

        /// <summary>
        /// Xóa loại hàng hoa
        /// </summary>
        /// <returns></returns>
        public bool XoaLoaiHangHoa(string maLHH)
        {
            try
            {
                //Truy vấn lấy tất cả các bản ghi trong LoaiHangHoa có maLHH bằng với maLoaiHangHoa.
                var xoa = from lhh in dbNhaSach.LoaiHangHoas
                          where lhh.maLHH == maLHH
                          select lhh;
                // Duyệt qua từng bản ghi và xóa chúng khỏi cơ sở dữ liệu.
                foreach (var x in xoa)
                {
                    dbNhaSach.LoaiHangHoas.DeleteOnSubmit(x);
                    dbNhaSach.SubmitChanges();
                }
                // Nếu xóa thành công, trả về true.
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                // Xử lý các trường hợp ngoại lệ cụ thể, chẳng hạn liên quan đến ràng buộc khóa ngoại
                if (ex.Number == 547)
                {
                    // Trả về false nếu có lỗi do ràng buộc khóa ngoại
                    return false;
                }
                return false;
            }
        }

        /// <summary>
        /// Sửa loại hàng hóa.
        /// </summary>
        public void SuaLoaiHangHoa(ET_LoaiHangHoa etLHH)
        {
            // Tìm đối tượng LoaiHangHoas trong cơ sở dữ liệu dựa trên maKH.

            var update = dbNhaSach.LoaiHangHoas.Single(lhh => lhh.maLHH == etLHH.MaLHH);

            // Cập nhật dựa trên thông tin nhận được.

            update.tenLHH = etLHH.TenHH;
            update.ghiChu = etLHH.GhiChu;

            // Lưu các thay đổi vào cơ sở dữ liệu.
            dbNhaSach.SubmitChanges();
        }

        //Tạo mã khách hàng tự động.
        public string TaoMaLoaiHangTuDong()
        {
            //Đếm số lượng loại hàng.
            int countMaLH = dbNhaSach.LoaiHangHoas.Count() + 1;

            //Tạo mã mới.
            string NewMaLH;
            do
            {
                NewMaLH = $"KH{countMaLH}";
                countMaLH++;
            } while (dbNhaSach.LoaiHangHoas.Any(lh => lh.maLHH == NewMaLH));
            return NewMaLH;
        }
    }
}
