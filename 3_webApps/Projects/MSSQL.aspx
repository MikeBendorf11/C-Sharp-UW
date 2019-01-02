<%@ Page Title="MSSQL" Language="C#" AutoEventWireup="true" MasterPageFile="~/Projects.Master" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>
 
<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Project 04</title>

    <script runat="server">
        const int CNAME = 0, CEMAIL = 1, CLOGIN = 2, CREASON = 3, CTOTCOLS = 4;

        string strOledbConnection = ConfigurationManager.ConnectionStrings["RemoteServer"].ConnectionString;

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
            $('#phContent1_ItemsGrid2').fadeIn(1500);
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

    <div id="asg1"  class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget white-bg col-2" >
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Contact Form and Database</h2><br /><br />
            <p>Schema and Procedures are in place to warranty data integrity. Server version is Microsoft SQL 2014 Management Studio.</p>
            <br />
                <div class="">
                    <asp:DataGrid class="" style="display: none" ID="ItemsGrid2" runat="server">

                        <HeaderStyle BackColor="#00aaaa"></HeaderStyle>

                    </asp:DataGrid>
                </div>
            
        </div>
        <div id="contactForm" class="templatemo-content-widget blue-bg col-1">
            <i class="fa fa-times"></i>
            <br />
                <table class="table-condensed">
                    <tr>
                        <td>Name:</td>
                        <td><asp:TextBox class="form-control" ID="TBName" Text="A name" runat="server"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td >Email:</td>
                        <td><asp:TextBox class="form-control" ID="TBEmail" Text="name@domain.com" runat="server"></asp:TextBox></td>
                        
                    </tr>
                    <tr>
                        <td>Intials:</td>
                        <td><asp:TextBox class="form-control" ID="TBLogin" Text="Your initials" runat="server"></asp:TextBox></td>

                    </tr>
                    <tr>
                        <td>Comments:</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:TextBox class="form-control" Width="100%" Height="100" ID="TBReason" runat="server" TextMode="MultiLine">Click send or click the boxes to clear the form</asp:TextBox><br>
                        </td>
                    </tr>
  <%--                     <tr>
                        <td colspan="1">
                            
                        </td>
                     <td>
                            <asp:Button class="form-control" ID="Button2" runat="server" Text="Delete Row" OnClick="Button2_Click" />
                        </td>
                    </tr--%>
                </table>
                <asp:Button class="form-control" ID="Button1" Width="150" runat="server" Text="Send" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="col-1"></div>
        <div class="col-2">

           

        </div>
        <div class="col-1"></div>
    </div>
</asp:Content>


