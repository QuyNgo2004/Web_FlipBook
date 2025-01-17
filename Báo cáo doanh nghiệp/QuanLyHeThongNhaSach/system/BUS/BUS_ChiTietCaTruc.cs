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
    public class BUS_ChiTietCaTruc
    {
        private static BUS_ChiTietCaTruc instance;

        public static BUS_ChiTietCaTruc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChiTietCaTruc();
                }
                return instance;
            }
        }
        public IQueryable Load_CTCaTruc()
        {
            return DAL_CTCaTruc.Instance.layDSCTCaTruc();
        }
        public IQueryable Load_CTCaTruc(int maCT)
        {
            return DAL_CTCaTruc.Instance.layDSCTCaTruc(maCT);
        }
        public void hienThiCTCaTruc(DataGridView dgv)
        {
            dgv.DataSource = DAL_CTCaTruc.Instance.layDSCTCaTruc();
        }
        public void hienThiCTCaTruc(DataGridView dgv, int maCT)
        {
            dgv.DataSource = DAL_CTCaTruc.Instance.layDSCTCaTruc( maCT);
        }
        public bool themCTCaTruc(int maCT,string maNS)
        {
            try
            {
                return DAL_CTCaTruc.Instance.themCTCaTruc( maCT,  maNS);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool TimKiem(int maCT, string maNS)
        {
            return DAL_CTCaTruc.Instance.TimKiem(maCT, maNS);
        }
        public void xoaCTCaTruc(int ma)
        {
            try
            {
                DAL_CTCaTruc.Instance.xoaCTCaTruc(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaCTCaTruc(int maCTCT,int maCT, string maNS)
        {
            try
            {
                DAL_CTCaTruc.Instance.suaCTCaTruc( maCTCT,  maCT,  maNS);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
