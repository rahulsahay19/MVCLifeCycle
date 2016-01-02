using System;
using System.Web;

namespace MVC_Life_Cycle.CustomHandlers
{
    public class CustomHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Redirect("http://myview.rahulnivi.net");
        }

        //This is also correct
        //public bool IsReusable
        //{
        //    get { return false;}
        //}

        //But I have used expression syntax here
        public bool IsReusable => false;
    }
}