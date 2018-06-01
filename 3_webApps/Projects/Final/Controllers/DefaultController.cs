using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

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
    
        public ActionResult NewLogin(string Name, string Email, string Login, string Password)
        {
            if (Session["User"] != null && Request.HttpMethod != "POST") //already logged in
            {
                ViewBag.Message = "You are already logged in";
                return RedirectToAction("MyCourses", "User");
            }
            else if (Session["User"] == null && Request.HttpMethod == "GET")//not logged in a 1st time loaded
            {
                ViewBag.Message = "Enter your personal info";
                return View();
            }
            else if (Session["User"] == null && Request.HttpMethod == "POST")//summit form create user
            {
                ViewBag.Message = "Welcome!"; //return name from db
                Session["User"] = "valid"; //extract id form db                      
                db.pInsStudents(Name, Email, Login, Password);
                return RedirectToAction("MyCourses", "User");
            }
            ViewBag.Message = "Unknown condition";
            return View();
        }
    }
}