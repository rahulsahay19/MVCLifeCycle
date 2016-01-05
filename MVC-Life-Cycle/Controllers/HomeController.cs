using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Life_Cycle.Utils;

namespace MVC_Life_Cycle.Controllers
{
    public class HomeController : Controller
    {
        [CustomFilter.CustomFilter]
        [CustomFilter.CustomFilter2]
        [CustomFilter.CustomFilter3]
        [CustomFilter.CustomFilter4]
        [CustomFilter.CustomFilter5]

        public ActionResult Index()
        {
            return View();
        }

        [IsValidRequest]
        public JsonResult About()
        {
            return Json("{Msg: From a Custom Action Invoker!}", JsonRequestBehavior.AllowGet);
        }

        public ActionResult About(string msg)
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}