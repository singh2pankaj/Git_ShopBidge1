using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;



namespace API_ShopBridge.Master_Item
{
    [DataContract]
    public class SVC_Model_Brand
    {
        [DataMember]
        public string Brand_ID { get; set; }

        [DataMember]
        public string Brand_Name { get; set; }

       
    }
}