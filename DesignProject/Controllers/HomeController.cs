using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.Title = "DesignProject";
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult MyEvents()
        {
            return View();
        }

        public ActionResult MyProfile()
        {
            return View();
        }

        public ActionResult EditMyProfile()
        {
            return View();
        }

        public ActionResult SelectSession()
        {
            return View();
        }

        public ActionResult SessionTemplate()
        {
            return View();
        }

        public ActionResult click(object item, object message)
        {
            item = message;
            return View();
        }
    }
}
