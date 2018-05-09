using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

namespace Projects.App_Code
{
    
    public class UserData 
    {
        public static Stopwatch sw = new Stopwatch();
        static List<string> strPrevPage = new List<string>();

        public static string StrPrevPage(string sInput) {
            string result = "";
            if (!strPrevPage.Any())
            {
                strPrevPage.Add("");
                return result;
            }
                
            else
                strPrevPage.Add(sInput);
            
            for(int i = strPrevPage.Count-1, results=4; i >=0 ; i--, results--)
            {   
                if (results < 1) break;
                if (strPrevPage[i] == "") continue;
                result += strPrevPage[i] + " | "; 
            }
            return result;
        }

    }
}