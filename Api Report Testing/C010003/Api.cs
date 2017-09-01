using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
 
namespace YBInterface.Support.C010003
{
    public class Api : ApiBase<Request<RequestBody>, RequestBody, Response<responseBody>, responseBody>
    {
        const string FUNCTION_NO = "C010003";
        const string FUNCTION_NAME = "门诊补偿公示表";

        public Api(QZNhCommon qzNh)
            : base(qzNh)
        {             
        }

        protected override string FunctionNo
        {
            get { return FUNCTION_NO; }
        }

        protected override string FunctionName
        {
            get { return FUNCTION_NAME; }
        }

        protected override RequestBody BuildRequestBody()
        {
            DateTime now = DateTime.Now;
            string D503_34 = "2";
            string D503_35 = now.AddDays(-10).ToString(Constants.DATE_FORMAT);
            string D503_36 = now.ToString(Constants.DATE_FORMAT);

            RequestBody requestBody = new RequestBody()
            {
                D503_34 = D503_34, //日期类型
                D503_35 = D503_35, //起始日期
                D503_36 = D503_36, //终止日期
                D503_15 = this.QzNh.GetNhZd("就诊类别", "25", true), //就诊类别
                D501_11 = string.Empty, //就诊机构代码                
            };

            return requestBody;
        }
    }
}
