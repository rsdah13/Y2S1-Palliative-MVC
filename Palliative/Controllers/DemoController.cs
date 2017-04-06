using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Palliative.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Medications()
        {
            return View();
        }

        public ActionResult HomeCarePlan()
        {
            return View();
        }

        public ActionResult ActivityLog()
        {
            return View();
        }

        public ActionResult CareBook()
        {
            return View();
        }
    }
}