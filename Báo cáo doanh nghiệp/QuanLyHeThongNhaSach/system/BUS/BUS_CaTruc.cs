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
    public class BUS_CaTruc
    {
        private static BUS_CaTruc instance;

        public static BUS_CaTruc Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_CaTruc();
                }
                return instance;
            }
        }
        public IQueryable Load_CaTruc()
        {
            return DAL_CaTruc.Instance.layDSCaTruc();
        }
        public IQueryable Load_CaTruc(string maCN)
        {
            return DAL_CaTruc.Instance.layDSCaTruc(maCN);
        }
        public void hienThiCaTruc(DataGridView dgv)
        {
            dgv.DataSource = DAL_CaTruc.Instance.layDSCaTruc();
        }
        public void hienThiCaTruc(DataGridView dgv,string maCN)
        {
            dgv.DataSource = DAL_CaTruc.Instance.layDSCaTruc(maCN);
        }
        public bool themCaTruc(ET_CaTruc CaTruc)
        {
            try
            {
                return DAL_CaTruc.Instance.themCaTruc(CaTruc);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void xoaCaTruc(int ma)
        {
            try
            {
                DAL_CaTruc.Instance.xoaCaTruc(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaCaTruc(ET_CaTruc CaTruc)
        {
            try
            {
                DAL_CaTruc.Instance.suaCaTruc(CaTruc);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
