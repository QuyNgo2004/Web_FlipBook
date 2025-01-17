using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Data
    {
        DAL_Data data = new DAL_Data();
        
        public void connection_String (string connectionString)
        {

        }

        public bool Load_Data()
        {
            return data.Load_Data();
        }
    }
}
