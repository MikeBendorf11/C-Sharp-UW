<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Projects.Master" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Project 04</title>

    <script runat="server">
        const int CNAME = 0, CEMAIL = 1, CLOGIN = 2, CREASON = 3, CTOTCOLS = 4;
        //string strOledbConnection = @"Provider=SQLOLEDB;
        //                            Data Source=MBENDORF-E7240\SQLEXPRESS;
        //                            Integrated Security=SSPI;
        //                            Initial Catalog=ASPNetHomework";
        string strOledbConnection = @"Provider=SQLOLEDB;Data Source=tcp:s17.winhost.com;Initial Catalog=DB_122058_test2;User ID=DB_122058_test2_user;Password=uwcs;";

        protected void Page_Load(Object sender, EventArgs e)
        {
            LoadTable();
        }

        //Delete
        protected void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection objOleCon = new OleDbConnection();
            try
            {
                objOleCon.ConnectionString = strOledbConnection;
                OleDbCommand objCmd = new OleDbCommand("pDelLogins", objOleCon);
                objCmd.CommandType = CommandType.StoredProcedure;
                objOleCon.Open();
                objCmd.ExecuteNonQuery();

            }
            catch (Exception ex) { Label1.Text += "<b>" + ex.ToString() + "</b>"; }
            finally
            {
                objOleCon.Close();
                LoadTable();
            }
        }
        //insert
        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection objOleCon = new OleDbConnection();
            try
            {
                objOleCon.ConnectionString = strOledbConnection;
                OleDbCommand objCmd = new OleDbCommand("pInsLogins", objOleCon);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.AddWithValue("@Name", TBName.Text);
                objCmd.Parameters.AddWithValue("@EmailAddress", TBEmail.Text);
                objCmd.Parameters.AddWithValue("@LoginName", TBName.Text);
                objCmd.Parameters.AddWithValue("@ReasonForAccess", TBReason.Text);
                objOleCon.Open();
                objCmd.ExecuteNonQuery();

            }
            catch (Exception ex) { Label1.Text += "<b>" + ex.ToString() + "</b>"; }
            finally
            {
                objOleCon.Close();
                LoadTable();
            }
        }

        ICollection CreateDataSource(int iNofRows, string[][] strDataArray)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Email", typeof(string)));
            dt.Columns.Add(new DataColumn("LoginName", typeof(string)));
            dt.Columns.Add(new DataColumn("Reason", typeof(string)));

            for (int i = 0; i < iNofRows; i++)
            {
                dr = dt.NewRow();
                dr[CNAME] = strDataArray[i][CNAME];
                dr[CEMAIL] = strDataArray[i][CEMAIL];
                dr[CLOGIN] = strDataArray[i][CLOGIN];
                dr[CREASON] = strDataArray[i][CREASON];
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            return dv;
        }

        protected void LoadTable()
        {
            OleDbConnection objOleCon = new OleDbConnection();
            OleDbCommand objCmd = new OleDbCommand();
            try
            {
                objOleCon.ConnectionString = strOledbConnection;
                objOleCon.Open();

                //find nOfRows
                objCmd.Connection = objOleCon;
                objCmd.CommandText = "Select Count(*) From [Logins]";
                int iNofRows = (int)objCmd.ExecuteScalar();
                string[][] strDataArray = new string[iNofRows][];
                for (int i = 0; i < iNofRows; i++)
                    strDataArray[i] = new string[CTOTCOLS];

                //Command reading all
                objCmd.CommandText = "Select * From [Logins]";
                OleDbDataReader reader = objCmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    strDataArray[count][CNAME] = (string)reader["Name"];
                    strDataArray[count][CEMAIL] = (string)reader["EmailAddress"];
                    strDataArray[count][CLOGIN] = (string)reader["LoginName"];
                    strDataArray[count][CREASON] = (string)reader["ReasonForAccess"];
                    count++;
                }
                //draw table
                ItemsGrid2.DataSource = CreateDataSource(iNofRows, strDataArray);
                ItemsGrid2.DataBind();

            }
            catch (Exception ex) { Label1.Text += "<b>" + ex.ToString() + "</b>"; }
            finally { objOleCon.Close(); }
        }
    </script>
    <script>
        var flag = true;
        $(document).ready(function () {
            $(":text, #phContent1_TBReason").click(function () {
                if (flag) {
                    $(":text, #phContent1_TBReason").val('');
                    flag = false;
                }
            });
        });
    </script>
</asp:Content>



<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="padding-bottom: 15px; padding-top: 15px">
            <h1>Project 03</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div id="asg1" class="templatemo-content-widget white-bg col-1">
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Databases</h2>
            <hr>
            <h4>MSSQL and Stored Procedures</h4>
            <p></p>
            <ul style="list-style-type: decimal">
                <li>Each button event triggers a corresponding Stored Procedure</li>
                <li>This is better than using SQL command strings as it prevents SQL injection attacks</li>
                <li>From here on I will just write data to my hosted database, so everything is updated from one repository</li>
                <li>I am using VS Publish feature to update my remote project, goodbye to FTP clients</li>
            </ul>
        </div>
        <div class="templatemo-content-widget pink-bg">
            <i class="fa fa-times"></i>
            <div class="templatemo-login-form">
                <table style="margin: auto; width: 70%;">
                    <tr>
                        <td><span>Name: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBName" Text="A name" runat="server"></asp:TextBox></td>
                        <td style="width: 100px"></td>
                    </tr>
                    <tr>
                        <td><span>Email Address: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBEmail" Text="name@domain.com" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><span>Login Name: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBLogin" Text="Your initials" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3"><span>Reason for Access?</span></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:TextBox class="form-control" Width="100%" Height="100" ID="TBReason" runat="server" TextMode="MultiLine">Click the boxes to clear the form or just click send to add a row to the database</asp:TextBox><br>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="1">

                            <asp:Button class="templatemo-white-button" ID="Button1" Width="150" runat="server" Text="Add Row" OnClick="Button1_Click" />
                        </td>
                        <td>
                            <asp:Button class="templatemo-white-button" ID="Button2" runat="server" Text="Delete Row" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="col-2">

            <div class="panel panel-default templatemo-content-widget white-bg no-padding templatemo-overflow-hidden col-2">
                <i class="fa fa-times"></i>
                <div class="panel-heading templatemo-position-relative">
                    <h2 class="text-uppercase">Login Table</h2>
                </div>
                <div class="table-responsive">
                    <asp:DataGrid class="table table-striped table-bordered" ID="ItemsGrid2" runat="server">

                        <HeaderStyle BackColor="#00aaaa"></HeaderStyle>

                    </asp:DataGrid>
                </div>
            </div>

        </div>
    </div>
</asp:Content>


