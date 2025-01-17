using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiNhanh : DAL_Data
    {
        private static DAL_ChiNhanh instance;
        public static DAL_ChiNhanh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_ChiNhanh();
                }
                return instance;
            }
        }
        //QLNhaSachDataContext db = new QLNhaSachDataContext();

        public IQueryable layDSChiNhanh()
        {
            IQueryable dsChiNhanh = from cn in DbNhaSach.ChiNhanhs
                                    select new 
                                    { 
                                        MaCN = cn.maCN,
                                        TenCN = cn.tenCN,
                                        DiaChi = cn.diaChi,
                                        SoDienThoai = cn.soDienThoai,
                                        Email = cn.email,
                                        GhiChu = cn.ghiChu,
                                    };                                   
            return dsChiNhanh;
        }

        public string AutoMa_ChiNhanh()
        {
            int demCN = dbNhaSach.ChiNhanhs.Count();
            string newMa;
            do
            {
                demCN++;
                if (demCN < 10)
                {
                    newMa = $"CN0{demCN}";
                }
                else
                {
                    newMa = $"CN{demCN}";
                }
            } while (dbNhaSach.ChiNhanhs.Any(cn => cn.maCN == newMa));
            return newMa;
        }
        public bool KiemTraMaChiNhanh(string ma)
        {
            bool flag = false;
            try
            {
                var xoa = from cn in DbNhaSach.ChiNhanhs
                          where cn.maCN == ma
                          select cn;
                if (xoa.Count() == 0)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return flag;
        }

        public bool themChiNhanh(ET_ChiNhanh chiNhanh)
        {
            
            try
            {
                ChiNhanh cn = new ChiNhanh
                {
                    maCN = chiNhanh.MaCN,
                    tenCN = chiNhanh.TenCN,
                    diaChi = chiNhanh.DiaChi,
                    soDienThoai = chiNhanh.SoDienThoai,
                    email = chiNhanh.Email,
                    ghiChu = chiNhanh.GhiChu,
                };
                DbNhaSach.ChiNhanhs.InsertOnSubmit(cn);
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

        public void xoaChiNhanh(string ma)
        {
            try
            {
                var xoa = from cn in DbNhaSach.ChiNhanhs
                          where cn.maCN == ma
                          select cn;
                foreach (var item in xoa)
                {
                    DbNhaSach.ChiNhanhs.DeleteOnSubmit(item);
                    DbNhaSach.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaChiNhanh(ET_ChiNhanh chiNhanh)
        {
            try
            {
                var capnhat = DbNhaSach.ChiNhanhs.Single(cn => cn.maCN == chiNhanh.MaCN);
                capnhat.maCN = chiNhanh.MaCN;
                capnhat.tenCN = chiNhanh.TenCN;
                capnhat.diaChi = chiNhanh.DiaChi;
                capnhat.soDienThoai = chiNhanh.SoDienThoai;
                capnhat.ghiChu = chiNhanh.GhiChu;
                DbNhaSach.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
