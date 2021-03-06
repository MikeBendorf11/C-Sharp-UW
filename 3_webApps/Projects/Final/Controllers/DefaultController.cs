﻿using System.Linq;
using System.Web.Mvc;
using Final.Models;
using System.Configuration;
using Final.App_Code;


namespace Final.Controllers 
{
    public class DefaultController : Controller
    {
        StudentProcessor processor = new StudentProcessor();
        //DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        string strOledbConnection = ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString;

        //GET: Default
        public ActionResult Courses() 
        {
            return View(processor.db.vClasses.ToList());
        }
    
        public ActionResult NewLogin(string Name, string Email, string Login, string Password)
        {
            if (Session["User"] != null && Request.HttpMethod != "POST") //already logged in
            {
                TempData["shortMessage"] = "You are already logged in. ";
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            else if (Session["User"] == null && Request.HttpMethod == "GET")//not logged in and 1st time loaded
            {
                ViewBag.Message = "Please fill up this form.";
                return View();
            }
            else if (Session["User"] == null && Request.HttpMethod == "POST")//summited form 
            {
                if(Name=="" || Email=="" || Login=="" || Password == "")//validations??
                {
                    ViewBag.Message = "Please fill up this form"; 
                    return View();
                }
                processor.db.pInsStudents(Name, Email, Login, Password);
                TempData["shortMessage"] = "Welcome " + Name + "!";
                Session["User"] = processor.getStdId(Login, Password);
                return RedirectToAction("MyCourses", "User");
            }
            ViewBag.Message = "Unknown condition"; 
            return View();
        }
    }
}