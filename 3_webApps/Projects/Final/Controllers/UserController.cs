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
    public class UserController : Controller
    {
        DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        string strOledbConnection = ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString;

        public ActionResult Login(string Login, string Password)
        {
            if (Session["User"] == null && Request.HttpMethod != "POST") //not logged in
            { 
                ViewBag.Message = "Please Login";
                return View();
            }
            else if (Session["User"] == null && Request.HttpMethod == "POST")
            {
                OleDbConnection objOleCon = new OleDbConnection();
                objOleCon.ConnectionString = strOledbConnection;
                OleDbCommand objCmd = new OleDbCommand("Select count(*) from [vStudents] where StudentLogin like '" + Login + "' AND StudentPassword LIKE '" + Password + "'", objOleCon);
                //objCmd.Parameters.AddWithValue("@StudentLogin", "'"+Login+"'");
                //objCmd.Parameters.AddWithValue("@StudentPassword", "'"+Password+"'");
                try
                {
                    objOleCon.Open();
                    if ((Int32)objCmd.ExecuteScalar() == 1)
                    {
                        ViewBag.Message = "Welcome!";
                        Session["User"] = "valid";                       
                        return RedirectToAction("MyCourses");
                    }
                    else
                        ViewBag.Message = "User not found"; 
                }
                catch (Exception ex){ViewBag.Message = ex.ToString();}
                finally { objOleCon.Close(); }
            }
            else if (Session["User"] != null) 
            {
                ViewBag.Message = "You are already logged in";
                return RedirectToAction("MyCourses");
            }
            return View();
        }
        public ActionResult MyCourses()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            return RedirectToAction("Login");
        }
        public ActionResult Register()
        {
            if (Session["User"] != null)
            {
                return View();
            }
            return RedirectToAction("Login");
        }
    }
}