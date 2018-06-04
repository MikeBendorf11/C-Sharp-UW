using System;
using Final.Models;
using System.Diagnostics;
using System.Configuration;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Final.App_Code
{
    public class StudentProcessor
    {
        public DB_122058_test2Entities1 db = new DB_122058_test2Entities1();
        OleDbConnection objOleCon = new OleDbConnection(ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString);
        
        /**********************************************
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
       
        /*Query works in sqlserver but here returns empty ???*/
        //public List<vClass> RemainingList(int stdID)
        //{
        //    List<vClass> remainingList = new List<vClass>();
        //    OleDbCommand objCmd = new OleDbCommand("select ClassID from Classes except (select ClassID from ClassStudents where StudentId=" + stdID + ")",objOleCon);
        //    try
        //    {
        //        objOleCon.Open();
        //        OleDbDataReader reader = objCmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            vClass tempRow = new vClass();
        //            tempRow.ClassId = (int)reader["ClassId"];
        //            tempRow.ClassName = (string)reader["ClassName"];
        //            tempRow.ClassDate = (DateTime)reader["ClassDate"];
        //            tempRow.ClassDescription = (string)reader["ClassDescription"];

        //            remainingList.Add(tempRow);
        //        }                  
        //    }
        //    catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        //    finally { objOleCon.Close(); }
        //    return remainingList;
        //}
                
    }
}