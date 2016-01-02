using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using MVC_Life_Cycle.Controllers;

namespace MVC_Life_Cycle.CustomFactory
{
    public class CustomFactory :IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            //Finds the controller with its name and then bring the logic here
            if (controllerName == "Sample")
            {
                return new SampleController();
            }
            else
            {
                //Else return the existing one
                return new HomeController();
            }
        }

        //These two implementations are not required for the time being. Hence, kept the default values
        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
           return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            //Since, this is void method. Hence, left empty for the time being
        }
    }
}