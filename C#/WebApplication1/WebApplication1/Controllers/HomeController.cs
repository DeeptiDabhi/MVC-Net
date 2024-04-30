using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            //using viewdata send data cntroller to view
            ViewData["Name"] = "Deepti";
            ViewData["TodayDate"] = DateTime.Now;

            //using viewbag send data cntroller to view
            ViewBag.Stack = ".Net";
            ViewBag.Date = DateTime.Now.ToString();
            return View("HomePage");
        }
    }
}