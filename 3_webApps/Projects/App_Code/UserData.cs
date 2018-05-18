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
        public static string Avatar = "avatar7";
        static List<string> strPrevPage = new List<string>();
        static string sessionTime;

        public static string StrPrevPage(string sInput)
        {
            string result = "";
            if (!strPrevPage.Any())
            {
                strPrevPage.Add("");
                return result;
            }
            else
                strPrevPage.Add(sInput);

            for (int i = strPrevPage.Count - 1, results = 4; i >= 0; i--, results--)
            {
                if (results < 1 || strPrevPage[i] == null) break;
                if (strPrevPage[i] == "" || strPrevPage[i].Contains("?")) continue;
                result += strPrevPage[i] + "&nbsp;<i class='fa fa-arrow-circle-left fa-fw'></i>&nbsp;";
            }
            return result;
        }
    }
    public class Pages
    {
        public string Name { get; set; }
        public string TimeSpend { get; set; }
        public Pages(string name, string timeSpend)
        {
            Name = name;
            TimeSpend = timeSpend;
        }
    }
}