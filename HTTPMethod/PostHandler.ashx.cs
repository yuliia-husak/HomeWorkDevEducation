using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTPMethod
{
    /// <summary>
    /// Summary description for PostHandler
    /// </summary>
    public class PostHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)        {
            context.Response.ContentType = "text/plain";

            string aParam = context.Request.Form["a"];
            string bParam = context.Request.Form["b"];

            context.Response.Write("<b>POST</b> параметры переданные с запросом а= " + aParam + " ,b=" + bParam);
            
           //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}