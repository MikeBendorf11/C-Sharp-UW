using System; 
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
                    TempData["welcome"] = "Welcome!";
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
                TempData["shortMessage"] = "You are already logged in. ";
                return Redirect(Request.UrlReferrer.PathAndQuery);
            }
            ViewBag.Message = "Unknown Condition"; 
            return View();
        }
        
        //string ClassID is the "value=" attribute of the summit button for every course row
        public ActionResult MyCourses(string ClassID, string CourseN)   
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
            //dropped course
            else if(Session["User"] != null && Request.HttpMethod == "POST")
            {
                int stdID = int.Parse(Session["User"].ToString());
                Match match = Regex.Match(ClassID, @"\d"); 
                int classID = int.Parse(match.Value);
                processor.db.pDelClassStudents(classID, stdID);

                ObjectResult or = processor.db.pSelClassesByStudentID(stdID);
                TempData["shortMessage"] = "Dropped " + CourseN;
                return View(or);
            }  
            TempData["shortMessage"] = "Unknown condition";
            ViewBag.Message = "Unknown condition";
            return RedirectToAction("Login");
        }
      
        public ActionResult Register(string ClassID, string CourseN)
        {
            if (Session["User"] != null && Request.HttpMethod != "POST")
            {
                int stdID = int.Parse(Session["User"].ToString());
                ObjectResult or = processor.db.pSelRemainingClassesByStudentID(stdID);
                return View(or);
            }
            //registered for course
            else if (Session["User"] != null && Request.HttpMethod == "POST")
            {
                int stdID = int.Parse(Session["User"].ToString());
                Match match = Regex.Match(ClassID, @"\d");
                int classID = int.Parse(match.Value);
                processor.db.pInsClassStudents(classID, stdID);

                ObjectResult or = processor.db.pSelRemainingClassesByStudentID(stdID);
                TempData["shortMessage"] = "Registered for " + CourseN;
                return View(or);
            }
                TempData["shortMessage"] = "Please login first"; 
            return RedirectToAction("Login"); 
        }
        public ActionResult Logout()
        {
            if (Session["User"] == null)
            {
                //TempData["ShortMessage"] = "Please Login First";
                return RedirectToAction("Login", "User");
            }
            else
            {
                Session["User"] = null;
                TempData["ShortMessage"] = "Logout Successful!";
                return RedirectToAction("Courses", "Default");
            }
                
        }
    };
};