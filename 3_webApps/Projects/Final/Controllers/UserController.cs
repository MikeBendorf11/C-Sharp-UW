using System;

using System.Web.Mvc;
using Final.Models;
using Final.App_Code;
using System.Configuration;
using System.Data.OleDb;

namespace Final.Controllers
{
    public class UserController : Controller
    {
        StudentProcessor processor = new StudentProcessor();
        DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        string strOledbConnection = ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString;
        TempData["shortMessage"] = "";

        public ActionResult Login(string Login, string Password)
        {
            if (Session["User"] == null && Request.HttpMethod != "POST") //not logged in
            { 
                ViewBag.Message = "Please Login";
                return View();
            }
            else if (Session["User"] == null && Request.HttpMethod == "POST")// attempting to log in
            {
                int stdId = processor.getStdId(Login, Password);
                if (stdId > 0)
                {
                    TempData["shortMessage"] = "Welcome!"; //return name from db
                    Session["User"] = stdId.ToString(); 
                    return RedirectToAction("MyCourses");
                } 
                else
                {
                    ViewBag.Message = "User not found";
                    return View();
                }
            }
            else if (Session["User"] != null) 
            {
                TempData["shortMessage"] = "You are already logged in";
                return RedirectToAction("MyCourses");
            }
            ViewBag.Message = "Unknown Condition";
            return View();
        }
        public ActionResult MyCourses()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            TempData["shortMessage"] = "Please login first";
            return RedirectToAction("Login");
        }
        public ActionResult Register()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            TempData["shortMessage"] = "Please login first"; 
            return RedirectToAction("Login");
        }
    }
}