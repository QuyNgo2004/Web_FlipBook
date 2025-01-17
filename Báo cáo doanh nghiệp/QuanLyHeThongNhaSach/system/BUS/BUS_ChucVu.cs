using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChucVu
    {
        private static BUS_ChucVu instance;

        public static BUS_ChucVu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ChucVu();
                }
                return instance;
            }
        }
        public IQueryable Load_ChucVu()
        {
            return DAL_ChucVu.Instance.layDSChucVu();
        }
        
    }
}
