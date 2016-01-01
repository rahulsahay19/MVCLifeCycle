using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVC_Life_Cycle;
using MVC_Life_Cycle.CustomModules;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "RegisterCustomModule")]
namespace MVC_Life_Cycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterCustomModule()

        {
            HttpApplication.RegisterModule(typeof(CustomModule));
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {
            Debug.WriteLine("Application Stopped");
        }
    }
}
