using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestProgress
{
    /// <summary>
    /// Summary description for TestHandler
    /// </summary>
    public class TestHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            System.Threading.Thread.Sleep(3000);

            context.Response.Write("Hello World" + DateTime.Now.ToLocalTime());
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