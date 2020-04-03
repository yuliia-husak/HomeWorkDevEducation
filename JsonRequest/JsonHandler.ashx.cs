using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonRequest
{
    /// <summary>
    /// Summary description for JsonHandler
    /// </summary>
    public class JsonHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.Write("{\"firstName\":\"Ivan\",\"lastName\":\"Ivanov\"}");
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