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
    public class BUS_NhanSu
    {
        private static BUS_NhanSu instance;


        public string AutoMa_NhanSu()
        {
            return DAL_NhanSu.Instance.AutoMa_NhanSu();
        }
        public static BUS_NhanSu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhanSu();
                }
                return instance;
            }
        }
        public bool KT_TTNS(string ma)
        {
            return DAL_NhanSu.Instance.KT_TTNS(ma);
        }
        public void hienThiNhanSu(DataGridView dgv)
        {
            dgv.DataSource = DAL_NhanSu.Instance.layDSNhanSu();
        }
        public void hienThiNhanSu(DataGridView dgv,string ma)
        {
            dgv.DataSource = DAL_NhanSu.Instance.layDSNhanSu(ma);
        }
        public bool themNhanSu(ET_NhanSu NhanSu)
        {
            try
            {
                return DAL_NhanSu.Instance.themNhanSu(NhanSu);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void xoaNhanSu(string ma)
        {
            try
            {
                DAL_NhanSu.Instance.xoaNhanSu(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaNhanSu(ET_NhanSu NhanSu)
        {
            try
            {
                DAL_NhanSu.Instance.suaNhanSu(NhanSu);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
