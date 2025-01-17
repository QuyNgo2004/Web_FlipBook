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
    public class BUS_ChiNhanh
    {
        private static BUS_ChiNhanh instance;

        public static BUS_ChiNhanh Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiNhanh();
                }
                return instance;
            }
        }
        public IQueryable Load_ChiNhanh()
        {
           return DAL_ChiNhanh.Instance.layDSChiNhanh();
        }
        public void hienThiChiNhanh(DataGridView dgv)
        {
            dgv.DataSource = DAL_ChiNhanh.Instance.layDSChiNhanh();
        }

        public bool themChiNhanh(ET_ChiNhanh chiNhanh)
        {
            try
            {
                return DAL_ChiNhanh.Instance.themChiNhanh(chiNhanh);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void xoaChiNhanh(string ma)
        {
            try
            {
                DAL_ChiNhanh.Instance.xoaChiNhanh(ma);
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
                DAL_ChiNhanh.Instance.suaChiNhanh(chiNhanh);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string AutoMa_ChiNhanh()
        {
            return DAL_ChiNhanh.Instance.AutoMa_ChiNhanh();
        }

        public bool KiemTraMaChiNhanh(string ma)
        {
            try
            {
                return DAL_ChiNhanh.Instance.KiemTraMaChiNhanh(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
