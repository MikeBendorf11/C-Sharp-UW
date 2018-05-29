using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult MyCourses()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult NewLogin()
        {
            return View();
        }
    }
} 