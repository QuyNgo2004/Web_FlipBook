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
    public class BUS_NhaPhanPhoi
    {
        private static BUS_NhaPhanPhoi instance;

        public static BUS_NhaPhanPhoi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_NhaPhanPhoi();
                }
                return instance;
            }
        }

        public void hienThiNhaPhanPhoi(DataGridView dgv)
        {
            dgv.DataSource = DAL_NhaPhanPhoi.Instance.layDSNhaPhanPhoi();
        }

        public IQueryable loadnpp()
        {
            return DAL_NhaPhanPhoi.Instance.layDSNhaPhanPhoi();
        }

        public bool themNhaPhanPhoi(ET_NhaPhanPhoi nhaPhanPhoi)
        {
            try
            {
                return DAL_NhaPhanPhoi.Instance.themNhaPhanPhoi(nhaPhanPhoi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void xoaNhaPhanPhoi(string ma)
        {
            try
            {
                DAL_NhaPhanPhoi.Instance.xoaNhaPhanPhoi(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void suaNhaPhanPhoi(ET_NhaPhanPhoi nhaPhanPhoi)
        {
            try
            {
                DAL_NhaPhanPhoi.Instance.suaNhaPhanPhoi(nhaPhanPhoi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string AutoMa_NhaPhanPhoi()
        {
            return DAL_NhaPhanPhoi.Instance.AutoMa_NhaPhanPhoi();
        }

        public bool KiemTraMaNhaPhanPhoi(string ma)
        {
            try
            {
                return DAL_NhaPhanPhoi.Instance.KiemTraMaNhaPhanPhoi(ma);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
