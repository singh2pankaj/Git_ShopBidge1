using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace API_ShopBridge.Master_Item
{

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service_ShopBridge : IService_ShopBridge
    {

        
        SqlConnection con;



        public List<SVC_Model_Brand> Display_Brand(string brand_id,string brand_name)
        {
           
            try
            {
                con = new SqlConnection(Stat_ConnectionString.get_ConnectionString());
                
                var para = new DynamicParameters();
                para.Add("@brand_id", brand_id);
                para.Add("@brand_name", brand_name);

                return con.Query<SVC_Model_Brand>("sp_Display_Brand", para, null, true, 0, CommandType.StoredProcedure).ToList();
                
            }

            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

              
                con.Dispose();

            }
        }



     
        public List<SVC_Model_Item> Display_Item(string item_code, string item_name, string brand_id)
        {

            try
            {
                con = new SqlConnection(Stat_ConnectionString.get_ConnectionString());

                var para = new DynamicParameters();
                para.Add("@item_code", item_code);
                para.Add("@item_name", item_name);
                para.Add("@brand_id", brand_id);

                return con.Query<SVC_Model_Item>("sp_Display_Item", para, null, true, 0, CommandType.StoredProcedure).ToList();

            }

            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                con.Dispose();

            }
        }



        public string Insert_Item(SVC_Model_Item SVC_Model_Item1)
        {
            string msg = "";
                
            try
            {
                //SVC_Model_Item1 = new SVC_Model_Item();

                con = new SqlConnection(Stat_ConnectionString.get_ConnectionString());
                
                var para = new DynamicParameters();
                para.Add("@Item_Name", SVC_Model_Item1.Item_Name);
                para.Add("@Item_Desc", SVC_Model_Item1.Item_Desc);
                para.Add("@Item_Price", SVC_Model_Item1.Item_Price);
                para.Add("@Brand_ID", SVC_Model_Item1.Brand_ID);

                var affectedRows = con.Execute("sp_Insert_Item", para, null, 0, CommandType.StoredProcedure);

                msg = "Data saved successfully";

            }

            catch (Exception ex)
            {
                msg = ex.Message;
                //throw new FaultException(ex.Message);
                
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

              
                con.Dispose();

            }

            return msg;
        }




        public string Modify_Item(SVC_Model_Item SVC_Model_Item1)
        {
            string msg = "";

            try
            {
              

                con = new SqlConnection(Stat_ConnectionString.get_ConnectionString());

                var para = new DynamicParameters();

                para.Add("@Item_Code", SVC_Model_Item1.Item_Code);
                para.Add("@Item_Name", SVC_Model_Item1.Item_Name);
                para.Add("@Item_Desc", SVC_Model_Item1.Item_Desc);
                para.Add("@Item_Price", SVC_Model_Item1.Item_Price);
                para.Add("@Brand_ID", SVC_Model_Item1.Brand_ID);


                var affectedRows = con.Execute("sp_Modify_Item", para, null, 0, CommandType.StoredProcedure);

                msg = "Data saved successfully";

            }

            catch (Exception ex)
            {
                msg = ex.Message;
                //throw new FaultException(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                con.Dispose();

            }

            return msg;
        }




        public string Delete_Item(SVC_Model_Item SVC_Model_Item1)
        {
            string msg = "";

            try
            {


                con = new SqlConnection(Stat_ConnectionString.get_ConnectionString());

                var para = new DynamicParameters();

                para.Add("@Item_Code", SVC_Model_Item1.Item_Code);
               
                var affectedRows = con.Execute("sp_Delete_Item", para, null, 0, CommandType.StoredProcedure);

                msg = "Data saved successfully";

            }

            catch (Exception ex)
            {
                msg = ex.Message;
                //throw new FaultException(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }


                con.Dispose();

            }

            return msg;
        }


    }
}
