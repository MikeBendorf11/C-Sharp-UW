<%@ Page Title="RegexXml" Language="C#" MasterPageFile="~/Projects.Master" %>

<%@ Import Namespace="trs" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="Projects.App_Code" %>


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

    <div id="asg1" class="templatemo-flex-row flex-content-row">
                <div class="templatemo-content-widget blue-bg col-1" style="height: fit-content;">
            <i class="fa fa-times"></i>
            <div class="square-dark"></div>
            <h2 class="templatemo-inline-block">Parsing Markup</h2>

            <br />
            <br />

            <ul>
                <li>A regex method is used to collect specific data from an XML sample string. 
                </li>
                <li>The extracted data matches the created class schema ex. only checks have a check number property
                </li>
                <li>Below a sample of the original data
                </li>
            </ul>


            <br />
            <textarea class="form-control" style="width: 100%; height: 200px">
<Transactions>
    <Transaction>
        <Id>1</Id>
        <Date>11/23/2014</Date>
        <Type>Deposit</Type>
        <Description>Pay</Description>
        <Category>Income</Category>
        <Amount>1327</Amount>
    </Transaction>
    <Transaction>
        <Id>2</Id>
        <Date>11/24/2014</Date>
        <Type>Check</Type>
        <Description>Food</Description>
                  </textarea>


        </div>
        <div class="col-1">

            <div class="panel panel-default templatemo-content-widget white-bg no-padding templatemo-overflow-hidden" id="tableDiv" style="height: 0%">
                <i class="fa fa-times"></i>
                <br />
                <div class="">
                    <asp:DataGrid class="table-assi1 table-bordered table-condensed" ID="ItemsGrid" runat="server">

                        <HeaderStyle BackColor="#00aaaa"></HeaderStyle>

                    </asp:DataGrid>
                </div>
            </div>

        </div>

    </div>

</asp:Content>

