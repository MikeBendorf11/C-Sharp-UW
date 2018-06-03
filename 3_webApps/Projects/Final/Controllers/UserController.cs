﻿using System; 
using System.Web.Mvc;
using Final.Models;
using Final.App_Code;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Text.RegularExpressions;

namespace Final.Controllers
{
    public class UserController : Controller
    {
        StudentProcessor processor = new StudentProcessor();

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
                    Session["User"] = stdId; 
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
        
        //string ClassID is the "value=" attribute of the summit button for every course row
        public ActionResult MyCourses(string ClassID)
        {
            if (Session["User"] == null)
            {
                TempData["shortMessage"] = "Please login first";
                return RedirectToAction("Login");
            }
            else if (Session["User"] != null && Request.HttpMethod != "POST")
            {
                int stdID = int.Parse(Session["User"].ToString());
                ObjectResult or = processor.db.pSelClassesByStudentID(stdID);
                return View(or);
            }
            else if(Session["User"] != null && Request.HttpMethod == "POST")
            {
                int stdID = int.Parse(Session["User"].ToString());
                Match match = Regex.Match(ClassID, @"\d"); 
                int classID = int.Parse(match.Value);
                processor.db.pDelClassStudents(classID, stdID);

                ObjectResult or = processor.db.pSelClassesByStudentID(stdID);
                return View(or);
            }
            TempData["shortMessage"] = "Uknown condition";
            ViewBag.Message = "Uknown condition";
            return RedirectToAction("Login");
        }

        private ActionResult View(Func<IEnumerator<pSelClassesByStudentID_Result>> getEnumerator)
        {
            throw new NotImplementedException();
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
};