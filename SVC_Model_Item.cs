
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace API_ShopBridge.Master_Item
{


    [DataContract]
    public class SVC_Model_Item
    {
        [DataMember]
        public Int64 Item_Code { get; set; }

        [DataMember]
        public string Item_Name { get; set; }

        [DataMember]
        public string Item_Desc { get; set; }

        [DataMember]
        public string Item_Price { get; set; }

        [DataMember]
        public string Brand_ID { get; set; }

        [DataMember]
        public string Brand_Name { get; set; }

    }
}