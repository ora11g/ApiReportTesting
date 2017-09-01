using System;
using System.Collections.Generic; 
using System.Text;
using System.Xml.Serialization;

namespace YBInterface.Support
{
    public enum Status
    {
        OK = 0,
        ERROR = 1,
    }
        
    [System.Xml.Serialization.XmlRootAttribute("response")]
    public partial class Response<TResponseBody> where TResponseBody : class, new()
    {
        public Response() 
        {             
            this.status = Status.ERROR;
            this.head = new ResponseHead()
            {
                describe = string.Empty,
                stateCode = "Internal Error"
            };

            this.body = new TResponseBody();
        }        

        public ResponseHead head { get; set; }

        public TResponseBody body { get; set; }

        [XmlIgnoreAttribute]
        public Status status { get; set; } 
    }

    public partial class ResponseHead
    {
        public string stateCode { get; set; }

        public string describe { get; set; }
    }
}
