using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final.Models;
using System.Diagnostics;
using Final.Controllers;
using System.Configuration;
using System.Data.OleDb;
using System.Data.Entity.Core.Objects;

namespace Final.App_Code
{
    public class StudentProcessor
    {
        public DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        OleDbConnection objOleCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString);
        
        /**********************************************
         * Author: Mijael
         * Finds the student ID match for the username and password. Returns 0 if it didn't find an student 
         * TODOS: field validations, return name from login
         **********************************************/
        public int getStdId(string Login, string Password)
        {
            int stdId = 0;
            OleDbCommand objCmd = new OleDbCommand("Select * from [vStudents] where StudentLogin like '" + Login + "' AND StudentPassword LIKE '" + Password + "'", objOleCon); 
            try
            {
                objOleCon.Open();
                OleDbDataReader reader = objCmd.ExecuteReader();
                reader.Read();
                stdId = (int)reader["StudentId"];
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
            finally { objOleCon.Close(); }
            return stdId;
        }
        
                
    }
}