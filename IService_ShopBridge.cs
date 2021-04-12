using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace API_ShopBridge.Master_Item
{
    
    [ServiceContract]
    public interface IService_ShopBridge
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Display_Brand?brand_id={brand_id}&brand_name={brand_name}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SVC_Model_Brand> Display_Brand(string brand_id, string brand_name);




        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Display_Item?item_code={item_code}&item_name={item_name}&brand_id={brand_id}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<SVC_Model_Item> Display_Item(string item_code, string item_name, string brand_id);




        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Insert_Item", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Insert_Item(SVC_Model_Item SVC_Model_Item1);




        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Modify_Item", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Modify_Item(SVC_Model_Item SVC_Model_Item1);




        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Delete_Item", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string Delete_Item(SVC_Model_Item SVC_Model_Item1);



    }
}
