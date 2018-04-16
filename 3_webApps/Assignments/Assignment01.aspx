<%@ Page Language="C#" MasterPageFile="~/Assignments.Master" %>
<%@ Import Namespace="trs" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Assignment 01</title>
    <script runat="server">

        TransactionList tl = new TransactionList();
        
        ICollection CreateDataSource()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("Id", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Date", typeof(string)));
            dt.Columns.Add(new DataColumn("Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Amount", typeof(string)));

            for (int i = 0; i < 10; i++)
            {
                dr = dt.NewRow();
                dr[0] = tl[i].Id;
                dr[1] = tl[i].Date.ToShortDateString();
                dr[2] = tl[i].Type;
                dr[3] = tl[i].Amount.ToString("#0.00");
                dt.Rows.Add(dr);
            }
            DataView dv = new DataView(dt);
            return dv;

        }
        void Page_Load(Object sender, EventArgs e)
        {
            trs.Transaction.lastId = 0;
            if (!IsPostBack)
            {
                // Load this data only once.
                ItemsGrid.DataSource = CreateDataSource();
                ItemsGrid.DataBind();
            }
        }

    </script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
            <div class="templatemo-flex-row flex-content-row">
                <div id="asg1" class="templatemo-content-widget white-bg col-1">
                    <i class="fa fa-times"></i>
                    <div class="square"></div>
                    <h2 class="templatemo-inline-block">Assignment01:</h2><hr>
                    <h4>Create your own demo</h4>
                    <p>Now that you have seen how others describe and demonstrate these concepts, let’s try out your skills by creating a new ASP.NET page and Word document that demonstrates how to create ASP.NET web pages that use HTML and JavaScript.</p>
                    <ul style="list-style-type:decimal">
                        <li> Create a new Empty ASP.NET project.</li>
                        <li>Create a web page that includes ASP.NET (C#), HTML, and JavaScript.</li>
                    </ul>
                </div>
            </div>
            <div class="panel panel-default templatemo-content-widget white-bg no-padding templatemo-overflow-hidden">
            <i class="fa fa-times"></i>
            <div class="panel-heading templatemo-position-relative">
                <h2 class="text-uppercase">User Table</h2>
            </div>
            <div class="table-responsive">
                <asp:DataGrid class="table table-striped table-bordered" ID="ItemsGrid" runat="server">

                    <HeaderStyle BackColor="#00aaaa"></HeaderStyle>

                </asp:DataGrid>
            </div>
        </div>
</asp:Content>

