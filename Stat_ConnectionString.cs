using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel;

namespace API_ShopBridge
{
    class Stat_ConnectionString
    {
       
        //public static string servername;
        //public static string databasename;
        //public static string userid;
        //public static string pwd;


        public static string get_ConnectionString()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["ShopBridgeEntities"].ToString();
                return constr;
            }

            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }


       

    }
}
