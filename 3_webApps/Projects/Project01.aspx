<%@ Page Language="C#" MasterPageFile="~/Projects.Master" %>

<%@ Import Namespace="trs" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Projects.App_Code" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Project 01</title>
    
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
    <script>
        $(document).ready(function () {
            $("#tableDiv").animate({
                height: '100%'
            }, 2000);
        });
    </script>
</asp:Content>



<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
     <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="padding-bottom:15px; padding-top: 15px">
            <h1>PROJECT 01</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
    <div class="col-2">
        
        <div class="panel panel-default templatemo-content-widget white-bg no-padding templatemo-overflow-hidden col-2" style="height:0px" id="tableDiv">
        <i class="fa fa-times"></i>
        <div class="panel-heading templatemo-position-relative">
            <h2 class="text-uppercase">Transaction Table</h2>
        </div>
        <div class="table-responsive">
            <asp:DataGrid class="table table-striped table-bordered" ID="ItemsGrid" runat="server">

                <HeaderStyle BackColor="#00aaaa"></HeaderStyle>

            </asp:DataGrid>
        </div>
    </div>
        
    </div>
        <div id="asg1" class="templatemo-content-widget blue-bg col-1" style="height:fit-content;">
            <i class="fa fa-times"></i>
            <div class="square-dark"></div>
            <h2 class="templatemo-inline-block">Course Intro:</h2>
            <hr>
            <h4>Using HTML, CSS, JS and ASP.net</h4>
            <p></p>
            <ul style="list-style-type: decimal">
                <li>Transaction classes are on 2 separate files</li>
                <li>Regex is used to parse through XML for transaction data</li>
                <li>A datagrid is bound to the transaction object to display the table</li>
                <li>An example of the original data before parsing:</li>
            </ul><br />
            <textarea style="width:300px; height: 100px"><Transactions><Transaction><Id>1</Id><Date>11/23/2014</Date><Type>Deposit</Type><Description>Pay</Description><Category>Income</Category><Amount>1327</Amount></Transaction><Transaction><Id>2</Id><Date>11/24/2014</Date><Type>Check</Type><Description>Food</Description></textarea>
        </div>
    </div>
    
</asp:Content>

