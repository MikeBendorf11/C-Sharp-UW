<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Assignments.Master" %>

<%@ Import Namespace="System.Data" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Assingment 04</title>
    <script runat="server">
        ICollection CreateDataSource()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("EmailAddress", typeof(string)));
            dt.Columns.Add(new DataColumn("LoginName", typeof(string)));
            dt.Columns.Add(new DataColumn("ReasonForAccess", typeof(string)));

            for (int i = 0; i < 10; i++)
            {
                dr = dt.NewRow();
                //dr[0] = tl[i].Id;
                //dr[1] = tl[i].Date.ToShortDateString();
                //dr[2] = tl[i].Type;
                //dr[3] = tl[i].Amount.ToString("#0.00");
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            return dv;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void Page_Load(Object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection objOleCon = new System.Data.OleDb.OleDbConnection();
            System.Data.OleDb.OleDbCommand objCmd = new System.Data.OleDb.OleDbCommand();
            try
            {   //1. Make a Connection
                string strOledbConnection = @"Provider=SQLOLEDB;
                                    Data Source=MBENDORF-E7240\SQLEXPRESS;
                                    Integrated Security=SSPI;
                                    Initial Catalog=ASPNetHomework";
                objOleCon.ConnectionString = strOledbConnection;
                objOleCon.Open();

                //2. Issue a Command
                objCmd.Connection = objOleCon;
                objCmd.CommandText = "Select * From [Logins]";
                System.Data.OleDb.OleDbDataReader reader = objCmd.ExecuteReader();

                //3.Creade datatable
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("EmailAddress", typeof(string)));
                dt.Columns.Add(new DataColumn("LoginName", typeof(string)));
                dt.Columns.Add(new DataColumn("ReasonForAccess", typeof(string)));

                //3. Process the Results
                while (reader.Read())
                {
                    dr = dt.NewRow();
                    dr[0] = (string)reader["Name"];
                    dr[1] = (string)reader["EmailAddress"];
                    dr[2] = (string)reader["LoginName"];
                    dr[3] = (string)reader["ReasonForAccess"];
                    dt.Rows.Add(dr);
                }
                DataView dv = new DataView(dt);
                ItemsGrid2.DataSource = dv;
                ItemsGrid2.DataBind();
            }
            catch (Exception ex) { Label1.Text += "<b>" + ex.ToString() + "</b>"; }
            finally { objOleCon.Close(); } //4. Run clean up code

        }
    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div id="asg1" class="templatemo-content-widget white-bg col-1">
            <i class="fa fa-times"></i>
            <div class="square"></div>
            <h2 class="templatemo-inline-block">Assignment04:</h2>
            <hr>
            <div class="square-light"></div>
            <h4>Adding info to a Database:</h4>
            <p>In this homework you will details about debugging ASP.NET pages that use client side, server side, and database functions</p>
            <ul style="list-style-type: decimal">
                <li>Modify Assignment02.aspx Content page </li>
                <li>Create a database using the provided SQL code</li>
                <li>Create one stored procedure of your worn</li>
                <li>Modify the database using the created stored procedures</li>
            </ul>
        </div>
        <div class="templatemo-content-widget blue-bg">
            <i class="fa fa-times"></i>
            <form runat="server" class="templatemo-login-form">
                <table style="margin: auto; width: 70%;">
                    <tr>
                        <td><span>Name: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBName" runat="server"></asp:TextBox></td>
                        <td style="width: 100px"></td>
                    </tr>
                    <tr>
                        <td><span>Email Address: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBEmail" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><span>Login Name: </span></td>
                        <td>
                            <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBLogin" runat="server"></asp:TextBox></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3"><span>Reason for Access?</span></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:TextBox class="form-control" Width="100%" Height="100" ID="TBReason" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <br />
                            <asp:Button class="templatemo-blue-button" ID="Button1" Width="110" runat="server" Text="Summit" OnClick="Button1_Click" />
                            &nbsp;
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </form>

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
    <%--//s--%>
</asp:Content>


