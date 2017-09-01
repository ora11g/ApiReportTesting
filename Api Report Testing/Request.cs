using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace YBInterface.Support
{    
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.section9.org/cms/referral/data")]
    [XmlRootAttribute(ElementName = "request",  Namespace = "http://www.section9.org/cms/referral/data")]
    public class Request<TRequestBody> where TRequestBody : class, new()
    {
        public RequestHead head { get; set; }        

        public TRequestBody body { get; set; }

        /// <summary>
        /// 医保参合证号
        /// </summary>
        [XmlIgnoreAttribute]
        public string ybRegNo { get; set; }
    }
        
    public partial class RequestHead
    {
        public string version { get; set; }

        public string functionNo { get; set; }

        [XmlIgnoreAttribute]
        public string functionName { get; set; }

        public string targetOrg { get; set; }

        public RequestHeadHealthcareprovider healthcareprovider { get; set; }
                
        public partial class RequestHeadHealthcareprovider
        {
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string identity { get; set; }

            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string password { get; set; }
        }
    }
}
