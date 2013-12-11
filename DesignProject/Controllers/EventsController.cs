using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesignProject.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/

        public ActionResult Schedule()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EventTemplate()
        {
            return View();
        }
    }
}
