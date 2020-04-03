//<%@ WebHandler Language="C#" Class="GetHandler" %>

using System;
using System.Web;


    /// <summary>
    /// Summary description for GetHandler2
    /// </summary>
    public class GetHandler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            // context.Response.Write("Hello World");
            string aParam = context.Request.QueryString["a"];
            string bParam = context.Request.QueryString["b"];

            context.Response.Write("<b>GET</b> параметры переданные с запросом: а=" + aParam + ",b=" + bParam);
        } 

        public bool IsReusable  {
            get
            {
                return false;
            }
        }
    }
