using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu : DAL_Data
    {
        private static DAL_ChucVu instance;
        public static DAL_ChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChucVu();
                }
                return instance;
            }
        }
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSChucVu()
        {
            IQueryable dsChucVu = from cv in DbNhaSach.ChucVus
                                  select new
                                  {
                                      Mã = cv.maChucVu,
                                      Tên = cv.tenChucVu,
                                  };
            return dsChucVu;
        }

        public bool themChucVu(ET_ChucVu ChucVu)
        {
            try
            {
                ChucVu cv = new ChucVu()
                {
                    maChucVu = ChucVu.MaChucVu,
                    tenChucVu = ChucVu.TenChucVu,
                };
                DbNhaSach.ChucVus.InsertOnSubmit(cv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DbNhaSach.SubmitChanges();
            }
            return true;
        }

        public void xoaChucVu(int ma)
        {
            try
            {
                var xoa = from cv in DbNhaSach.ChucVus
                          where cv.maChucVu == ma
                          select cv;
                foreach (var item in xoa)
                {
                    DbNhaSach.ChucVus.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaChucVu(ET_ChucVu ChucVu)
        {
            try
            {
                var capnhat = DbNhaSach.ChucVus.Single(cv => cv.maChucVu == ChucVu.MaChucVu);
                capnhat.tenChucVu = ChucVu.TenChucVu;
                
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
