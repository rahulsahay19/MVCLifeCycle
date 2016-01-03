using System.Reflection;
using System.Web.Mvc;

namespace MVC_Life_Cycle.Utils
{
    public class IsValidRequest :ActionMethodSelectorAttribute
    {
        //Currently just hardcoded to true.
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return true;
        }
    }
}