using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace Final.Controllers
{
    public class DefaultController : Controller
    {
        DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        string strOledbConnection = ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString;

        //GET: Default
        public ActionResult Courses()
        {
            return View(db.vClasses.ToList());
        }
    
        public ActionResult NewLogin()
        {
            if (Session["User"] != null) //already logged in
            {
                ViewBag.Message = "You are already logged in";
                return RedirectToAction("MyCourses", "User");
            }
            else
            {
                ViewBag.Message = "Create a new user";
                return View();
            }
            
        }
    }
}