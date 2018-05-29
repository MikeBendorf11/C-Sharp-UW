using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;


namespace Final.Controllers
{
    public class DefaultController : Controller
    {
        DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        //GET: Default
        public ActionResult Courses()
        {
            return View(db.vClasses.ToList());
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