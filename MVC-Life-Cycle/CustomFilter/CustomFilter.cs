using System.Web;
using System.Web.Mvc;

namespace MVC_Life_Cycle.CustomFilter
{
    //Filter attribute is there to make the same accessible as attributes inside controller's methods
    //IActionFilter offcourse gives two pre and post execution methods.
    public class CustomFilter :FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 1 Executing, <br />";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 1 Executed, <br />";
        }
    }

    public class CustomFilter2 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 2 Executing, <br />";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 2 Executed, <br />";
        }
    }

    public class CustomFilter3 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 3 Executing, <br />";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 3 Executed, <br />";
        }
    }
    public class CustomFilter4 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 4 Executing, <br />";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 4 Executed, <br />";
        }
    }

    public class CustomFilter5 : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 5 Executing, <br />";
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            HttpContext.Current.Application["Filter"] += "Filter 5 Executed, <br />";
        }
    }
}