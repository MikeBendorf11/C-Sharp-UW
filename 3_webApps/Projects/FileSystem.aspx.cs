using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;

namespace Projects
{
    public class FileSystem : System.Web.UI.Page
    {
        protected global::System.Web.UI.WebControls.Button Button1;
        protected global::System.Web.UI.WebControls.Label Label1;
        protected global::System.Web.UI.WebControls.TextBox
            TBName, TBEmail, TBLogin, TBReason;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Button1.Click += new EventHandler(this.Button1_Click);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string text = String.Format("Name: {0}\nEmail: {1}\nLogin: {2}\nReason: {3}"
                , TBName.Text, TBEmail.Text, TBLogin.Text, TBReason.Text);
            try
            {
                File.WriteAllText(Server.MapPath("~/App_Data/data.txt"), text);
                Debug.WriteLine("###" + Server.MapPath("~/"));
                
            }
            catch (UnauthorizedAccessException u)
            {
                Debug.WriteLine("nop: " + u.Message);
            }
            TBName.Text =  TBEmail.Text = TBLogin.Text = TBReason.Text = "";
            Button1.Text = "SUCCESS";
            Label1.Text = "A file has been created at the server \"~/App_Data/data.txt\"";
        }
    }
}