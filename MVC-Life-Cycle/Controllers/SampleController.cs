using System;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Life_Cycle.Controllers
{
    public class SampleController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            //Displaying some message
            HttpContext.Current.Response.Write("Hello From Custom Controller Implementation");
        }
    }
}