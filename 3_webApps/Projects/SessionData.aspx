<%@ Page Title="SessionData" Language="C#" MasterPageFile="~/Projects.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="server">
    <script>
        $(document).ready(function () {
            console.log('session data')
            $("#PanelProj4").fadeIn(1500);
            //$("#DivProj4").fadeIn();
            //$(".table-assi4").show(1000);

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phContent1" runat="server">
   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phProj4" runat="server">

    <div class="templatemo-flex-row flex-content-row">
        <div class="col-1"></div>
        <div id="sessionData" class="templatemo-content-widget blue-bg col-2" style="">

            <i class="fa fa-times"></i>
            <div class="square-dark"></div>
            <h2 class="templatemo-inline-block">User Activity</h2>
            <h4>Managing State Data:</h4>
            <p>
                While visiting different links the server tracks down the time and the order of pages visited.  
            </p>
            <p>The Session is managed using the C# TimeSpan and StopWatch classes. This information is stored in a class called UserData</p>
        </div>
        <div class="col-1"></div>
    </div>
</asp:Content>
