using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Data
    {
        protected  QLNhaSachDataContext dbNhaSach;
        public DAL_Data()
        {
            Load_Data();
        }


        // Load connection string
        public QLNhaSachDataContext Connetion_String(string connect)
        {
              return  new QLNhaSachDataContext(connect);
        }
        public  bool Load_Data()
        {
            bool flag = true;
            try
            {
                //string conection = @"Data Source=" + "DESKTOP-4HPV2E5\\LISM" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
                string conection = @"Data Source=" + "MSI\\SQLEXPRESS" + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";

                SqlConnection sqlConnection = new SqlConnection(conection);
                sqlConnection.Open();
                DbNhaSach =  Connetion_String(conection);
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return flag;
        }


        public QLNhaSachDataContext DbNhaSach { get => dbNhaSach; set => dbNhaSach = value; }
    }
}
