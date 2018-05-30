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
            return View();
        }
         
        //[HttpPost]
        public ActionResult Login(string Login, string Password)
        {
            //Login = Password = "";
            OleDbConnection objOleCon = new OleDbConnection();
            objOleCon.ConnectionString = strOledbConnection;
            OleDbCommand objCmd = new OleDbCommand("Select count(*) from [vStudents] where StudentLogin like '"+Login+ "' AND StudentPassword LIKE '" +Password+ "'", objOleCon);
            //objCmd.Parameters.AddWithValue("@StudentLogin", "'"+Login+"'");
            //objCmd.Parameters.AddWithValue("@StudentPassword", "'"+Password+"'");
            try
            {
                objOleCon.Open();
                
                int i = (Int32)objCmd.ExecuteScalar();
                 
                
                if ( i == 1)
                {
                    ViewBag.Message = "Valid User";
                    Session["User"] = "valid";
                }
                else
                {
                    ViewBag.Message = "User not found";
                }
            }
            catch (Exception ex) { ViewBag.Message = ex.ToString(); }
            finally
            {
                objOleCon.Close();
            }
            return View();
        }
        public ActionResult NewLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidateLogin()
        {

            return RedirectToAction("Login");
        }
    }
}